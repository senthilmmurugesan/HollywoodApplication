using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HollywoodLibrary
{
   public class Movies
    {
    public string LastError { get; set; }
        
    public int Add(int MovieID, string MovieTitle, int RunningTime, System.DateTime ReleaseDate)
    {
        HollywoodDBConnect aHollywoodConn = new HollywoodDBConnect();
        string sql = "Insert INTO Movies values (@MovieId, @MovieTitle, @RunningTime, @ReleaseDate)";

        SqlParameter param1 = new SqlParameter("@MovieId",SqlDbType.Int );
        param1.Value = MovieID;
        SqlParameter param2 = new SqlParameter("@MovieTitle", SqlDbType.Text);
        param2.Value = MovieTitle;
        SqlParameter param3 = new SqlParameter("@RunningTime", SqlDbType.Int);
        param3.Value = RunningTime;
        SqlParameter param4 = new SqlParameter("@ReleaseDate", SqlDbType.DateTime);
        param4.Value = ReleaseDate;

        try
        {
         return aHollywoodConn.ExecuteNonQuery(sql, CommandType.Text, param1, param2, param3, param4);
        }
        catch (Exception ex)
        {
         LastError = ex.Message;
        return -1;
        }
     }
        public DataTable GetActors(int mID)
        {

            HollywoodDBConnect aHollywoodConn = new HollywoodDBConnect();
            SqlParameter param = new SqlParameter("@MovieID", SqlDbType.Int);
            param.Value = mID;

            try
            {
                return aHollywoodConn.GetTable("SELECT Actors.LastName, Actors.FirstName, Actors.DateOfBirth FROM Actors INNER JOIN Roles ON Actors.ActorID = Roles.ActorID WHERE MovieID = @MovieID", CommandType.Text, param);

            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }


        }

        public int GetCount()
        {
            try
            {
                HollywoodDBConnect aHollywoodConn = new HollywoodDBConnect();
                return Convert.ToInt32(aHollywoodConn.GetScalar("SELECT COUNT(*) FROM MOVIES", CommandType.Text));
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return -1;
            }
        }

        public DataTable GetBestPictures()
        {
            HollywoodDBConnect aHollywoodConn = new HollywoodDBConnect();
            try
            {
                return aHollywoodConn.GetTable("spBestMovies", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }
        }
    }
}
