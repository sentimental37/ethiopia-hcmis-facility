
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
	public abstract class _Order : SqlClientEntity
	{
		public _Order()
		{
			this.QuerySource = "Order";
			this.MappingName = "Order";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_OrderLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_OrderLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter OrderStatusID
			{
				get
				{
					return new SqlParameter("@OrderStatusID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter RequestedBy
			{
				get
				{
					return new SqlParameter("@RequestedBy", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Date
			{
				get
				{
					return new SqlParameter("@Date", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter EurDate
			{
				get
				{
					return new SqlParameter("@EurDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter RefNo
			{
				get
				{
					return new SqlParameter("@RefNo", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Remark
			{
				get
				{
					return new SqlParameter("@Remark", SqlDbType.Text, 2147483647);
				}
			}
			
			public static SqlParameter FromStore
			{
				get
				{
					return new SqlParameter("@FromStore", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string OrderStatusID = "OrderStatusID";
            public const string RequestedBy = "RequestedBy";
            public const string Date = "Date";
            public const string EurDate = "EurDate";
            public const string RefNo = "RefNo";
            public const string Remark = "Remark";
            public const string FromStore = "FromStore";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Order.PropertyNames.ID;
					ht[OrderStatusID] = _Order.PropertyNames.OrderStatusID;
					ht[RequestedBy] = _Order.PropertyNames.RequestedBy;
					ht[Date] = _Order.PropertyNames.Date;
					ht[EurDate] = _Order.PropertyNames.EurDate;
					ht[RefNo] = _Order.PropertyNames.RefNo;
					ht[Remark] = _Order.PropertyNames.Remark;
					ht[FromStore] = _Order.PropertyNames.FromStore;

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
            public const string OrderStatusID = "OrderStatusID";
            public const string RequestedBy = "RequestedBy";
            public const string Date = "Date";
            public const string EurDate = "EurDate";
            public const string RefNo = "RefNo";
            public const string Remark = "Remark";
            public const string FromStore = "FromStore";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Order.ColumnNames.ID;
					ht[OrderStatusID] = _Order.ColumnNames.OrderStatusID;
					ht[RequestedBy] = _Order.ColumnNames.RequestedBy;
					ht[Date] = _Order.ColumnNames.Date;
					ht[EurDate] = _Order.ColumnNames.EurDate;
					ht[RefNo] = _Order.ColumnNames.RefNo;
					ht[Remark] = _Order.ColumnNames.Remark;
					ht[FromStore] = _Order.ColumnNames.FromStore;

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
            public const string OrderStatusID = "s_OrderStatusID";
            public const string RequestedBy = "s_RequestedBy";
            public const string Date = "s_Date";
            public const string EurDate = "s_EurDate";
            public const string RefNo = "s_RefNo";
            public const string Remark = "s_Remark";
            public const string FromStore = "s_FromStore";

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

		public virtual int OrderStatusID
	    {
			get
	        {
				return base.Getint(ColumnNames.OrderStatusID);
			}
			set
	        {
				base.Setint(ColumnNames.OrderStatusID, value);
			}
		}

		public virtual int RequestedBy
	    {
			get
	        {
				return base.Getint(ColumnNames.RequestedBy);
			}
			set
	        {
				base.Setint(ColumnNames.RequestedBy, value);
			}
		}

		public virtual DateTime Date
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Date);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Date, value);
			}
		}

		public virtual DateTime EurDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.EurDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.EurDate, value);
			}
		}

		public virtual string RefNo
	    {
			get
	        {
				return base.Getstring(ColumnNames.RefNo);
			}
			set
	        {
				base.Setstring(ColumnNames.RefNo, value);
			}
		}

		public virtual string Remark
	    {
			get
	        {
				return base.Getstring(ColumnNames.Remark);
			}
			set
	        {
				base.Setstring(ColumnNames.Remark, value);
			}
		}

		public virtual int FromStore
	    {
			get
	        {
				return base.Getint(ColumnNames.FromStore);
			}
			set
	        {
				base.Setint(ColumnNames.FromStore, value);
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

		public virtual string s_OrderStatusID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.OrderStatusID) ? string.Empty : base.GetintAsString(ColumnNames.OrderStatusID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.OrderStatusID);
				else
					this.OrderStatusID = base.SetintAsString(ColumnNames.OrderStatusID, value);
			}
		}

		public virtual string s_RequestedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.RequestedBy) ? string.Empty : base.GetintAsString(ColumnNames.RequestedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.RequestedBy);
				else
					this.RequestedBy = base.SetintAsString(ColumnNames.RequestedBy, value);
			}
		}

		public virtual string s_Date
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Date) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Date);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Date);
				else
					this.Date = base.SetDateTimeAsString(ColumnNames.Date, value);
			}
		}

		public virtual string s_EurDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.EurDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.EurDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.EurDate);
				else
					this.EurDate = base.SetDateTimeAsString(ColumnNames.EurDate, value);
			}
		}

		public virtual string s_RefNo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.RefNo) ? string.Empty : base.GetstringAsString(ColumnNames.RefNo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.RefNo);
				else
					this.RefNo = base.SetstringAsString(ColumnNames.RefNo, value);
			}
		}

		public virtual string s_Remark
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Remark) ? string.Empty : base.GetstringAsString(ColumnNames.Remark);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Remark);
				else
					this.Remark = base.SetstringAsString(ColumnNames.Remark, value);
			}
		}

		public virtual string s_FromStore
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.FromStore) ? string.Empty : base.GetintAsString(ColumnNames.FromStore);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.FromStore);
				else
					this.FromStore = base.SetintAsString(ColumnNames.FromStore, value);
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

				public WhereParameter OrderStatusID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.OrderStatusID, Parameters.OrderStatusID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter RequestedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.RequestedBy, Parameters.RequestedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Date
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Date, Parameters.Date);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter EurDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.EurDate, Parameters.EurDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter RefNo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.RefNo, Parameters.RefNo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Remark
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Remark, Parameters.Remark);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter FromStore
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.FromStore, Parameters.FromStore);
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

			public WhereParameter OrderStatusID
		    {
				get
		        {
					if(_OrderStatusID_W == null)
	        	    {
						_OrderStatusID_W = TearOff.OrderStatusID;
					}
					return _OrderStatusID_W;
				}
			}

			public WhereParameter RequestedBy
		    {
				get
		        {
					if(_RequestedBy_W == null)
	        	    {
						_RequestedBy_W = TearOff.RequestedBy;
					}
					return _RequestedBy_W;
				}
			}

			public WhereParameter Date
		    {
				get
		        {
					if(_Date_W == null)
	        	    {
						_Date_W = TearOff.Date;
					}
					return _Date_W;
				}
			}

			public WhereParameter EurDate
		    {
				get
		        {
					if(_EurDate_W == null)
	        	    {
						_EurDate_W = TearOff.EurDate;
					}
					return _EurDate_W;
				}
			}

			public WhereParameter RefNo
		    {
				get
		        {
					if(_RefNo_W == null)
	        	    {
						_RefNo_W = TearOff.RefNo;
					}
					return _RefNo_W;
				}
			}

			public WhereParameter Remark
		    {
				get
		        {
					if(_Remark_W == null)
	        	    {
						_Remark_W = TearOff.Remark;
					}
					return _Remark_W;
				}
			}

			public WhereParameter FromStore
		    {
				get
		        {
					if(_FromStore_W == null)
	        	    {
						_FromStore_W = TearOff.FromStore;
					}
					return _FromStore_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _OrderStatusID_W = null;
			private WhereParameter _RequestedBy_W = null;
			private WhereParameter _Date_W = null;
			private WhereParameter _EurDate_W = null;
			private WhereParameter _RefNo_W = null;
			private WhereParameter _Remark_W = null;
			private WhereParameter _FromStore_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_OrderStatusID_W = null;
				_RequestedBy_W = null;
				_Date_W = null;
				_EurDate_W = null;
				_RefNo_W = null;
				_Remark_W = null;
				_FromStore_W = null;

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

				public AggregateParameter OrderStatusID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrderStatusID, Parameters.OrderStatusID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter RequestedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.RequestedBy, Parameters.RequestedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Date
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Date, Parameters.Date);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter EurDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.EurDate, Parameters.EurDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter RefNo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.RefNo, Parameters.RefNo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Remark
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Remark, Parameters.Remark);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter FromStore
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.FromStore, Parameters.FromStore);
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

			public AggregateParameter OrderStatusID
		    {
				get
		        {
					if(_OrderStatusID_W == null)
	        	    {
						_OrderStatusID_W = TearOff.OrderStatusID;
					}
					return _OrderStatusID_W;
				}
			}

			public AggregateParameter RequestedBy
		    {
				get
		        {
					if(_RequestedBy_W == null)
	        	    {
						_RequestedBy_W = TearOff.RequestedBy;
					}
					return _RequestedBy_W;
				}
			}

			public AggregateParameter Date
		    {
				get
		        {
					if(_Date_W == null)
	        	    {
						_Date_W = TearOff.Date;
					}
					return _Date_W;
				}
			}

			public AggregateParameter EurDate
		    {
				get
		        {
					if(_EurDate_W == null)
	        	    {
						_EurDate_W = TearOff.EurDate;
					}
					return _EurDate_W;
				}
			}

			public AggregateParameter RefNo
		    {
				get
		        {
					if(_RefNo_W == null)
	        	    {
						_RefNo_W = TearOff.RefNo;
					}
					return _RefNo_W;
				}
			}

			public AggregateParameter Remark
		    {
				get
		        {
					if(_Remark_W == null)
	        	    {
						_Remark_W = TearOff.Remark;
					}
					return _Remark_W;
				}
			}

			public AggregateParameter FromStore
		    {
				get
		        {
					if(_FromStore_W == null)
	        	    {
						_FromStore_W = TearOff.FromStore;
					}
					return _FromStore_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _OrderStatusID_W = null;
			private AggregateParameter _RequestedBy_W = null;
			private AggregateParameter _Date_W = null;
			private AggregateParameter _EurDate_W = null;
			private AggregateParameter _RefNo_W = null;
			private AggregateParameter _Remark_W = null;
			private AggregateParameter _FromStore_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_OrderStatusID_W = null;
				_RequestedBy_W = null;
				_Date_W = null;
				_EurDate_W = null;
				_RefNo_W = null;
				_Remark_W = null;
				_FromStore_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_OrderDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.OrderStatusID);
			p.SourceColumn = ColumnNames.OrderStatusID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.RequestedBy);
			p.SourceColumn = ColumnNames.RequestedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Date);
			p.SourceColumn = ColumnNames.Date;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.EurDate);
			p.SourceColumn = ColumnNames.EurDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.RefNo);
			p.SourceColumn = ColumnNames.RefNo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Remark);
			p.SourceColumn = ColumnNames.Remark;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.FromStore);
			p.SourceColumn = ColumnNames.FromStore;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
