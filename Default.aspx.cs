using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class _Default : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Zero_Click(object sender, EventArgs e)
    {
        Result.Text += "0";
    }


    protected void Add_Click(object sender, EventArgs e)
    {
        Result.Text += " + ";
    }


    protected void Equal_Click(object sender, EventArgs e)
    {
      
        string[] result = (Result.Text).Split();
        Calculator calc = new Calculator(result);
        Result.Text = calc.calculate(result);


    }



    protected void Two_Click(object sender, EventArgs e)
    {
        Result.Text += "2";
    }

    protected void One_Click(object sender, EventArgs e)
    {
        Result.Text += "1";
    }

    protected void Three_Click(object sender, EventArgs e)
    {
        Result.Text += "3";
    }

    protected void Four_Click(object sender, EventArgs e)
    {
        Result.Text += "4";
    }

    protected void Five_Click(object sender, EventArgs e)
    {
        Result.Text += "5";
    }

    protected void Six_Click(object sender, EventArgs e)
    {
        Result.Text += "6";
    }

    protected void Seven_Click(object sender, EventArgs e)
    {
        Result.Text += "7";
    }

    protected void Eight_Click(object sender, EventArgs e)
    {
        Result.Text += "8";
    }

    protected void Nine_Click(object sender, EventArgs e)
    {
        Result.Text += "9";
    }

    protected void Decimal_Click(object sender, EventArgs e)
    {
        Result.Text += ".";
    }

    protected void Division_Click(object sender, EventArgs e)
    {
        Result.Text += " / ";
    }

    protected void Clear_Click(object sender, EventArgs e)
    {
        Result.Text = "0";
    }

    protected void Multiply_Click(object sender, EventArgs e)
    {
        Result.Text += " * ";
    }

    protected void Subtract_Click(object sender, EventArgs e)
    {
        Result.Text += " - ";
    }
}
