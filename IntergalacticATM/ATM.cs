using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticATM
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.Title = "Intergalacitic Space ATM";
            Console.WriteLine("Welcome to the Intergalactic Space ATM!\n" +
                "Please enter your account number:");
            int userAcct = int.Parse(Console.ReadLine());

            bool isCorrectAcct = false;
            bool isCorrectPin = false;
            decimal balance = 0;
            #region logo
            string logo = @"
                                                                     ..;===+.
                                                                  .:=iiiiii=+=
                                                               .=i))=;::+)i=+,
                                                            ,=i);)I)))I):=i=;
                                                         .=i==))))ii)))I:i++
                                                       +)+))iiiiiiii))I=i+:'
                                  .,:;;++++++;:,.       )iii+:::;iii))+i='
                               .:;++=iiiiiiiiii=++;.    =::,,,:::=i));=+'
                             ,;+==ii)))))))))))ii==+;,      ,,,:=i))+=:
                           ,;+=ii))))))IIIIII))))ii===;.    ,,:=i)=i+
                          ;+=ii)))IIIIITIIIIII))))iiii=+,   ,:=));=,
                        ,+=i))IIIIIITTTTTITIIIIII)))I)i=+,,:+i)=i+
                       ,+i))IIIIIITTTTTTTTTTTTI))IIII))i=::i))i='
                      ,=i))IIIIITLLTTTTTTTTTTIITTTTIII)+;+i)+i`
                      =i))IIITTLTLTTTTTTTTTIITTLLTTTII+:i)ii:'
                     +i))IITTTLLLTTTTTTTTTTTTLLLTTTT+:i)))=,
                     =))ITTTTTTTTTTTLTTTTTTLLLLLLTi:=)IIiii;
                    .i)IIITTTTTTTTLTTTITLLLLLLLT);=)I)))))i;
                    :))IIITTTTTLTTTTTTLLHLLLLL);=)II)IIIIi=:
                    :i)IIITTTTTTTTTLLLHLLHLL)+=)II)ITTTI)i=
                    .i)IIITTTTITTLLLHHLLLL);=)II)ITTTTII)i+
                    =i)IIIIIITTLLLLLLHLL=:i)II)TTTTTTIII)i'
                  +i)i)))IITTLLLLLLLLT=:i)II)TTTTLTTIII)i;
                +ii)i:)IITTLLTLLLLT=;+i)I)ITTTTLTTTII))i;
               =;)i=:,=)ITTTTLTTI=:i))I)TTTLLLTTTTTII)i;
             +i)ii::,  +)IIITI+:+i)I))TTTTLLTTTTTII))=,
           :=;)i=:,,    ,i++::i))I)ITTTTTTTTTTIIII)=+'
         .+ii)i=::,,   ,,::=i)))iIITTTTTTTTIIIII)=+
        ,==)ii=;:,,,,:::=ii)i)iIIIITIIITIIII))i+:'
       +=:))i==;:::;=iii)+)=  `:i)))IIIII)ii+'
     .+=:))iiiiiiii)))+ii;
    .+=;))iiiiii)));ii+
   .+=i:)))))))=+ii+
  .;==i+::::=)i=;
  ,+==iiiiii+,
  `+=+++;

Intergalactic Space Banks
Serving Our Customers to Infinity and Beyond

";
            #endregion


            int userPIN;


            while (isCorrectAcct == false)
            {

                if (userAcct == 00000)
                {
                    isCorrectAcct = true;
                    Console.Clear();
                    Console.Write("Enter PIN: ");


                    continue;
                }//end if



                Console.Clear();
                Console.WriteLine("That account is not registered in our system. Please try again.\nPlease enter your account number:");
                userAcct = int.Parse(Console.ReadLine());


            } //end while

            userPIN = int.Parse(Console.ReadLine());

            while (isCorrectPin == false)
            {
                if (userPIN == 1234)
                {
                    isCorrectPin = true;
                    Console.Clear();


                    continue;
                }//end if

                Console.Clear();
                Console.Write("Sorry, that is not correct. Please try again.\nEnter PIN: ");
                userPIN = int.Parse(Console.ReadLine());
            }//end while

            bool exitMenu = false;


            do
            {


                Console.WriteLine("Welcome, valued customer! How may we help you today?\n" +
                            "1. Make a Deposit\n" +
                            "2. Make a Withdrawal\n" +
                            "3. View Account Balance\n" +
                            "4. Exit");
                ConsoleKey userChoice = Console.ReadKey().Key;



                switch (userChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Console.Write("How much would you like to deposit?\n$");
                        decimal userDeposit = decimal.Parse(Console.ReadLine());
                        balance += userDeposit;
                        Console.Clear();
                        Console.WriteLine($"Thank you.\n" +
                            $"You have deposited {userDeposit:c} into account number 00000.\n" +
                            $"Your new balance is {balance:c}\n\n" +
                            $"Would you like to:\n" +
                            $"1. Make another deposit/withdrawal\n" +
                            $"2. Exit ATM ");

                        ConsoleKey anotherDeposit = Console.ReadKey().Key;

                        switch (anotherDeposit)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                Console.WriteLine("You are now exiting the ATM. Are you sure? Y/N: ");
                                ConsoleKey exitATMWithdrawal = Console.ReadKey().Key;
                                switch (exitATMWithdrawal)
                                {
                                    case ConsoleKey.Y:
                                        Console.Clear();
                                        Console.WriteLine("Thank you for using Intergalactic Space Banks!\n" +
                                            "We look forward to doing business with you again.\n\n" +
                                            "{0}", logo);
                                        exitMenu = true;
                                        break;

                                    case ConsoleKey.N:
                                        Console.Clear();
                                        break;
                                }
                                break;

                        }

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.Write($"Your current balance is {balance:c}\nHow much would you like to withdraw?\n$");
                        decimal userWithdraw = decimal.Parse(Console.ReadLine());
                        if (userWithdraw < balance)
                        {
                            Console.Clear();
                            balance -= userWithdraw;
                            Console.Clear();
                            Console.Write($"Thank you.\nYou have withdrawn {userWithdraw:c} from account number 00000.\n" +
                                $"Your new balance is {balance:c}\n\n" +
                                $"Would you like to:\n" +
                                $"1. Make another deposit/withdrawal\n" +
                                $"2. Exit ATM ");

                            ConsoleKey anotherWithdrawal = Console.ReadKey().Key;

                            switch (anotherWithdrawal)
                            {
                                case ConsoleKey.D1:
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    break;

                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    Console.WriteLine("You are now exiting the ATM. Are you sure? Y/N: ");
                                    ConsoleKey exitATMWithdrawal = Console.ReadKey().Key;
                                    switch (exitATMWithdrawal)
                                    {
                                        case ConsoleKey.Y:
                                            Console.Clear();
                                            Console.WriteLine("Thank you for using Intergalactic Space Banks!\n" +
                                                "We look forward to doing business with you again.\n\n" +
                                                "{0}", logo);
                                            exitMenu = true;
                                            break;

                                        case ConsoleKey.N:
                                            Console.Clear();
                                            break;
                                    }
                                    break;

                            }
                        }//end if
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"I'm sorry, you don't have enough to withdraw. Please try again.\nYour current balance is {balance:c}");
                            Console.Write($"Would you like to:\n" +
                                $"1. Make another deposit/withdrawal\n" +
                                $"2. Exit ATM ");

                            ConsoleKey anotherWithdrawal = Console.ReadKey().Key;

                            switch (anotherWithdrawal)
                            {
                                case ConsoleKey.D1:
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    break;

                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    Console.WriteLine("You are now exiting the ATM. Are you sure? Y/N: ");
                                    ConsoleKey exitATMWithdrawal = Console.ReadKey().Key;
                                    switch (exitATMWithdrawal)
                                    {
                                        case ConsoleKey.Y:
                                            Console.Clear();
                                            Console.WriteLine("Thank you for using Intergalactic Space Banks!\n" +
                                                "We look forward to doing business with you again.\n\n" +
                                                "{0}", logo);
                                            exitMenu = true;
                                            break;

                                        case ConsoleKey.N:
                                            Console.Clear();
                                            break;
                                    }
                                    break;

                            }

                        }//end else


                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.WriteLine($"Your current account balance is: {balance:c}.\n\n" +
                            $"Would you like to:\n" +
                            $"1. Make another deposit/withdrawal\n" +
                            $"2. Exit ATM ");

                        ConsoleKey anotherTrans = Console.ReadKey().Key;

                        switch (anotherTrans)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                Console.WriteLine("You are now exiting the ATM. Are you sure? Y/N: ");
                                ConsoleKey exitATMWithdrawal = Console.ReadKey().Key;
                                switch (exitATMWithdrawal)
                                {
                                    case ConsoleKey.Y:
                                        Console.Clear();
                                        Console.WriteLine("Thank you for using Intergalactic Space Banks!\n" +
                                            "We look forward to doing business with you again.\n\n" +
                                            "{0}", logo);
                                        exitMenu = true;
                                        break;

                                    case ConsoleKey.N:
                                        Console.Clear();
                                        break;
                                }
                                break;

                        }

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        Console.WriteLine("You are now exiting the ATM. Are you sure? Y/N: ");
                        ConsoleKey exitATM = Console.ReadKey().Key;

                        switch (exitATM)
                        {
                            case ConsoleKey.Y:
                                Console.Clear();
                                Console.WriteLine("Thank you for using Intergalactic Space Banks!\n" +
                                            "We look forward to doing business with you again.\n\n" +
                                            "{0}", logo);
                                exitMenu = true;
                                break;

                            case ConsoleKey.N:
                                Console.Clear();
                                break;
                        }//end switch
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("That was not a valid option. Try again.");
                        break;
                }//end switch

            } while (exitMenu != true);







        }//end Main
    }
}
