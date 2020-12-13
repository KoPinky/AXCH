using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXCH
{
    public class DB
    {
        public static AXCHEntities db = new AXCHEntities();
        public static bool Save()
        {
            try
            {
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Helper.ErrorMessage(ex.Message);
                return false;
            }
        }
    }
}
