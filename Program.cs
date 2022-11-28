

namespace Waterbill

{

    internal class Waterbill

    {

        public string Name { get; set; }

        public string plot { get; set; }

        public string address { get; set; }

        public double portablewaterused { get; set; }

        public double portablewatercost { get; set; }

        public double portablewaterwastecost { get; set; }





        public double Totalcost;



        public Waterbill(string Fullnames, string PloLive, string add, double Kl, double klAmount, double WasterWater, double TotalAMOUNT)

        {

            Name = Fullnames;

            plot = PloLive;

            address = add;

            portablewaterused = Kl;

            portablewatercost = klAmount;

            portablewaterwastecost = WasterWater;





            Totalcost = TotalAMOUNT;

        }

        public double dom()

        {

            switch (portablewaterused)

            {

                case > 5.0:

                    portablewatercost = portablewaterused + 3.60;



                    portablewaterwastecost = portablewaterused * 0.65;



                    Totalcost = (portablewaterused * 3.60) + (portablewaterused * 0.65);

                    Console.WriteLine("******************************************************************************************************************");

                    Console.WriteLine("Names: " + Name + "Stay" + plot + "Area" + address + "Monthly Bill");

                    Console.WriteLine("Portable Water used Kl " + portablewaterused);

                    Console.WriteLine(" Portable water cost is : P " + portablewatercost);

                    Console.WriteLine(" Waste water cost is : P " + portablewaterwastecost);

                    Console.WriteLine("VAT 14%");

                    Console.WriteLine("Total Amount : P " + Totalcost);

                    Console.WriteLine("******************************************************************************************************************");

                    break;



                case 5.0 - 15.0:

                    portablewatercost = portablewaterused * 11.78;



                    portablewaterwastecost = portablewaterused * 2.95;



                    Totalcost = (portablewaterused * 13.43) + (portablewaterused * 3.36) + (portablewaterused * 3.60) + (portablewaterused * 0.65);

                    Console.WriteLine("******************************************************************************************************************");

                    Console.WriteLine("Names: " + Name + "Stay" + plot + "area" + address + "Monthly Bill");

                    Console.WriteLine("Portable Water used Kl:  " + portablewaterused);

                    Console.WriteLine("Portable water cost is : P " + portablewatercost);

                    Console.WriteLine(" Waste water cost is : P " + portablewaterwastecost);

                    Console.WriteLine("VAT 14%");

                    Console.WriteLine("Total Amount : P " + Totalcost);

                    Console.WriteLine("******************************************************************************************************************");

                    break;



                case > 15.0 - 25.0:

                    portablewatercost = portablewaterused * 20.62;



                    portablewaterwastecost = portablewaterused * 4.41;



                    Totalcost = (portablewaterused * 23.51) + (portablewaterused * 5.03) + (portablewaterused * 13.43) + (portablewaterused * 3.36) + (portablewaterused * 3.60) + (portablewaterused * 0.65);

                    Console.WriteLine("******************************************************************************************************************");

                    Console.WriteLine("Names: " + Name + "Stay" + plot + "area" + address + "Monthly Bill");

                    Console.WriteLine("Portable Water used Kl " + portablewaterused);

                    Console.WriteLine(" Portable water cost is : P " + portablewatercost);

                    Console.WriteLine(" Waste water cost is : P " + portablewaterwastecost);



                    Console.WriteLine("Total Amount : P " + Totalcost);

                    Console.WriteLine("******************************************************************************************************************");

                    break;



                case > 25.0 - 40.0:

                    portablewatercost = portablewaterused * 31.72;



                    portablewaterwastecost = portablewaterused * 5.89;



                    Totalcost = (portablewaterused * 36.16) + (portablewaterused * 6.71) + (portablewaterused * 23.51) + (portablewaterused * 5.03) + (portablewaterused * 13.43) + (portablewaterused * 3.36) + (portablewaterused * 3.60) + (portablewaterused * 0.65);

                    Console.WriteLine("******************************************************************************************************************");

                    Console.WriteLine("Names: " + Name + "Stay" + plot + "Area" + address + "Monthly Bill");

                    Console.WriteLine("Portable Water used Kl  " + portablewaterused);

                    Console.WriteLine("Portable water cost is : P " + portablewatercost);

                    Console.WriteLine("Waste water cost is : P " + portablewaterwastecost);

                    Console.WriteLine("VAT 14%");

                    Console.WriteLine("Total Amount : P " + Totalcost);

                    Console.WriteLine("******************************************************************************************************************");

                    break;



                default:

                    portablewatercost = portablewaterused * 39.66;



                    portablewaterwastecost = portablewaterused * 7.36;

                    ;

                    Totalcost = (portablewaterused * 45.21) + (portablewaterused * 8.39) + (portablewaterused * 36.16) + (portablewaterused * 6.71) + (portablewaterused * 23.51) + (portablewaterused * 5.03) + (portablewaterused * 13.43) + (portablewaterused * 3.36) + (portablewaterused * 3.60) + (portablewaterused * 0.65);

                    Console.WriteLine("******************************************************************************************************************");

                    Console.WriteLine("Names: " + Name + "Stay" + plot + "Area" + address + "Monthly Bill");

                    Console.WriteLine("Portable Water used Kl " + portablewaterused);

                    Console.WriteLine(" Portable water cost is : P " + portablewatercost);

                    Console.WriteLine(" Waste water cost is : P " + portablewaterwastecost);

                    Console.WriteLine("VAT 14%");

                    Console.WriteLine("Total Amount : P " + Totalcost);

                    Console.WriteLine("******************************************************************************************************************");

                    break;



            }

            return portablewatercost;

        }







