﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Technight.Server.DataObjects.Adapters
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sqldev")]
	public partial class CookBookDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertIngredient(Ingredient instance);
    partial void UpdateIngredient(Ingredient instance);
    partial void DeleteIngredient(Ingredient instance);
    partial void InsertRecipeIngredient(RecipeIngredient instance);
    partial void UpdateRecipeIngredient(RecipeIngredient instance);
    partial void DeleteRecipeIngredient(RecipeIngredient instance);
    partial void InsertRecipe(Recipe instance);
    partial void UpdateRecipe(Recipe instance);
    partial void DeleteRecipe(Recipe instance);
    partial void InsertUserPassword(UserPassword instance);
    partial void UpdateUserPassword(UserPassword instance);
    partial void DeleteUserPassword(UserPassword instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public CookBookDataContext() : 
				base(global::Technight.Server.Properties.Settings.Default.sqldevConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CookBookDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CookBookDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CookBookDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CookBookDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Ingredient> Ingredients
		{
			get
			{
				return this.GetTable<Ingredient>();
			}
		}
		
		public System.Data.Linq.Table<RecipeIngredient> RecipeIngredients
		{
			get
			{
				return this.GetTable<RecipeIngredient>();
			}
		}
		
		public System.Data.Linq.Table<Recipe> Recipes
		{
			get
			{
				return this.GetTable<Recipe>();
			}
		}
		
		public System.Data.Linq.Table<UserPassword> UserPasswords
		{
			get
			{
				return this.GetTable<UserPassword>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ingredients")]
	public partial class Ingredient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IngredientId;
		
		private string _Name;
		
		private string _Amount;
		
		private System.Nullable<System.DateTime> _InsertDt;
		
		private EntitySet<RecipeIngredient> _RecipeIngredients;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIngredientIdChanging(int value);
    partial void OnIngredientIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAmountChanging(string value);
    partial void OnAmountChanged();
    partial void OnInsertDtChanging(System.Nullable<System.DateTime> value);
    partial void OnInsertDtChanged();
    #endregion
		
		public Ingredient()
		{
			this._RecipeIngredients = new EntitySet<RecipeIngredient>(new Action<RecipeIngredient>(this.attach_RecipeIngredients), new Action<RecipeIngredient>(this.detach_RecipeIngredients));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IngredientId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IngredientId
		{
			get
			{
				return this._IngredientId;
			}
			set
			{
				if ((this._IngredientId != value))
				{
					this.OnIngredientIdChanging(value);
					this.SendPropertyChanging();
					this._IngredientId = value;
					this.SendPropertyChanged("IngredientId");
					this.OnIngredientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Amount
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertDt", DbType="DateTime")]
		public System.Nullable<System.DateTime> InsertDt
		{
			get
			{
				return this._InsertDt;
			}
			set
			{
				if ((this._InsertDt != value))
				{
					this.OnInsertDtChanging(value);
					this.SendPropertyChanging();
					this._InsertDt = value;
					this.SendPropertyChanged("InsertDt");
					this.OnInsertDtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ingredient_RecipeIngredient", Storage="_RecipeIngredients", ThisKey="IngredientId", OtherKey="IngredientId")]
		public EntitySet<RecipeIngredient> RecipeIngredients
		{
			get
			{
				return this._RecipeIngredients;
			}
			set
			{
				this._RecipeIngredients.Assign(value);
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
		
		private void attach_RecipeIngredients(RecipeIngredient entity)
		{
			this.SendPropertyChanging();
			entity.Ingredient = this;
		}
		
		private void detach_RecipeIngredients(RecipeIngredient entity)
		{
			this.SendPropertyChanging();
			entity.Ingredient = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RecipeIngredients")]
	public partial class RecipeIngredient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _RecipeId;
		
		private int _IngredientId;
		
		private EntityRef<Ingredient> _Ingredient;
		
		private EntityRef<Recipe> _Recipe;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnRecipeIdChanging(int value);
    partial void OnRecipeIdChanged();
    partial void OnIngredientIdChanging(int value);
    partial void OnIngredientIdChanged();
    #endregion
		
		public RecipeIngredient()
		{
			this._Ingredient = default(EntityRef<Ingredient>);
			this._Recipe = default(EntityRef<Recipe>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipeId", DbType="Int NOT NULL")]
		public int RecipeId
		{
			get
			{
				return this._RecipeId;
			}
			set
			{
				if ((this._RecipeId != value))
				{
					if (this._Recipe.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRecipeIdChanging(value);
					this.SendPropertyChanging();
					this._RecipeId = value;
					this.SendPropertyChanged("RecipeId");
					this.OnRecipeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IngredientId", DbType="Int NOT NULL")]
		public int IngredientId
		{
			get
			{
				return this._IngredientId;
			}
			set
			{
				if ((this._IngredientId != value))
				{
					if (this._Ingredient.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIngredientIdChanging(value);
					this.SendPropertyChanging();
					this._IngredientId = value;
					this.SendPropertyChanged("IngredientId");
					this.OnIngredientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ingredient_RecipeIngredient", Storage="_Ingredient", ThisKey="IngredientId", OtherKey="IngredientId", IsForeignKey=true)]
		public Ingredient Ingredient
		{
			get
			{
				return this._Ingredient.Entity;
			}
			set
			{
				Ingredient previousValue = this._Ingredient.Entity;
				if (((previousValue != value) 
							|| (this._Ingredient.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ingredient.Entity = null;
						previousValue.RecipeIngredients.Remove(this);
					}
					this._Ingredient.Entity = value;
					if ((value != null))
					{
						value.RecipeIngredients.Add(this);
						this._IngredientId = value.IngredientId;
					}
					else
					{
						this._IngredientId = default(int);
					}
					this.SendPropertyChanged("Ingredient");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Recipe_RecipeIngredient", Storage="_Recipe", ThisKey="RecipeId", OtherKey="RecipeId", IsForeignKey=true)]
		public Recipe Recipe
		{
			get
			{
				return this._Recipe.Entity;
			}
			set
			{
				Recipe previousValue = this._Recipe.Entity;
				if (((previousValue != value) 
							|| (this._Recipe.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Recipe.Entity = null;
						previousValue.RecipeIngredients.Remove(this);
					}
					this._Recipe.Entity = value;
					if ((value != null))
					{
						value.RecipeIngredients.Add(this);
						this._RecipeId = value.RecipeId;
					}
					else
					{
						this._RecipeId = default(int);
					}
					this.SendPropertyChanged("Recipe");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recipes")]
	public partial class Recipe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RecipeId;
		
		private string _Name;
		
		private System.Nullable<System.DateTime> _InsertDt;
		
		private string _Author;
		
		private System.Nullable<int> _Rating;
		
		private string _Origin;
		
		private EntitySet<RecipeIngredient> _RecipeIngredients;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRecipeIdChanging(int value);
    partial void OnRecipeIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnInsertDtChanging(System.Nullable<System.DateTime> value);
    partial void OnInsertDtChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnRatingChanging(System.Nullable<int> value);
    partial void OnRatingChanged();
    partial void OnOriginChanging(string value);
    partial void OnOriginChanged();
    #endregion
		
		public Recipe()
		{
			this._RecipeIngredients = new EntitySet<RecipeIngredient>(new Action<RecipeIngredient>(this.attach_RecipeIngredients), new Action<RecipeIngredient>(this.detach_RecipeIngredients));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RecipeId
		{
			get
			{
				return this._RecipeId;
			}
			set
			{
				if ((this._RecipeId != value))
				{
					this.OnRecipeIdChanging(value);
					this.SendPropertyChanging();
					this._RecipeId = value;
					this.SendPropertyChanged("RecipeId");
					this.OnRecipeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertDt", DbType="DateTime")]
		public System.Nullable<System.DateTime> InsertDt
		{
			get
			{
				return this._InsertDt;
			}
			set
			{
				if ((this._InsertDt != value))
				{
					this.OnInsertDtChanging(value);
					this.SendPropertyChanging();
					this._InsertDt = value;
					this.SendPropertyChanged("InsertDt");
					this.OnInsertDtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="NVarChar(50)")]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Int")]
		public System.Nullable<int> Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this.OnRatingChanging(value);
					this.SendPropertyChanging();
					this._Rating = value;
					this.SendPropertyChanged("Rating");
					this.OnRatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Origin", DbType="VarChar(50)")]
		public string Origin
		{
			get
			{
				return this._Origin;
			}
			set
			{
				if ((this._Origin != value))
				{
					this.OnOriginChanging(value);
					this.SendPropertyChanging();
					this._Origin = value;
					this.SendPropertyChanged("Origin");
					this.OnOriginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Recipe_RecipeIngredient", Storage="_RecipeIngredients", ThisKey="RecipeId", OtherKey="RecipeId")]
		public EntitySet<RecipeIngredient> RecipeIngredients
		{
			get
			{
				return this._RecipeIngredients;
			}
			set
			{
				this._RecipeIngredients.Assign(value);
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
		
		private void attach_RecipeIngredients(RecipeIngredient entity)
		{
			this.SendPropertyChanging();
			entity.Recipe = this;
		}
		
		private void detach_RecipeIngredients(RecipeIngredient entity)
		{
			this.SendPropertyChanging();
			entity.Recipe = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserPasswords")]
	public partial class UserPassword : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserPasswordId;
		
		private int _UserId;
		
		private string _Password;
		
		private System.Nullable<System.DateTime> _InsertDt;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserPasswordIdChanging(int value);
    partial void OnUserPasswordIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnInsertDtChanging(System.Nullable<System.DateTime> value);
    partial void OnInsertDtChanged();
    #endregion
		
		public UserPassword()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPasswordId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserPasswordId
		{
			get
			{
				return this._UserPasswordId;
			}
			set
			{
				if ((this._UserPasswordId != value))
				{
					this.OnUserPasswordIdChanging(value);
					this.SendPropertyChanging();
					this._UserPasswordId = value;
					this.SendPropertyChanged("UserPasswordId");
					this.OnUserPasswordIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertDt", DbType="DateTime")]
		public System.Nullable<System.DateTime> InsertDt
		{
			get
			{
				return this._InsertDt;
			}
			set
			{
				if ((this._InsertDt != value))
				{
					this.OnInsertDtChanging(value);
					this.SendPropertyChanging();
					this._InsertDt = value;
					this.SendPropertyChanged("InsertDt");
					this.OnInsertDtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserPassword", Storage="_User", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.UserPasswords.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.UserPasswords.Add(this);
						this._UserId = value.UserId;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserId;
		
		private string _username;
		
		private string _email;
		
		private System.Nullable<System.DateTime> _lastlogin;
		
		private System.Nullable<System.DateTime> _InsertDt;
		
		private System.Nullable<System.DateTime> _UpdateDt;
		
		private EntitySet<UserPassword> _UserPasswords;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnlastloginChanging(System.Nullable<System.DateTime> value);
    partial void OnlastloginChanged();
    partial void OnInsertDtChanging(System.Nullable<System.DateTime> value);
    partial void OnInsertDtChanged();
    partial void OnUpdateDtChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdateDtChanged();
    #endregion
		
		public User()
		{
			this._UserPasswords = new EntitySet<UserPassword>(new Action<UserPassword>(this.attach_UserPasswords), new Action<UserPassword>(this.detach_UserPasswords));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastlogin", DbType="DateTime")]
		public System.Nullable<System.DateTime> lastlogin
		{
			get
			{
				return this._lastlogin;
			}
			set
			{
				if ((this._lastlogin != value))
				{
					this.OnlastloginChanging(value);
					this.SendPropertyChanging();
					this._lastlogin = value;
					this.SendPropertyChanged("lastlogin");
					this.OnlastloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertDt", DbType="DateTime")]
		public System.Nullable<System.DateTime> InsertDt
		{
			get
			{
				return this._InsertDt;
			}
			set
			{
				if ((this._InsertDt != value))
				{
					this.OnInsertDtChanging(value);
					this.SendPropertyChanging();
					this._InsertDt = value;
					this.SendPropertyChanged("InsertDt");
					this.OnInsertDtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateDt", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdateDt
		{
			get
			{
				return this._UpdateDt;
			}
			set
			{
				if ((this._UpdateDt != value))
				{
					this.OnUpdateDtChanging(value);
					this.SendPropertyChanging();
					this._UpdateDt = value;
					this.SendPropertyChanged("UpdateDt");
					this.OnUpdateDtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserPassword", Storage="_UserPasswords", ThisKey="UserId", OtherKey="UserId")]
		public EntitySet<UserPassword> UserPasswords
		{
			get
			{
				return this._UserPasswords;
			}
			set
			{
				this._UserPasswords.Assign(value);
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
		
		private void attach_UserPasswords(UserPassword entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_UserPasswords(UserPassword entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591