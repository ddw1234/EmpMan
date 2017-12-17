using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BEL_EMPMan;
using DAL_EMPMan;



namespace BLL_EMPMan
{
    public class Register_BLL
    {
        public Int32 Saveuserpass(Register_BEL objbel)
        {
            Register_DAL objdal = new Register_DAL();
            try
            {
                return objdal.Saveuserpass(objbel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objdal = null;
            }
        }

        public DataSet Loginuser(Register_BEL objbel)
        {
            Register_DAL objdal = new Register_DAL();
            try
            {
                return objdal.Loginuser(objbel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objdal = null;
            }
        }
    }
}
