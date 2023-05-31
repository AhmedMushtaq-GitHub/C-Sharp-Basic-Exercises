/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Oop
    {
        int val1 = 234;
        int val2 = 432;
        int result;
        void add()
        {
            result = val1 + val2;
            Console.WriteLine(result);
        }
        void subtrac()
        {
            result = val1 - val2;
            Console.WriteLine(result);
        }
        public static void Main()
        {
            Oop obj = new Oop();
            {
             
                obj.add();
                obj.subtrac();
            }
        }


    }
}
*/

/*Console.WriteLine(324+432);
Console.WriteLine(324-432);
Console.WriteLine(324/432);
Console.WriteLine(324*432);
Console.WriteLine(324%432);
*/

/*Console.WriteLine(324 + 432+654*54/754);
Console.WriteLine(324 - 432+654-654*564/7654*76/(754*43/6*37-54)/754+64*654/7-54+6457*-54/7*554);
Console.WriteLine(324 / 432787%78+789%798);
Console.WriteLine(324 * 432765+(765*4-7));
Console.WriteLine(324 % 432/756*7567-754-765);*/

/*int input1, input2, temp;
Console.WriteLine("input the 1st number");
input1 =int.Parse(Console.ReadLine());
Console.WriteLine("input the 2nd number");
input2 = int.Parse(Console.ReadLine());

temp = input1;
input1 = input2;
input2 = temp;

Console.WriteLine("After swaping");
Console.WriteLine("your input 2 is here insted input 1 : >>" + input1);
Console.WriteLine("your input 1 is here insted input 2 : >>" + input2);*/

/*int a, b, c, result;
Console.WriteLine("enter 1 number to multiply");
a=int.Parse(Console.ReadLine());
Console.WriteLine("enter 2 number to multiply");
b=int.Parse(Console.ReadLine());
Console.WriteLine("enter c number to multiply");
c=int.Parse(Console.ReadLine());

result= a*b*c;
Console.WriteLine($"{a} * {b} * {c} = { result}");
Console.ReadLine();*/


/*int num1, num2;
Console.WriteLine("Enter num 1");
num1 =Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Enter num 2");
num2 =Convert.ToInt32( Console.ReadLine());

Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
Console.ReadLine();*/

//Write a Table

/*int input;
Console.WriteLine("Enter a number to Write a table");
input =Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{input} * {i} = {input * i} ");
}*/


//Write a C# Sharp program that takes four numbers as input to calculate and print the average.

/*Console.WriteLine("Enter values to known his average");
Console.Write("1 value : ");
int val1 =Convert.ToInt32 (Console.ReadLine());
Console.Write("2 value : ");
int val2 = Convert.ToInt32(Console.ReadLine());
Console.Write("3 value : ");
int val3 = Convert.ToInt32(Console.ReadLine());
Console.Write("4 value : ");
int val4 = Convert.ToInt32(Console.ReadLine());
Console.Write("5 value : ");

int result = (val1 + val2 + val3 + val4) / 4;

Console.WriteLine(result);
*/

//Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
/*int age;
Console.WriteLine("Enter your age");
age =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Yor are looking older than " + age);*/

//Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.

/*int input;
Console.Write("Enter a number : ");
input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("{0}{0}{0}{0}",input);
Console.WriteLine("{0} {0} {0} {0}",input);
Console.WriteLine("{0}{0}{0}{0}",input);
Console.WriteLine("{0} {0} {0} {0}",input);*/

//Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.

/*
int input;
Console.WriteLine("Enter a number");
input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0}{0}{0} ",input);
Console.WriteLine("{0} {0} ",input);
Console.WriteLine("{0} {0} ",input);
Console.WriteLine("{0} {0} ",input);
Console.WriteLine("{0}{0}{0} ",input);
*/

/*string input;
Console.WriteLine("Enter a String");
input = Console.ReadLine()??"";
Console.WriteLine("kitny number wala remoive krna");
int num =Convert.ToInt32( Console.ReadLine());

static string remove_char(string str, int n)
{
    return str.Remove(n, 1);
    Console.WriteLine();
}*/

/*Console.WriteLine("Enetr a line ");
string str = Console.ReadLine()??"";
if (str.Length >= 1)
{
    var s = str.Substring(0, 1);
    Console.WriteLine(s + str + s);
}*/

int a, b;
Console.WriteLine("Enter FISRT VALUE");
a =int.Parse( Console.ReadLine());
Console.WriteLine("Enter FISRT VALUE");
b =int.Parse( Console.ReadLine());

Console.WriteLine((a < 0 && b > 0) || (a < 0 && b > 0));