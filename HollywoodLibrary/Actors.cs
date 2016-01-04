using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HollywoodLibrary
{
   
    public class Actors
    {
      public string LastError{get;set;}
        
        public DataTable GetAllActors()
        {
            try
            {
                string sqlString = "SELECT * FROM Actors";
                HollywoodDBConnect aHollywoodConn = new HollywoodDBConnect();

                DataSet actorsDS = new DataSet();
                actorsDS = aHollywoodConn.GetDataSet(sqlString);
                return actorsDS.Tables[0];
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
    }
}
