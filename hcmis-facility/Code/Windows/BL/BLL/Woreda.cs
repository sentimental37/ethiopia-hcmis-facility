
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;
using System.Data;

namespace BLL
{
	public class Woreda : _Woreda
	{
		public Woreda()
		{
		
		}

        public DataTable GetWoredaByZone(int ZoneId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ZoneID.Value = ZoneId;
            this.Query.Load();
            return this.DataTable;
        }
	}
}