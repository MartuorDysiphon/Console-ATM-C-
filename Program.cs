﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

public class cardHolder
{
    string cardNo;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public cardHolder(string cardNo, int pin, string firstName, string lastName, double balance)
    {
        this.cardNo = cardNo;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    //getters for cardHolder
    public string getCardNo()
    {
        return cardNo;
    }

    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    //setters for cardHolder
    public void setCardNo(string newCardNo)
    {
        cardNo = newCardNo;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }
        
    public static void Main(string[] args)
    {
        void homePrintOptions()
        {
            Console.WriteLine("Please Choose from one of the following options.......");
            Console.WriteLine("1. Existing Client");
            Console.WriteLine("2. New Client");
            Console.WriteLine("3. Exit");
        }



        void printOptions()
        {

            //Console.WriteLine("");
            Console.WriteLine("Please Choose from one of the following options.......");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to deposit?: ");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine($"Thank you for your deposit. Your Current Balance : {currentUser.getBalance()} ");
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw?: ");
            double withdraw = double.Parse(Console.ReadLine()); 
             
            //VerificationException of funds
            if (currentUser.getBalance() < withdraw)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("You successfully withdrawn money: You are good to go ");
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine($"Your Current Balance: {currentUser.getBalance()} ");
            
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("11286312", 1234, "Amelia", "Adams", 1071.20));
        cardHolders.Add(new cardHolder("13492671", 2468, "Jamal", "Samson", 668.81));
        cardHolders.Add(new cardHolder("19348628", 3671, "Karabo", "Maila", 67.81));
        cardHolders.Add(new cardHolder("13492671", 2468, "Jamal", "Samson", 3667.81));

        Console.WriteLine("Welcome To Martuor Dysiphon Banking Systems:");
        int homeOption = 0;
        do
        {
            homePrintOptions();
            try
            {
                homeOption = int.Parse(Console.ReadLine());
            }
            catch { }
            if (homeOption == 1) 
            {
                cardHolders.Add(new cardHolder("11286312", 1234, "Amelia", "Adams", 1071.20));
                cardHolder

            }
            else if (homeOption == 2) 
            {
                //prompt user Console.WriteLine("");
                Console.WriteLine("Welcome To Martuor Dysiphon Banking Systems:");
                Console.WriteLine("Please Enter your account Number: ");
                string accountNumber = "";
                cardHolder currentUser;

                while (true)
                {
                    try
                    {
                        accountNumber = Console.ReadLine();
                        //database verification
                        currentUser = cardHolders.FirstOrDefault(a => a.cardNo == accountNumber);
                        if (currentUser != null)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Account not reconised. Enter a valid Account Number!");
                        }
                    }

                    catch
                    {
                        Console.WriteLine("Account not reconised. Enter a valid Account Number!");
                    }
                }

                Console.WriteLine("Please Enter your account Pin : ");
                int userPin = 0;
                while (true)
                {
                    try
                    {
                        userPin = int.Parse(Console.ReadLine());
                        //database verification
                        if (currentUser.getPin() == userPin)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Pin. Please Enter a valid Pin!");
                        }
                    }

                    catch
                    {
                        Console.WriteLine("Incorrect Pin. Please Enter a valid Pin!");
                    }
                }

                Console.WriteLine($"Welcome {currentUser.getFirstName()} :) ");
                int option = 0;
                do
                {
                    printOptions();
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch { }
                    if (option == 1) { deposit(currentUser); }
                    else if (option == 2) { withdraw(currentUser); }
                    else if (option == 3) { balance(currentUser); }
                    else { option = 0; }
                }
                while (option != 4);
                Console.WriteLine("Thank you, Have an amazing day :) ");
            }
            else { homeOption = 0; }
        }
        while (homeOption != 4);
        Console.WriteLine("Thank you, Have an amazing day :) ");

        


    }

}