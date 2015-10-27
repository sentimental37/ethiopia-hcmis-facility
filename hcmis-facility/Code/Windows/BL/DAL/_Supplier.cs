
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace DAL
{
	public abstract class _Supplier : SqlClientEntity
	{
		public _Supplier()
		{
			this.QuerySource = "Supplier";
			this.MappingName = "Supplier";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_SupplierLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ID, ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_SupplierLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ID
			{
				get
				{
					return new SqlParameter("@ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter CompanyName
			{
				get
				{
					return new SqlParameter("@CompanyName", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Address
			{
				get
				{
					return new SqlParameter("@Address", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Telephone
			{
				get
				{
					return new SqlParameter("@Telephone", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter ContactPerson
			{
				get
				{
					return new SqlParameter("@ContactPerson", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Mobile
			{
				get
				{
					return new SqlParameter("@Mobile", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter CompanyInfo
			{
				get
				{
					return new SqlParameter("@CompanyInfo", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter IsActive
			{
				get
				{
					return new SqlParameter("@IsActive", SqlDbType.Bit, 0);
				}
			}
			
			public static SqlParameter Email
			{
				get
				{
					return new SqlParameter("@Email", SqlDbType.VarChar, 50);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string CompanyName = "CompanyName";
            public const string Address = "Address";
            public const string Telephone = "Telephone";
            public const string ContactPerson = "ContactPerson";
            public const string Mobile = "Mobile";
            public const string CompanyInfo = "CompanyInfo";
            public const string IsActive = "IsActive";
            public const string Email = "Email";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Supplier.PropertyNames.ID;
					ht[CompanyName] = _Supplier.PropertyNames.CompanyName;
					ht[Address] = _Supplier.PropertyNames.Address;
					ht[Telephone] = _Supplier.PropertyNames.Telephone;
					ht[ContactPerson] = _Supplier.PropertyNames.ContactPerson;
					ht[Mobile] = _Supplier.PropertyNames.Mobile;
					ht[CompanyInfo] = _Supplier.PropertyNames.CompanyInfo;
					ht[IsActive] = _Supplier.PropertyNames.IsActive;
					ht[Email] = _Supplier.PropertyNames.Email;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ID = "ID";
            public const string CompanyName = "CompanyName";
            public const string Address = "Address";
            public const string Telephone = "Telephone";
            public const string ContactPerson = "ContactPerson";
            public const string Mobile = "Mobile";
            public const string CompanyInfo = "CompanyInfo";
            public const string IsActive = "IsActive";
            public const string Email = "Email";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Supplier.ColumnNames.ID;
					ht[CompanyName] = _Supplier.ColumnNames.CompanyName;
					ht[Address] = _Supplier.ColumnNames.Address;
					ht[Telephone] = _Supplier.ColumnNames.Telephone;
					ht[ContactPerson] = _Supplier.ColumnNames.ContactPerson;
					ht[Mobile] = _Supplier.ColumnNames.Mobile;
					ht[CompanyInfo] = _Supplier.ColumnNames.CompanyInfo;
					ht[IsActive] = _Supplier.ColumnNames.IsActive;
					ht[Email] = _Supplier.ColumnNames.Email;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ID = "s_ID";
            public const string CompanyName = "s_CompanyName";
            public const string Address = "s_Address";
            public const string Telephone = "s_Telephone";
            public const string ContactPerson = "s_ContactPerson";
            public const string Mobile = "s_Mobile";
            public const string CompanyInfo = "s_CompanyInfo";
            public const string IsActive = "s_IsActive";
            public const string Email = "s_Email";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ID
	    {
			get
	        {
				return base.Getint(ColumnNames.ID);
			}
			set
	        {
				base.Setint(ColumnNames.ID, value);
			}
		}

		public virtual string CompanyName
	    {
			get
	        {
				return base.Getstring(ColumnNames.CompanyName);
			}
			set
	        {
				base.Setstring(ColumnNames.CompanyName, value);
			}
		}

		public virtual string Address
	    {
			get
	        {
				return base.Getstring(ColumnNames.Address);
			}
			set
	        {
				base.Setstring(ColumnNames.Address, value);
			}
		}

		public virtual string Telephone
	    {
			get
	        {
				return base.Getstring(ColumnNames.Telephone);
			}
			set
	        {
				base.Setstring(ColumnNames.Telephone, value);
			}
		}

		public virtual string ContactPerson
	    {
			get
	        {
				return base.Getstring(ColumnNames.ContactPerson);
			}
			set
	        {
				base.Setstring(ColumnNames.ContactPerson, value);
			}
		}

		public virtual string Mobile
	    {
			get
	        {
				return base.Getstring(ColumnNames.Mobile);
			}
			set
	        {
				base.Setstring(ColumnNames.Mobile, value);
			}
		}

		public virtual string CompanyInfo
	    {
			get
	        {
				return base.Getstring(ColumnNames.CompanyInfo);
			}
			set
	        {
				base.Setstring(ColumnNames.CompanyInfo, value);
			}
		}

		public virtual bool IsActive
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsActive);
			}
			set
	        {
				base.Setbool(ColumnNames.IsActive, value);
			}
		}

		public virtual string Email
	    {
			get
	        {
				return base.Getstring(ColumnNames.Email);
			}
			set
	        {
				base.Setstring(ColumnNames.Email, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ID) ? string.Empty : base.GetintAsString(ColumnNames.ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ID);
				else
					this.ID = base.SetintAsString(ColumnNames.ID, value);
			}
		}

		public virtual string s_CompanyName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CompanyName) ? string.Empty : base.GetstringAsString(ColumnNames.CompanyName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CompanyName);
				else
					this.CompanyName = base.SetstringAsString(ColumnNames.CompanyName, value);
			}
		}

		public virtual string s_Address
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Address) ? string.Empty : base.GetstringAsString(ColumnNames.Address);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Address);
				else
					this.Address = base.SetstringAsString(ColumnNames.Address, value);
			}
		}

		public virtual string s_Telephone
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Telephone) ? string.Empty : base.GetstringAsString(ColumnNames.Telephone);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Telephone);
				else
					this.Telephone = base.SetstringAsString(ColumnNames.Telephone, value);
			}
		}

		public virtual string s_ContactPerson
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ContactPerson) ? string.Empty : base.GetstringAsString(ColumnNames.ContactPerson);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ContactPerson);
				else
					this.ContactPerson = base.SetstringAsString(ColumnNames.ContactPerson, value);
			}
		}

		public virtual string s_Mobile
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Mobile) ? string.Empty : base.GetstringAsString(ColumnNames.Mobile);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Mobile);
				else
					this.Mobile = base.SetstringAsString(ColumnNames.Mobile, value);
			}
		}

		public virtual string s_CompanyInfo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CompanyInfo) ? string.Empty : base.GetstringAsString(ColumnNames.CompanyInfo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CompanyInfo);
				else
					this.CompanyInfo = base.SetstringAsString(ColumnNames.CompanyInfo, value);
			}
		}

		public virtual string s_IsActive
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsActive) ? string.Empty : base.GetboolAsString(ColumnNames.IsActive);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsActive);
				else
					this.IsActive = base.SetboolAsString(ColumnNames.IsActive, value);
			}
		}

		public virtual string s_Email
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Email) ? string.Empty : base.GetstringAsString(ColumnNames.Email);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Email);
				else
					this.Email = base.SetstringAsString(ColumnNames.Email, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CompanyName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CompanyName, Parameters.CompanyName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Address
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Address, Parameters.Address);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Telephone
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Telephone, Parameters.Telephone);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ContactPerson
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ContactPerson, Parameters.ContactPerson);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Mobile
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Mobile, Parameters.Mobile);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CompanyInfo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CompanyInfo, Parameters.CompanyInfo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsActive
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Email
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Email, Parameters.Email);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public WhereParameter CompanyName
		    {
				get
		        {
					if(_CompanyName_W == null)
	        	    {
						_CompanyName_W = TearOff.CompanyName;
					}
					return _CompanyName_W;
				}
			}

			public WhereParameter Address
		    {
				get
		        {
					if(_Address_W == null)
	        	    {
						_Address_W = TearOff.Address;
					}
					return _Address_W;
				}
			}

			public WhereParameter Telephone
		    {
				get
		        {
					if(_Telephone_W == null)
	        	    {
						_Telephone_W = TearOff.Telephone;
					}
					return _Telephone_W;
				}
			}

			public WhereParameter ContactPerson
		    {
				get
		        {
					if(_ContactPerson_W == null)
	        	    {
						_ContactPerson_W = TearOff.ContactPerson;
					}
					return _ContactPerson_W;
				}
			}

			public WhereParameter Mobile
		    {
				get
		        {
					if(_Mobile_W == null)
	        	    {
						_Mobile_W = TearOff.Mobile;
					}
					return _Mobile_W;
				}
			}

			public WhereParameter CompanyInfo
		    {
				get
		        {
					if(_CompanyInfo_W == null)
	        	    {
						_CompanyInfo_W = TearOff.CompanyInfo;
					}
					return _CompanyInfo_W;
				}
			}

			public WhereParameter IsActive
		    {
				get
		        {
					if(_IsActive_W == null)
	        	    {
						_IsActive_W = TearOff.IsActive;
					}
					return _IsActive_W;
				}
			}

			public WhereParameter Email
		    {
				get
		        {
					if(_Email_W == null)
	        	    {
						_Email_W = TearOff.Email;
					}
					return _Email_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _CompanyName_W = null;
			private WhereParameter _Address_W = null;
			private WhereParameter _Telephone_W = null;
			private WhereParameter _ContactPerson_W = null;
			private WhereParameter _Mobile_W = null;
			private WhereParameter _CompanyInfo_W = null;
			private WhereParameter _IsActive_W = null;
			private WhereParameter _Email_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_CompanyName_W = null;
				_Address_W = null;
				_Telephone_W = null;
				_ContactPerson_W = null;
				_Mobile_W = null;
				_CompanyInfo_W = null;
				_IsActive_W = null;
				_Email_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CompanyName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CompanyName, Parameters.CompanyName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Address
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Address, Parameters.Address);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Telephone
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Telephone, Parameters.Telephone);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ContactPerson
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ContactPerson, Parameters.ContactPerson);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Mobile
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Mobile, Parameters.Mobile);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CompanyInfo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CompanyInfo, Parameters.CompanyInfo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsActive
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Email
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Email, Parameters.Email);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public AggregateParameter CompanyName
		    {
				get
		        {
					if(_CompanyName_W == null)
	        	    {
						_CompanyName_W = TearOff.CompanyName;
					}
					return _CompanyName_W;
				}
			}

			public AggregateParameter Address
		    {
				get
		        {
					if(_Address_W == null)
	        	    {
						_Address_W = TearOff.Address;
					}
					return _Address_W;
				}
			}

			public AggregateParameter Telephone
		    {
				get
		        {
					if(_Telephone_W == null)
	        	    {
						_Telephone_W = TearOff.Telephone;
					}
					return _Telephone_W;
				}
			}

			public AggregateParameter ContactPerson
		    {
				get
		        {
					if(_ContactPerson_W == null)
	        	    {
						_ContactPerson_W = TearOff.ContactPerson;
					}
					return _ContactPerson_W;
				}
			}

			public AggregateParameter Mobile
		    {
				get
		        {
					if(_Mobile_W == null)
	        	    {
						_Mobile_W = TearOff.Mobile;
					}
					return _Mobile_W;
				}
			}

			public AggregateParameter CompanyInfo
		    {
				get
		        {
					if(_CompanyInfo_W == null)
	        	    {
						_CompanyInfo_W = TearOff.CompanyInfo;
					}
					return _CompanyInfo_W;
				}
			}

			public AggregateParameter IsActive
		    {
				get
		        {
					if(_IsActive_W == null)
	        	    {
						_IsActive_W = TearOff.IsActive;
					}
					return _IsActive_W;
				}
			}

			public AggregateParameter Email
		    {
				get
		        {
					if(_Email_W == null)
	        	    {
						_Email_W = TearOff.Email;
					}
					return _Email_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _CompanyName_W = null;
			private AggregateParameter _Address_W = null;
			private AggregateParameter _Telephone_W = null;
			private AggregateParameter _ContactPerson_W = null;
			private AggregateParameter _Mobile_W = null;
			private AggregateParameter _CompanyInfo_W = null;
			private AggregateParameter _IsActive_W = null;
			private AggregateParameter _Email_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_CompanyName_W = null;
				_Address_W = null;
				_Telephone_W = null;
				_ContactPerson_W = null;
				_Mobile_W = null;
				_CompanyInfo_W = null;
				_IsActive_W = null;
				_Email_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SupplierInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SupplierUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_SupplierDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CompanyName);
			p.SourceColumn = ColumnNames.CompanyName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Address);
			p.SourceColumn = ColumnNames.Address;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Telephone);
			p.SourceColumn = ColumnNames.Telephone;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ContactPerson);
			p.SourceColumn = ColumnNames.ContactPerson;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Mobile);
			p.SourceColumn = ColumnNames.Mobile;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CompanyInfo);
			p.SourceColumn = ColumnNames.CompanyInfo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsActive);
			p.SourceColumn = ColumnNames.IsActive;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Email);
			p.SourceColumn = ColumnNames.Email;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
