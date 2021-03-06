
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;
using System.Data;

namespace BLL
{
	public class Unit : _Unit
	{
		public Unit()
		{
	    }

        /// <summary>
        /// Loads the Unit by the mapping ID and returns the ID
        /// Note: The Description Column has been used for the puspose of mapping
        /// </summary>
        /// <param name="mappingID"></param>
        /// <returns>The ID of the Product table</returns>
        public int LoadByMappingID(int mappingID)
        {
            this.FlushData();
            
            string query = string.Format("Select * FROM Unit WHERE cast(Description as varchar)='{0}'", mappingID);
            this.LoadFromRawSql(query);
            if (this.RowCount > 0)
            {
                return this.ID;
            }
            else
            {
                return -1;
            }
        }

        public bool IsMapped
        {
            get { return !this.IsColumnNull("Description"); }
        }

        public int? MappingID
        {
            get { return this.IsColumnNull("Description") ? (int?)null : int.Parse(this.Description); }
            set{this.SetColumn("Description",value);}
        }


        public DataTable EnterUnit()
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("Select Distinct (Name) from temp"));
            return this.DataTable;
        }
	}
}
