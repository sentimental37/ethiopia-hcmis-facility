﻿
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

// Generated by MyGeneration Version # (1.2.0.7)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace DAL
{
    public abstract class _ItemUnit : SqlClientEntity
    {
        public _ItemUnit()
        {
            this.QuerySource = "ItemUnit";
            this.MappingName = "ItemUnit";

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

            return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ItemUnitLoadAll]", parameters);
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


            return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ItemUnitLoadByPrimaryKey]", parameters);
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

            public static SqlParameter QtyPerUnit
            {
                get
                {
                    return new SqlParameter("@QtyPerUnit", SqlDbType.Int, 0);
                }
            }

            public static SqlParameter Text
            {
                get
                {
                    return new SqlParameter("@Text", SqlDbType.VarChar, 50);
                }
            }

        }
        #endregion

        #region ColumnNames
        public class ColumnNames
        {
            public const string ID = "ID";
            public const string ItemID = "ItemID";
            public const string QtyPerUnit = "QtyPerUnit";
            public const string Text = "Text";

            static public string ToPropertyName(string columnName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[ID] = _ItemUnit.PropertyNames.ID;
                    ht[ItemID] = _ItemUnit.PropertyNames.ItemID;
                    ht[QtyPerUnit] = _ItemUnit.PropertyNames.QtyPerUnit;
                    ht[Text] = _ItemUnit.PropertyNames.Text;

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
            public const string QtyPerUnit = "QtyPerUnit";
            public const string Text = "Text";

            static public string ToColumnName(string propertyName)
            {
                if (ht == null)
                {
                    ht = new Hashtable();

                    ht[ID] = _ItemUnit.ColumnNames.ID;
                    ht[ItemID] = _ItemUnit.ColumnNames.ItemID;
                    ht[QtyPerUnit] = _ItemUnit.ColumnNames.QtyPerUnit;
                    ht[Text] = _ItemUnit.ColumnNames.Text;

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
            public const string QtyPerUnit = "s_QtyPerUnit";
            public const string Text = "s_Text";

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

        public virtual int QtyPerUnit
        {
            get
            {
                return base.Getint(ColumnNames.QtyPerUnit);
            }
            set
            {
                base.Setint(ColumnNames.QtyPerUnit, value);
            }
        }

        public virtual string Text
        {
            get
            {
                return base.Getstring(ColumnNames.Text);
            }
            set
            {
                base.Setstring(ColumnNames.Text, value);
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
                if (string.Empty == value)
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
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.ItemID);
                else
                    this.ItemID = base.SetintAsString(ColumnNames.ItemID, value);
            }
        }

        public virtual string s_QtyPerUnit
        {
            get
            {
                return this.IsColumnNull(ColumnNames.QtyPerUnit) ? string.Empty : base.GetintAsString(ColumnNames.QtyPerUnit);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.QtyPerUnit);
                else
                    this.QtyPerUnit = base.SetintAsString(ColumnNames.QtyPerUnit, value);
            }
        }

        public virtual string s_Text
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Text) ? string.Empty : base.GetstringAsString(ColumnNames.Text);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Text);
                else
                    this.Text = base.SetstringAsString(ColumnNames.Text, value);
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
                    if (_tearOff == null)
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

                public WhereParameter QtyPerUnit
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.QtyPerUnit, Parameters.QtyPerUnit);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Text
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Text, Parameters.Text);
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
                    if (_ID_W == null)
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
                    if (_ItemID_W == null)
                    {
                        _ItemID_W = TearOff.ItemID;
                    }
                    return _ItemID_W;
                }
            }

            public WhereParameter QtyPerUnit
            {
                get
                {
                    if (_QtyPerUnit_W == null)
                    {
                        _QtyPerUnit_W = TearOff.QtyPerUnit;
                    }
                    return _QtyPerUnit_W;
                }
            }

            public WhereParameter Text
            {
                get
                {
                    if (_Text_W == null)
                    {
                        _Text_W = TearOff.Text;
                    }
                    return _Text_W;
                }
            }

            private WhereParameter _ID_W = null;
            private WhereParameter _ItemID_W = null;
            private WhereParameter _QtyPerUnit_W = null;
            private WhereParameter _Text_W = null;

            public void WhereClauseReset()
            {
                _ID_W = null;
                _ItemID_W = null;
                _QtyPerUnit_W = null;
                _Text_W = null;

                this._entity.Query.FlushWhereParameters();

            }

            private BusinessEntity _entity;
            private TearOffWhereParameter _tearOff;

        }

        public WhereClause Where
        {
            get
            {
                if (_whereClause == null)
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
                    if (_tearOff == null)
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

                public AggregateParameter QtyPerUnit
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.QtyPerUnit, Parameters.QtyPerUnit);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter Text
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Text, Parameters.Text);
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
                    if (_ID_W == null)
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
                    if (_ItemID_W == null)
                    {
                        _ItemID_W = TearOff.ItemID;
                    }
                    return _ItemID_W;
                }
            }

            public AggregateParameter QtyPerUnit
            {
                get
                {
                    if (_QtyPerUnit_W == null)
                    {
                        _QtyPerUnit_W = TearOff.QtyPerUnit;
                    }
                    return _QtyPerUnit_W;
                }
            }

            public AggregateParameter Text
            {
                get
                {
                    if (_Text_W == null)
                    {
                        _Text_W = TearOff.Text;
                    }
                    return _Text_W;
                }
            }

            private AggregateParameter _ID_W = null;
            private AggregateParameter _ItemID_W = null;
            private AggregateParameter _QtyPerUnit_W = null;
            private AggregateParameter _Text_W = null;

            public void AggregateClauseReset()
            {
                _ID_W = null;
                _ItemID_W = null;
                _QtyPerUnit_W = null;
                _Text_W = null;

                this._entity.Query.FlushAggregateParameters();

            }

            private BusinessEntity _entity;
            private TearOffAggregateParameter _tearOff;

        }

        public AggregateClause Aggregate
        {
            get
            {
                if (_aggregateClause == null)
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
            cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ItemUnitInsert]";

            CreateParameters(cmd);

            return cmd;
        }

        protected override IDbCommand GetUpdateCommand()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ItemUnitUpdate]";

            CreateParameters(cmd);

            return cmd;
        }

        protected override IDbCommand GetDeleteCommand()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ItemUnitDelete]";

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

            p = cmd.Parameters.Add(Parameters.QtyPerUnit);
            p.SourceColumn = ColumnNames.QtyPerUnit;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Text);
            p.SourceColumn = ColumnNames.Text;
            p.SourceVersion = DataRowVersion.Current;


            return cmd;
        }
    }
}
