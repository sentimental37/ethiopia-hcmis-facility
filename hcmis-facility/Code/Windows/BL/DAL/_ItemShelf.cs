
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
	public abstract class _ItemShelf : SqlClientEntity
	{
		public _ItemShelf()
		{
			this.QuerySource = "ItemShelf";
			this.MappingName = "ItemShelf";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ItemShelfLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ItemShelfLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter ItemID
			{
				get
				{
					return new SqlParameter("@ItemID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ShelfID
			{
				get
				{
					return new SqlParameter("@ShelfID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter IsEmpty
			{
				get
				{
					return new SqlParameter("@IsEmpty", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string ItemID = "ItemID";
            public const string ShelfID = "ShelfID";
            public const string IsEmpty = "IsEmpty";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ItemShelf.PropertyNames.ID;
					ht[ItemID] = _ItemShelf.PropertyNames.ItemID;
					ht[ShelfID] = _ItemShelf.PropertyNames.ShelfID;
					ht[IsEmpty] = _ItemShelf.PropertyNames.IsEmpty;

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
            public const string ItemID = "ItemID";
            public const string ShelfID = "ShelfID";
            public const string IsEmpty = "IsEmpty";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ItemShelf.ColumnNames.ID;
					ht[ItemID] = _ItemShelf.ColumnNames.ItemID;
					ht[ShelfID] = _ItemShelf.ColumnNames.ShelfID;
					ht[IsEmpty] = _ItemShelf.ColumnNames.IsEmpty;

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
            public const string ItemID = "s_ItemID";
            public const string ShelfID = "s_ShelfID";
            public const string IsEmpty = "s_IsEmpty";

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

		public virtual int ItemID
	    {
			get
	        {
				return base.Getint(ColumnNames.ItemID);
			}
			set
	        {
				base.Setint(ColumnNames.ItemID, value);
			}
		}

		public virtual int ShelfID
	    {
			get
	        {
				return base.Getint(ColumnNames.ShelfID);
			}
			set
	        {
				base.Setint(ColumnNames.ShelfID, value);
			}
		}

		public virtual bool IsEmpty
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsEmpty);
			}
			set
	        {
				base.Setbool(ColumnNames.IsEmpty, value);
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

		public virtual string s_ItemID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ItemID) ? string.Empty : base.GetintAsString(ColumnNames.ItemID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ItemID);
				else
					this.ItemID = base.SetintAsString(ColumnNames.ItemID, value);
			}
		}

		public virtual string s_ShelfID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ShelfID) ? string.Empty : base.GetintAsString(ColumnNames.ShelfID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ShelfID);
				else
					this.ShelfID = base.SetintAsString(ColumnNames.ShelfID, value);
			}
		}

		public virtual string s_IsEmpty
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsEmpty) ? string.Empty : base.GetboolAsString(ColumnNames.IsEmpty);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsEmpty);
				else
					this.IsEmpty = base.SetboolAsString(ColumnNames.IsEmpty, value);
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

				public WhereParameter ItemID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ItemID, Parameters.ItemID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ShelfID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ShelfID, Parameters.ShelfID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsEmpty
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsEmpty, Parameters.IsEmpty);
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

			public WhereParameter ItemID
		    {
				get
		        {
					if(_ItemID_W == null)
	        	    {
						_ItemID_W = TearOff.ItemID;
					}
					return _ItemID_W;
				}
			}

			public WhereParameter ShelfID
		    {
				get
		        {
					if(_ShelfID_W == null)
	        	    {
						_ShelfID_W = TearOff.ShelfID;
					}
					return _ShelfID_W;
				}
			}

			public WhereParameter IsEmpty
		    {
				get
		        {
					if(_IsEmpty_W == null)
	        	    {
						_IsEmpty_W = TearOff.IsEmpty;
					}
					return _IsEmpty_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _ItemID_W = null;
			private WhereParameter _ShelfID_W = null;
			private WhereParameter _IsEmpty_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_ItemID_W = null;
				_ShelfID_W = null;
				_IsEmpty_W = null;

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

				public AggregateParameter ItemID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ItemID, Parameters.ItemID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ShelfID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ShelfID, Parameters.ShelfID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsEmpty
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsEmpty, Parameters.IsEmpty);
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

			public AggregateParameter ItemID
		    {
				get
		        {
					if(_ItemID_W == null)
	        	    {
						_ItemID_W = TearOff.ItemID;
					}
					return _ItemID_W;
				}
			}

			public AggregateParameter ShelfID
		    {
				get
		        {
					if(_ShelfID_W == null)
	        	    {
						_ShelfID_W = TearOff.ShelfID;
					}
					return _ShelfID_W;
				}
			}

			public AggregateParameter IsEmpty
		    {
				get
		        {
					if(_IsEmpty_W == null)
	        	    {
						_IsEmpty_W = TearOff.IsEmpty;
					}
					return _IsEmpty_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _ItemID_W = null;
			private AggregateParameter _ShelfID_W = null;
			private AggregateParameter _IsEmpty_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_ItemID_W = null;
				_ShelfID_W = null;
				_IsEmpty_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ItemShelfInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ItemShelfUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ItemShelfDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.ItemID);
			p.SourceColumn = ColumnNames.ItemID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ShelfID);
			p.SourceColumn = ColumnNames.ShelfID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsEmpty);
			p.SourceColumn = ColumnNames.IsEmpty;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
