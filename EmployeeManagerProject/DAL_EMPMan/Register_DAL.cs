using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using BEL_EMPMan;

namespace DAL_EMPMan
{
   
    public class Register_DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);

        public Int32 Saveuserpass(Register_BEL objBEL)
        {
            int result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Insert_login_user", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", objBEL.USERNAME);
                cmd.Parameters.AddWithValue("@password", objBEL.PASSWORD);
                cmd.Parameters.AddWithValue("@firstname",Convert.ToString(objBEL.FIRSTNAME));
                SqlParameter inuserid = new SqlParameter("@userid", SqlDbType.Int) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(inuserid);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                if (result > 0)
                {
                    int userid = Convert.ToInt32(inuserid.Value);
                    return result;
                }
                else
                {
                    return 0;
                }
                               
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            
        }
        public DataSet Loginuser(Register_BEL objBEL)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("Select_Login_Details",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", objBEL.USERNAME);
                cmd.Parameters.AddWithValue("@password", objBEL.PASSWORD);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                cmd.Dispose();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                ds.Dispose();
            }
        }
       
    }
}
