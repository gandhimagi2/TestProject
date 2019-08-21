using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        Calculate _Calculate;
        string res;
        protected void Page_Load(object sender, EventArgs e)
        {
            _Calculate = new Calculate();
        }

        protected void Button0_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "0";
            calc_dis.Value = calc_dis.Value + "0";
            calc_result.Visible = false;
            Text1.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "1";
            calc_dis.Value = calc_dis.Value + "1";
            calc_result.Visible = false;
            Text1.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "2";
            calc_dis.Value = calc_dis.Value + "2";
            calc_result.Visible = false;
            Text1.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "3";
            calc_dis.Value = calc_dis.Value + "3";
            calc_result.Visible = false;
            Text1.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "4";
            calc_dis.Value = calc_dis.Value + "4";
            calc_result.Visible = false;
            Text1.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "5";
            calc_dis.Value = calc_dis.Value + "5";
            calc_result.Visible = false;
            Text1.Visible = true;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "6";
            calc_dis.Value = calc_dis.Value + "6";
            calc_result.Visible = false;
            Text1.Visible = true;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "7";
            calc_dis.Value = calc_dis.Value + "7";
            calc_result.Visible = false;
            Text1.Visible = true;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "8";
            calc_dis.Value = calc_dis.Value + "8";
            calc_result.Visible = false;
            Text1.Visible = true;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + "9";
            calc_dis.Value = calc_dis.Value + "9";
            calc_result.Visible = false;
            Text1.Visible = true;
        }

        protected void ButtonComa_Click(object sender, EventArgs e)
        {
            calc_result.Value = calc_result.Value + ".";
            calc_dis.Value = calc_dis.Value + ".";
        }

        protected void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else if (Convert.ToInt32(calc_result.Value) > 0)
            {
                calc_result.Value = "-" + calc_result.Value;
                calc_dis.Value = calc_result.Value;
            }
            else
            {
                int i = Convert.ToInt32(calc_result.Value) * -1;
                String s = i.ToString();
                calc_result.Value = s;
                calc_dis.Value = calc_result.Value;
            }
            Text1.Visible = true;
            calc_result.Visible = false;
        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Addition";
                calc_result.Value = string.Empty;
                res = ViewState["Value1"] + "+";
                calc_dis.Value = res;
            }
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Subtraction";
                calc_result.Value = string.Empty;
                res = ViewState["Value1"] + "-";
                calc_dis.Value = res;
            }
        }

        protected void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Multiplication";
                calc_result.Value = string.Empty;
                res = ViewState["Value1"] + "*";
                calc_dis.Value = res;
            }
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Division";
                calc_result.Value = string.Empty;
                res = ViewState["Value1"] + "/";
                calc_dis.Value = res;
            }
        }

        protected void ButtonPercentage_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["Value1"] = calc_result.Value;
                ViewState["Operation"] = "Percentage";
                calc_result.Value = string.Empty;
                res = ViewState["Value1"] + "%";
                calc_dis.Value = res;
            }
        }

        protected void ButtonCE_Click(object sender, EventArgs e)
        {
            if ((string)ViewState["Operation"] != null)
            {
                ViewState["Operation"] = null;
            }
            else if ((string)ViewState["Value1"] != null)
            {
                ViewState["Value1"] = null;
            }
            calc_dis.Value = string.Empty;
            calc_result.Value = string.Empty;
        }

        protected void ButtonReturn_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                string CharactersInTextBox = calc_result.Value;
                string FinalCharactersInTextBox = string.Empty;
                calc_dis.Value = string.Empty;
                for (int i = 0; i < CharactersInTextBox.Length - 1; i++)
                {
                    FinalCharactersInTextBox = FinalCharactersInTextBox + CharactersInTextBox[i];
                }

                calc_result.Value = FinalCharactersInTextBox;
                calc_dis.Value = FinalCharactersInTextBox;
            }
        }

        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (calc_result.Value == string.Empty)
            {
                Response.Write("<script>alert('No Value is given.')</script>");
                calc_dis.Value = string.Empty;
            }
            else
            {
                ViewState["Value2"] = calc_result.Value;
                res = calc_dis.Value ;
                calc_result.Value = string.Empty;
                calc_result.Visible = true;
                Text1.Visible = false;
                calc_dis.Value = res;
                try
                {
                    if ((string)ViewState["Operation"] == "Addition")
                    {
                        calc_result.Value = _Calculate.Add(Convert.ToDouble(ViewState["Value1"]), Convert.ToDouble(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Subtraction")
                    {
                        calc_result.Value = _Calculate.Subtract(Convert.ToDouble(ViewState["Value1"]), Convert.ToDouble(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Multiplication")
                    {
                        calc_result.Value = _Calculate.Multiply(Convert.ToDouble(ViewState["Value1"]), Convert.ToDouble(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Division")
                    {
                        calc_result.Value = _Calculate.Divide(Convert.ToDouble(ViewState["Value1"]), Convert.ToDouble(ViewState["Value2"])).ToString();
                    }
                    else if ((string)ViewState["Operation"] == "Percentage")
                    {
                        calc_result.Value = _Calculate.Percentage(Convert.ToInt32(ViewState["Value1"]), Convert.ToInt32(ViewState["Value2"])).ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert('No Operation was recorded.')</script>");
                        calc_dis.Value = string.Empty;
                    }

                }
                catch (FormatException)
                {
                    Response.Write("<script>alert('Wrong Input Format.')</script>");
                    calc_dis.Value = string.Empty;
                }
            }
        }
    }
}

