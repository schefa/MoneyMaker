﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoneyMaker.Models.Database
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LocalDatabase")]
	public partial class DatabaseClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnCreated();
    partial void InsertBankAccount(BankAccount instance);
    partial void UpdateBankAccount(BankAccount instance);
    partial void DeleteBankAccount(BankAccount instance);
    partial void InsertWatchList(WatchList instance);
    partial void UpdateWatchList(WatchList instance);
    partial void DeleteWatchList(WatchList instance);
    partial void InsertDepot(Depot instance);
    partial void UpdateDepot(Depot instance);
    partial void DeleteDepot(Depot instance);
    partial void InsertSettings(Settings instance);
    partial void UpdateSettings(Settings instance);
    partial void DeleteSettings(Settings instance);
    partial void InsertStocks(Stocks instance);
    partial void UpdateStocks(Stocks instance);
    partial void DeleteStocks(Stocks instance);
    partial void InsertStocksMap(StocksMap instance);
    partial void UpdateStocksMap(StocksMap instance);
    partial void DeleteStocksMap(StocksMap instance);
    partial void InsertTransactions(Transactions instance);
    partial void UpdateTransactions(Transactions instance);
    partial void DeleteTransactions(Transactions instance);
    partial void InsertUserLines(UserLines instance);
    partial void UpdateUserLines(UserLines instance);
    partial void DeleteUserLines(UserLines instance);
    #endregion
		
		public DatabaseClassDataContext() : 
				base(global::MoneyMaker.Properties.Settings.Default.LocalDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatabaseClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BankAccount> BankAccount
		{
			get
			{
				return this.GetTable<BankAccount>();
			}
		}
		
		public System.Data.Linq.Table<WatchList> WatchList
		{
			get
			{
				return this.GetTable<WatchList>();
			}
		}
		
		public System.Data.Linq.Table<Depot> Depot
		{
			get
			{
				return this.GetTable<Depot>();
			}
		}
		
		public System.Data.Linq.Table<Settings> Settings
		{
			get
			{
				return this.GetTable<Settings>();
			}
		}
		
		public System.Data.Linq.Table<Stocks> Stocks
		{
			get
			{
				return this.GetTable<Stocks>();
			}
		}
		
		public System.Data.Linq.Table<StocksMap> StocksMap
		{
			get
			{
				return this.GetTable<StocksMap>();
			}
		}
		
		public System.Data.Linq.Table<Transactions> Transactions
		{
			get
			{
				return this.GetTable<Transactions>();
			}
		}
		
		public System.Data.Linq.Table<UserLines> UserLines
		{
			get
			{
				return this.GetTable<UserLines>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BankAccount")]
	public partial class BankAccount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BankAccountID;
		
		private decimal _AccountBalance;
		
		private EntitySet<Transactions> _Transactions;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBankAccountIDChanging(int value);
    partial void OnBankAccountIDChanged();
    partial void OnAccountBalanceChanging(decimal value);
    partial void OnAccountBalanceChanged();
    #endregion
		
		public BankAccount()
		{
			this._Transactions = new EntitySet<Transactions>(new Action<Transactions>(this.attach_Transactions), new Action<Transactions>(this.detach_Transactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BankAccountID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BankAccountID
		{
			get
			{
				return this._BankAccountID;
			}
			set
			{
				if ((this._BankAccountID != value))
				{
					this.OnBankAccountIDChanging(value);
					this.SendPropertyChanging();
					this._BankAccountID = value;
					this.SendPropertyChanged("BankAccountID");
					this.OnBankAccountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountBalance", DbType="Money NOT NULL")]
		public decimal AccountBalance
		{
			get
			{
				return this._AccountBalance;
			}
			set
			{
				if ((this._AccountBalance != value))
				{
					this.OnAccountBalanceChanging(value);
					this.SendPropertyChanging();
					this._AccountBalance = value;
					this.SendPropertyChanged("AccountBalance");
					this.OnAccountBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BankAccount_Transactions", Storage="_Transactions", ThisKey="BankAccountID", OtherKey="BankAccountID")]
		public EntitySet<Transactions> Transactions
		{
			get
			{
				return this._Transactions;
			}
			set
			{
				this._Transactions.Assign(value);
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
		
		private void attach_Transactions(Transactions entity)
		{
			this.SendPropertyChanging();
			entity.BankAccount = this;
		}
		
		private void detach_Transactions(Transactions entity)
		{
			this.SendPropertyChanging();
			entity.BankAccount = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WatchList")]
	public partial class WatchList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _WatchListID;
		
		private string _Name;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnWatchListIDChanging(int value);
    partial void OnWatchListIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public WatchList()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WatchListID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int WatchListID
		{
			get
			{
				return this._WatchListID;
			}
			set
			{
				if ((this._WatchListID != value))
				{
					this.OnWatchListIDChanging(value);
					this.SendPropertyChanging();
					this._WatchListID = value;
					this.SendPropertyChanged("WatchListID");
					this.OnWatchListIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Depot")]
	public partial class Depot : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DepotID;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDepotIDChanging(int value);
    partial void OnDepotIDChanged();
    #endregion
		
		public Depot()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepotID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DepotID
		{
			get
			{
				return this._DepotID;
			}
			set
			{
				if ((this._DepotID != value))
				{
					this.OnDepotIDChanging(value);
					this.SendPropertyChanging();
					this._DepotID = value;
					this.SendPropertyChanged("DepotID");
					this.OnDepotIDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Settings")]
	public partial class Settings : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SettingsID;
		
		private int _AccountID;
		
		private string _key;
		
		private string _value;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSettingsIDChanging(int value);
    partial void OnSettingsIDChanged();
    partial void OnAccountIDChanging(int value);
    partial void OnAccountIDChanged();
    partial void OnkeyChanging(string value);
    partial void OnkeyChanged();
    partial void OnvalueChanging(string value);
    partial void OnvalueChanged();
    #endregion
		
		public Settings()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SettingsID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SettingsID
		{
			get
			{
				return this._SettingsID;
			}
			set
			{
				if ((this._SettingsID != value))
				{
					this.OnSettingsIDChanging(value);
					this.SendPropertyChanging();
					this._SettingsID = value;
					this.SendPropertyChanged("SettingsID");
					this.OnSettingsIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountID", DbType="Int NOT NULL")]
		public int AccountID
		{
			get
			{
				return this._AccountID;
			}
			set
			{
				if ((this._AccountID != value))
				{
					this.OnAccountIDChanging(value);
					this.SendPropertyChanging();
					this._AccountID = value;
					this.SendPropertyChanged("AccountID");
					this.OnAccountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[key]", Storage="_key", DbType="NVarChar(50)")]
		public string key
		{
			get
			{
				return this._key;
			}
			set
			{
				if ((this._key != value))
				{
					this.OnkeyChanging(value);
					this.SendPropertyChanging();
					this._key = value;
					this.SendPropertyChanged("key");
					this.OnkeyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="NVarChar(50)")]
		public string value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this.OnvalueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("value");
					this.OnvalueChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Stocks")]
	public partial class Stocks : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StockID;
		
		private string _Name;
		
		private string _Symbol;
		
		private string _StockExchange;
		
		private string _Typ;
		
		private EntitySet<StocksMap> _StocksMap;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStockIDChanging(int value);
    partial void OnStockIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSymbolChanging(string value);
    partial void OnSymbolChanged();
    partial void OnStockExchangeChanging(string value);
    partial void OnStockExchangeChanged();
    partial void OnTypChanging(string value);
    partial void OnTypChanged();
    #endregion
		
		public Stocks()
		{
			this._StocksMap = new EntitySet<StocksMap>(new Action<StocksMap>(this.attach_StocksMap), new Action<StocksMap>(this.detach_StocksMap));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StockID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int StockID
		{
			get
			{
				return this._StockID;
			}
			set
			{
				if ((this._StockID != value))
				{
					this.OnStockIDChanging(value);
					this.SendPropertyChanging();
					this._StockID = value;
					this.SendPropertyChanged("StockID");
					this.OnStockIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Symbol", DbType="VarChar(50)")]
		public string Symbol
		{
			get
			{
				return this._Symbol;
			}
			set
			{
				if ((this._Symbol != value))
				{
					this.OnSymbolChanging(value);
					this.SendPropertyChanging();
					this._Symbol = value;
					this.SendPropertyChanged("Symbol");
					this.OnSymbolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StockExchange", DbType="VarChar(10)")]
		public string StockExchange
		{
			get
			{
				return this._StockExchange;
			}
			set
			{
				if ((this._StockExchange != value))
				{
					this.OnStockExchangeChanging(value);
					this.SendPropertyChanging();
					this._StockExchange = value;
					this.SendPropertyChanged("StockExchange");
					this.OnStockExchangeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Typ", DbType="VarChar(50)")]
		public string Typ
		{
			get
			{
				return this._Typ;
			}
			set
			{
				if ((this._Typ != value))
				{
					this.OnTypChanging(value);
					this.SendPropertyChanging();
					this._Typ = value;
					this.SendPropertyChanged("Typ");
					this.OnTypChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Stocks_StocksMap", Storage="_StocksMap", ThisKey="StockID", OtherKey="StockID")]
		public EntitySet<StocksMap> StocksMap
		{
			get
			{
				return this._StocksMap;
			}
			set
			{
				this._StocksMap.Assign(value);
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
		
		private void attach_StocksMap(StocksMap entity)
		{
			this.SendPropertyChanging();
			entity.Stocks = this;
		}
		
		private void detach_StocksMap(StocksMap entity)
		{
			this.SendPropertyChanging();
			entity.Stocks = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StocksMap")]
	public partial class StocksMap : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _StocksMapID;
		
		private char _Category;
		
		private int _CategoryID;
		
		private int _StockID;
		
		private System.Nullable<decimal> _PurchasePrice;
		
		private System.Nullable<int> _Quantity;
		
		private System.Nullable<System.DateTime> _PurchaseDate;
		
		private EntitySet<UserLines> _UserLines;
		
		private EntityRef<Stocks> _Stocks;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStocksMapIDChanging(int value);
    partial void OnStocksMapIDChanged();
    partial void OnCategoryChanging(char value);
    partial void OnCategoryChanged();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnStockIDChanging(int value);
    partial void OnStockIDChanged();
    partial void OnPurchasePriceChanging(System.Nullable<decimal> value);
    partial void OnPurchasePriceChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnPurchaseDateChanging(System.Nullable<System.DateTime> value);
    partial void OnPurchaseDateChanged();
    #endregion
		
		public StocksMap()
		{
			this._UserLines = new EntitySet<UserLines>(new Action<UserLines>(this.attach_UserLines), new Action<UserLines>(this.detach_UserLines));
			this._Stocks = default(EntityRef<Stocks>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StocksMapID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int StocksMapID
		{
			get
			{
				return this._StocksMapID;
			}
			set
			{
				if ((this._StocksMapID != value))
				{
					this.OnStocksMapIDChanging(value);
					this.SendPropertyChanging();
					this._StocksMapID = value;
					this.SendPropertyChanged("StocksMapID");
					this.OnStocksMapIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="Char(1) NOT NULL")]
		public char Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int NOT NULL")]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StockID", DbType="Int NOT NULL")]
		public int StockID
		{
			get
			{
				return this._StockID;
			}
			set
			{
				if ((this._StockID != value))
				{
					if (this._Stocks.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStockIDChanging(value);
					this.SendPropertyChanging();
					this._StockID = value;
					this.SendPropertyChanged("StockID");
					this.OnStockIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchasePrice", DbType="Money")]
		public System.Nullable<decimal> PurchasePrice
		{
			get
			{
				return this._PurchasePrice;
			}
			set
			{
				if ((this._PurchasePrice != value))
				{
					this.OnPurchasePriceChanging(value);
					this.SendPropertyChanging();
					this._PurchasePrice = value;
					this.SendPropertyChanged("PurchasePrice");
					this.OnPurchasePriceChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PurchaseDate", DbType="Date")]
		public System.Nullable<System.DateTime> PurchaseDate
		{
			get
			{
				return this._PurchaseDate;
			}
			set
			{
				if ((this._PurchaseDate != value))
				{
					this.OnPurchaseDateChanging(value);
					this.SendPropertyChanging();
					this._PurchaseDate = value;
					this.SendPropertyChanged("PurchaseDate");
					this.OnPurchaseDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="StocksMap_UserLines", Storage="_UserLines", ThisKey="StocksMapID", OtherKey="StocksMapID")]
		public EntitySet<UserLines> UserLines
		{
			get
			{
				return this._UserLines;
			}
			set
			{
				this._UserLines.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Stocks_StocksMap", Storage="_Stocks", ThisKey="StockID", OtherKey="StockID", IsForeignKey=true)]
		public Stocks Stocks
		{
			get
			{
				return this._Stocks.Entity;
			}
			set
			{
				Stocks previousValue = this._Stocks.Entity;
				if (((previousValue != value) 
							|| (this._Stocks.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Stocks.Entity = null;
						previousValue.StocksMap.Remove(this);
					}
					this._Stocks.Entity = value;
					if ((value != null))
					{
						value.StocksMap.Add(this);
						this._StockID = value.StockID;
					}
					else
					{
						this._StockID = default(int);
					}
					this.SendPropertyChanged("Stocks");
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
		
		private void attach_UserLines(UserLines entity)
		{
			this.SendPropertyChanging();
			entity.StocksMap = this;
		}
		
		private void detach_UserLines(UserLines entity)
		{
			this.SendPropertyChanging();
			entity.StocksMap = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Transactions")]
	public partial class Transactions : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TransactionID;
		
		private char _TransactionType;
		
		private int _BankAccountID;
		
		private System.DateTime _Created;
		
		private System.Nullable<decimal> _Amount;
		
		private string _Description;
		
		private EntityRef<BankAccount> _BankAccount;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransactionIDChanging(int value);
    partial void OnTransactionIDChanged();
    partial void OnTransactionTypeChanging(char value);
    partial void OnTransactionTypeChanged();
    partial void OnBankAccountIDChanging(int value);
    partial void OnBankAccountIDChanged();
    partial void OnCreatedChanging(System.DateTime value);
    partial void OnCreatedChanged();
    partial void OnAmountChanging(System.Nullable<decimal> value);
    partial void OnAmountChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Transactions()
		{
			this._BankAccount = default(EntityRef<BankAccount>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TransactionID
		{
			get
			{
				return this._TransactionID;
			}
			set
			{
				if ((this._TransactionID != value))
				{
					this.OnTransactionIDChanging(value);
					this.SendPropertyChanging();
					this._TransactionID = value;
					this.SendPropertyChanged("TransactionID");
					this.OnTransactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionType", DbType="Char(1) NOT NULL")]
		public char TransactionType
		{
			get
			{
				return this._TransactionType;
			}
			set
			{
				if ((this._TransactionType != value))
				{
					this.OnTransactionTypeChanging(value);
					this.SendPropertyChanging();
					this._TransactionType = value;
					this.SendPropertyChanged("TransactionType");
					this.OnTransactionTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BankAccountID", DbType="Int NOT NULL")]
		public int BankAccountID
		{
			get
			{
				return this._BankAccountID;
			}
			set
			{
				if ((this._BankAccountID != value))
				{
					if (this._BankAccount.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBankAccountIDChanging(value);
					this.SendPropertyChanging();
					this._BankAccountID = value;
					this.SendPropertyChanged("BankAccountID");
					this.OnBankAccountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Created", DbType="DateTime NOT NULL")]
		public System.DateTime Created
		{
			get
			{
				return this._Created;
			}
			set
			{
				if ((this._Created != value))
				{
					this.OnCreatedChanging(value);
					this.SendPropertyChanging();
					this._Created = value;
					this.SendPropertyChanged("Created");
					this.OnCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Money")]
		public System.Nullable<decimal> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BankAccount_Transactions", Storage="_BankAccount", ThisKey="BankAccountID", OtherKey="BankAccountID", IsForeignKey=true)]
		public BankAccount BankAccount
		{
			get
			{
				return this._BankAccount.Entity;
			}
			set
			{
				BankAccount previousValue = this._BankAccount.Entity;
				if (((previousValue != value) 
							|| (this._BankAccount.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BankAccount.Entity = null;
						previousValue.Transactions.Remove(this);
					}
					this._BankAccount.Entity = value;
					if ((value != null))
					{
						value.Transactions.Add(this);
						this._BankAccountID = value.BankAccountID;
					}
					else
					{
						this._BankAccountID = default(int);
					}
					this.SendPropertyChanged("BankAccount");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserLines")]
	public partial class UserLines : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LineID;
		
		private int _StocksMapID;
		
		private double _PricePoint1;
		
		private double _PricePoint2;
		
		private double _TimePoint1;
		
		private double _TimePoint2;
		
		private string _LineColor;
		
		private short _Thickness;
		
		private EntityRef<StocksMap> _StocksMap;
		
    #region Definitionen der Erweiterungsmethoden
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLineIDChanging(int value);
    partial void OnLineIDChanged();
    partial void OnStocksMapIDChanging(int value);
    partial void OnStocksMapIDChanged();
    partial void OnPricePoint1Changing(double value);
    partial void OnPricePoint1Changed();
    partial void OnPricePoint2Changing(double value);
    partial void OnPricePoint2Changed();
    partial void OnTimePoint1Changing(double value);
    partial void OnTimePoint1Changed();
    partial void OnTimePoint2Changing(double value);
    partial void OnTimePoint2Changed();
    partial void OnLineColorChanging(string value);
    partial void OnLineColorChanged();
    partial void OnThicknessChanging(short value);
    partial void OnThicknessChanged();
    #endregion
		
		public UserLines()
		{
			this._StocksMap = default(EntityRef<StocksMap>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LineID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LineID
		{
			get
			{
				return this._LineID;
			}
			set
			{
				if ((this._LineID != value))
				{
					this.OnLineIDChanging(value);
					this.SendPropertyChanging();
					this._LineID = value;
					this.SendPropertyChanged("LineID");
					this.OnLineIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StocksMapID", DbType="Int NOT NULL")]
		public int StocksMapID
		{
			get
			{
				return this._StocksMapID;
			}
			set
			{
				if ((this._StocksMapID != value))
				{
					if (this._StocksMap.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStocksMapIDChanging(value);
					this.SendPropertyChanging();
					this._StocksMapID = value;
					this.SendPropertyChanged("StocksMapID");
					this.OnStocksMapIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PricePoint1", DbType="Float NOT NULL")]
		public double PricePoint1
		{
			get
			{
				return this._PricePoint1;
			}
			set
			{
				if ((this._PricePoint1 != value))
				{
					this.OnPricePoint1Changing(value);
					this.SendPropertyChanging();
					this._PricePoint1 = value;
					this.SendPropertyChanged("PricePoint1");
					this.OnPricePoint1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PricePoint2", DbType="Float NOT NULL")]
		public double PricePoint2
		{
			get
			{
				return this._PricePoint2;
			}
			set
			{
				if ((this._PricePoint2 != value))
				{
					this.OnPricePoint2Changing(value);
					this.SendPropertyChanging();
					this._PricePoint2 = value;
					this.SendPropertyChanged("PricePoint2");
					this.OnPricePoint2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimePoint1", DbType="Float NOT NULL")]
		public double TimePoint1
		{
			get
			{
				return this._TimePoint1;
			}
			set
			{
				if ((this._TimePoint1 != value))
				{
					this.OnTimePoint1Changing(value);
					this.SendPropertyChanging();
					this._TimePoint1 = value;
					this.SendPropertyChanged("TimePoint1");
					this.OnTimePoint1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimePoint2", DbType="Float NOT NULL")]
		public double TimePoint2
		{
			get
			{
				return this._TimePoint2;
			}
			set
			{
				if ((this._TimePoint2 != value))
				{
					this.OnTimePoint2Changing(value);
					this.SendPropertyChanging();
					this._TimePoint2 = value;
					this.SendPropertyChanged("TimePoint2");
					this.OnTimePoint2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LineColor", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string LineColor
		{
			get
			{
				return this._LineColor;
			}
			set
			{
				if ((this._LineColor != value))
				{
					this.OnLineColorChanging(value);
					this.SendPropertyChanging();
					this._LineColor = value;
					this.SendPropertyChanged("LineColor");
					this.OnLineColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thickness", DbType="SmallInt NOT NULL")]
		public short Thickness
		{
			get
			{
				return this._Thickness;
			}
			set
			{
				if ((this._Thickness != value))
				{
					this.OnThicknessChanging(value);
					this.SendPropertyChanging();
					this._Thickness = value;
					this.SendPropertyChanged("Thickness");
					this.OnThicknessChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="StocksMap_UserLines", Storage="_StocksMap", ThisKey="StocksMapID", OtherKey="StocksMapID", IsForeignKey=true)]
		public StocksMap StocksMap
		{
			get
			{
				return this._StocksMap.Entity;
			}
			set
			{
				StocksMap previousValue = this._StocksMap.Entity;
				if (((previousValue != value) 
							|| (this._StocksMap.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._StocksMap.Entity = null;
						previousValue.UserLines.Remove(this);
					}
					this._StocksMap.Entity = value;
					if ((value != null))
					{
						value.UserLines.Add(this);
						this._StocksMapID = value.StocksMapID;
					}
					else
					{
						this._StocksMapID = default(int);
					}
					this.SendPropertyChanged("StocksMap");
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