        public double Com()

        {

            switch (portablewaterused)

            {

                case > 5.0:

                    portablewatercost = portablewaterused * 4.32;



                    portablewaterwastecost = portablewaterused * 0.65;



                    Totalcost = (portablewaterused * 4.92) + (portablewaterused * 0.74);

                    Console.WriteLine("******************************************************************************************************************");

                    Console.WriteLine("Names: " + Name + "Stay" + plot + "Area" + address + "Monthly Bil");

                    Console.WriteLine("Portable Water used Kl " + portablewaterused);

                    Console.WriteLine(" Portable water cost is : P " + portablewatercost);

                    Console.WriteLine(" Waste water cost is : P " + portablewaterwastecost);

                    Console.WriteLine("VAT 14%");

                    Console.WriteLine("Total Amount : P" + Totalcost);

                    Console.WriteLine("******************************************************************************************************************");

                    break;



                case 5.0 - 15.0:

                    portablewatercost = portablewaterused * 12.83;



                    portablewaterwastecost = portablewaterused * 2.95;



                    Totalcost = (portablewaterused * 14.61) + (portablewaterused * 3.36) + (portablewaterused * 4.92) + (portablewaterused * 0.74);

                    Console.WriteLine("******************************************************************************************************************");

                    Console.WriteLine("Names: " + Name + "Stay" + plot + "Area" + address + "Monthly Bill");

                    Console.WriteLine("Portable Water cost " + portablewaterused);

                    Console.WriteLine(" Portable water cost is : " + portablewatercost);

                    Console.WriteLine(" Waste water cost is : " + portablewaterwastecost);

                    Console.WriteLine("VAT 14%");

                    Console.WriteLine("Total Amount : " + Totalcost);

                    Console.WriteLine("******************************************************************************************************************");

                    break;

                case > 15.0 - 25.0:

                    portablewatercost = portablewaterused * 22.44;



                    portablewaterwastecost = portablewaterused * 4.41;



                    Totalcost = (portablewaterused * 25.88) + (portablewaterused * 5.03) + (portablewaterused * 14.61) + (portablewaterused * 3.36) + (portablewaterused * 4.92) + (portablewaterused * 0.74);

                    Console.WriteLine("******************************************************************************************************************");

                    Console.WriteLine("Names: " + Name + "Stay" + plot + "Area" + address + "Monthly Bill");

                    Console.WriteLine("Portable Water used Kl" + portablewaterused);

                    Console.WriteLine(" Portable water cost is : P " + portablewatercost);

                    Console.WriteLine(" Waste water cost is : P " + portablewaterwastecost);

                    Console.WriteLine("VAT 14%");

                    Console.WriteLine("Total Amount : P " + Totalcost);

                    Console.WriteLine("******************************************************************************************************************");

                    break;



                case > 25.0 - 40.0:

                    portablewatercost = portablewaterused * 34.52;



                    portablewaterwastecost = portablewaterused * 5.89;



                    Totalcost = (portablewaterused * 39.35) + (portablewaterused * 6.71) + (portablewaterused * 25.88) + (portablewaterused * 5.03) + (portablewaterused * 14.61) + (portablewaterused * 3.36) + (portablewaterused * 4.92) + (portablewaterused * 0.74);

                    Console.WriteLine("******************************************************************************************************************");

                    Console.WriteLine("Names: " + Name + "Stay" + plot + "Area" + address + "Monthly Bill");

                    Console.WriteLine("Portable Water used Kl " + portablewaterused);

                    Console.WriteLine("Monthly Bill for Portable water cost is : P " + portablewatercost);

                    Console.WriteLine("Monthly Bill for Waste water cost is : P " + portablewaterwastecost);

                    Console.WriteLine("VAT 14%");

                    Console.WriteLine("Total Amount : P " + Totalcost);

                    Console.WriteLine("******************************************************************************************************************");

                    break;



                default:

                    portablewatercost = portablewaterused * 43.16;



                    portablewaterwastecost = portablewaterused * 7.36;



                    Totalcost = (portablewaterused * 49.20) + (portablewaterused * 8.39) + (portablewaterused * 39.35) + (portablewaterused * 6.71) + (portablewaterused * 25.88) + (portablewaterused * 5.03) + (portablewaterused * 14.61) + (portablewaterused * 3.36) + (portablewaterused * 4.92) + (portablewaterused * 0.74);

                    Console.WriteLine("******************************************************************************************************************");

                    Console.WriteLine("Names: " + Name + "Stay" + plot + "Area" + address + "Monthly Bill");

                    Console.WriteLine("Portable Water used Kl" + portablewaterused);

                    Console.WriteLine(" Portable water cost is : P " + portablewatercost);

                    Console.WriteLine(" Waste water cost is : P " + portablewaterwastecost);

                    Console.WriteLine("VAT 14%");

                    Console.WriteLine("Total Amount : P " + Totalcost);

                    Console.WriteLine("******************************************************************************************************************");

                    break;



            }

            return portablewaterused;

        }

    }

