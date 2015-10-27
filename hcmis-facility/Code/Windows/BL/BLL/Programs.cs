
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;
using System.Data;

namespace BLL
{
	public class Programs : _Programs
	{
		public Programs()
		{
		
		}

        public DataTable GetParentPrograms()
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ParentID.Value = 0;
            this.Query.Load();
            return this.DataTable;
        }

        public DataTable GetSubPrograms()
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT * FROM Programs WHERE ParentID != 0"));
            return this.DataTable;
        }
        public DataTable GetAllPrograms()
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT * FROM Programs"));
            return this.DataTable;
        }
        public DataTable GetProgramByName(string programName)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.Name.Value = programName;
            this.Query.Load();
            return this.DataTable;
        }

        public DataTable GetSubProgramsByParentId(int parentId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ParentID.Value = parentId;
            this.Query.Load();
            return this.DataTable;
        }
	}
}
