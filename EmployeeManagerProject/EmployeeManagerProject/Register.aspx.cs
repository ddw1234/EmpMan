using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BEL_EMPMan;
using BLL_EMPMan;

namespace EmployeeManagerProject
{
    public partial class Register : System.Web.UI.Page
    {
         
        #region Create the objects of classes
        Register_BEL objbel = new Register_BEL();
        Register_BLL objbll = new Register_BLL();
        
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblmastertext = (Label)Master.FindControl("lblmaster");
                lblmastertext.Text = "Register Employee";
            }
        }
        #region adding user username and password
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            objbel.USERNAME = txtUsername.Text;
            objbel.PASSWORD = txtPassword.Text;
            objbel.FIRSTNAME = Convert.ToString(txtfirstname.Text);
            try
            {
                int result = objbll.Saveuserpass(objbel);
                if (result > 0)
                {
                    lblstatus.Text = "Your login created successfully";
                    lblstatus.ForeColor = System.Drawing.Color.Blue;
                    ClearControl();
                }
                else
                {
                    lblstatus.Text = "Your login gets failed";
                    lblstatus.ForeColor = System.Drawing.Color.Red;
                }

            }
            catch (Exception ex)
            {
                Response.Write("Error occured : " + ex.Message.ToString());
            }
            finally
            {
                objbel = null;
                objbll = null;
            }
               
        }
        #endregion
        protected void ClearControl()
        {
            txtfirstname.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControl();
        }
    }
}