using System;

namespace ICT627_Assessment2_TaxCalculator
{
    class Program
    {
        //public static string taxcodesummary;
        //public static string takehomeresult;
        //public static string taxpayableval;
        static void Main(string[] args)
        {
            PTCInitial();
            //Summary.summary();
            //TryAgain.repeat();




        }
        public static void PTCInitial()
        {
            double yearly;

            Console.WriteLine(" ______________________________________________________________________________________________");
            Console.WriteLine("|                                        Tax Code                                              |");
            Console.WriteLine("|                        This Module checks your current tax code.                             | ");
            Console.WriteLine("|               Please Enter \"yes\", or \"no\" towards the following questions                    | ");
            Console.WriteLine("|                  Please Enter your annual salary when asked by the system.                   | ");
            Console.WriteLine("|______________________________________________________________________________________________|");
            Console.WriteLine("");

            Console.Write("Do you Recieve an income tested benefit?: ");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                Console.Write("Is this Tax Code for the income tested benefit?: ");
                response = Console.ReadLine();
                if (response == "yes")
                {
                    Console.WriteLine("Your Tax Code is: M");
                    //taxcodesummary = "Your Tax Code is: M";
                    Console.WriteLine("--------------------------------");
                    Console.Write("Please enter your Annual Income: ");
                    string checkyearly = Console.ReadLine();
                    //if (double.TryParse(checkyearly, out yearly))
                    //{
                    //    TaxPay.TaxPayableCalc(yearly);
                    //    TaxCalcQ.TCQ(yearly);
                    //}
                }
                else if (response == "no")
                {
                    Console.WriteLine("The System will now calculate your Secondary Income Tax Code");
                    ScdInc();
                }

                else
                {
                    Console.Write("Please enter a correct response");
                    Console.Clear();
                    PTCInitial();
                }


            }
            else if (response == "no")
            {
                Console.Write("Is this tax code for your main or highest source of income?: ");
                response = Console.ReadLine();
                if (response == "yes")
                {
                    PrmInc();
                }

                else if (response == "no")
                {
                    Console.WriteLine("The System will now calculate your Secondary Income Tax Code");
                    ScdInc();
                }

                else
                {
                    Console.Write("Please enter a correct response");
                    Console.Clear();
                    PTCInitial();
                }
            }

            else
            {
                Console.Write("Please enter a correct response");
                Console.Clear();
                PTCInitial();
            }
        }

