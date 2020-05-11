using System;
using System.Transactions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                double num1, num2, result;

                String question;
                Console.WriteLine(" Do you want to perform a calculation, enter yes or no");


                question = Console.ReadLine();

                for (int i = 0; i < 100; i++)
                {


                    if (String.Compare(question, "yes") == 0)
                    {



                        Console.WriteLine("Enter first number:= ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Second number:= ");
                        num2 = double.Parse(Console.ReadLine());


                        String operators;
                        Console.WriteLine("Select and type operator from the following: + or - or * or /");
                        operators = Console.ReadLine();


                        switch (operators)
                        {
                            case "+":

                                result = num1 + num2;
                                Console.WriteLine("number1 + number2 = " + result);
                                break;
                            case "-":
                                result = num1 - num2;
                                Console.WriteLine("number1 - number2 = " + result);
                                break;

                            case "*":

                                result = num1 * num2;
                                Console.WriteLine("Number1 * Number2 = " + result);
                                break;
                            case "/":
                                result = num1 / num2;
                                Console.WriteLine("Number1 / Number2 = " + result);
                                break;

                            default:
                                Console.WriteLine("You have entered incorrect operator");
                                break;


                        }

                    }

                    else
                    {
                        Console.WriteLine("Press enter twice to exit the program");
                        break;
                    }

                    Console.WriteLine("Do you want to perform another calculation, enter yes or no");

                    question = Console.ReadLine();

                }
            }
            

            
            catch (FormatException ex)
            {
               
                
                Console.WriteLine(" Not a Valid number. Please try again");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot Divide by zero. Please try again");
            }

            Console.ReadLine();
            }

        }
    }
