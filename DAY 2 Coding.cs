callbyvalueandreferences
----------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace callbyvalueandreferences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //global section
        class swapdemo
        {
            public void swapexample1(int x, int y)
            {
                int temp;
                temp = x;
                x= y;
                y= temp;
            }

            public void swapexample2(ref int x,ref int y)
            {
                int temp;
                temp = x;
                x = y;
                y = temp;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 10;
            b = 20;
            MessageBox.Show("Before swapping ...");
            MessageBox.Show("A=" + a + "\nB=" + b);
            swapdemo obj = new swapdemo();
            obj.swapexample1(a, b);
            MessageBox.Show("After swapping ...");
            MessageBox.Show("A=" + a + "\nB=" + b);
         
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 10;
            b = 20;
            MessageBox.Show("Before swapping ...");
            MessageBox.Show("A=" + a + "\nB=" + b);
            swapdemo obj = new swapdemo();
            obj.swapexample2(ref a, ref b);
            MessageBox.Show("After swapping ...");
            MessageBox.Show("A=" + a + "\nB=" + b);
        }
    }
}

        
boxing and unboxing demo
------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingandUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //value type is going inside ref type then it is called boxing 
            //while displaying ref type which is storing value type it is called 
            //unboxing 
            // now this process of boxing and unboxing should happen for same type of
            // data types compatibity should match 
            // means int x=45 i cannot put it in string eventhough string is reference type 

            object objone;
            int numberone;
            numberone = 77;
            objone = numberone;//boxing

            Console.WriteLine($"objectone is {objone}");// internally it will unbox means while displaying
                                                        // object will unwrap the data and display which is unboxin we call it as unboxing 

            // doing it with string data type 
            // Boxing: Converting a string value to an object type
            string originalString = "Hello, Boxing and Unboxing!";
            object boxedString = originalString;

            Console.WriteLine($"Boxed string:  {boxedString}");//unboxing

            // here i didnt faced the problem of typecasting above  becasue it is going into base 
            //data type object 
            // below is also doing unboxing but i am going from larger house to smaller house so typecastng
            // needed 
            int unboxint =(int) objone;// unboxing only but using typecasting
            string unboxedString = (string)boxedString;


            Console.WriteLine($"{unboxint}-- {unboxedString}");

            Console.ReadLine();

        }
    }
}

