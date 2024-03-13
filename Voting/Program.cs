using System;
using System.ComponentModel.Design;


class Voting
{
    static void Main(string[] args)
    {
        int inputAge;
        Console.WriteLine("Please write your age");
        inputAge = Convert.ToInt32(Console.ReadLine());

        int inputId;
        Console.WriteLine("Please enter 1 if you have a valid ID and 2 if you don't");
        inputId = Convert.ToInt32(Console.ReadLine());


        if (inputAge >= 18)
        {
            switch (inputId)
            {
                case 1:
                    Console.WriteLine("You are elegible to enter the voting booth");
                    break;
                case 2:
                    Console.WriteLine("You are not elegible to enter the voting booth");
                    break;
                default:
                    Console.WriteLine("Please enter valid information");
                    break;
            }
        }
        else
        {
            if (inputId != 1 && inputId != 2)
            {
                Console.WriteLine("Please enter valid information");
            }
            else
            {
                Console.WriteLine("You are not eligible to enter the voting booth");
            }
        }
    }
    }