using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testBottles
{
    public partial class testMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int tb1 = TextBox1.Text;
        }

        protected void Bottle_Decider(Double requiredVol) {
            Double oneLtrBottle = 1000000;
            Double twoLtrBottle = 2000000;
            Double twoNHalfLtrBottle = 2500000;
            Double threeLtrBottle = 3000000;

            if (requiredVol < oneLtrBottle)
            {
                TextBox5.Text = "1 ltr bottle is required";
            }
            else if (requiredVol < twoLtrBottle)
            {
                TextBox5.Text = "2 ltr bottle is required";
            }
            else if (requiredVol < twoNHalfLtrBottle)
            {
                TextBox5.Text = "2.5 ltr bottle is required";
            }
            else if (requiredVol < threeLtrBottle)
            {
                TextBox5.Text = "3 ltr bottle is required";
            }
            else
            {
                TextBox5.Text = "Total required Volume is" + requiredVol.ToString() + ". Hence larger bottle is required";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox box1 = TextBox1;
            TextBox box2 = TextBox2;
            TextBox box3 = TextBox3;
            TextBox box4 = TextBox4;

            RadioButton rb1 = RadioButton1;
            RadioButton rb2 = RadioButton2;
            RadioButton rb3 = RadioButton3;
            RadioButton rb4 = RadioButton4;

            Double pill1Volume = 508.938;
            Double pill2Volume = 708.938;
            Double pill3Volume = 908.938;
            Double pill4Volume = 1008.938;
            Double packingDensity = 0.7405;
            
            if (rb1.Checked) {
                Double requiredVol = Convert.ToInt32(box1.Text) * pill1Volume / packingDensity;
                Bottle_Decider(requiredVol);
            }
            else if (rb2.Checked)
            {
                Double requiredVol = Convert.ToInt32(box2.Text) * pill1Volume / packingDensity;
                Bottle_Decider(requiredVol);
            }
            else if (rb3.Checked)
            {
                Double requiredVol = Convert.ToInt32(box3.Text) * pill1Volume / packingDensity;
                Bottle_Decider(requiredVol);
            }
            else if (rb4.Checked)
            {
                Double requiredVol = Convert.ToInt32(box4.Text) * pill1Volume / packingDensity;
                Bottle_Decider(requiredVol);
            }

        }
    }
}