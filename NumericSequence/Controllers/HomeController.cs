using NumericSequence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumericSequence.Controllers
{
    
    public class HomeController : Controller
    {
        public int inputNumber { get; set; }
        public ActionResult Index()
        {
            
            NumberViewModel nVM = new NumberViewModel();
            inputNumber = 10;
            nVM.InputNumber = inputNumber;
            nVM.All = this.GetAllNumbers(inputNumber);
            nVM.OddSequence = this.GetOddNumbers(inputNumber);
            nVM.EvenSequence = this.GetEvenNumbers(inputNumber);
            nVM.CustomisedSequence = this.GetCustomisedNumbers(inputNumber);
            nVM.FibonacciSequence = this.GetFibonacciNumbers(inputNumber);
            return View(nVM);
        }

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public ActionResult IndexPost([Bind(Include = "InputNumber, All")] NumberViewModel nVM)
        {
            int nbr = nVM.InputNumber;
            nVM.All = this.GetAllNumbers(nbr);
            nVM.OddSequence = this.GetOddNumbers(nbr);
            nVM.EvenSequence = this.GetEvenNumbers(nbr);
            nVM.CustomisedSequence = this.GetCustomisedNumbers(nbr);
            nVM.FibonacciSequence = this.GetFibonacciNumbers(nbr);
            return View(nVM);
        }

        public string GetAllNumbers(int nbr)
        {
            string all = "0";
            for (int i = 1; i <= nbr; i++)
            {
                all += ", " + i.ToString();
            }
            return all;
        }

        public string GetOddNumbers(int nbr)
        {
            string all = "1";
            for (int i = 2; i <= nbr; i++)
            {
                if (i % 2 != 0)
                {
                    all += ", " + i.ToString();
                }
            }
            return all;
        }

        public string GetEvenNumbers(int nbr)
        {
            string all = "0";
            for (int i = 1; i <= nbr; i++)
            {
                if (i % 2 == 0)
                {
                    all += ", " + i.ToString();
                }
            }
            return all;
        }

        public string GetCustomisedNumbers(int nbr)
        {
            string all = "Z";
            for (int i = 1; i <= nbr; i++)
            {
                var chr = GetCustomChar(i);
                all += ", ";
                all += chr == string.Empty ? i.ToString() : chr;
            }
            return all;
        }

        private string GetCustomChar(int n)
        {
            string op = string.Empty;
            bool NbrIsMultipleOf3 = ((n % 3) == 0);
            bool NbrIsMultipleOf5 = ((n % 5) == 0);
                        
            if (NbrIsMultipleOf3) { op = "C"; }
            if (NbrIsMultipleOf5) { op = "E"; }
            if (NbrIsMultipleOf3 && NbrIsMultipleOf5) { op = "Z"; }
            return op;
        }

        public string GetFibonacciNumbers(int nbr)
        {
            
            string all = "0";
            for (int i = 1; i <= nbr; i++)
            {
                int fibNbr = FibonacciSeries(i);
                if (fibNbr <= nbr)
                {
                    all += ", " + fibNbr.ToString();
                }
            }
            return all;
        }

        private int FibonacciSeries(int n)
        {
            if (n == 0) return 0; //the first Fibonacci number    
            if (n == 1) return 1; //the second Fibonacci number    
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Numeric Sequence Calculator";

            return View();
        }

        public ActionResult Instructions()
        {
            ViewBag.Message = "How to use the Numeric Sequence Calculator.";

            return View();
        }
    }
}