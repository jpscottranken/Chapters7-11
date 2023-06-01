using System;
using static System.Console;

namespace MPGConsole03
{
    internal class Program
    {
        //  Declare and initialize program constants
        const decimal MINMILES = 1M;
        const decimal MAXMILES = 1000M;
        const decimal MINGALLS = 1M;
        const decimal MAXGALLS = 100M;

        static void Main(string[] args)
        {
            bool again = true;          //  Program continue variable
            decimal milesDriven;
            decimal gallonsUsed;
            decimal milesPerGallon;     //  milesDriven / gallonsUsed

            while (again)
            {
                Clear();

                milesDriven = ValidateMilesDriven();

                gallonsUsed = ValidateGallonsUsed();

                milesPerGallon = CalculateMPG(milesDriven, gallonsUsed);

                PrintAll(milesDriven, gallonsUsed, milesPerGallon);

                again = RunProgramAgain();
            }
        }

        //  Function to validate miles driven
        static decimal ValidateMilesDriven()
        {
            string  mdStr;
            decimal mdDec = 0; ;

            try
            {
                Write($"\nPlease Enter Miles Driven Between {MINMILES} and {MAXMILES}: ");
                mdStr = ReadLine();

                mdDec = Convert.ToDecimal(mdStr);

                if ((mdDec < MINMILES) || (mdDec > MAXMILES))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException fe)
            {
                WriteLine($"\nError: {fe.Message}\n\n");
                mdDec = 1;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                WriteLine($"\nError: {aoore.Message}\n\n");
                mdDec = 0;
            }

            return mdDec;
        }

        //  Function to validate gallons used
        static decimal ValidateGallonsUsed()
        {
            string guStr;
            decimal guDec = 0; ;

            try
            {
                Write($"\nPlease Enter Gallons Used Between {MINGALLS} and {MAXGALLS}: ");
                guStr = ReadLine();

                guDec = Convert.ToDecimal(guStr);

                if ((guDec < MINGALLS) || (guDec > MAXGALLS))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException fe)
            {
                WriteLine($"\nError: {fe.Message}\n\n");
                guDec = 1;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                WriteLine($"\nError: {aoore.Message}\n\n");
                guDec = 0;
            }

            return guDec;
        }

        //  Function to calculate MPG as  miles driven / gallons used
        static decimal CalculateMPG(decimal m, decimal g)
        {
            decimal mpg = 0M;

            try
            {
                mpg = m / g;
            }
            catch (DivideByZeroException dbze)
            {
                WriteLine($"Error: {dbze.Message}");
                mpg = 0M;
            }

            return mpg;
        }

        //  Print out miles driven, gallons used, miles per gallon
        static void PrintAll(decimal md, decimal gu, decimal mpg)
        {
            WriteLine($"\n\nMiles = {md}\nGallons = {gu}\nMPG = {mpg.ToString("n2")}");
            ReadLine();
        }

        //  Function to allow user to run program again (or not)
        static bool RunProgramAgain()
        {
            string yesOrNo = "";
            char firstChar = '\0';
            bool retVal    = true;

            try
            {
                Write("\nWould You Like To Run The Program Again? (Y/N):\t");
                yesOrNo = ReadLine().Trim();

                firstChar = yesOrNo[0];             //  First character of yesOrNo string
                if (!firstChar.ToString().ToUpper().Equals("Y"))
                {
                    retVal = false;
                }
            }
            catch (IndexOutOfRangeException ioorex)
            {
                WriteLine($"\n\nError: {ioorex.Message}");
                retVal = false;
                ReadLine();
            }

            return retVal;
        }
    }
}
