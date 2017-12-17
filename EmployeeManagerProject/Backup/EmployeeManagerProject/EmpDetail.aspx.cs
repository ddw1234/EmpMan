using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BEL_EMPMan;
using BLL_EMPMan;

namespace EmployeeManagerProject
{
    public partial class EmpDetail : System.Web.UI.Page
    {
        #region Creating object
        EmpDetail_BEL objempbel = new EmpDetail_BEL();
        EmpDetail_BLL objempbll = new EmpDetail_BLL();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDepartment();
            }
        }
        public void FillDepartment()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
         
            try
            {
                ds=objempbll.FillDepartment();
                dt = ds.Tables[0];
                ddlDepartment.DataSource = dt;
                ddlDepartment.DataTextField = "Deptname";
                ddlDepartment.DataValueField = "DeptId";
                ddlDepartment.DataBind();
                ddlDepartment.Items.Insert(0, new ListItem("Select Department","0"));
               
            }
            catch (Exception ex)
            {
                Response.Write("Error in code :" + ex.Message.ToString());
            }
            finally
            {
                objempbel=null;
                objempbll=null;

            }

        }
       
    }
}