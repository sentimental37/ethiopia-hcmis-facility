
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;

namespace BLL
{
	public class ABC : _ABC
	{
		public ABC()
		{
            
		}

        public bool LoadQuery(string str)
        {
            try
            {
                return this.LoadFromRawSql(str);
            }
            catch {
                return false;
            }
        }

	}
}
