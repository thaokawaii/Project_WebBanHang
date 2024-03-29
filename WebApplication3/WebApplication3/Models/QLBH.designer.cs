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

namespace WebApplication3.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_BANHANG")]
	public partial class QLBHDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCTDONHANG(CTDONHANG instance);
    partial void UpdateCTDONHANG(CTDONHANG instance);
    partial void DeleteCTDONHANG(CTDONHANG instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertDONDATHANG(DONDATHANG instance);
    partial void UpdateDONDATHANG(DONDATHANG instance);
    partial void DeleteDONDATHANG(DONDATHANG instance);
    partial void InsertLOAISP(LOAISP instance);
    partial void UpdateLOAISP(LOAISP instance);
    partial void DeleteLOAISP(LOAISP instance);
    partial void InsertNHACUNGCAP(NHACUNGCAP instance);
    partial void UpdateNHACUNGCAP(NHACUNGCAP instance);
    partial void DeleteNHACUNGCAP(NHACUNGCAP instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    #endregion
		
		public QLBHDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_BANHANGConnectionString2"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLBHDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLBHDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLBHDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLBHDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ADMIN> ADMINs
		{
			get
			{
				return this.GetTable<ADMIN>();
			}
		}
		
		public System.Data.Linq.Table<CTDONHANG> CTDONHANGs
		{
			get
			{
				return this.GetTable<CTDONHANG>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this.GetTable<DONDATHANG>();
			}
		}
		
		public System.Data.Linq.Table<LOAISP> LOAISPs
		{
			get
			{
				return this.GetTable<LOAISP>();
			}
		}
		
		public System.Data.Linq.Table<NHACUNGCAP> NHACUNGCAPs
		{
			get
			{
				return this.GetTable<NHACUNGCAP>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ADMIN")]
	public partial class ADMIN
	{
		
		private string _TENDN;
		
		private string _MATKHAU;
		
		public ADMIN()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDN", DbType="Char(30)")]
		public string TENDN
		{
			get
			{
				return this._TENDN;
			}
			set
			{
				if ((this._TENDN != value))
				{
					this._TENDN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATKHAU", DbType="Char(20)")]
		public string MATKHAU
		{
			get
			{
				return this._MATKHAU;
			}
			set
			{
				if ((this._MATKHAU != value))
				{
					this._MATKHAU = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTDONHANG")]
	public partial class CTDONHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SODH;
		
		private int _MASP;
		
		private System.Nullable<int> _SOLUONG;
		
		private System.Nullable<decimal> _DONGIA;
		
		private EntityRef<DONDATHANG> _DONDATHANG;
		
		private EntityRef<SANPHAM> _SANPHAM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSODHChanging(int value);
    partial void OnSODHChanged();
    partial void OnMASPChanging(int value);
    partial void OnMASPChanged();
    partial void OnSOLUONGChanging(System.Nullable<int> value);
    partial void OnSOLUONGChanged();
    partial void OnDONGIAChanging(System.Nullable<decimal> value);
    partial void OnDONGIAChanged();
    #endregion
		
		public CTDONHANG()
		{
			this._DONDATHANG = default(EntityRef<DONDATHANG>);
			this._SANPHAM = default(EntityRef<SANPHAM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SODH", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SODH
		{
			get
			{
				return this._SODH;
			}
			set
			{
				if ((this._SODH != value))
				{
					if (this._DONDATHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSODHChanging(value);
					this.SendPropertyChanging();
					this._SODH = value;
					this.SendPropertyChanged("SODH");
					this.OnSODHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MASP
		{
			get
			{
				return this._MASP;
			}
			set
			{
				if ((this._MASP != value))
				{
					if (this._SANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMASPChanging(value);
					this.SendPropertyChanging();
					this._MASP = value;
					this.SendPropertyChanged("MASP");
					this.OnMASPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLUONG", DbType="Int")]
		public System.Nullable<int> SOLUONG
		{
			get
			{
				return this._SOLUONG;
			}
			set
			{
				if ((this._SOLUONG != value))
				{
					this.OnSOLUONGChanging(value);
					this.SendPropertyChanging();
					this._SOLUONG = value;
					this.SendPropertyChanged("SOLUONG");
					this.OnSOLUONGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Money")]
		public System.Nullable<decimal> DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this.OnDONGIAChanging(value);
					this.SendPropertyChanging();
					this._DONGIA = value;
					this.SendPropertyChanged("DONGIA");
					this.OnDONGIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONDATHANG_CTDONHANG", Storage="_DONDATHANG", ThisKey="SODH", OtherKey="SODH", IsForeignKey=true)]
		public DONDATHANG DONDATHANG
		{
			get
			{
				return this._DONDATHANG.Entity;
			}
			set
			{
				DONDATHANG previousValue = this._DONDATHANG.Entity;
				if (((previousValue != value) 
							|| (this._DONDATHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DONDATHANG.Entity = null;
						previousValue.CTDONHANGs.Remove(this);
					}
					this._DONDATHANG.Entity = value;
					if ((value != null))
					{
						value.CTDONHANGs.Add(this);
						this._SODH = value.SODH;
					}
					else
					{
						this._SODH = default(int);
					}
					this.SendPropertyChanged("DONDATHANG");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CTDONHANG", Storage="_SANPHAM", ThisKey="MASP", OtherKey="MASP", IsForeignKey=true)]
		public SANPHAM SANPHAM
		{
			get
			{
				return this._SANPHAM.Entity;
			}
			set
			{
				SANPHAM previousValue = this._SANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._SANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SANPHAM.Entity = null;
						previousValue.CTDONHANGs.Remove(this);
					}
					this._SANPHAM.Entity = value;
					if ((value != null))
					{
						value.CTDONHANGs.Add(this);
						this._MASP = value.MASP;
					}
					else
					{
						this._MASP = default(int);
					}
					this.SendPropertyChanged("SANPHAM");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MAKH;
		
		private string _TENDN;
		
		private string _MATKHAU;
		
		private string _TENKH;
		
		private string _DIACHI;
		
		private string _SDT;
		
		private string _EMAIL;
		
		private System.Nullable<System.DateTime> _NGAYSINH;
		
		private EntitySet<DONDATHANG> _DONDATHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMAKHChanging(int value);
    partial void OnMAKHChanged();
    partial void OnTENDNChanging(string value);
    partial void OnTENDNChanged();
    partial void OnMATKHAUChanging(string value);
    partial void OnMATKHAUChanged();
    partial void OnTENKHChanging(string value);
    partial void OnTENKHChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnEMAILChanging(string value);
    partial void OnEMAILChanged();
    partial void OnNGAYSINHChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYSINHChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._DONDATHANGs = new EntitySet<DONDATHANG>(new Action<DONDATHANG>(this.attach_DONDATHANGs), new Action<DONDATHANG>(this.detach_DONDATHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MAKH
		{
			get
			{
				return this._MAKH;
			}
			set
			{
				if ((this._MAKH != value))
				{
					this.OnMAKHChanging(value);
					this.SendPropertyChanging();
					this._MAKH = value;
					this.SendPropertyChanged("MAKH");
					this.OnMAKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENDN", DbType="VarChar(30)")]
		public string TENDN
		{
			get
			{
				return this._TENDN;
			}
			set
			{
				if ((this._TENDN != value))
				{
					this.OnTENDNChanging(value);
					this.SendPropertyChanging();
					this._TENDN = value;
					this.SendPropertyChanged("TENDN");
					this.OnTENDNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATKHAU", DbType="VarChar(20)")]
		public string MATKHAU
		{
			get
			{
				return this._MATKHAU;
			}
			set
			{
				if ((this._MATKHAU != value))
				{
					this.OnMATKHAUChanging(value);
					this.SendPropertyChanging();
					this._MATKHAU = value;
					this.SendPropertyChanged("MATKHAU");
					this.OnMATKHAUChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENKH", DbType="NVarChar(30)")]
		public string TENKH
		{
			get
			{
				return this._TENKH;
			}
			set
			{
				if ((this._TENKH != value))
				{
					this.OnTENKHChanging(value);
					this.SendPropertyChanging();
					this._TENKH = value;
					this.SendPropertyChanged("TENKH");
					this.OnTENKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(60)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMAIL", DbType="Char(30)")]
		public string EMAIL
		{
			get
			{
				return this._EMAIL;
			}
			set
			{
				if ((this._EMAIL != value))
				{
					this.OnEMAILChanging(value);
					this.SendPropertyChanging();
					this._EMAIL = value;
					this.SendPropertyChanged("EMAIL");
					this.OnEMAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYSINH", DbType="Date")]
		public System.Nullable<System.DateTime> NGAYSINH
		{
			get
			{
				return this._NGAYSINH;
			}
			set
			{
				if ((this._NGAYSINH != value))
				{
					this.OnNGAYSINHChanging(value);
					this.SendPropertyChanging();
					this._NGAYSINH = value;
					this.SendPropertyChanged("NGAYSINH");
					this.OnNGAYSINHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_DONDATHANGs", ThisKey="MAKH", OtherKey="MAKH")]
		public EntitySet<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this._DONDATHANGs;
			}
			set
			{
				this._DONDATHANGs.Assign(value);
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
		
		private void attach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONDATHANG")]
	public partial class DONDATHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SODH;
		
		private System.Nullable<int> _MAKH;
		
		private string _DATHANHTOAN;
		
		private string _TINHTRANG;
		
		private System.Nullable<System.DateTime> _NGAYDH;
		
		private System.Nullable<System.DateTime> _NGAYGIAO;
		
		private EntitySet<CTDONHANG> _CTDONHANGs;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSODHChanging(int value);
    partial void OnSODHChanged();
    partial void OnMAKHChanging(System.Nullable<int> value);
    partial void OnMAKHChanged();
    partial void OnDATHANHTOANChanging(string value);
    partial void OnDATHANHTOANChanged();
    partial void OnTINHTRANGChanging(string value);
    partial void OnTINHTRANGChanged();
    partial void OnNGAYDHChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYDHChanged();
    partial void OnNGAYGIAOChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYGIAOChanged();
    #endregion
		
		public DONDATHANG()
		{
			this._CTDONHANGs = new EntitySet<CTDONHANG>(new Action<CTDONHANG>(this.attach_CTDONHANGs), new Action<CTDONHANG>(this.detach_CTDONHANGs));
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SODH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SODH
		{
			get
			{
				return this._SODH;
			}
			set
			{
				if ((this._SODH != value))
				{
					this.OnSODHChanging(value);
					this.SendPropertyChanging();
					this._SODH = value;
					this.SendPropertyChanged("SODH");
					this.OnSODHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKH", DbType="Int")]
		public System.Nullable<int> MAKH
		{
			get
			{
				return this._MAKH;
			}
			set
			{
				if ((this._MAKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAKHChanging(value);
					this.SendPropertyChanging();
					this._MAKH = value;
					this.SendPropertyChanged("MAKH");
					this.OnMAKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DATHANHTOAN", DbType="NVarChar(30)")]
		public string DATHANHTOAN
		{
			get
			{
				return this._DATHANHTOAN;
			}
			set
			{
				if ((this._DATHANHTOAN != value))
				{
					this.OnDATHANHTOANChanging(value);
					this.SendPropertyChanging();
					this._DATHANHTOAN = value;
					this.SendPropertyChanged("DATHANHTOAN");
					this.OnDATHANHTOANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TINHTRANG", DbType="NVarChar(20)")]
		public string TINHTRANG
		{
			get
			{
				return this._TINHTRANG;
			}
			set
			{
				if ((this._TINHTRANG != value))
				{
					this.OnTINHTRANGChanging(value);
					this.SendPropertyChanging();
					this._TINHTRANG = value;
					this.SendPropertyChanged("TINHTRANG");
					this.OnTINHTRANGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYDH", DbType="Date")]
		public System.Nullable<System.DateTime> NGAYDH
		{
			get
			{
				return this._NGAYDH;
			}
			set
			{
				if ((this._NGAYDH != value))
				{
					this.OnNGAYDHChanging(value);
					this.SendPropertyChanging();
					this._NGAYDH = value;
					this.SendPropertyChanged("NGAYDH");
					this.OnNGAYDHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYGIAO", DbType="Date")]
		public System.Nullable<System.DateTime> NGAYGIAO
		{
			get
			{
				return this._NGAYGIAO;
			}
			set
			{
				if ((this._NGAYGIAO != value))
				{
					this.OnNGAYGIAOChanging(value);
					this.SendPropertyChanging();
					this._NGAYGIAO = value;
					this.SendPropertyChanged("NGAYGIAO");
					this.OnNGAYGIAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONDATHANG_CTDONHANG", Storage="_CTDONHANGs", ThisKey="SODH", OtherKey="SODH")]
		public EntitySet<CTDONHANG> CTDONHANGs
		{
			get
			{
				return this._CTDONHANGs;
			}
			set
			{
				this._CTDONHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_KHACHHANG", ThisKey="MAKH", OtherKey="MAKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.DONDATHANGs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.DONDATHANGs.Add(this);
						this._MAKH = value.MAKH;
					}
					else
					{
						this._MAKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KHACHHANG");
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
		
		private void attach_CTDONHANGs(CTDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONDATHANG = this;
		}
		
		private void detach_CTDONHANGs(CTDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.DONDATHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAISP")]
	public partial class LOAISP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MALOAI;
		
		private string _TENLOAI;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMALOAIChanging(string value);
    partial void OnMALOAIChanged();
    partial void OnTENLOAIChanging(string value);
    partial void OnTENLOAIChanged();
    #endregion
		
		public LOAISP()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOAI", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MALOAI
		{
			get
			{
				return this._MALOAI;
			}
			set
			{
				if ((this._MALOAI != value))
				{
					this.OnMALOAIChanging(value);
					this.SendPropertyChanging();
					this._MALOAI = value;
					this.SendPropertyChanged("MALOAI");
					this.OnMALOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENLOAI", DbType="NVarChar(30)")]
		public string TENLOAI
		{
			get
			{
				return this._TENLOAI;
			}
			set
			{
				if ((this._TENLOAI != value))
				{
					this.OnTENLOAIChanging(value);
					this.SendPropertyChanging();
					this._TENLOAI = value;
					this.SendPropertyChanged("TENLOAI");
					this.OnTENLOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISP_SANPHAM", Storage="_SANPHAMs", ThisKey="MALOAI", OtherKey="MALOAI")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISP = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISP = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHACUNGCAP")]
	public partial class NHACUNGCAP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MANCC;
		
		private string _TENNCC;
		
		private string _DIACHI;
		
		private string _SDT;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMANCCChanging(int value);
    partial void OnMANCCChanged();
    partial void OnTENNCCChanging(string value);
    partial void OnTENNCCChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public NHACUNGCAP()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANCC", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MANCC
		{
			get
			{
				return this._MANCC;
			}
			set
			{
				if ((this._MANCC != value))
				{
					this.OnMANCCChanging(value);
					this.SendPropertyChanging();
					this._MANCC = value;
					this.SendPropertyChanged("MANCC");
					this.OnMANCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENNCC", DbType="NVarChar(40)")]
		public string TENNCC
		{
			get
			{
				return this._TENNCC;
			}
			set
			{
				if ((this._TENNCC != value))
				{
					this.OnTENNCCChanging(value);
					this.SendPropertyChanging();
					this._TENNCC = value;
					this.SendPropertyChanged("TENNCC");
					this.OnTENNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(60)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHACUNGCAP_SANPHAM", Storage="_SANPHAMs", ThisKey="MANCC", OtherKey="MANCC")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NHACUNGCAP = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NHACUNGCAP = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MASP;
		
		private string _MALOAI;
		
		private System.Nullable<int> _MANCC;
		
		private string _TENSP;
		
		private string _ANH;
		
		private System.Nullable<int> _SL;
		
		private System.Nullable<double> _DONGIA;
		
		private string _MOTA;
		
		private System.Nullable<System.DateTime> _NGAYCAPNHAT;
		
		private EntitySet<CTDONHANG> _CTDONHANGs;
		
		private EntityRef<LOAISP> _LOAISP;
		
		private EntityRef<NHACUNGCAP> _NHACUNGCAP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMASPChanging(int value);
    partial void OnMASPChanged();
    partial void OnMALOAIChanging(string value);
    partial void OnMALOAIChanged();
    partial void OnMANCCChanging(System.Nullable<int> value);
    partial void OnMANCCChanged();
    partial void OnTENSPChanging(string value);
    partial void OnTENSPChanged();
    partial void OnANHChanging(string value);
    partial void OnANHChanged();
    partial void OnSLChanging(System.Nullable<int> value);
    partial void OnSLChanged();
    partial void OnDONGIAChanging(System.Nullable<double> value);
    partial void OnDONGIAChanged();
    partial void OnMOTAChanging(string value);
    partial void OnMOTAChanged();
    partial void OnNGAYCAPNHATChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYCAPNHATChanged();
    #endregion
		
		public SANPHAM()
		{
			this._CTDONHANGs = new EntitySet<CTDONHANG>(new Action<CTDONHANG>(this.attach_CTDONHANGs), new Action<CTDONHANG>(this.detach_CTDONHANGs));
			this._LOAISP = default(EntityRef<LOAISP>);
			this._NHACUNGCAP = default(EntityRef<NHACUNGCAP>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MASP
		{
			get
			{
				return this._MASP;
			}
			set
			{
				if ((this._MASP != value))
				{
					this.OnMASPChanging(value);
					this.SendPropertyChanging();
					this._MASP = value;
					this.SendPropertyChanged("MASP");
					this.OnMASPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MALOAI", DbType="Char(10)")]
		public string MALOAI
		{
			get
			{
				return this._MALOAI;
			}
			set
			{
				if ((this._MALOAI != value))
				{
					if (this._LOAISP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMALOAIChanging(value);
					this.SendPropertyChanging();
					this._MALOAI = value;
					this.SendPropertyChanged("MALOAI");
					this.OnMALOAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MANCC", DbType="Int")]
		public System.Nullable<int> MANCC
		{
			get
			{
				return this._MANCC;
			}
			set
			{
				if ((this._MANCC != value))
				{
					if (this._NHACUNGCAP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMANCCChanging(value);
					this.SendPropertyChanging();
					this._MANCC = value;
					this.SendPropertyChanged("MANCC");
					this.OnMANCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENSP", DbType="NVarChar(50)")]
		public string TENSP
		{
			get
			{
				return this._TENSP;
			}
			set
			{
				if ((this._TENSP != value))
				{
					this.OnTENSPChanging(value);
					this.SendPropertyChanging();
					this._TENSP = value;
					this.SendPropertyChanged("TENSP");
					this.OnTENSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ANH", DbType="VarChar(50)")]
		public string ANH
		{
			get
			{
				return this._ANH;
			}
			set
			{
				if ((this._ANH != value))
				{
					this.OnANHChanging(value);
					this.SendPropertyChanging();
					this._ANH = value;
					this.SendPropertyChanged("ANH");
					this.OnANHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SL", DbType="Int")]
		public System.Nullable<int> SL
		{
			get
			{
				return this._SL;
			}
			set
			{
				if ((this._SL != value))
				{
					this.OnSLChanging(value);
					this.SendPropertyChanging();
					this._SL = value;
					this.SendPropertyChanged("SL");
					this.OnSLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DONGIA", DbType="Float")]
		public System.Nullable<double> DONGIA
		{
			get
			{
				return this._DONGIA;
			}
			set
			{
				if ((this._DONGIA != value))
				{
					this.OnDONGIAChanging(value);
					this.SendPropertyChanging();
					this._DONGIA = value;
					this.SendPropertyChanged("DONGIA");
					this.OnDONGIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MOTA", DbType="NVarChar(200)")]
		public string MOTA
		{
			get
			{
				return this._MOTA;
			}
			set
			{
				if ((this._MOTA != value))
				{
					this.OnMOTAChanging(value);
					this.SendPropertyChanging();
					this._MOTA = value;
					this.SendPropertyChanged("MOTA");
					this.OnMOTAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYCAPNHAT", DbType="Date")]
		public System.Nullable<System.DateTime> NGAYCAPNHAT
		{
			get
			{
				return this._NGAYCAPNHAT;
			}
			set
			{
				if ((this._NGAYCAPNHAT != value))
				{
					this.OnNGAYCAPNHATChanging(value);
					this.SendPropertyChanging();
					this._NGAYCAPNHAT = value;
					this.SendPropertyChanged("NGAYCAPNHAT");
					this.OnNGAYCAPNHATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CTDONHANG", Storage="_CTDONHANGs", ThisKey="MASP", OtherKey="MASP")]
		public EntitySet<CTDONHANG> CTDONHANGs
		{
			get
			{
				return this._CTDONHANGs;
			}
			set
			{
				this._CTDONHANGs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISP_SANPHAM", Storage="_LOAISP", ThisKey="MALOAI", OtherKey="MALOAI", IsForeignKey=true)]
		public LOAISP LOAISP
		{
			get
			{
				return this._LOAISP.Entity;
			}
			set
			{
				LOAISP previousValue = this._LOAISP.Entity;
				if (((previousValue != value) 
							|| (this._LOAISP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAISP.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._LOAISP.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MALOAI = value.MALOAI;
					}
					else
					{
						this._MALOAI = default(string);
					}
					this.SendPropertyChanged("LOAISP");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHACUNGCAP_SANPHAM", Storage="_NHACUNGCAP", ThisKey="MANCC", OtherKey="MANCC", IsForeignKey=true)]
		public NHACUNGCAP NHACUNGCAP
		{
			get
			{
				return this._NHACUNGCAP.Entity;
			}
			set
			{
				NHACUNGCAP previousValue = this._NHACUNGCAP.Entity;
				if (((previousValue != value) 
							|| (this._NHACUNGCAP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHACUNGCAP.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._NHACUNGCAP.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MANCC = value.MANCC;
					}
					else
					{
						this._MANCC = default(Nullable<int>);
					}
					this.SendPropertyChanged("NHACUNGCAP");
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
		
		private void attach_CTDONHANGs(CTDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = this;
		}
		
		private void detach_CTDONHANGs(CTDONHANG entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = null;
		}
	}
}
#pragma warning restore 1591
