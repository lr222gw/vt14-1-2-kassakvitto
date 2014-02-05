using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kassakvitto
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void sendButton_Click(object sender, EventArgs e)
        {
            if(IsValid){
                var amount = double.Parse(moneybox.Text);
                var theRecipe = new Model.Receipt(amount);

                theRecipe.Calculate(amount); //exekverar Calculate metoden..

                
            }

            

        }
    }
}