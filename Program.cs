using System;

namespace ICT627_Assessment2_TaxCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PTCInitial();
            




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
                 
                    Console.WriteLine("--------------------------------");
                    Console.Write("Please enter your Annual Income: ");
                    string checkyearly = Console.ReadLine();
                  
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
                                
                            }
                            else if (response == "no")
                            {
                                Console.WriteLine("your tax code is: M");
                                
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
                                
                            }
                            else if (response == "no")
                            {
                                Console.WriteLine("your tax code is: ME");
                            
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
                          
                        }
                        else if (response == "no")
                        {
                            Console.WriteLine("your tax code is: M");
                      
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
                
                    
                    
                }
                else if (response == "no")
                {
                    Console.WriteLine("your tax code is: M");
                    
                   
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
                        
                    }
                    else if (response == "no")
                    {
                        Console.WriteLine("your tax code is: SB");
                        
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
                        
                    }
                    else if (response == "no")
                    {
                        Console.WriteLine("your tax code is: S");
                       
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
                       
                    }
                    else if (response == "no")
                    {
                        Console.WriteLine("your tax code is: SH");
                      
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
                        
                    }
                    else if (response == "no")
                    {
                        Console.WriteLine("your tax code is: ST");
                        
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
