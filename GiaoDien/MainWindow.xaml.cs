using KAutoHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GiaoDien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private SoundPlayer sp_active;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private bool _IsInjected;
        public bool IsInjected { get => _IsInjected; set { _IsInjected = value; OnPropertyChanged(); } }

        private bool _IsOneHitBoss;
        public bool IsOneHitBoss { get => _IsOneHitBoss; set { _IsOneHitBoss = value; OnPropertyChanged(); } }

        private bool _IsOneHitCreep;
        public bool IsOneHitCreep { get => _IsOneHitCreep; set { _IsOneHitCreep = value; OnPropertyChanged(); } }

        private bool _IsFullLife;
        public bool IsFullLife { get => _IsFullLife; set { _IsFullLife = value; OnPropertyChanged(); } }

        private bool _IsImortal;
        public bool IsImortal { get => _IsImortal; set { _IsImortal = value; OnPropertyChanged(); } }

        private IntPtr _Handle;
        public IntPtr Handle { get => _Handle; set { _Handle = value; IsInjected = Handle != IntPtr.Zero; } }

        private Thread playerMaxHPThread = null;
        private Thread playerMaxLife = null;
        private int playerLifeInit;

        private delegate void threadToStart();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            FirstLoad();
        }

        private async void FirstLoad()
        {
            IsInjected = false;
            sp_active = new SoundPlayer(Properties.Resources.hover);
            LoadHandle();
            LoadPlayerLifeInit();
        }

        private void LoadHandle()
        {
            var nProcess = Process.GetProcesses().Where(p => p.ProcessName.Contains("MegaManX4")).ToList();
            if (nProcess.Count > 0)
            {
                Handle = MemoryHelper.OpenProcess(nProcess[0].Id);
            }
            else
            {
                Handle = IntPtr.Zero;
            }
        }

        private void DockPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Image_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Image_PreviewMouseDown_2(object sender, MouseButtonEventArgs e)
        {
            LoadHandle();
            PlaySoundActive();
        }

        private void PlaySoundActive()
        {
            sp_active.Play();
        }

        private void Image_MouseDown_OneHitCreep(object sender, MouseButtonEventArgs e)
        {
            IsOneHitCreep = !IsOneHitCreep;
            PlaySoundActive();
        }

        private void Image_MouseDown_OneHitBoss(object sender, MouseButtonEventArgs e)
        {
            IsOneHitBoss = !IsOneHitBoss;
            PlaySoundActive();
        }

        private void Image_MouseDown_FullLife(object sender, MouseButtonEventArgs e)
        {
            IsFullLife = !IsFullLife;
            PlaySoundActive();
            StartThread(playerMaxHPThread, IsFullLife, () =>
            {
                IntPtr entryPlayerHpPoint = IntPtr.Add(Handle, 0x144F5C);
                uint offset = (uint)0x00544F5c;
                while (true)
                {
                    MemoryHelper.WriteInt(Handle, entryPlayerHpPoint, offset, 2905376);
                    Thread.Sleep(10);
                }
            });
        }

        private void StartThread(Thread thread, bool checkFlag, threadToStart func)
        {
            if (checkFlag)
            {
                if (thread != null)
                {
                    try
                    {
                        CancelThread(thread);
                    }
                    catch { }
                }
                thread = new Thread(() => func());
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                CancelThread(thread);
            }
        }

        private void CancelThread(Thread thread)
        {
            if (thread == null) return;
            try
            {
                thread.Abort();
                thread = null;
            }
            catch { }
        }

        private void Image_MouseDown_Immortal(object sender, MouseButtonEventArgs e)
        {
            IsImortal = !IsImortal;
            PlaySoundActive();
            if (IsImortal)
            {
                SetPlayerLife(playerLifeInit + 7);
            }
            else
            {
                SetPlayerLife(playerLifeInit);
            }
        }

        private void Image_MouseDonw_Reset(object sender, MouseButtonEventArgs e)
        {
            if (!IsInjected) LoadHandle();
            if (IsImortal)
            {
                IsImortal = IsFullLife = IsOneHitCreep = IsOneHitBoss = false;
            }
            else
            {
                IsImortal = IsFullLife = IsOneHitCreep = IsOneHitBoss = true;
            }
            PlaySoundActive();
        }

        private void LoadPlayerLifeInit()
        {
            IntPtr entryPlayerLifePoint = IntPtr.Add(Handle, 0x13A084);
            uint offset = 0x0053a084;
            playerLifeInit = MemoryHelper.ReadInt(Handle, entryPlayerLifePoint, offset);
        }

        private void SetPlayerLife(int life)
        {
            IntPtr entryPlayerLifePoint = IntPtr.Add(Handle, 0x13A084);
            uint offset = 0x0053a084;
            MemoryHelper.WriteInt(Handle, entryPlayerLifePoint, offset, life);
        }
    }
}