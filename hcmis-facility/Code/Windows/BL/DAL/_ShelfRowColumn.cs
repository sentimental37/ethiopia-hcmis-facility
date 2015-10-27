
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
	public abstract class _ShelfRowColumn : SqlClientEntity
	{
		public _ShelfRowColumn()
		{
			this.QuerySource = "ShelfRowColumn";
			this.MappingName = "ShelfRowColumn";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ShelfRowColumnLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ShelfRowColumnLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter Label
			{
				get
				{
					return new SqlParameter("@Label", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter ShelfID
			{
				get
				{
					return new SqlParameter("@ShelfID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Index
			{
				get
				{
					return new SqlParameter("@Index", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Dimension
			{
				get
				{
					return new SqlParameter("@Dimension", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter Type
			{
				get
				{
					return new SqlParameter("@Type", SqlDbType.VarChar, 50);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string Label = "Label";
            public const string ShelfID = "ShelfID";
            public const string Index = "Index";
            public const string Dimension = "Dimension";
            public const string Type = "Type";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ShelfRowColumn.PropertyNames.ID;
					ht[Label] = _ShelfRowColumn.PropertyNames.Label;
					ht[ShelfID] = _ShelfRowColumn.PropertyNames.ShelfID;
					ht[Index] = _ShelfRowColumn.PropertyNames.Index;
					ht[Dimension] = _ShelfRowColumn.PropertyNames.Dimension;
					ht[Type] = _ShelfRowColumn.PropertyNames.Type;

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
            public const string Label = "Label";
            public const string ShelfID = "ShelfID";
            public const string Index = "Index";
            public const string Dimension = "Dimension";
            public const string Type = "Type";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ShelfRowColumn.ColumnNames.ID;
					ht[Label] = _ShelfRowColumn.ColumnNames.Label;
					ht[ShelfID] = _ShelfRowColumn.ColumnNames.ShelfID;
					ht[Index] = _ShelfRowColumn.ColumnNames.Index;
					ht[Dimension] = _ShelfRowColumn.ColumnNames.Dimension;
					ht[Type] = _ShelfRowColumn.ColumnNames.Type;

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
            public const string Label = "s_Label";
            public const string ShelfID = "s_ShelfID";
            public const string Index = "s_Index";
            public const string Dimension = "s_Dimension";
            public const string Type = "s_Type";

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

		public virtual string Label
	    {
			get
	        {
				return base.Getstring(ColumnNames.Label);
			}
			set
	        {
				base.Setstring(ColumnNames.Label, value);
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

		public virtual int Index
	    {
			get
	        {
				return base.Getint(ColumnNames.Index);
			}
			set
	        {
				base.Setint(ColumnNames.Index, value);
			}
		}

		public virtual double Dimension
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Dimension);
			}
			set
	        {
				base.Setdouble(ColumnNames.Dimension, value);
			}
		}

		public virtual string Type
	    {
			get
	        {
				return base.Getstring(ColumnNames.Type);
			}
			set
	        {
				base.Setstring(ColumnNames.Type, value);
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

		public virtual string s_Label
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Label) ? string.Empty : base.GetstringAsString(ColumnNames.Label);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Label);
				else
					this.Label = base.SetstringAsString(ColumnNames.Label, value);
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

		public virtual string s_Index
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Index) ? string.Empty : base.GetintAsString(ColumnNames.Index);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Index);
				else
					this.Index = base.SetintAsString(ColumnNames.Index, value);
			}
		}

		public virtual string s_Dimension
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Dimension) ? string.Empty : base.GetdoubleAsString(ColumnNames.Dimension);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Dimension);
				else
					this.Dimension = base.SetdoubleAsString(ColumnNames.Dimension, value);
			}
		}

		public virtual string s_Type
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Type) ? string.Empty : base.GetstringAsString(ColumnNames.Type);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Type);
				else
					this.Type = base.SetstringAsString(ColumnNames.Type, value);
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

				public WhereParameter Label
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Label, Parameters.Label);
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

				public WhereParameter Index
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Index, Parameters.Index);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Dimension
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Dimension, Parameters.Dimension);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Type
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Type, Parameters.Type);
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

			public WhereParameter Label
		    {
				get
		        {
					if(_Label_W == null)
	        	    {
						_Label_W = TearOff.Label;
					}
					return _Label_W;
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

			public WhereParameter Index
		    {
				get
		        {
					if(_Index_W == null)
	        	    {
						_Index_W = TearOff.Index;
					}
					return _Index_W;
				}
			}

			public WhereParameter Dimension
		    {
				get
		        {
					if(_Dimension_W == null)
	        	    {
						_Dimension_W = TearOff.Dimension;
					}
					return _Dimension_W;
				}
			}

			public WhereParameter Type
		    {
				get
		        {
					if(_Type_W == null)
	        	    {
						_Type_W = TearOff.Type;
					}
					return _Type_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _Label_W = null;
			private WhereParameter _ShelfID_W = null;
			private WhereParameter _Index_W = null;
			private WhereParameter _Dimension_W = null;
			private WhereParameter _Type_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_Label_W = null;
				_ShelfID_W = null;
				_Index_W = null;
				_Dimension_W = null;
				_Type_W = null;

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

				public AggregateParameter Label
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Label, Parameters.Label);
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

				public AggregateParameter Index
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Index, Parameters.Index);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Dimension
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Dimension, Parameters.Dimension);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Type
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Type, Parameters.Type);
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

			public AggregateParameter Label
		    {
				get
		        {
					if(_Label_W == null)
	        	    {
						_Label_W = TearOff.Label;
					}
					return _Label_W;
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

			public AggregateParameter Index
		    {
				get
		        {
					if(_Index_W == null)
	        	    {
						_Index_W = TearOff.Index;
					}
					return _Index_W;
				}
			}

			public AggregateParameter Dimension
		    {
				get
		        {
					if(_Dimension_W == null)
	        	    {
						_Dimension_W = TearOff.Dimension;
					}
					return _Dimension_W;
				}
			}

			public AggregateParameter Type
		    {
				get
		        {
					if(_Type_W == null)
	        	    {
						_Type_W = TearOff.Type;
					}
					return _Type_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _Label_W = null;
			private AggregateParameter _ShelfID_W = null;
			private AggregateParameter _Index_W = null;
			private AggregateParameter _Dimension_W = null;
			private AggregateParameter _Type_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_Label_W = null;
				_ShelfID_W = null;
				_Index_W = null;
				_Dimension_W = null;
				_Type_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ShelfRowColumnInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ShelfRowColumnUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ShelfRowColumnDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.Label);
			p.SourceColumn = ColumnNames.Label;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ShelfID);
			p.SourceColumn = ColumnNames.ShelfID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Index);
			p.SourceColumn = ColumnNames.Index;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Dimension);
			p.SourceColumn = ColumnNames.Dimension;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Type);
			p.SourceColumn = ColumnNames.Type;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}