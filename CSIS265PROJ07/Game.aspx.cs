using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSIS265PROJ07
{
    public partial class Game : System.Web.UI.Page
    {

        private Random generator;
        private int input1;
        private int count;
        protected void Page_Load(object sender, EventArgs e)
        {
            generator = new Random();
          
            if (Page.IsPostBack)
            {
                input1 = (int)Session["input1"];
            }
            else
            {
                input1 = generator.Next(1, 101);         
                Session["input1"] = input1;
            }
        }

        protected void btnNewGame_Click(object sender, EventArgs e)
        {
           
            LblMessage.Text = string.Empty;
            txtInputValue.Text = string.Empty;
            input1 = generator.Next(1, 101);
            Session["input1"] = input1;
            Session["Click"] = 0;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (Session["Click"] == null)
            {
                Session["Click"] = 0;
            }
            count = Convert.ToInt16(Session["Click"]);
            Session["Click"] = ++count;

            
            if(String.Compare(txtInputValue.Text, input1.ToString()) == 0)
            {
                 LblMessage.Text = $" your guess is correct ({count} tries)";
                    
            }
            else if (String.Compare(txtInputValue.Text, input1.ToString()) < 0)
            {
                LblMessage.Text = $"({count} tries) your guess is too low";
            }
            else if (String.Compare(txtInputValue.Text, input1.ToString()) > 0)
            {
                    LblMessage.Text = $"({count} tries) Your guess is too high";
            }

            if (count == 7)
            {
                LblMessage.Text = $" you did not guess { input1 } within {count} tries";
                
            }
        }
    }
}