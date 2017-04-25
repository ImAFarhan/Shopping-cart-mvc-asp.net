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

namespace MVC.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SeProject")]
	public partial class DbHandlerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertVendor(Vendor instance);
    partial void UpdateVendor(Vendor instance);
    partial void DeleteVendor(Vendor instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    #endregion
		
		public DbHandlerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SeProjectConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DbHandlerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbHandlerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbHandlerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbHandlerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Vendor> Vendors
		{
			get
			{
				return this.GetTable<Vendor>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Pid;
		
		private string _PName;
		
		private System.Nullable<int> _VendorId;
		
		private System.Nullable<int> _Quantity;
		
		private System.Nullable<int> _Price;
		
		private string _Description;
		
		private System.Data.Linq.Binary _PImage;
		
		private EntityRef<Vendor> _Vendor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPidChanging(int value);
    partial void OnPidChanged();
    partial void OnPNameChanging(string value);
    partial void OnPNameChanged();
    partial void OnVendorIdChanging(System.Nullable<int> value);
    partial void OnVendorIdChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnPriceChanging(System.Nullable<int> value);
    partial void OnPriceChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPImageChanging(System.Data.Linq.Binary value);
    partial void OnPImageChanged();
    #endregion
		
		public Product()
		{
			this._Vendor = default(EntityRef<Vendor>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Pid
		{
			get
			{
				return this._Pid;
			}
			set
			{
				if ((this._Pid != value))
				{
					this.OnPidChanging(value);
					this.SendPropertyChanging();
					this._Pid = value;
					this.SendPropertyChanged("Pid");
					this.OnPidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PName", DbType="VarChar(MAX)")]
		public string PName
		{
			get
			{
				return this._PName;
			}
			set
			{
				if ((this._PName != value))
				{
					this.OnPNameChanging(value);
					this.SendPropertyChanging();
					this._PName = value;
					this.SendPropertyChanged("PName");
					this.OnPNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VendorId", DbType="Int")]
		public System.Nullable<int> VendorId
		{
			get
			{
				return this._VendorId;
			}
			set
			{
				if ((this._VendorId != value))
				{
					if (this._Vendor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnVendorIdChanging(value);
					this.SendPropertyChanging();
					this._VendorId = value;
					this.SendPropertyChanged("VendorId");
					this.OnVendorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int")]
		public System.Nullable<int> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PImage", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public  byte[] PImage
		{
			get
			{
				return this._PImage.ToArray();
			}
			set
			{
				if ((this._PImage != value))
				{
					this.OnPImageChanging(value);
					this.SendPropertyChanging();
					this._PImage = value;
					this.SendPropertyChanged("PImage");
					this.OnPImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Vendor_Product", Storage="_Vendor", ThisKey="VendorId", OtherKey="Vid", IsForeignKey=true)]
		public Vendor Vendor
		{
			get
			{
				return this._Vendor.Entity;
			}
			set
			{
				Vendor previousValue = this._Vendor.Entity;
				if (((previousValue != value) 
							|| (this._Vendor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Vendor.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Vendor.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._VendorId = value.Vid;
					}
					else
					{
						this._VendorId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Vendor");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Vendor")]
	public partial class Vendor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Vid;
		
		private string _VName;
		
		private string _VEmail;
		
		private string _VPassword;
		
		private System.Data.Linq.Binary  _VImage;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnVidChanging(int value);
    partial void OnVidChanged();
    partial void OnVNameChanging(string value);
    partial void OnVNameChanged();
    partial void OnVEmailChanging(string value);
    partial void OnVEmailChanged();
    partial void OnVPasswordChanging(string value);
    partial void OnVPasswordChanged();
    partial void OnVImageChanging(System.Data.Linq.Binary value);
    partial void OnVImageChanged();
    #endregion
		
		public Vendor()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Vid
		{
			get
			{
				return this._Vid;
			}
			set
			{
				if ((this._Vid != value))
				{
					this.OnVidChanging(value);
					this.SendPropertyChanging();
					this._Vid = value;
					this.SendPropertyChanged("Vid");
					this.OnVidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VName", DbType="VarChar(MAX)")]
		public string VName
		{
			get
			{
				return this._VName;
			}
			set
			{
				if ((this._VName != value))
				{
					this.OnVNameChanging(value);
					this.SendPropertyChanging();
					this._VName = value;
					this.SendPropertyChanged("VName");
					this.OnVNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VEmail", DbType="VarChar(MAX)")]
		public string VEmail
		{
			get
			{
				return this._VEmail;
			}
			set
			{
				if ((this._VEmail != value))
				{
					this.OnVEmailChanging(value);
					this.SendPropertyChanging();
					this._VEmail = value;
					this.SendPropertyChanged("VEmail");
					this.OnVEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VPassword", DbType="VarChar(MAX)")]
		public string VPassword
		{
			get
			{
				return this._VPassword;
			}
			set
			{
				if ((this._VPassword != value))
				{
					this.OnVPasswordChanging(value);
					this.SendPropertyChanging();
					this._VPassword = value;
					this.SendPropertyChanged("VPassword");
					this.OnVPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VImage", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary VImage
		{
			get
			{
				return this._VImage;
			}
			set
			{
				if ((this._VImage != value))
				{
					this.OnVImageChanging(value);
					this.SendPropertyChanging();
					this._VImage = value;
					this.SendPropertyChanged("VImage");
					this.OnVImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Vendor_Product", Storage="_Products", ThisKey="Vid", OtherKey="VendorId")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
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
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Vendor = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Vendor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Cid;
		
		private string _VName;
		
		private string _UEmail;
		
		private string _UPassword;
		
		private System.Data.Linq.Binary _CImage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCidChanging(int value);
    partial void OnCidChanged();
    partial void OnVNameChanging(string value);
    partial void OnVNameChanged();
    partial void OnUEmailChanging(string value);
    partial void OnUEmailChanged();
    partial void OnUPasswordChanging(string value);
    partial void OnUPasswordChanged();
    partial void OnCImageChanging(System.Data.Linq.Binary value);
    partial void OnCImageChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Cid
		{
			get
			{
				return this._Cid;
			}
			set
			{
				if ((this._Cid != value))
				{
					this.OnCidChanging(value);
					this.SendPropertyChanging();
					this._Cid = value;
					this.SendPropertyChanged("Cid");
					this.OnCidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VName", DbType="VarChar(MAX)")]
		public string VName
		{
			get
			{
				return this._VName;
			}
			set
			{
				if ((this._VName != value))
				{
					this.OnVNameChanging(value);
					this.SendPropertyChanging();
					this._VName = value;
					this.SendPropertyChanged("VName");
					this.OnVNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UEmail", DbType="VarChar(MAX)")]
		public string UEmail
		{
			get
			{
				return this._UEmail;
			}
			set
			{
				if ((this._UEmail != value))
				{
					this.OnUEmailChanging(value);
					this.SendPropertyChanging();
					this._UEmail = value;
					this.SendPropertyChanged("UEmail");
					this.OnUEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UPassword", DbType="VarChar(MAX)")]
		public string UPassword
		{
			get
			{
				return this._UPassword;
			}
			set
			{
				if ((this._UPassword != value))
				{
					this.OnUPasswordChanging(value);
					this.SendPropertyChanging();
					this._UPassword = value;
					this.SendPropertyChanged("UPassword");
					this.OnUPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CImage", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public byte[] CImage
		{
			get
			{
				return this._CImage.ToArray();
			}
			set
			{
				if ((this._CImage != value))
				{
					this.OnCImageChanging(value);
					this.SendPropertyChanging();
					this._CImage = value;
					this.SendPropertyChanged("CImage");
					this.OnCImageChanged();
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
}
#pragma warning restore 1591
