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
    public class EmpDetail_DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);

        public DataSet FillDepartment()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("FetchDepartmentDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public Int32 InsertEmpDetail(EmpDetail_BEL objbel)
        {
            int result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Insert_tbl_Empdetail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@firstname", objbel.FirstName);
                cmd.Parameters.AddWithValue("@middlename", Convert.ToString(objbel.MiddleName));
                cmd.Parameters.AddWithValue("@lastname", objbel.LastName);
                cmd.Parameters.AddWithValue("@address", Convert.ToString(objbel.Address));
                cmd.Parameters.AddWithValue("@city", objbel.City);
                cmd.Parameters.AddWithValue("@gender", objbel.Gender);
                cmd.Parameters.AddWithValue("@emailid", objbel.Emailid);
                cmd.Parameters.AddWithValue("@empstatus", objbel.EmpStatus);
                cmd.Parameters.AddWithValue("@deptid", objbel.DeptID);
                cmd.Parameters.AddWithValue("@emptype", objbel.EmpType);
                cmd.Parameters.AddWithValue("@dateofbirth", objbel.DateOfBirth);
                cmd.Parameters.AddWithValue("@dateofjoin", objbel.DateofJoin);
                SqlParameter EmpId = new SqlParameter("@EmpId", SqlDbType.Int) { Direction = ParameterDirection.Output };
                cmd.Parameters.Add(EmpId);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                if (result > 0)
                {
                    int EMPNewId = Convert.ToInt32(EmpId.Value);
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
        public DataSet FillGridview()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("fetch_tbl_Empdetail",con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
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
            }

        }
        public DataSet Fetchdatausinggrid(EmpDetail_BEL objbel)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("Fetch_tbl_empdetails_forgridempid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", objbel.EmpId);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
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
            }

        }
        public Int32 UpdateEmpDetail(EmpDetail_BEL objbel)
        {
            int result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Update_tbl_Empdetail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", objbel.EmpId);
                cmd.Parameters.AddWithValue("@firstname", objbel.FirstName);
                cmd.Parameters.AddWithValue("@middlename", Convert.ToString(objbel.MiddleName));
                cmd.Parameters.AddWithValue("@lastname", objbel.LastName);
                cmd.Parameters.AddWithValue("@address", Convert.ToString(objbel.Address));
                cmd.Parameters.AddWithValue("@city", objbel.City);
                cmd.Parameters.AddWithValue("@gender", objbel.Gender);
                cmd.Parameters.AddWithValue("@emailid", objbel.Emailid);
                cmd.Parameters.AddWithValue("@empstatus", objbel.EmpStatus);
                cmd.Parameters.AddWithValue("@deptid", objbel.DeptID);
                cmd.Parameters.AddWithValue("@emptype", objbel.EmpType);
                cmd.Parameters.AddWithValue("@dateofbirth", objbel.DateOfBirth);
                cmd.Parameters.AddWithValue("@dateofjoin", objbel.DateofJoin);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                if (result > 0)
                {
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

        public Int32 Deleterecord(EmpDetail_BEL objbel)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Delete_tbl_Empdetail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", objbel.EmpId);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                if (result > 0)
                {
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
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
