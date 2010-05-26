using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UntestedApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(selectedItems() > 2) throw  new Exception("There was an Error");
            orderform.Visible = false;
            thankyou.Visible = true;
           
        }

        private int selectedItems()
        {
            var count = 0;
            foreach (ListItem i in widgets.Items)
            {
                if (i.Selected) count++;
            }
            return count;
        }
    }
}
