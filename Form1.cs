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

        double result = 0;
        string operacion = "";
        string buttonNUM = "";
        bool checkOperation = false;
        string ans = "";
        private void Button_Click(object sender, EventArgs e)
        {
   
                if ((OutputTextbox.Text == "0")|| (checkOperation)|| OutputTextbox.Text == "Math Error")
                {
                    OutputTextbox.ResetText();
                }

                Button button = (Button)sender;
                buttonNUM = buttonNUM + button.Text;
                checkOperation = false;
                if (button.Text == "Ans")
                {
                    OutputTextbox.Text = OutputTextbox.Text + ans;
                }

                if (button.Text == ".")
                {
                        if (!OutputTextbox.Text.Contains("."))
                        {
                          OutputTextbox.Text = OutputTextbox.Text + button.Text;
                        }
                }
                
                else
                {
                    if (button.Text != "Ans")
                    {
                        OutputTextbox.Text = OutputTextbox.Text + button.Text;
                    }
                }            
        }

        private void Operation_Button(object sender, EventArgs e)
        {
            buttonNUM = "";
            if (!checkOperation)
            {
                if (OutputTextbox.Text == "0")
                {
                    OutputTextbox.ResetText();
                }

                Button button = (Button)sender;
                operacion = button.Text;
                try
                {
                    result = double.Parse(OutputTextbox.Text);
                }
                catch
                {

                }
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
            ans = "";
        }
        private void History_click(TextBox opl,string res)
        {
            HistoryLabel.Text = HistoryLabel.Text + res +""+ operacion +"" + buttonNUM + " = " +opl.Text+"\n";
        }
        private void IGUAL_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "X":
                    try
                    {

                        OutputTextbox.Text = (result * double.Parse(OutputTextbox.Text)).ToString();
                        History_click(OutputTextbox,result.ToString());
                        ans = OutputTextbox.Text;
                        result = Convert.ToDouble(ans);
                        AnsLebel(ans);
                        OutputTextbox.ResetText();
                        buttonNUM = "";
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
                        History_click(OutputTextbox, result.ToString());
                        ans = OutputTextbox.Text;
                        result = Convert.ToDouble(ans);
                        AnsLebel(ans);
                        OutputTextbox.ResetText();
                         buttonNUM = "";
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
                        History_click(OutputTextbox, result.ToString());
                        ans = OutputTextbox.Text;
                        result = Convert.ToDouble(ans);
                        AnsLebel(ans);
                        OutputTextbox.ResetText();
                        buttonNUM = "";
                        break;
                    }
                    catch 
                    {
                        break;
                    }
                case " ÷":
                    try
                    {
                        if (OutputTextbox.Text =="0")
                        {
                            OutputTextbox.Text = "Math Error";
                            OutputLabel.ResetText();
                            break;
                        }
                        OutputTextbox.Text = (result / double.Parse(OutputTextbox.Text)).ToString();
                        History_click(OutputTextbox, result.ToString());
                        ans = OutputTextbox.Text;
                        result = Convert.ToDouble(ans);
                        AnsLebel(ans);
                        OutputTextbox.ResetText();
                        buttonNUM = "";
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
        private void AnsLebel(string anss)
        {
            OutputLabel.Text = anss;
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
