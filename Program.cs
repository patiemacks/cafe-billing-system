using System;

namespace BillingSystem
{
    class Program
    {
        /* Basic App Info */

        string appName = "MACKS CAFE CHARGING SYSTEM";
        string appVersion = "1.0.0";
        string appAuthor = "patiemacks";

        /* Variable Declaration */

        string customerName = "";
        string servicesRendered = "";
        int amountCharged=0;
        int numberOfServicesOffered = 0;
        int minutesSpent = 1;
        int numberOfCopies = 1;
        int miscCharges = 1;
        string levelOfAssistance = "";
        int levelOfAssistanceValue = 1;

        /* Diffirent Cafe Service Charges */

        int photocopyCharges = 0;
        int scanningCharges = 0;
        int ordinaryComputerUseCharges = 0;
        int internetAccessCharges = 0;
        int faxingCharges = 0;
        int phoneCallCharges = 0;

        /* Calculate Service Charges */

        int CalcServicesRenderedCharges()
        {
            decimal overallCharges = this.minutesSpent * this.numberOfServicesOffered;
            return amountCharged;
        }
        /*Calculate Scanning Charges  */

        int CalculateScanningCharges()
        {
            int scanningCharges = this.numberOfCopies * amountCharged;
            return scanningCharges;
        }


        /* Calculate Faxing Charges */
        int CalcfaxingCharges()
        {
            int faxingCharges = this.numberOfCopies * amountCharged;
            return faxingCharges;
        }


        /* Calculate Photocopying Charges */

        int CalcPhotocopyCharges()
        {
            int photocopyCharges = this.numberOfCopies * amountCharged;
            return photocopyCharges;
        }

        /* Calculate internet access Charges */

        int CalInternetAccessCharges()
        {
            int internetAccessCharges = this.internetAccessCharges + this.minutesSpent; 
            return internetAccessCharges;
        }

        /* Miscellaneous Charges */

        int CalcMiscCharges()
        {
            int miscCharges = this.ordinaryComputerUseCharges + this.phoneCallCharges;
            return miscCharges;
        }

        /* Function Show Basic App Info Output To Console */

        void showAppInfo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\t" + this.appName);
            Console.WriteLine("\t\t\tVersion : " + this.appVersion);
            Console.WriteLine("\t\t\tAuthor : " + this.appAuthor);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        /* Print Final Receipt */

        void printRecipt()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("****************************************");
            Console.WriteLine("Customer Name : " + this.customerName);
            Console.WriteLine("Level of Assistance : " + this.levelOfAssistance);
            Console.WriteLine("Level of total Cost : " + this.levelOfAssistanceValue);
            Console.WriteLine("Services Rendered Charges : R" + amountCharged);
            Console.WriteLine("Faxing Charges : R" + faxingCharges);
            Console.WriteLine("Scanning Charges : R" + scanningCharges);
            Console.WriteLine("Photocopy Charges : R" + photocopyCharges);
            Console.WriteLine("Internet Access Charges : R" + internetAccessCharges);
            Console.WriteLine("Ordinary Computer usage and Phonecall Charges : R" + miscCharges);
            Console.WriteLine("Total Charges : R " + (levelOfAssistanceValue+ amountCharged+ faxingCharges + scanningCharges + photocopyCharges +internetAccessCharges + miscCharges));
            Console.WriteLine("****************************************");
        }

        /* Main Entry Point of Application */
        static void Main(string[] args)
        {

            Program prg = new Program(); // Create Object of Class
            prg.showAppInfo();  // Show Basic Aapp Info

            Console.Write("Please Enter Customer Name : ");
            prg.customerName = Console.ReadLine(); // Input customer name

            Console.WriteLine();
            Console.WriteLine("Level of Assistance :");
            Console.WriteLine("1. Level 1 -> R5");
            Console.WriteLine("2. Level 2 -> R7");
            Console.WriteLine("3. Level 3 -> R10");
            Console.WriteLine("4. Level 4 -> R20");
            Console.WriteLine();
            Console.Write("Please Enter Level of Assistance Amount : " );
            int levelOfAssistanceInput = int.Parse(Console.ReadLine()); // Input level of assistance


            Console.Write("Please Enter Services Rendered Charges : ");
            prg.servicesRendered = Console.ReadLine();

            Console.Write("Please Enter Photocopy Charges : ");
            prg.photocopyCharges = int.Parse(Console.ReadLine());

            Console.Write("Please Enter  Scan Charges : ");
            prg.scanningCharges = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Faxing Charges : ");
            prg.faxingCharges = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Internet Access Charges : ");
            prg.internetAccessCharges = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Miscellenous Charges : ");
            prg.ordinaryComputerUseCharges = int.Parse(Console.ReadLine());

            /* calling final function to output final details with calculation */
            prg.printRecipt();
            Console.ReadKey();
        }
    }
}