    internal class WaterBilltest

    {

        static void Main(string[] args)

        {

            StreamWriter outputFile;

            StreamWriter recordFile;

            outputFile = new("Invoice.csv");

            recordFile = File.AppendText("Report.csv");



            Waterbill waterbill = new Waterbill("0", "0", "0", 0, 0, 0, 0);











            ConsoleKeyInfo key;



            string password = ("");



            Console.WriteLine(" Please Enter Username");

            string Username = Console.ReadLine();



            Console.WriteLine("Please Enter Password ");

            do

            {

                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace)

                {

                    password += key.KeyChar;



                    Console.Write("*********");



                }

                else

                {

                    if (password.Length > 9)

                    {

                        password = password.Substring(0, password.Length - 1);

                        Console.Write("\b \b");

                    }

                }



            } while (key.Key! == ConsoleKey.Enter);



            outputFile.WriteLine("User Name is : " + Username);

            outputFile.WriteLine("Password is :" + password);







            Console.WriteLine("*****************************************************************************");

            outputFile.WriteLine("******************************************************************************");

            Console.WriteLine();

            Console.WriteLine("Please Enter Full Names :");

            waterbill.Name = Console.ReadLine();

            outputFile.WriteLine("Name" + waterbill.Name);

            Console.WriteLine("Please Enter REsidential place");

            waterbill.plot = Console.ReadLine();

            outputFile.WriteLine("Residence " + waterbill.plot);

            Console.WriteLine("Please Enter Address Plot");

            waterbill.address = Console.ReadLine();

            outputFile.WriteLine("Plot" + waterbill.address);

            Console.WriteLine("Please enter water Kilo Litres used");

            waterbill.portablewaterused = Convert.ToDouble(Console.ReadLine());

            outputFile.WriteLine("Portable Water Used :" + waterbill.portablewaterused);

            Console.WriteLine("The water used in Kilo Liters What user type  is it Domestic enter 1 if not then Enter 2 for Business Commercial");

            int answer;

            answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _   _ __ _ _ _ _ _ _ _  _ _   __ _ _ _ _ _ _  __ _ _ _ _ _ __ _ ");



            if (answer == 1)

            {



                outputFile.WriteLine(waterbill.Name + waterbill.plot + waterbill.address + " Monthly Bill");

                Console.WriteLine(waterbill.dom());

                outputFile.WriteLine(waterbill.dom());

            }

            else

            {



                outputFile.WriteLine(waterbill.Name + waterbill.plot + waterbill.address + " Monthly Bill");

                Console.WriteLine(waterbill.Com());

                outputFile.WriteLine(waterbill.Com());

            }



            ConsoleKeyInfo key1;



            string password1 = ("");



            Console.WriteLine(" Please Enter Username");

            string Username1 = Console.ReadLine();// user name. 



            Console.WriteLine("Please Enter Password ");

            do

            {

                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace)

                {

                    password += key.KeyChar;



                    Console.Write("*********");



                }

                else

