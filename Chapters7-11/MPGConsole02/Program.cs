using System;
using static System.Console;

namespace MPGConsole02
{
    internal class Program
    {
        //  Declare and initialize program constants
        const decimal MINMILES =    1M;
        const decimal MAXMILES = 1000M;
        const decimal MINGALLS =    1M;
        const decimal MAXGALLS =  100M;

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
                //WriteLine($"The Miles Driven Has A Value Of: {milesDriven}");

                gallonsUsed = ValidateGallonsUsed();
                //WriteLine($"The Gallons Used Has A Value Of: {gallonsUsed}");

                milesPerGallon = CalculateMPG(milesDriven, gallonsUsed);

                PrintAll(milesDriven, gallonsUsed, milesPerGallon);

                again = RunProgramAgain();
            }
        }

        //  Function to validate the inputted miles driven
        static decimal ValidateMilesDriven()
        {
            bool    result;
            string  mdStr = "";
            decimal mdDec = 0M;

            //Write("Please Enter Miles Driven Between 1 and 1000: ");
            //Write("\nPlease Enter Miles Driven Between " +
            //      MINMILES + " and " + MAXMILES + ":");
            Write($"\nPlease Enter Miles Driven Between {MINMILES} and {MAXMILES}: ");
            mdStr = ReadLine();

            result = decimal.TryParse(mdStr, out mdDec );
            if (!result)
            {                                           //  Input was non-numeric
                WriteLine("\nIllegal. Non-Numeric Input!");
                mdDec = 0;
            }
            else if ((mdDec < MINMILES) || (mdDec > MAXMILES))
            {                                           //  Perform range check
                WriteLine("\nIllegal. Out-Of-Range Input!");
                mdDec = 1;
            }

            //  Input was numeric and was between MINMILES and MAXMILES (1 - 1000)
            return mdDec;

        }

        //  Function to validate the inputted gallons used
        static decimal ValidateGallonsUsed()
        {
            bool result;
            string guStr = "";
            decimal guDec = 0M;

            //Write("Please Enter Gallons Used Between 1 and 100: ");
            //Write("\nPlease Enter Gallon Used Between " +
            //      MINGALLS + " and " + MAXGALLSS + ":");
            Write($"\nPlease Enter Gallons Used Between {MINGALLS} and {MAXGALLS}: ");
            guStr = ReadLine();

            result = decimal.TryParse(guStr, out guDec);
            if (!result)
            {                                           //  Input was non-numeric
                WriteLine("\nIllegal. Non-Numeric Input!");
                guDec = 0;
            }
            else if ((guDec < MINMILES) || (guDec > MAXMILES))
            {                                           //  Perform range check
                WriteLine("\nIllegal. Out-Of-Range Input!");
                guDec = 1;
            }

            //  Input was numeric and was between MINGALLS and MAXGALLS (1 - 100)
            return guDec;
        }

        //  Function to calculate miles per gallons
        static decimal CalculateMPG(decimal m, decimal g)
        {
            if (g == 0)
            {
                WriteLine("Illegal Attempt To Divide By 0");
                return 0M;
            }

            return m / g;
        }

        //  Print out miles driven, gallons used, miles per gallon
        static void PrintAll(decimal md, decimal gu, decimal mpg)
        {
            WriteLine($"Miles = {md}\nGallons = {gu}\nMPG = {mpg.ToString("n2")}");
        }

        static bool RunProgramAgain()
        {
            string yesOrNo = "";
            char firstChar = '\0';
            bool retVal    = true;

            Write("\nWould You Like To Run The Program Again? (Y/N):\t");
            yesOrNo = ReadLine().Trim();

            firstChar = yesOrNo[0];             //  First character of yesOrNo string
            if (!firstChar.ToString().ToUpper().Equals("Y"))
            {
                retVal = false;
            }

            return retVal;
        }
    }
}
