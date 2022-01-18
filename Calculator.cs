using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Calculator
/// </summary>
public class Calculator
{
    

        private string op1, op2;
        private double num1, num2;

        private string operation;
        private double result;

        private string[] input;
        // constrcutor 
        public Calculator() { }

        public Calculator(string[] input)
        {
            this.input = input;
            calculate(input);
        }


        //addition
        public double add()
        {
            double result;
            result = num1 + num2;
            return result;
        }

        //subtract
        public double sub()
        {
            double result;
            result = num1 - num2;
            return result;
        }

        //multiply
        public double mult()
        {
            double result;
            result = num1 * num2;
            return result;
        }

        //divide
        public double div()
        {
            double result;
            result = num1 / num2;
            return result;

        }

        //Solving
        public double Solve()
        {

            bool error = false;
            double r = 0;
            switch (operation)
            {
                case "+":
                    r = add();
                    break;
                case "-":
                    r = sub();
                    break;
                case "*":
                    r = mult();
                    break;
                case "/":
                    if (num1 != 0 && num2 == 0)
                        error = true;
                    else
                        r = div();
                    break;
            }

            if (error == true)
            {
                return 0;
            }

            return r;
        }

        //look for non-integers in inputuation
        public bool errors()
        {
            bool success = true;

            for (int i = 0; i < input.Length; i += 2)
            {
                double num;
                success = double.TryParse(input[i], out num);
                if (success == false)
                {
                    //Console.WriteLine("Invalid Input");
                    break;
                }
            }
            return success;
        }

        //look for incorrect operators
        public bool operror()
        {
            bool success = true;
            for (int i = 1; i < input.Length; i += 2)
            {
                if ((input[i] == "+") || (input[i] == "-") || (input[i] == "*") || (input[i] == "/"))
                {
                    success = true;

                }
                else
                {
                    success = false;
                    break;
                }
            }
            return success;
        }

        //calculate inputuation
        public string calculate(string[] input)
        {
            this.input = input;
            if (errors() == true && operror() == true)
            {
                op1 = input[0];
                for (int i = 1; i < input.Length; i += 2)
                {
                    operation = input[i];
                    op2 = input[i + 1];

                    //convert to int
                    num1 = Convert.ToDouble(op1);
                    num2 = Convert.ToDouble(op2);

                    //update result
                    result = Solve();
                    op1 = Convert.ToString(result);

                    if (i == input.Length - 2)
                    {
                        return result.ToString();
                    }
                }
                return "Invalid Input";
            }
            else
                return "Invalid Input";
        }
    }
