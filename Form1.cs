using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void S_BTN_Click(object sender, EventArgs e)
        {
            if (C_TX.Text == "")
            {
                MessageBox.Show("Input cannot be empty!");
                return;
            }
            string user_input = C_TX.Text;

            if (c_after(user_input))
            {
                c_before(user_input);
            }
        }

        public void c_before(string user_input)
        {
            
            //first level
            if (user_input == "MAC2281" || user_input == "MAC2311")
            {
                MessageBox.Show("You do not have any classes you have taken before MAC 2281 or MAC 2311");
            }

            //second level
            else if (user_input == "PHY2048" || user_input == "MAC2282" || user_input == "MAC2312" ||
                user_input == "COP2510" || user_input == "COT3100")
            {
                MessageBox.Show("taken before: MAC 2281 or MAC 2311");
            }
    
            //third level
            else if (user_input == "CDA3103")
            {
                MessageBox.Show("taken before: COP 2510, MAC 2281 or MAC 2311");
            }
            else if (user_input == "PHY2049")
            {
                MessageBox.Show("taken before: PHY 2048, MAC 2282 or MAC 2312, MAC 2281 or MAC 2311");
            }
            else if (user_input == "COP3514")
            {
                MessageBox.Show("taken before: COP 2510, MAC 2281, MAC 2311"); 
            }
            else if (user_input == "MAC2283" || user_input == "MAC2313")
            {
                MessageBox.Show("taken before: MAC 2282 or MAC 2312, MAC 2281 or MAC 2311");
            }
            

            //fourth level
            else if (user_input == "CDA3201" || user_input == "COP4530")
            {
                MessageBox.Show("taken before: CDA 3103, COP 3514, COP 2510, MAC 2281 or MAC 2311");
            }

            else
            {
                MessageBox.Show("Error! Invalid Input!");
            }

            C_TX.Text = "";
        }


        public bool c_after(string user_input)
        {
            bool success = true;
            switch (user_input)
            {
                //first level
                case "MAC2311":
                    MessageBox.Show("choose: PHY 2048, MAC 2282 or MAC 2312, COP 2510, COT 3100");
                    break;
                case "MAC2281":
                    MessageBox.Show("choose: PHY 2048, MAC 2282 or MAC 2312, COP 2510, COT 3100");
                    break;
                

                //second level
                case "COP2510":
                    MessageBox.Show("choose: CDA 3103, COP 3514");
                    break;
                case "COT3100":
                    MessageBox.Show("Error! You have to be in Upper Division, contact your advisor.");
                    break;
                case "PHY2048":
                    MessageBox.Show("choose: PHY 2049");
                    break;
                case "MAC2282":
                    MessageBox.Show("choose: PHY 2049, MAC 2283 or MAC 2313");
                    break;
                case "MAC2312":
                    MessageBox.Show("choose: PHY 2049, MAC 2283 or MAC 2313");
                    break;
                

                //third level
                case "COP3514":
                    MessageBox.Show("choose: CDA 3201, COP 4530");
                    break;
                case "PHY2049":
                    MessageBox.Show("You do not have any other class to take after PHY 2049.");
                    break;
                case "MAC2283":
                    MessageBox.Show("You do not have any other class to take after MAC 2283.");
                    break;
                case "CDA3103":
                    MessageBox.Show("choose: CDA 3201, COP 4530");
                    break;
                case "MAC2313":
                    MessageBox.Show("You do not have any other class to take after MAC 2313");
                    break;
                

                //fourth level
                case "COP4530":
                    MessageBox.Show("Error! You have to be in Upper Division, contact your advisor");
                    break;
                case "CDA3201":
                    MessageBox.Show("Error! You have to be in Upper Division, contact your advisor");
                    break;
                

                //invalid input
                default:
                    MessageBox.Show("Error! You have entered invalid input!");
                    success = false;
                    C_TX.Text = "";
                    break;
            }

            return success;
        }
    }
}
