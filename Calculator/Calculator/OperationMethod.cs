using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Jace;

namespace Calculator
{
    static class OperationMethod
    {
        public static string answer(StringBuilder text)
        {
            double result = 0.00;

            if (!text.ToString().Substring(0).Equals("."))
            {
                if (text.Length != 0)
                {
                    if ((text.ToString().Substring(text.Length - 1)).Equals("+") || (text.ToString().Substring(text.Length - 1)).Equals("-") || (text.ToString().Substring(text.Length - 1)).Equals("*") || (text.ToString().Substring(text.Length - 1)).Equals("/"))
                    {
                        text.Length -= 1;
                    }
                    else
                    {
                        CalculationEngine engine = new CalculationEngine();
                        string expression = text.ToString();
                        result = engine.Calculate(expression);
                    }
                }
            }
            else
            {
                text.Clear();
                text.Append("0.0");
            }

            return result.ToString();
        }

        public static string delRule(StringBuilder text)
        {
            if (text.Length != 0)
            {
                text.Length -= 1;
            }

            return text.ToString();
        }

        public static string dotRule(StringBuilder text, string btnText)
        {
            if (!text.ToString().Contains("."))
                if (text.ToString() == string.Empty)
                    text.Append("0.");
                else
                    text.Append(".");

            return text.ToString();
        }

        public static string zeroRule(StringBuilder text, string btnText)
        {
            if (!text.ToString().Substring(0).Equals("0"))
            {
                if (text.Length > 1)
                {
                    if ((text.ToString().Substring(text.Length - 1)).Equals("+") || (text.ToString().Substring(text.Length - 1)).Equals("-") || (text.ToString().Substring(text.Length - 1)).Equals("*") || (text.ToString().Substring(text.Length - 1)).Equals("/"))
                    {
                        if ((text.ToString().Substring(text.Length - 1).Equals("0")))
                        {
                            text.Length -= 1;
                        }
                    }
                    else
                    {
                        text.Append(btnText);
                    }
                }
                else
                {
                    text.Append(btnText);
                }
            }

            return text.ToString();
        }

        public static string removeZero(StringBuilder text, string btnText)
        {
            if (text.ToString().Substring(0).Equals("0"))
            {
                text.Length -= 1;
            }
            return text.Append(btnText).ToString();
        }

        public static string operationDisplay(StringBuilder text, string btnText, string txtDisplay)
        {
            if (!string.IsNullOrEmpty(txtDisplay))
            {
                text.Clear();
                text.Append(txtDisplay);
            }

            if (text.Length == 0)
                text.Append("0");
            else if ((text.ToString().Substring(text.Length - 1)).Equals("+") || (text.ToString().Substring(text.Length - 1)).Equals("-") || (text.ToString().Substring(text.Length - 1)).Equals("*") || (text.ToString().Substring(text.Length - 1)).Equals("/"))
                text.Length -= 1;

            return text.Append(btnText).ToString();
        }
    }
}