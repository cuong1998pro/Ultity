﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteTinTuc
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebsiteTinTuc")]
	public partial class TinTucDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBanTin(BanTin instance);
    partial void UpdateBanTin(BanTin instance);
    partial void DeleteBanTin(BanTin instance);
    partial void InsertChiTiet(ChiTiet instance);
    partial void UpdateChiTiet(ChiTiet instance);
    partial void DeleteChiTiet(ChiTiet instance);
    partial void InsertDangNhap(DangNhap instance);
    partial void UpdateDangNhap(DangNhap instance);
    partial void DeleteDangNhap(DangNhap instance);
    #endregion
		
		public TinTucDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebsiteTinTucConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TinTucDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TinTucDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TinTucDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TinTucDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BanTin> BanTins
		{
			get
			{
				return this.GetTable<BanTin>();
			}
		}
		
		public System.Data.Linq.Table<ChiTiet> ChiTiets
		{
			get
			{
				return this.GetTable<ChiTiet>();
			}
		}
		
		public System.Data.Linq.Table<DangNhap> DangNhaps
		{
			get
			{
				return this.GetTable<DangNhap>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_Delete")]
		public int BanTin_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBantin", DbType="Int")] System.Nullable<int> iDBantin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBantin);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DangNhap_Search")]
		public ISingleResult<DangNhap_SearchResult> DangNhap_Search([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="NVarChar(50)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(50)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, password);
			return ((ISingleResult<DangNhap_SearchResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_Insert")]
		public int BanTin_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NoiDung", DbType="NVarChar(50)")] string noiDung)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), noiDung);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_SelectAll")]
		public ISingleResult<BanTin_SelectAllResult> BanTin_SelectAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<BanTin_SelectAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_Update")]
		public int BanTin_Update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBantin", DbType="Int")] System.Nullable<int> iDBantin, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NoiDung", DbType="NVarChar(50)")] string noiDung)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBantin, noiDung);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_Delete")]
		public int ChiTiet_Delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_Insert")]
		public int ChiTiet_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TieuDe", DbType="NVarChar(250)")] string tieuDe, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NoiDung", DbType="NVarChar(MAX)")] string noiDung, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgayDang", DbType="DateTime")] System.Nullable<System.DateTime> ngayDang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tieuDe, noiDung, ngayDang, iDBanTin);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectAll")]
		public ISingleResult<ChiTiet_SelectAllResult> ChiTiet_SelectAll()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ChiTiet_SelectAllResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectBanTin")]
		public ISingleResult<ChiTiet_SelectBanTinResult> ChiTiet_SelectBanTin([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBanTin);
			return ((ISingleResult<ChiTiet_SelectBanTinResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectHome")]
		public ISingleResult<ChiTiet_SelectHomeResult> ChiTiet_SelectHome()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<ChiTiet_SelectHomeResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectID")]
		public ISingleResult<ChiTiet_SelectIDResult> ChiTiet_SelectID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((ISingleResult<ChiTiet_SelectIDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_Update")]
		public int ChiTiet_Update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TieuDe", DbType="NVarChar(250)")] string tieuDe, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NoiDung", DbType="NVarChar(MAX)")] string noiDung, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NgayDang", DbType="DateTime")] System.Nullable<System.DateTime> ngayDang, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, tieuDe, noiDung, ngayDang, iDBanTin);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_UpdateSoLanXem")]
		public int ChiTiet_UpdateSoLanXem([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DangNhap_Insert")]
		public int DangNhap_Insert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="NVarChar(50)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(50)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, password);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTiet_SelectRandom")]
		public ISingleResult<ChiTiet_SelectRandomResult> ChiTiet_SelectRandom([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDBanTin", DbType="Int")] System.Nullable<int> iDBanTin)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDBanTin);
			return ((ISingleResult<ChiTiet_SelectRandomResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.BanTin_SelectID")]
		public ISingleResult<BanTin_SelectIDResult> BanTin_SelectID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD);
			return ((ISingleResult<BanTin_SelectIDResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BanTin")]
	public partial class BanTin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _NoiDung;
		
		private EntitySet<ChiTiet> _ChiTiets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNoiDungChanging(string value);
    partial void OnNoiDungChanged();
    #endregion
		
		public BanTin()
		{
			this._ChiTiets = new EntitySet<ChiTiet>(new Action<ChiTiet>(this.attach_ChiTiets), new Action<ChiTiet>(this.detach_ChiTiets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this.OnNoiDungChanging(value);
					this.SendPropertyChanging();
					this._NoiDung = value;
					this.SendPropertyChanged("NoiDung");
					this.OnNoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BanTin_ChiTiet", Storage="_ChiTiets", ThisKey="ID", OtherKey="IDBanTin")]
		public EntitySet<ChiTiet> ChiTiets
		{
			get
			{
				return this._ChiTiets;
			}
			set
			{
				this._ChiTiets.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.BanTin = this;
		}
		
		private void detach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.BanTin = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTiet")]
	public partial class ChiTiet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TieuDe;
		
		private string _NoiDung;
		
		private System.Nullable<int> _LanXem;
		
		private System.Nullable<System.DateTime> _NgayDang;
		
		private int _IDBanTin;
		
		private EntityRef<BanTin> _BanTin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTieuDeChanging(string value);
    partial void OnTieuDeChanged();
    partial void OnNoiDungChanging(string value);
    partial void OnNoiDungChanged();
    partial void OnLanXemChanging(System.Nullable<int> value);
    partial void OnLanXemChanged();
    partial void OnNgayDangChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayDangChanged();
    partial void OnIDBanTinChanging(int value);
    partial void OnIDBanTinChanged();
    #endregion
		
		public ChiTiet()
		{
			this._BanTin = default(EntityRef<BanTin>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuDe", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string TieuDe
		{
			get
			{
				return this._TieuDe;
			}
			set
			{
				if ((this._TieuDe != value))
				{
					this.OnTieuDeChanging(value);
					this.SendPropertyChanging();
					this._TieuDe = value;
					this.SendPropertyChanged("TieuDe");
					this.OnTieuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(MAX)")]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this.OnNoiDungChanging(value);
					this.SendPropertyChanging();
					this._NoiDung = value;
					this.SendPropertyChanged("NoiDung");
					this.OnNoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanXem", DbType="Int")]
		public System.Nullable<int> LanXem
		{
			get
			{
				return this._LanXem;
			}
			set
			{
				if ((this._LanXem != value))
				{
					this.OnLanXemChanging(value);
					this.SendPropertyChanging();
					this._LanXem = value;
					this.SendPropertyChanged("LanXem");
					this.OnLanXemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayDang
		{
			get
			{
				return this._NgayDang;
			}
			set
			{
				if ((this._NgayDang != value))
				{
					this.OnNgayDangChanging(value);
					this.SendPropertyChanging();
					this._NgayDang = value;
					this.SendPropertyChanged("NgayDang");
					this.OnNgayDangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int NOT NULL")]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					if (this._BanTin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDBanTinChanging(value);
					this.SendPropertyChanging();
					this._IDBanTin = value;
					this.SendPropertyChanged("IDBanTin");
					this.OnIDBanTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BanTin_ChiTiet", Storage="_BanTin", ThisKey="IDBanTin", OtherKey="ID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public BanTin BanTin
		{
			get
			{
				return this._BanTin.Entity;
			}
			set
			{
				BanTin previousValue = this._BanTin.Entity;
				if (((previousValue != value) 
							|| (this._BanTin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BanTin.Entity = null;
						previousValue.ChiTiets.Remove(this);
					}
					this._BanTin.Entity = value;
					if ((value != null))
					{
						value.ChiTiets.Add(this);
						this._IDBanTin = value.ID;
					}
					else
					{
						this._IDBanTin = default(int);
					}
					this.SendPropertyChanged("BanTin");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DangNhap")]
	public partial class DangNhap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Username;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public DangNhap()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class DangNhap_SearchResult
	{
		
		private string _Username;
		
		private string _Password;
		
		public DangNhap_SearchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
	}
	
	public partial class BanTin_SelectAllResult
	{
		
		private int _ID;
		
		private string _NoiDung;
		
		public BanTin_SelectAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this._NoiDung = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectAllResult
	{
		
		private int _ID;
		
		private string _TieuDe;
		
		private string _NoiDung;
		
		private System.Nullable<int> _LanXem;
		
		private System.Nullable<System.DateTime> _NgayDang;
		
		private int _IDBanTin;
		
		private string _TenBanTin;
		
		public ChiTiet_SelectAllResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuDe", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string TieuDe
		{
			get
			{
				return this._TieuDe;
			}
			set
			{
				if ((this._TieuDe != value))
				{
					this._TieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(MAX)")]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this._NoiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanXem", DbType="Int")]
		public System.Nullable<int> LanXem
		{
			get
			{
				return this._LanXem;
			}
			set
			{
				if ((this._LanXem != value))
				{
					this._LanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayDang
		{
			get
			{
				return this._NgayDang;
			}
			set
			{
				if ((this._NgayDang != value))
				{
					this._NgayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int NOT NULL")]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBanTin", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenBanTin
		{
			get
			{
				return this._TenBanTin;
			}
			set
			{
				if ((this._TenBanTin != value))
				{
					this._TenBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectBanTinResult
	{
		
		private int _ID;
		
		private string _TieuDe;
		
		private string _NoiDung;
		
		private System.Nullable<int> _LanXem;
		
		private System.Nullable<System.DateTime> _NgayDang;
		
		private int _IDBanTin;
		
		private string _TenBanTin;
		
		public ChiTiet_SelectBanTinResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuDe", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string TieuDe
		{
			get
			{
				return this._TieuDe;
			}
			set
			{
				if ((this._TieuDe != value))
				{
					this._TieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(MAX)")]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this._NoiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanXem", DbType="Int")]
		public System.Nullable<int> LanXem
		{
			get
			{
				return this._LanXem;
			}
			set
			{
				if ((this._LanXem != value))
				{
					this._LanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayDang
		{
			get
			{
				return this._NgayDang;
			}
			set
			{
				if ((this._NgayDang != value))
				{
					this._NgayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int NOT NULL")]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBanTin", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenBanTin
		{
			get
			{
				return this._TenBanTin;
			}
			set
			{
				if ((this._TenBanTin != value))
				{
					this._TenBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectHomeResult
	{
		
		private int _ID;
		
		private string _TieuDe;
		
		private string _NoiDung;
		
		private System.Nullable<int> _LanXem;
		
		private System.Nullable<System.DateTime> _NgayDang;
		
		private int _IDBanTin;
		
		public ChiTiet_SelectHomeResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuDe", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string TieuDe
		{
			get
			{
				return this._TieuDe;
			}
			set
			{
				if ((this._TieuDe != value))
				{
					this._TieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(MAX)")]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this._NoiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanXem", DbType="Int")]
		public System.Nullable<int> LanXem
		{
			get
			{
				return this._LanXem;
			}
			set
			{
				if ((this._LanXem != value))
				{
					this._LanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayDang
		{
			get
			{
				return this._NgayDang;
			}
			set
			{
				if ((this._NgayDang != value))
				{
					this._NgayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int NOT NULL")]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectIDResult
	{
		
		private int _ID;
		
		private string _TieuDe;
		
		private string _NoiDung;
		
		private System.Nullable<int> _LanXem;
		
		private System.Nullable<System.DateTime> _NgayDang;
		
		private int _IDBanTin;
		
		private string _TenBanTin;
		
		public ChiTiet_SelectIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuDe", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string TieuDe
		{
			get
			{
				return this._TieuDe;
			}
			set
			{
				if ((this._TieuDe != value))
				{
					this._TieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(MAX)")]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this._NoiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanXem", DbType="Int")]
		public System.Nullable<int> LanXem
		{
			get
			{
				return this._LanXem;
			}
			set
			{
				if ((this._LanXem != value))
				{
					this._LanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayDang
		{
			get
			{
				return this._NgayDang;
			}
			set
			{
				if ((this._NgayDang != value))
				{
					this._NgayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int NOT NULL")]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBanTin", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenBanTin
		{
			get
			{
				return this._TenBanTin;
			}
			set
			{
				if ((this._TenBanTin != value))
				{
					this._TenBanTin = value;
				}
			}
		}
	}
	
	public partial class ChiTiet_SelectRandomResult
	{
		
		private int _ID;
		
		private string _TieuDe;
		
		private string _NoiDung;
		
		private System.Nullable<int> _LanXem;
		
		private System.Nullable<System.DateTime> _NgayDang;
		
		private int _IDBanTin;
		
		public ChiTiet_SelectRandomResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuDe", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string TieuDe
		{
			get
			{
				return this._TieuDe;
			}
			set
			{
				if ((this._TieuDe != value))
				{
					this._TieuDe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(MAX)")]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this._NoiDung = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanXem", DbType="Int")]
		public System.Nullable<int> LanXem
		{
			get
			{
				return this._LanXem;
			}
			set
			{
				if ((this._LanXem != value))
				{
					this._LanXem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDang", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayDang
		{
			get
			{
				return this._NgayDang;
			}
			set
			{
				if ((this._NgayDang != value))
				{
					this._NgayDang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBanTin", DbType="Int NOT NULL")]
		public int IDBanTin
		{
			get
			{
				return this._IDBanTin;
			}
			set
			{
				if ((this._IDBanTin != value))
				{
					this._IDBanTin = value;
				}
			}
		}
	}
	
	public partial class BanTin_SelectIDResult
	{
		
		private int _ID;
		
		private string _NoiDung;
		
		public BanTin_SelectIDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this._NoiDung = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