                {

                    if (password.Length > 0)

                    {

                        password = password.Substring(0, password.Length - 1);

                        Console.Write("\b \b");

                    }

                }



            } while (key.Key! == ConsoleKey.Enter);



            outputFile.WriteLine("User Name is : " + Username);

            outputFile.WriteLine("Password is :" + password);







            Console.WriteLine("*****************************************************************************");

            outputFile.WriteLine("******************************************************************************");

            Console.WriteLine();

            Console.WriteLine("Please Enter Full Names :");

            waterbill.Name = Console.ReadLine();

            outputFile.WriteLine("Name" + waterbill.Name);

            Console.WriteLine("Please Enter REsidential place");

            waterbill.plot = Console.ReadLine();

            outputFile.WriteLine("Residence " + waterbill.plot);

            Console.WriteLine("Please Enter Address Plot");

            waterbill.address = Console.ReadLine();

            outputFile.WriteLine("Plot" + waterbill.address);

            Console.WriteLine("Please enter water Kilo Litres used");

            waterbill.portablewaterused = Convert.ToDouble(Console.ReadLine());

            outputFile.WriteLine("Portable Water Used :" + waterbill.portablewaterused);

            Console.WriteLine("The water used in Kilo Liters What user type  is it Domestic enter 1 if not then Enter 2 for Business Commercial");

            int answer2;

            answer2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _   _ __ _ _ _ _ _ _ _  _ _   __ _ _ _ _ _ _  __ _ _ _ _ _ __ _ ");



            if (answer2 == 1)

            {



                outputFile.WriteLine(waterbill.Name + waterbill.plot + waterbill.address + " Monthly Bill");

                Console.WriteLine(waterbill.dom());

                outputFile.WriteLine(waterbill.dom());

            }

            else

            {



                outputFile.WriteLine(waterbill.Name + waterbill.plot + waterbill.address + " Monthly Bill");

                Console.WriteLine(waterbill.Com());

                outputFile.WriteLine(waterbill.Com());

            }











            ConsoleKeyInfo key3;



            string password3 = ("");



            Console.WriteLine(" Please Enter Username");

            string Username3 = Console.ReadLine();



            Console.WriteLine("Please Enter Password ");

            do

            {

                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace)

                {

                    password += key.KeyChar;



                    Console.Write("*********");



                }

                else

                {

                    if (password.Length > 0)

                    {

                        password = password.Substring(0, password.Length - 1);

                        Console.Write("\b \b");

                    }

                }



            } while (key.Key! == ConsoleKey.Enter);



            outputFile.WriteLine("User Name is : " + Username);

            outputFile.WriteLine("Password is :" + password);







            Console.WriteLine("*****************************************************************************");

            outputFile.WriteLine("******************************************************************************");

            Console.WriteLine();

            Console.WriteLine("Please Enter Full Names :");

            waterbill.Name = Console.ReadLine();

            outputFile.WriteLine("Name" + waterbill.Name);

            Console.WriteLine("Please Enter REsidential place");

            waterbill.plot = Console.ReadLine();

            outputFile.WriteLine("Residence " + waterbill.plot);

            Console.WriteLine("Please Enter Address Plot");

            waterbill.address = Console.ReadLine();

            outputFile.WriteLine("Plot" + waterbill.address);

            Console.WriteLine("Please enter water Kilo Litres used");

            waterbill.portablewaterused = Convert.ToDouble(Console.ReadLine());

            outputFile.WriteLine("Portable Water Used :" + waterbill.portablewaterused);

            Console.WriteLine("The water used in Kilo Liters What user type  is it Domestic enter 1 if not then Enter 2 for Business Commercial");

            int answer3;

            answer3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _   _ __ _ _ _ _ _ _ _  _ _   __ _ _ _ _ _ _  __ _ _ _ _ _ __ _ ");



            if (answer3 == 1)

            {



                outputFile.WriteLine(waterbill.Name + waterbill.plot + waterbill.address + " Monthly Bill");

                Console.WriteLine(waterbill.dom());

                outputFile.WriteLine(waterbill.dom());

            }

            else

            {



                outputFile.WriteLine(waterbill.Name + waterbill.plot + waterbill.address + " Monthly Bill");

                Console.WriteLine(waterbill.Com());

                outputFile.WriteLine(waterbill.Com());

            }







            outputFile.Close();

            recordFile.Close();

            Console.WriteLine("_ _ _ _ _  __ _ _ _ _  _ __  __ _ _ __  _ _ _ _ __  _ _ _ _  _  _  _ __ _ _ _ _ __  _ __ _  _  _  _ _ __ _ _ _ _ _ _  __ ");































        }

    }

}