        static void PrmInc()
        {
            double yearly;

            Console.Write("Are you a New Zealand Tax resident?: ");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine("--------------------------------");
                Console.Write("How much is your annual Income?: ");
                string checkyearly = Console.ReadLine();
                if (double.TryParse(checkyearly, out yearly))
                {
                    if (yearly >= 24000 && yearly <= 48000)
                    {
                        Console.WriteLine("_____________________________________________________________");
                        Console.Write("Are you or your Partner entitled to Working for Families tax credit or overseas equivalent? ");
                        Console.WriteLine("or");
                        Console.WriteLine("Do you recieve NZ super veteran pension or an overseas equivalent?");
                        Console.Write("Answer: ");
                        response = Console.ReadLine();
                        if (response == "yes")
                        {
                            Console.Write("Do you have student loans?: ");
                            response = Console.ReadLine();
                            if (response == "yes")
                            {
                                Console.WriteLine("your tax code is: M SL");
                                //taxcodesummary = "Your Tax Code is: M SL";
                                //TaxPay.TaxPayableCalc(yearly);
                                //TaxCalcQ.TCQ(yearly);
                            }
                            else if (response == "no")
                            {
                                Console.WriteLine("your tax code is: M");
                                //taxcodesummary = "Your Tax Code is: M";
                                //TaxPay.TaxPayableCalc(yearly);
                                //TaxCalcQ.TCQ(yearly);
                            }
                            else
                            {
                                Console.WriteLine("please enter a correct response");
                                PrmInc();
                            }

                        }
                        else if (response == "no")
                        {
                            Console.Write("Do you have student loans?: ");
                            response = Console.ReadLine();
                            if (response == "yes")
                            {
                                Console.WriteLine("your tax code is: ME SL");
                                //taxcodesummary = "Your Tax Code is: ME SL";
                                //TaxPay.TaxPayableCalc(yearly);
                                //TaxCalcQ.TCQ(yearly);
                            }
                            else if (response == "no")
                            {
                                Console.WriteLine("your tax code is: ME");
                                //taxcodesummary = "Your Tax Code is: ME";
                                //TaxPay.TaxPayableCalc(yearly);
                                //TaxCalcQ.TCQ(yearly);
                            }
                            else
                            {
                                Console.WriteLine("please enter a correct response");
                                PrmInc();
                            }
                        }

                    }
                    else
                    {
                        Console.Write("Do you have student loans?: ");
                        response = Console.ReadLine();
                        if (response == "yes")
                        {
                            Console.WriteLine("your tax code is: M SL");
                            //taxcodesummary = "Your Tax Code is: M SL";
                            //TaxPay.TaxPayableCalc(yearly);
                            //TaxCalcQ.TCQ(yearly);
                        }
                        else if (response == "no")
                        {
                            Console.WriteLine("your tax code is: M");
                            //taxcodesummary = "Your Tax Code is: M";
                            //TaxPay.TaxPayableCalc(yearly);
                            //TaxCalcQ.TCQ(yearly);
                        }
                        else
                        {
                            Console.WriteLine("please enter a correct response");
                            PrmInc();
                        }
                    }

                }

                else
                {
                    Console.WriteLine("Please enter a numerical value");
                    PrmInc();
                }


            }
            else if (response == "no")
            {
                Console.Write("Do you have student loans?: ");
                response = Console.ReadLine();
                if (response == "yes")
                {
                    Console.WriteLine("your tax code is: M SL");
                    //taxcodesummary = "Your Tax Code is: M SL";
                    Console.Write("Please enter your Annual Income: ");
                    string checkyearly = Console.ReadLine();
                    if (double.TryParse(checkyearly, out yearly))
                    {
                        //TaxPay.TaxPayableCalc(yearly);
                        //TaxCalcQ.TCQ(yearly);
                    }
                }
                else if (response == "no")
                {
                    Console.WriteLine("your tax code is: M");
                    //taxcodesummary = "Your Tax Code is: M";
                    Console.Write("Please enter your Annual Income: ");
                    string checkyearly = Console.ReadLine();
                    if (double.TryParse(checkyearly, out yearly))
                    {
                        //TaxPay.TaxPayableCalc(yearly);
                        //TaxCalcQ.TCQ(yearly);
                    }
                }
                else
                {
                    Console.WriteLine("please enter a correct response");
                    PrmInc();
                }
            }
            else
            {
                Console.WriteLine("Please enter a correct response");
                PrmInc();
            }


        }

        static void ScdInc()
        {
            double yearly;
            Console.WriteLine("--------------------------------");
            Console.Write("How much is your annual Income from all sources?: ");
            string checkyearly = Console.ReadLine();
            if (double.TryParse(checkyearly, out yearly))
            {
                if (yearly <= 14000)
                {
                    Console.Write("Do you have student loans?: ");
                    string response = Console.ReadLine();
                    if (response == "yes")
                    {
                        Console.WriteLine("your tax code is: SB SL");
                        //taxcodesummary = "Your Tax Code is: SB SL";
                        //TaxPay.TaxPayableCalc(yearly);
                        //TaxCalcQ.TCQ(yearly);
                    }
                    else if (response == "no")
                    {
                        Console.WriteLine("your tax code is: SB");
                        //taxcodesummary = "Your Tax Code is: SB";
                        //TaxPay.TaxPayableCalc(yearly);
                        //TaxCalcQ.TCQ(yearly);
                    }
                    else
                    {
                        Console.WriteLine("please enter a correct response");
                        ScdInc();
                    }
                }
                else if (yearly >= 14001 && yearly <= 48000)
                {
                    Console.Write("Do you have student loans?: ");
                    string response = Console.ReadLine();
                    if (response == "yes")
                    {
                        Console.WriteLine("your tax code is: S SL");
                        //taxcodesummary = "Your Tax Code is: S SL";
                        //TaxPay.TaxPayableCalc(yearly);
                        //TaxCalcQ.TCQ(yearly);
                    }
                    else if (response == "no")
                    {
                        Console.WriteLine("your tax code is: S");
                        //taxcodesummary = "Your Tax Code is: S";
                        //TaxPay.TaxPayableCalc(yearly);
                        //TaxCalcQ.TCQ(yearly);
                    }
                    else
                    {
                        Console.WriteLine("please enter a correct response");
                        ScdInc();
                    }
                }
                else if (yearly >= 48001 && yearly <= 70000)
                {
                    Console.Write("Do you have student loans?: ");
                    string response = Console.ReadLine();
                    if (response == "yes")
                    {
                        Console.WriteLine("your tax code is: SH SL");
                        //taxcodesummary = "Your Tax Code is: SH SL";
                        //TaxPay.TaxPayableCalc(yearly);
                        //TaxCalcQ.TCQ(yearly);
                    }
                    else if (response == "no")
                    {
                        Console.WriteLine("your tax code is: SH");
                        //taxcodesummary = "Your Tax Code is: SH";
                        //TaxPay.TaxPayableCalc(yearly);
                        //TaxCalcQ.TCQ(yearly);
                    }
                    else
                    {
                        Console.WriteLine("please enter a correct response");
                        ScdInc();
                    }
                }
                else
                {
                    Console.Write("Do you have student loans?: ");
                    string response = Console.ReadLine();
                    if (response == "yes")
                    {
                        Console.WriteLine("your tax code is: ST SL");
                        //taxcodesummary = "Your Tax Code is: ST SL";
                        //TaxPay.TaxPayableCalc(yearly);
                        //TaxCalcQ.TCQ(yearly);
                    }
                    else if (response == "no")
                    {
                        Console.WriteLine("your tax code is: ST");
                        //taxcodesummary = "Your Tax Code is: ST";
                        //TaxPay.TaxPayableCalc(yearly);
                        //TaxCalcQ.TCQ(yearly);
                    }
                    else
                    {
                        Console.WriteLine("please enter a correct response");
                        ScdInc();
                    }
                }

            }
            else
            {
                Console.WriteLine("Please enter a numerical value");
                ScdInc();
            }
        }
    }
}
