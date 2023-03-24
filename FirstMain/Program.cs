using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class MyNamee
{
    static void Main()
    {
         Console.WriteLine("Please enter your FirstName:");
         string FirstName = Console.ReadLine();

         Console.WriteLine("Please enter your LastName:");
         string LastName = Console.ReadLine();

         string UserName = FirstName + " " + LastName;
         Console.WriteLine("Hello, " + UserName + ", My friend" );
         Console.WriteLine("Hello {0}", UserName);
         C# is case Sensitive
         bool b = True;
         float a = 9;
         float b = 10;

         float ans = a + b;
         float ans1 = a * b;
         float ans2 = a % b;
         float ans3 = a / b;

         Console.WriteLine(ans);

         Console.WriteLine(ans);
         Console.WriteLine(ans1);
         Console.WriteLine(ans2);
         Console.WriteLine(ans3);
         Console.WriteLine(int.MinValue);
         Console.WriteLine(int.MaxValue);

         string Name = "\"Destiny\"";
         Console.WriteLine(Name);

         int Number = 10;
         int AnotherNumber = 20;


         if(Number == 10 && AnotherNumber == 20){
             Console.WriteLine("Nice One");

         }

        int Number1 = 15;


         bool IsNumber10 = Number1 == 10 ? true : false;
        if (Number1 == 10)
          {
              IsNumber10 = true;
          }
          else
          {
              IsNumber10 = false;
          }
         Console.WriteLine("Number == 10 is {0}", IsNumber10);
        


        Console.WriteLine("Are You a Major? ");
        string AreYouMajor = Console.ReadLine();
        AreYouMajor = AreYouMajor.ToUpper;

        if (AreYouMajor == "Yes" || AreYouMajor == "yes" || AreYouMajor == "Y" || AreYouMajor == "y")
        {
            Console.WriteLine("User is Major");
        }

        else if (AreYouMajor == "No" || AreYouMajor == "no" || AreYouMajor == "N" || AreYouMajor == "n")
        {
            Console.WriteLine("User is Major");
        }

        else
        {
            Console.WriteLine("User did not answer the equestion");
        }

        int? TicketOnSale = 100;
        null collating operator
        int AvailableTickets = TicketOnSale ?? 0;





        if (TicketOnSale == null)
        {
            AvailableTickets = 0; ;
        }
        else
        {
            AvailableTickets = (int)TicketOnSale;
        }
        Console.WriteLine("Available Tickets = {0}", AvailableTickets);



        Console.WriteLine("All even from 1 to 20");

        for (int i = 0; i <= 20; i++)
        {
            if(i % 2 == 1)
            {

                Console.WriteLine(i);
            }

        }



        Console.WriteLine("Please enter a number:");
        string a = Console.ReadLine();

        bool num1 = int.TryParse(a, out int numMain1);
        while (num1 == false)
        {
            Console.WriteLine("Please Input an integar");
            a = Console.ReadLine();
            num1 = int.TryParse(a, out numMain1);
        }

        Console.WriteLine("Please enter another number:");
        string b = Console.ReadLine();


        bool num2 = int.TryParse(b, out int numMain2);
        while (num2 == false)
        {
            Console.WriteLine("Please Input an integar");
            b = Console.ReadLine();
            num2 = int.TryParse(b, out  numMain2);
        }


        int ans = numMain1 + numMain2;

        Console.WriteLine(ans);

        DataType conversion
        int i = 100;
        float f = i;

        float f = 4567890098.88f;
        int i = Convert.ToInt32(f);

        Console.WriteLine(i);
        

        //compiler will not do implicit conversion
        //explicit converter

        //diff btwn parse and try pass

        //string StrNumber = "100";
        //int Result = 0;

        //bool IsConversionSuccessful = int.TryParse(StrNumber, out Result);
        //if(IsConversionSuccessful)
        //{
        //    Console.WriteLine(Result);
        //}
        //else
        //{
        //    Console.WriteLine("Please Enter A Valid Number");
        //}
        //int i = int.Parse(StrNumber);

        //value parameter
        //return type is bool
        // reference parameter 
        //output parameter

        //Array

        string input = "Hello World!";
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        string reversed = new string(chars);
        Console.WriteLine(reversed);*/


        int[] EvenNum = new int[15];

        EvenNum[0] = 0;
        EvenNum[1] = 2;
        EvenNum[2] = 4;
        EvenNum[3] = 6;
        EvenNum[4] = 8;
        EvenNum[5] = 10;
        EvenNum[6] = 12;
        EvenNum[7] = 14;

        //array is sticktly types
        //once you initalize the size of an arry, youcannot write beyond that size

        Console.WriteLine(EvenNum[0]);
        Console.WriteLine(EvenNum[1]);
        Console.WriteLine(EvenNum[2]);
        Console.WriteLine(EvenNum[3]);
        Console.WriteLine(EvenNum[4]);
        Console.WriteLine(EvenNum[5]);
        Console.WriteLine(EvenNum[6]);
        Console.WriteLine(EvenNum[7]);
        

        Console.WriteLine("Enter Your Full Name");
        string name = Console.ReadLine();


        Console.WriteLine("Enter Your age");
        string Age = Console.ReadLine();
        

        //bool age = int.TryParse(Age, out aGe)
        
        int age = int.Parse(Age);
        string[] question = new string[100];
        string[] answers = new string[100];
        if (age < 18)
        {
            Console.WriteLine("You are not Of age for this quiz");

        }
        else
        {

            question[0] = "What is the Full Mean Of Y? ";
            question[1]= "What is the Full Mean Of R";
            question[2] = "What is the Full Mean Of M ";
            question[4] = "What is the Full Mean Of I";
            question[5] = "What is the Full Mean Of Y? ";
        }

        int score = 0;
        for(int i = 0; i < 6; i++) 
        {
            Console.WriteLine($"{i+1}. {question[i]}");

        }
        

        /// Summary
        /// to comment the functionalities of a class
        /// 

        Console.WriteLine("Please Enter a Number\n");

        int UserNum = int.Parse(Console.ReadLine());

        if(UserNum >1)
        {
            Console.WriteLine($"Your Number is {UserNum}, which is not 1 One");
        }

        else
        {
            Console.WriteLine("You picked a number one");
        }

        if (UserNum != 1 && UserNum != 2 && UserNum != 3)
        {
            Console.WriteLine("Your Number is not between 1 and 3");

        }
        else
        {
            Console.WriteLine("Your Number is between 1 and 3 ");
        }

        if(UserNum == 10 | UserNum == 20) 
        {
            Console.WriteLine("Your Number is 10 or 20 ");
        }
        else
        {
            Console.WriteLine("Balablue");
        }



        
        if (num == 10)
        {
            Console.WriteLine("Your number is 10");
        }
        else if(num == 20)
        {
            Console.WriteLine("Your number is 20");
        }
        else if( num == 30)
        {
            Console.WriteLine("Your number is 20");
        } 
        else 
        {
            Console.WriteLine("Your number is niether 10, 20 or 30");
        }
        

        Console.WriteLine("Please Enter a number");
        int num = int.Parse(Console.ReadLine());

        switch(num)
        {
            case 10:
                Console.WriteLine("Your number is 10");
                break;
            case 20:
                Console.WriteLine("Your number is 20");
                break;
            case 30:
                Console.WriteLine("Your number is 20");
                break;
            default: Console.WriteLine("Your number is niether 10, 20 or 30");
                break;
        }
        

        switch (num)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your number is {0}", num);
                Console.WriteLine($"Your new number is {num}");
                break;
            default:
                Console.WriteLine("Your number is niether 10, 20 or 30");
                break;
        }


        int TotalCoffeeCost = 0;
        string UserDecide = string.Empty;

        do
        {
            int USerChoice = -1;
            do
            {
                Console.WriteLine(" Please Select Your Cofee Size: 1$ - Small, 2$ - Medium, 3$ - Large");
                USerChoice = int.Parse(Console.ReadLine());



                switch (USerChoice)
                {
                    case 1:
                        TotalCoffeeCost += 1;
                        break;
                    case 2:
                        TotalCoffeeCost += 2;
                        break;
                    case 3:
                        TotalCoffeeCost += 3;
                        break;
                    default:
                        Console.WriteLine($"Your choice {USerChoice} is invalid");
                        break;
                }
            } while (USerChoice != 1 && USerChoice != 2 && USerChoice != 3);

            do
            {
                Console.WriteLine("Do You Want to Buy Another Coffee - Yes or No? ");
                UserDecide = Console.ReadLine().ToUpper();

                if (UserDecide != "YES" && UserDecide != "NO")
                {
                    Console.WriteLine($"Your Choice is invalid {UserDecide} is invalid");
                }
            } while (UserDecide != "YES" && UserDecide != "NO");
        } while (UserDecide.ToUpper() != "NO");

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine($"Total Bill = {TotalCoffeeCost}$");
        

        string UseChoice = "";
        do {
            Console.WriteLine("PLease Enter Your Target Number");
            int Target = int.Parse(Console.ReadLine());

            int start = 0;
            while (start <= Target)
            {
                Console.Write(start + " ");
                start = start + 2;
            }


            do
            {
                Console.WriteLine("\nDo you want to Continue (Yes Or No): ");
                UseChoice = Console.ReadLine().ToUpper();
                if (UseChoice != "YES" && UseChoice != "NO")
                {
                    Console.WriteLine("Invalid Input, Please Say Yes Or No");
                }
            } while (UseChoice != "YES" && UseChoice != "NO");
        } while (UseChoice == "YES");

        int[] Numbers = new int[3];

        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        foreach(int j in Numbers)
        {
            Console.WriteLine(j);
        }

        for (int k = 0; k < Numbers.Length; k++)
        {
            Console.WriteLine(Numbers[k]);
        }

        int i = 0;
        while(i < Numbers.Length)
        {
            Console.WriteLine(Numbers[i]);
            i++;
        }


   }

}


