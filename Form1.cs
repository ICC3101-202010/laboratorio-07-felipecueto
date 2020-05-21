using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        List<string> history = new List<string>();
        double result = 0;
        string operacion = "";
        string buttonNUM = "";
        bool checkOperation = false;
        string ans = "";
        private void Button_Click(object sender, EventArgs e)
        {
   
                if ((OutputTextbox.Text == "0")|| (checkOperation))
                {
                    OutputTextbox.ResetText();
                }

                Button button = (Button)sender;
            buttonNUM = button.Text;
                checkOperation = false;

                if (button.Text == ".")
                {
                    if (!OutputTextbox.Text.Contains("."))
                    {
                      OutputTextbox.Text = OutputTextbox.Text + button.Text;
                    }
                }
                else
                {
                     OutputTextbox.Text = OutputTextbox.Text + button.Text;
                }
 

            
        }

        private void Operation_Button(object sender, EventArgs e)
        {
            if (!checkOperation)
            {
                if (OutputTextbox.Text == "0")
                {
                    OutputTextbox.ResetText();
                }

                Button button = (Button)sender;
                operacion = button.Text;
                result = double.Parse(OutputTextbox.Text);
                checkOperation = true;
                OutputLabel.Text = result + " " + operacion;
               

            }
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            string del = OutputTextbox.Text;
            try
            {
                del = del.Remove(del.Length - 1);
                OutputTextbox.Text = del;
            }
            catch
            {

            }
        }

        private void AC_Click(object sender, EventArgs e)
        {
            OutputTextbox.Text = "0";
            result = 0;
            OutputLabel.ResetText();
        }

        private void Ans_Click(object sender, EventArgs e)
        {
            OutputTextbox.Text = ans;
        }

        private void History_click(TextBox opl)
        {
            HistoryLabel.Text = HistoryLabel.Text + result +""+ operacion +"" + buttonNUM + " = " +opl.Text+"\n";
        }

        private void IGUAL_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "X":
                    try
                    {

                        OutputTextbox.Text = (result * double.Parse(OutputTextbox.Text)).ToString();
                        ans = OutputTextbox.Text;
                        History_click(OutputTextbox);
                        break;
                    }
                    catch
                    {
                        break;
                    }
            
                    
                case "-":
                    try
                    {

                        OutputTextbox.Text = (result - double.Parse(OutputTextbox.Text)).ToString();
                        ans = OutputTextbox.Text;
                        History_click(OutputTextbox);
                        break;
                    }
                    catch
                    {
                        break;
                    }
                case "+":
                    try
                    {

                        OutputTextbox.Text = (result + double.Parse(OutputTextbox.Text)).ToString();
                        ans = OutputTextbox.Text;
                        History_click(OutputTextbox);
                        break;
                    }
                    catch 
                    {
                        break;
                    }
                case " ÷":
                    try
                    {
                        OutputTextbox.Text = (result / double.Parse(OutputTextbox.Text)).ToString();
                        ans = OutputTextbox.Text;
                        History_click(OutputTextbox);
                        break;

                    }
                    catch
                    {
                        break;
                    }
                default:
                    break;


            }




        }

        private void HistorialButton_Click(object sender, EventArgs e)
        {
            if (HistoryPanel.Visible)
            {
                HistoryPanel.Visible = false;
            }
            else
            {
                HistoryPanel.Visible = true;
            }
        }

        private void DeleteHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryLabel.ResetText();
        }
    }
}
