
// Generated by MyGeneration Version # (1.3.0.9)

using System;
using System.Data;
using DAL;
using EthiopianDate;

namespace BLL
{
	public class RRF : _RRF
	{
		public RRF()
		{
		
		}

        public int AddNewRRF(int rrfType, int fromYear, int fromMonth,int toYear, int toMonth, bool overWriteOn)
        {
            if(RRFExists(rrfType,fromYear,fromMonth,toYear,toMonth))
            {
                if (!overWriteOn)
                    return -1;
            }
            else
            {
                this.AddNew();
            }

            //this.StoreID = storeID;
            this.RRFType = rrfType;
            this.FromYear = fromYear;
            this.FromMonth = fromMonth;
            this.ToMonth = toMonth;
            this.ToYear = toYear;
            this.DateOfSubmission = DateTime.Now;
            this.Save();
            return this.ID;
        }

        public bool RRFExists(int rrfType, int fromYear, int fromMonth,int toYear, int toMonth)
        {
            this.FlushData();
            //this.Where.StoreID.Value = storeID;
            this.Where.FromYear.Value = fromYear;
            this.Where.FromMonth.Value = fromMonth;
            this.Where.ToYear.Value = toYear;
            this.Where.ToMonth.Value = toMonth;
            this.Where.RRFType.Value = rrfType;
            this.Query.Load();
            return this.RowCount > 0;
        }

        public DataTable GetSavedRRFList()
        {
            this.FlushData();
            this.LoadAll();
            return this.DataTable;
        }

        public DataTable GetSavedRRFForDisplay()
        {
            this.FlushData();
            string query = "select ID,DateOfSubmission, LastRRFStatus, RRFType, cast(FromMonth as varchar) + ',' + cast(FromYear as varchar) + ' - ' + cast(ToMonth as varchar) + ',' + cast(ToYear as varchar) Period from RRF";
            this.LoadFromRawSql(query);
            this.AddColumn("DateOfSubmissionEth", typeof (string));
            this.AddColumn("RRFTypeText", typeof(string));
            
            while(!this.EOF)
            {
                string ethDate = this.IsColumnNull("DateOfSubmission")? "": EthiopianDate.EthiopianDate.GregorianToEthiopian(this.DateOfSubmission);
                this.SetColumn("DateOfSubmissionEth",ethDate);
                var str = new Stores();
                str.LoadByStoreID(this.RRFType);
                this.SetColumn("RRFTypeText", str.RowCount > 0 ? str.StoreName : "Unknown Store");
                this.MoveNext();
            }
            return this.DataTable;
        }
	}
}
