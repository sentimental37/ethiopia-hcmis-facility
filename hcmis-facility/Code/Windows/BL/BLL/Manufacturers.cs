
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;
using System.Data;

namespace BLL
{
	public class Manufacturers : _Manufacturers
	{
		public Manufacturers()
		{
		
		}

        public DataTable GetNewManufacturersFor(int itemID)
        {
            String query = String.Format("select * from Manufacturers where ID not in (select ManufacturerID from ItemManufacturer where ItemID = {0})",itemID);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }

        public void LoadForItem(int id)
        {
            String query = String.Format("select m.* from ItemManufacturer im join Manufacturers m on im.ManufacturerID = m.ID where ItemID = {0} and RecevingDefault = 1",id);
            this.LoadFromRawSql(query);
        }
    }
}
