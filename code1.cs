using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int iStudentNumber, iStudentScore;
            string sStudentFirstname, sStudentSurname;
            string[] sModule = { "Module 1", "Module 2", "Module 3", "Module 4", "Module 5", "Module 6" };

            /*Console.WriteLine("Hello World!");

            Console.WriteLine("Please enter Student Name");
            Console.Write("First Name:");
            sStudentFirstname = Console.ReadLine();
            Console.Write("Surname:");
            sStudentSurname = Console.ReadLine();
            Console.Write("Please enter student Number:");
            iStudentNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter Module score:");

            Console.WriteLine("Student Name: " + sStudentFirstname + " " + sStudentSurname);
            Console.WriteLine("Student Number: " + iStudentNumber);

            Console.WriteLine("Enter the number of years:");
            string sEnterNumber = Console.ReadLine();

            while (!Int32.TryParse(sEnterNumber, out iStudentScore))
            {
                Console.WriteLine("Not a valid ammount, try again.");
                sEnterNumber = Console.ReadLine();

                if (iStudentScore >= 1 && iStudentScore <= 10)
                {
                    Console.WriteLine("Not a valid ammount, try again.");
                    sEnterNumber = Console.ReadLine();
                }
            }

            Console.ReadKey();*/



            int iScore;

            Console.Write("Please Enter Students Score (0-100): ");
            iScore = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Score is :" + iScore);
            Console.ReadKey();

            int iAge, iAge2, iResult;
            string Age, AgeText, result;
            Console.Write("Enter your age");
            AgeText = Console.ReadLine();

            try
            {
                iAge = int.Parse(AgeText);
                Console.WriteLine(
                    $"Hi  You are { iAge * 12 } months old.");
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    $"The age entered, { AgeText }, is not valid.");
                result = 1;
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");
                result = AgeText;
            }
            return AgeText;



            iAge = Convert.ToInt32(Console.ReadLine());


            if (Int32.TryParse(iAge.ToString, out iAge2))
            {
                Image1.Width = imageWidth;
            }

            while (iAge < 0 || iAge > 100)
            {
                Console.WriteLine("Error. Score not between 0-100: ");
                Console.Write("Please re-enter: ");
                iAge = Convert.ToInt32(Console.ReadLine());
            }



            double dSales;
            double dOverheads;
            double dProfit;
            double dBonus;
            String sTaxCode;

            Console.Write("Enter amount of sales for the year: ");
            dSales = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter cost of overheads for the year: ");
            dOverheads = Convert.ToDouble(Console.ReadLine());

            //calculate amount of profit or loss
            dProfit = dSales - dOverheads;

            Console.WriteLine();

            //display amount of profit or loss
            if (dProfit > 0)
            {
                Console.WriteLine("This year you made a profit of " + dProfit.ToString("C"));
            }
            else if (dProfit < 0)
            {
                Console.WriteLine("This year you made a loss of " + dProfit.ToString("C"));
            }
            else
            {
                Console.WriteLine("This year you have broken even.");
            }

            Console.WriteLine();

            //work out the bonus due
            if (dProfit <= 0)
            {
                dBonus = 0; sTaxCode = "N";
            }
            else if (dProfit > 0 && dProfit <= 1000)
            {
                dBonus = 50; sTaxCode = "A";
            }
            else if (dProfit > 1000 && dProfit <= 5000)
            {
                dBonus = 200; sTaxCode = "B";
            }
            else
            {
                dBonus = 600; sTaxCode = "C";
            }

            Console.WriteLine("You have earned a bonus of " + dBonus.ToString("C"));
            Console.WriteLine();

            //work out and display the tax code which applies
            switch (sTaxCode)
            {
                case "N":
                    Console.WriteLine("Tax code: N - nothing to pay");
                    break;
                case "A":
                    Console.WriteLine("Tax code A - 10%");
                    break;
                case "B":
                    Console.WriteLine("Tac code B - 25%");
                    break;
                case "C":
                    Console.WriteLine("Tax code C - 40%");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
       




        //foreach (var vItem in sModule);
        //{
        //    Console.Write("[sModule ", + vItem);
        //}

        //Console.ReadKey();
    }
    }
}