string demo
-------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInBuiltFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //String s1;
            //string s2;
            // here if i say s1. same methods i will se what i will see in s2. 
            // also if i say String. or string. same methods are there so both are same only 
            // dont get confuse ...so strings are referecne type only ...

            // how string we will learn later now let us see just some in built functions of 
            // string ..
            // one slide is stringlist there all methods and properties of strings are there 
            // which i will implent now 
            string str = "Hello World";
            string str2 = "Hello";
            string str3 = "world";
            //properties and fields

            string sample = "";
            string sample2=string.Empty;// like this also i can use 

            //chars proeprty means index prerties in each string or any string i want to 
            // know in this position which character is there then i will use chars means 
            // i will not write chars using [] this thing is chars only 
            Console.WriteLine($"chars means : 6th chacatr in str:{str[6]}--first character in str2:{str2[0]}");
            Console.WriteLine($"Length :{str.Length}");
            
              // Modifying
          Console.WriteLine("\nModifying:");
          Console.WriteLine($"Insert: {str.Insert(6,"Beautiful ")}");
          Console.WriteLine($"Remove: {str.Remove(7,4)}");
          Console.WriteLine($"Replace: {str.Replace("World", "C#")}");
          Console.WriteLine($"Trim: '{str.Trim()}'");
          Console.WriteLine($"TrimStart: '{str.TrimStart()}'");
          Console.WriteLine($"TrimEnd: '{str.TrimEnd()}'");
          Console.WriteLine($"PadLeft: '{str2.PadLeft(15, '*')}'");
          Console.WriteLine($"PadRight: '{str2.PadRight(10, '-')}'");
          Console.WriteLine($"ToUpper: {str3.ToUpper()}");
          Console.WriteLine($"ToLower: {str2.ToLower()}");

                       // extracting 
           Console.WriteLine("\n Extracting ...");
           string name = "Raghavendra";
           string name2 = "raghavendra kumar singh";

           Console.WriteLine($"Subsstring :{name.Substring(0,6)}");
           Console.WriteLine($"split :{string.Join(",", name2.Split(' '))}");
           Console.WriteLine($"Fullname : {string.Join("-", "ravi", "kumar")}");

                      /*.369

           // Searching
           Console.WriteLine("\nSearching:");
           string samplename = "Kiran Hello!";
           Console.WriteLine($"StartsWith 'K': {samplename.StartsWith("K")}");
           Console.WriteLine($"EndsWith '!': {samplename.EndsWith("!")}");
           Console.WriteLine($"IndexOf 'Hello': {samplename.IndexOf("Hello")}");
           Console.WriteLine($"Contains 'ran': {samplename.Contains("ran")}");

                        // comparing 

            Console.WriteLine("\n Comparing");
            string ss1 = "daghu";
            string ss2 = "raghu";

            string kk = "solve";
            string kk2 = "solve";
            Console.WriteLine($"compare :{string.Compare(ss1, ss2)}");   //<0 means ss1 is smaller than ss2 
            Console.WriteLine($"compare :{string.Compare(ss2, ss1)}");// > 0 means ss2 is largrr comes after ss1 
            Console.WriteLine($"compare :{ss1.CompareTo(ss2)}");   //<0 means ss1 is smaller than ss2 

            Console.WriteLine($"Equals :{kk2.Equals(kk)}");//checks the content inside string 

            Console.ReadLine();
            
        }
    }
}


Nullable types 
---------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //What are Nullable Types?
            //In C#, value types (like int, double, bool, etc.) cannot be
            //null by default. However, you can use Nullable<T> or the shorthand T?
            //to allow value types to store null

            //  int number = null;// not allowing ..as it is not possible 

            // Nullable integer
            int? number = null;

            // Nullable boolean
            bool? isAvailable = null;

            // Nullable double
            double? price = 99.99;// here i can put null also and also number optional

            // Checking if value exists
            if (number.HasValue)
            {
                Console.WriteLine("Number: " + number.Value);
            }
            else
            {
                Console.WriteLine("Number is null.");
            }

            Console.WriteLine("Another way of declaring nullable types ..");
            // Using Nullable<T>
            Nullable<int> number1 = null;

            // Alternative shorthand syntax (equivalent to Nullable<int>)
            int? anotherNumber = 20;

            // Checking if value exists
            if (number1.HasValue)
            {
                Console.WriteLine("Number: " + number1.Value);
            }
            else
            {
                Console.WriteLine("Number1 is null.");
            }

            Console.WriteLine("Another Number: " + anotherNumber);

            // Using GetValueOrDefault()
            Console.WriteLine($"Number (default 100 if null):  {number1.GetValueOrDefault(100)}");
            Console.ReadLine();

        }
    }
}


ifdemos
----------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifdemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // finding largest among 4 numbers using simple if 

            int a, b, c, d, l;

            Console.WriteLine("enter values in a,b,c,d");
            a=Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            l = a;
            if(b >l)
            {
                l = b;

            }
            if(c > l)
            {
                l = c;
            }
            if( d > l)
            {
                l = d;
            }
            Console.WriteLine($"The laregst is {l}");
            Console.ReadLine();
               
        }
    }
}


now i will refactor the code so select all things from main including comments but before console.Readline() only  say right clcik and there  quick actions and refactoring 
and then side by extact method select that one text box will come then give some name to funcion and press enter 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifdemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            simpleif();
            Console.ReadLine();

        }

        private static void simpleif()
        {
            // finding largest among 4 numbers using simple if 

            int a, b, c, d, l;

            Console.WriteLine("enter values in a,b,c,d");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            l = a;
            if (b > l)
            {
                l = b;

            }
            if (c > l)
            {
                l = c;
            }
            if (d > l)
            {
                l = d;
            }
            Console.WriteLine($"The laregst is {l}");
        }
    }
}

else if ladder demo with refactoring 
--------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifdemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // simpleif();

            elseifladder();

            Console.ReadLine();

        }

        private static void elseifladder()
        {
            int a, b, c, d;

            Console.WriteLine("enter values in a,b,c,d");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            // finding largest using ele if ladder 
            if (a > b && a > c && a > d)
                Console.WriteLine("{0} is larger...", a);
            else if (b > c && b > d)
                Console.WriteLine("{0} is larger...", b);
            else if (c > d)
                Console.WriteLine("{0} is larger...", c);
            else
                Console.WriteLine("{0} is larger....", d);
        }

        private static void simpleif()
        {
            // finding largest among 4 numbers using simple if 

            int a, b, c, d, l;

            Console.WriteLine("enter values in a,b,c,d");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            l = a;
            if (b > l)
            {
                l = b;

            }
            if (c > l)
            {
                l = c;
            }
            if (d > l)
            {
                l = d;
            }
            Console.WriteLine($"The laregst is {l}");
        }
    }
}

quardrant demo
---------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifdemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // simpleif();

            //elseifladder();

            quardrantmethod();

            Console.ReadLine();

        }

        private static void quardrantmethod()
        {
            int x, y;
            Console.WriteLine("Enter x,y co ordinates of the point");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\nThe point ({x},{y}) lies in : ");
            if (x == 0)
                if (y == 0)
                    Console.WriteLine("on origin");
                else
                    Console.WriteLine("On Y axis ");
            else
                if (y == 0)
                Console.WriteLine("On X axis");
            else
                   if (x > 0)
                if (y > 0)
                    Console.WriteLine("in the first quadrant");
                else
                    Console.WriteLine("in the fourth quadrant");
            else
                      if (y > 0)
                Console.WriteLine("in the second quadrant");
            else
                Console.WriteLine("in the third quadrant");
        }

        private static void elseifladder()
        {
            int a, b, c, d;

            Console.WriteLine("enter values in a,b,c,d");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            // finding largest using ele if ladder 
            if (a > b && a > c && a > d)
                Console.WriteLine("{0} is larger...", a);
            else if (b > c && b > d)
                Console.WriteLine("{0} is larger...", b);
            else if (c > d)
                Console.WriteLine("{0} is larger...", c);
            else
                Console.WriteLine("{0} is larger....", d);
        }

        private static void simpleif()
        {
            // finding largest among 4 numbers using simple if 

            int a, b, c, d, l;

            Console.WriteLine("enter values in a,b,c,d");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            l = a;
            if (b > l)
            {
                l = b;

            }
            if (c > l)
            {
                l = c;
            }
            if (d > l)
            {
                l = d;
            }
            Console.WriteLine($"The laregst is {l}");
        }
    }
}


open new proejct console
-------------------------
earlier code
----------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, choice;
            Console.Clear();
            Console.WriteLine("enter values in a and b...");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.addition....");
            Console.WriteLine("2.substraction...");
            Console.WriteLine("3.Multiplication....");
            Console.WriteLine("4.Division...");
            Console.WriteLine("enter your choice....");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine($"The sum is {c}");
                    break;
                case 2:
                    c = (a > b) ? (a - b) : (b - a);
                    Console.WriteLine($"The subtraction is {c}");
                    break;
                case 3:
                    c = a * b;
                    Console.WriteLine($"The prodcut is {c}");
                    break;
                case 4:
                    c = a / b;
                    Console.WriteLine($"The division is {c}");
                    break;
                default:
                    Console.WriteLine("enter values in between 1 and 4 only");
                    break;
            }
            Console.ReadLine();
        }
    }
}


with the chars and multiple options in switch 
-----------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, choice;
            char ch;
            Console.Clear();
            Console.WriteLine("enter values in a and b...");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("A.addition....");
            Console.WriteLine("B.substraction...");
            Console.WriteLine("C.Multiplication....");
            Console.WriteLine("D.Division...");
            Console.WriteLine("enter your choice....");
         //   choice = Convert.ToInt32(Console.ReadLine());
             ch=Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'A':
                case 'a': c = a + b;
                     Console.WriteLine($"The sum is {c}");
                        break;
                case 'B': c =(a>b)?(a - b):(b-a);
                        Console.WriteLine($"The subtraction is {c}");
                        break;
                case 'C':c = a * b;
                       Console.WriteLine($"The prodcut is {c}");
                        break;
                case 'D':c = a/b;
                       Console.WriteLine($"The division is {c}");
                       break;
                default:Console.WriteLine("enter values in between 1 and 4 only");
                    break;
            }
            Console.ReadLine();
        }
    }
}

loops demo 
-----------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // whileloop();
            //  dowhileloop();
            // dowhileloop2();

            //  denomination();

            forloopsdemos();

            Console.ReadLine();


        }

        private static void forloopsdemos()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine("\n\nFinding factorial using for loop of a number...");
            float f = 1.0F;
            int number;
            int counter; ;
            Console.WriteLine("\nenter the number to find facorial");
            number = Convert.ToInt32(Console.ReadLine());
            for (counter = 1; counter <= number; counter++)
            {
                f = f * counter;
            }
            Console.WriteLine($"The factorial of {number} is {f}");
        }

        private static void denomination()
        {
            int sum = 0;
            int x = 1;
            int y = 5;
            int z = 10;
            int noofnotes = 0;
            while (sum < 480)
            {
                sum = x + y + z;
                noofnotes = noofnotes + 1;
                x = x + 1;
                y = y + 5;
                z = z + 10;

            }
            Console.WriteLine($"The no of notes : {noofnotes} and total notes {noofnotes * 3}");
        }

        private static void dowhileloop2()
        {
            int counter = 1;
            Console.WriteLine("\n start the counter using do while loop");
            //   int keepgoing = 1;
            do
            {
                Console.Write($"{counter}  ");

                if (counter % 100 == 0 && counter != 0)
                {
                    Console.WriteLine("\n Do you want to continue <y/n>?");
                    if (Console.ReadLine() != "y")
                    {
                        // keepgoing = 0;
                        break;
                    }
                }
                counter++;


            } while (true);
        }

        private static void dowhileloop()
        {
            int counter = 1;// here if i give 120 means condition then also one 
            // time do while will execute which will not happen in while loop
            do
            {
                Console.Write($"{counter}  ");
                counter++;

            } while (counter <= 100);
        }

        private static void  whileloop()
        {
            int counter = 1;

            while (counter <= 100)
            {
                Console.Write($"{counter}  ");
              counter = counter + 1;// if u comment this code ininfite loop
            }
        }
    }
}


using switch in do while loop to make it menu driven 

------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, choice;
            char ch;
            Console.Clear();
            Console.WriteLine("enter values in a and b...");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("A.addition....");
                Console.WriteLine("B.substraction...");
                Console.WriteLine("C.Multiplication....");
                Console.WriteLine("D.Division...");
                Console.WriteLine("enter your choice....");
                //   choice = Convert.ToInt32(Console.ReadLine());
                ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case 'A':
                    case 'a':
                        c = a + b;
                        Console.WriteLine($"The sum is {c}");
                        break;
                    case 'B':
                        c = (a > b) ? (a - b) : (b - a);
                        Console.WriteLine($"The subtraction is {c}");
                        break;
                    case 'C':
                        c = a * b;
                        Console.WriteLine($"The prodcut is {c}");
                        break;
                    case 'D':
                        c = a / b;
                        Console.WriteLine($"The division is {c}");
                        break;
                    default:
                        Console.WriteLine("enter values in between 1 and 4 only");
                        break;
                }
                Console.WriteLine("Do you want to continue<y/n>?");
                if(Console.ReadLine()!="y")
                {
                    break;
                }

            } while (true);
            
           
            Console.ReadLine();
        }
    }
}


jump stateemnts demo 
---------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumpstatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //withing in the program u want to jump from one section to another section 
            // then go to is used u have to use label: 
            int num;
          L1: Console.WriteLine("\n enter value for num ..");
            num = Convert.ToInt16((Console.ReadLine()));
            if (num == 1)
            {
                goto test1;
            }
            else
            {
                goto L1;
            }
        test1: Console.WriteLine("Its all done..");

         //   breakandcontnuebothdemo();
            //  continuedemo();
           
            Console.ReadLine();
        }

        private static void breakandcontnuebothdemo()
        {
            // i want to take values from you means numbers when u give 
            // negative number i will by passs or froget that value and finally 
            // i shoudl print sum of only psoitive values 

            int sum = 0;
            int num;
            do
            {
                Console.WriteLine("Enter the number ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    continue;
                }
                else
                {
                    sum = sum + num;
                }
                if (num == 0)
                {
                    break;
                }

            } while (true);
            Console.WriteLine($"The sum of only psositive num:{sum}");
        }

        private static void continuedemo()
        {
            // program on continue keyword
            int counter = 0;
            while (counter <= 10)
            {

                counter++;
                if (counter == 5)
                {
                    continue;
                }
                Console.WriteLine($"{counter}");
            }
        }
    }
}


lab question 
-------------
using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number:");
        int num1;
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        int num2;
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Perform arithmetic operations
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        double quotient = 0;
        bool divisionByZero = false;

        if (num2 != 0)
        {
            quotient = (double)num1 / num2;
        }
        else
        {
            divisionByZero = true;
        }

        // Print the results
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The difference is: " + difference);
        Console.WriteLine("The product is: " + product);

        if (!divisionByZero)
        {
            Console.WriteLine("The quotient is: " + quotient);
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
    }
}
