using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_Car_Rental.View.Customer
{
    public partial class CustomerMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustName.InnerText = Login.CName == "" ? SignUp.CName : Login.CName;    /**/
            int custId = Login.CustId == 0 ? SignUp.CustId : Login.CustId;

            if(custId == 0 )
            {
                LoginState.InnerText = "Login";
                Greeter.InnerText = "";
            }
            else
            {
                LoginState.InnerText = "Logout";
            }

        }
    }
}