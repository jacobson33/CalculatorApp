using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator_jacobs33.Controllers
{
    public class FormCalculatorController : Controller
    {
        // GET: FormCalculator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculate(FormCollection formInfo)
        {
            string errorMessage = null;
            double number1;
            double number2;
            double result = 0;

            if (double.TryParse(formInfo["number1"], out number1) &&
                double.TryParse(formInfo["number2"], out number2))
            {
                switch (formInfo["operation"])
                {
                    case "add":
                        result = number1 + number2;
                        break;

                    case "subtract":
                        result = number1 - number2;
                        break;

                    case "multiply":
                        result = number1 * number2;
                        break;

                    case "divide":
                        if (number2 != 0)
                            result = number1 / number2;
                        else
                            errorMessage = "Cannot divide by zero.";
                        break;
                    case "factorial":
                        result = (int)number1;
                        for (int i = (int)number1 - 1; i > 0; i--)
                        {
                            result *= i;
                        }
                        break;

                    default:
                        errorMessage = "Invalid operation.";
                        break;
                }
            }
            else
            {
                errorMessage = "Invalid input.";
            }

            //round result to 2 decimals
            result = Math.Round(result, 2);


            if (errorMessage == null)
                ViewBag.Result = result;
            else
                ViewBag.Error = errorMessage;
            return View();
        }
    }
}