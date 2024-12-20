namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("please enter that number can be divided by 3 and 4 otherwise print no.");
            //int.TryParse(Console.ReadLine(), out int num);
            //if (num % 3 == 0 || num % 4 ==0)
            //{
            //    Console.WriteLine($"input : {num}");
            //    Console.WriteLine("output : yes");
            //}
            //else
            //{
            //    Console.WriteLine($"input : {num}");
            //    Console.WriteLine("output : No");
            //}

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("please enter integer then print negative if it is negative number otherwise print positive.");
            //int.TryParse(Console.ReadLine() , out int num);
            //if (num > 0)
            //    Console.WriteLine($"the number {num} is positive ");
            //else if (num < 0)
            //    Console.WriteLine($"the number {num} is negative");
            //else if (num == 0)
            //    Console.WriteLine($"the number is {num}");



            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("please enter number 1 : ");
            //int.TryParse(Console.ReadLine() , out int num1);
            //Console.WriteLine("please enter number 2 : ");
            //int.TryParse(Console.ReadLine(), out int num2);
            //Console.WriteLine("please enter number 3 : ");
            //int.TryParse(Console.ReadLine(), out int num3);
            //if (num1 > num2 && num1 > num3)
            //{
            //    if (num2 > num3)
            //    {
            //        Console.WriteLine($"Max elemant = {num1}");
            //        Console.WriteLine($"Min elemant = {num3}");
            //    }
            //    else if (num3 > num2)
            //    {
            //        Console.WriteLine($"Max elemant = {num1}");
            //        Console.WriteLine($"Min elemant = {num2}");
            //    }
            //}

            //else if (num2 > num1 && num2 > num3)
            //{
            //    if(num1 > num3)
            //    {
            //        Console.WriteLine($"Max elemant = {num2}");
            //        Console.WriteLine($"Min elemant = {num3}");
            //    }
            //    else if (num3 > num1)
            //    {
            //        Console.WriteLine($"Max elemant = {num2}");
            //        Console.WriteLine($"Min elemant = {num1}");
            //    }
            //}
            //else if (num3 > num1 && num3 > num2)
            //{
            //    if (num1 > num2)
            //    {
            //        Console.WriteLine($"Max elemant = {num3}");
            //        Console.WriteLine($"Min elemant = {num2}");
            //    }
            //    else if (num2 > num1)
            //    {
            //        Console.WriteLine($"Max elemant = {num3}");
            //        Console.WriteLine($"Min elemant = {num1}");
            //    }
            //}

            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("please enter number  : ");
            //int.TryParse(Console.ReadLine() , out int num);
            //if (num % 2 == 0)
            //    Console.WriteLine($"the number {num} is even ");
            //else
            //    Console.WriteLine($"the number {num} is odd ");

            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("please enter small char : ");
            //char ch = Convert.ToChar(Console.Read());
            //switch (ch)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine($"the char ({ch}) is ==> Vowel ");
            //        break;
            //    default:
            //        Console.WriteLine($"the char ({ch}) is ==> Consonant ");
            //        break;


            //}

            #endregion

            #region 6- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("please enter number integer then print a multiplication table up to 12.");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine($"input : {num}");
            //Console.Write($"output : ");
            //for (int i = 1; i <= 12; i++)
            //    Console.Write($"{num * i} ");

            #endregion

            #region 7- Write a program that allows to user to insert number then print all even numbers between 1 to this number.
            //Console.WriteLine("please enter number then print all even numbers between 1 to this number.");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine($"input : {num}");
            //Console.Write($"output : ");
            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.Write($"{i} ");
            //}

            #endregion

            #region 8- Write a program that takes two integers then prints the power.
            //Console.WriteLine("please enter two integers then prints the power.");
            //int.TryParse(Console.ReadLine(), out int num1);
            //int.TryParse(Console.ReadLine(), out int num2);
            //Console.WriteLine($"input : {num1} {num2}");
            //int result = 1;
            //for (int i = 1; i <= num2; i++)
            //{
            //    result *= num1;
            //};
            //Console.Write($"output : {result}");

            #endregion

            #region 9- Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("please enter month number");
            //int.TryParse(Console.ReadLine(), out int number_of_month);
            //switch (number_of_month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Days in Month: 31");
            //        break;
            //    case 2:
            //        Console.WriteLine("Days in Month: 28 or 29");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Days in Month: 30");
            //        break;
            //    default:
            //        Console.WriteLine("invuled month");
            //        break;
            //}

            #endregion

            #region 10- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            //// -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //// - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //// - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //// - If the worker takes more than 5 hours, they are required to leave the company.
            ////To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            //Console.WriteLine("please enter the time taken for the task is obtained via user : ");
            //double time_taken = Convert . ToDouble(Console.ReadLine());
            //if (time_taken >= 3 && time_taken <= 4)
            //    Console.WriteLine("they are instructed to increase their speed.");
            //else if (time_taken > 4 && time_taken <= 5)
            //    Console.WriteLine("they are provided with training to enhance their speed.");
            //else if (time_taken > 5)
            //    Console.WriteLine(" they are required to leave the company.");

            #endregion
        }
    }
}
