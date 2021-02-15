using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZingMp3CrawData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged

    {
        #region prop

        private bool isCheckVietNam;
        private bool isCheckAuMy;
        private bool isCheckHanQuoc;

        public bool IsCheckVietNam
        {
            get => isCheckVietNam; set
            {
                isCheckVietNam = value;
                isCheckAuMy = false;
                isCheckHanQuoc = false;
                OnPropertyChanged("IsCheckVietNam");
                OnPropertyChanged("IsCheckAuMy");
                OnPropertyChanged("IsCheckHanQuoc");
            }
        }

        public bool IsCheckAuMy
        {
            get => isCheckAuMy; set
            {
                isCheckVietNam = false;
                isCheckAuMy = value;
                isCheckHanQuoc = false;
                OnPropertyChanged("IsCheckVietNam");
                OnPropertyChanged("IsCheckAuMy");
                OnPropertyChanged("IsCheckHanQuoc");
            }
        }

        public bool IsCheckHanQuoc
        {
            get => isCheckHanQuoc; set
            {
                isCheckVietNam = false;
                isCheckAuMy = false;
                isCheckHanQuoc = value;
                OnPropertyChanged("IsCheckVietNam");
                OnPropertyChanged("IsCheckAuMy");
                OnPropertyChanged("IsCheckHanQuoc");
            }
        }

        #endregion prop

        public MainWindow()
        {
            InitializeComponent();
            lsbTopSong.ItemsSource = new List<string>() { "", "", "" };
            this.DataContext = this;
            IsCheckVietNam = true;
        }

        private void ChonBXH(ToggleButton button)
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string newName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(newName));
            }
        }

       
    }
}