using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Security;


namespace Basic_ATM
{
    class Intro
    {
        static int Main(string[] args)
        {
       
            Console.WriteLine("Welcome To Martuor Dysiphon Banking Systems");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("Press :");
            Console.WriteLine("1: New Client");
            Console.WriteLine("2: Existing Client");
            
            int value = int.Parse(Console.ReadLine());

            switch (value)
            {
                case 1:
                    Console.WriteLine("To Open an account the following are required: ");
                    Console.WriteLine("ID card: Proof of Address: Security No");
                    Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||");
                    Console.Write("Do you ave all te required documents|informations?; "); int nationality = int.Parse(Console.ReadLine());
                    Console.WriteLine("Press 1 if Yes| 2 if No");                    

                    if (nationality < 2 )
                    {
                        Console.Write("Enter your ID number:"); long ID = long.Parse(Console.ReadLine());
                        if(ID < 999999999999) 
                        {
                            Console.WriteLine("invalid ID");
                            Console.Write("Please Enter  yout correct ID number:"); long ID0 = long.Parse(Console.ReadLine());
                            if (ID0 < 999999999999)
                            {
                                Console.WriteLine("My Apoloies the followin ID numbers you are invalid");
                                Console.WriteLine($"1. invalid ID: {ID} ");
                                Console.WriteLine($"2. invalid ID: {ID0} ");
                                Console.WriteLine($"Seems like we cannot help you since you provided invalid ID numbers");
                            }
                        }
                        else
                        {
                            Console.Write("Enter your FirstName(s): "); string firstName = Console.ReadLine();
                            Console.Write("Enter your lastName: "); string lastName = Console.ReadLine();

                            //Date of Birth
                            int DD, MM, YYYY;
                            Console.WriteLine("Enter your Date of Birth |YYYY|DD|MM|");
                            Console.Write("Enter your Year of Birth: "); YYYY = int.Parse(Console.ReadLine());
                            Console.Write("Enter your Day of Birth: "); DD = int.Parse(Console.ReadLine());
                            Console.Write("Enter your Month of Birth: Choose from te bellow: "); MM = int.Parse(Console.ReadLine());
                            Console.WriteLine("1. January");
                            Console.WriteLine("2. February");
                            Console.WriteLine("3. March");
                            Console.WriteLine("4. April");
                            Console.WriteLine("5. May");
                            Console.WriteLine("6. June");
                            Console.WriteLine("7. July");
                            Console.WriteLine("8. August");
                            Console.WriteLine("9. September");
                            Console.WriteLine("10. October");
                            Console.WriteLine("11. November");
                            Console.WriteLine("12. December");


                        }
                    }
                    else
                        Console.Write("Please Enter your Passport or Internation Identification Number:");
                        long  ininterID = long.Parse(Console.ReadLine());


                   break; /*breaking case 1*/

                case 2:
                    Console.WriteLine("Ellow tere");

                    break;

                
               
                default:
                    Console.WriteLine("Sorry Invalid Option!");
                    break;
            }
            return value;
        }
       
        
    }

}

