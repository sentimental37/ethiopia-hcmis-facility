
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
	public abstract class _INN : SqlClientEntity
	{
		public _INN()
		{
			this.QuerySource = "INN";
			this.MappingName = "INN";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ProductsLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ProductsLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter IIN
			{
				get
				{
					return new SqlParameter("@IIN", SqlDbType.VarChar, 1500);
				}
			}
			
			public static SqlParameter ATC
			{
				get
				{
					return new SqlParameter("@ATC", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Description
			{
				get
				{
					return new SqlParameter("@Description", SqlDbType.VarChar, 1500);
				}
			}
			
			public static SqlParameter TypeID
			{
				get
				{
					return new SqlParameter("@TypeID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string IIN = "IIN";
            public const string ATC = "ATC";
            public const string Description = "Description";
            public const string TypeID = "TypeID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _INN.PropertyNames.ID;
					ht[IIN] = _INN.PropertyNames.IIN;
					ht[ATC] = _INN.PropertyNames.ATC;
					ht[Description] = _INN.PropertyNames.Description;
					ht[TypeID] = _INN.PropertyNames.TypeID;

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
            public const string IIN = "IIN";
            public const string ATC = "ATC";
            public const string Description = "Description";
            public const string TypeID = "TypeID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _INN.ColumnNames.ID;
					ht[IIN] = _INN.ColumnNames.IIN;
					ht[ATC] = _INN.ColumnNames.ATC;
					ht[Description] = _INN.ColumnNames.Description;
					ht[TypeID] = _INN.ColumnNames.TypeID;

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
            public const string IIN = "s_IIN";
            public const string ATC = "s_ATC";
            public const string Description = "s_Description";
            public const string TypeID = "s_TypeID";

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

		public virtual string IIN
	    {
			get
	        {
				return base.Getstring(ColumnNames.IIN);
			}
			set
	        {
				base.Setstring(ColumnNames.IIN, value);
			}
		}

		public virtual string ATC
	    {
			get
	        {
				return base.Getstring(ColumnNames.ATC);
			}
			set
	        {
				base.Setstring(ColumnNames.ATC, value);
			}
		}

		public virtual string Description
	    {
			get
	        {
				return base.Getstring(ColumnNames.Description);
			}
			set
	        {
				base.Setstring(ColumnNames.Description, value);
			}
		}

		public virtual int TypeID
	    {
			get
	        {
				return base.Getint(ColumnNames.TypeID);
			}
			set
	        {
				base.Setint(ColumnNames.TypeID, value);
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

		public virtual string s_IIN
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IIN) ? string.Empty : base.GetstringAsString(ColumnNames.IIN);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IIN);
				else
					this.IIN = base.SetstringAsString(ColumnNames.IIN, value);
			}
		}

		public virtual string s_ATC
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ATC) ? string.Empty : base.GetstringAsString(ColumnNames.ATC);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ATC);
				else
					this.ATC = base.SetstringAsString(ColumnNames.ATC, value);
			}
		}

		public virtual string s_Description
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Description) ? string.Empty : base.GetstringAsString(ColumnNames.Description);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Description);
				else
					this.Description = base.SetstringAsString(ColumnNames.Description, value);
			}
		}

		public virtual string s_TypeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.TypeID) ? string.Empty : base.GetintAsString(ColumnNames.TypeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.TypeID);
				else
					this.TypeID = base.SetintAsString(ColumnNames.TypeID, value);
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

				public WhereParameter IIN
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IIN, Parameters.IIN);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ATC
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ATC, Parameters.ATC);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Description
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter TypeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.TypeID, Parameters.TypeID);
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

			public WhereParameter IIN
		    {
				get
		        {
					if(_IIN_W == null)
	        	    {
						_IIN_W = TearOff.IIN;
					}
					return _IIN_W;
				}
			}

			public WhereParameter ATC
		    {
				get
		        {
					if(_ATC_W == null)
	        	    {
						_ATC_W = TearOff.ATC;
					}
					return _ATC_W;
				}
			}

			public WhereParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public WhereParameter TypeID
		    {
				get
		        {
					if(_TypeID_W == null)
	        	    {
						_TypeID_W = TearOff.TypeID;
					}
					return _TypeID_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _IIN_W = null;
			private WhereParameter _ATC_W = null;
			private WhereParameter _Description_W = null;
			private WhereParameter _TypeID_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_IIN_W = null;
				_ATC_W = null;
				_Description_W = null;
				_TypeID_W = null;

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

				public AggregateParameter IIN
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IIN, Parameters.IIN);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ATC
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ATC, Parameters.ATC);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Description
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter TypeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.TypeID, Parameters.TypeID);
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

			public AggregateParameter IIN
		    {
				get
		        {
					if(_IIN_W == null)
	        	    {
						_IIN_W = TearOff.IIN;
					}
					return _IIN_W;
				}
			}

			public AggregateParameter ATC
		    {
				get
		        {
					if(_ATC_W == null)
	        	    {
						_ATC_W = TearOff.ATC;
					}
					return _ATC_W;
				}
			}

			public AggregateParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public AggregateParameter TypeID
		    {
				get
		        {
					if(_TypeID_W == null)
	        	    {
						_TypeID_W = TearOff.TypeID;
					}
					return _TypeID_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _IIN_W = null;
			private AggregateParameter _ATC_W = null;
			private AggregateParameter _Description_W = null;
			private AggregateParameter _TypeID_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_IIN_W = null;
				_ATC_W = null;
				_Description_W = null;
				_TypeID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ProductsInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ProductsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ProductsDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.IIN);
			p.SourceColumn = ColumnNames.IIN;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ATC);
			p.SourceColumn = ColumnNames.ATC;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Description);
			p.SourceColumn = ColumnNames.Description;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.TypeID);
			p.SourceColumn = ColumnNames.TypeID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
