dotnet new console -o MyConsoleApp --use-program-main

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printdemo
{
     class Program
    {
        static void Main(string[] args)
        {

            int x, y, z;
            Console.WriteLine("enter values in x and y ...");
            x = Convert.ToInt32(Console.ReadLine());
            y=int.Parse(Console.ReadLine());
            z = x + y;
            Console.WriteLine("The sum of {0} and {1} is {2}", x, y, z);
            Console.WriteLine("The sum of {0,7} and {1,8} is {2,7}", x, y, z);
            Console.WriteLine("The sum of "+ x+", "+y+", "+z);
            Console.WriteLine($"The sum of {x}  and {y} and {z}");

            // print constants 
            Console.WriteLine("{0}", 34.56);
            Console.WriteLine("Febuary has {0} or {1}", 28, 29);
          
            //taking values in a single line 
            Console.WriteLine("enter values in single line comm seeprated ");
            string input = Console.ReadLine();
            int m, n;
            m = Convert.ToInt32(input.Split(',')[0]);
            n = Convert.ToInt32(input.Split(',')[1]);
            Console.WriteLine($"The sum of {m} and {n} is {m + n}");
            Console.WriteLine("enter values in single line and chooose your delimiters");
            string input1= Console.ReadLine();
            char[] chars = new char[] { ',','-','$','.' };
            int m1, n1;
            m1 = Convert.ToInt32(input1.Split(chars)[0]);
            n1 = Convert.ToInt32(input1.Split(chars)[1]);
            Console.WriteLine($"The sum of {m1} and {n1} is {m1 + n1}");
            Console.WriteLine($"int max value :{int.MaxValue}\n int min value : {int.MinValue}");
            Console.WriteLine($"byte max value :{byte.MaxValue}\n int min value : {byte.MinValue}");
            //some more data type 
            decimal kk = 345.45M;// for decimal use convention M
            float ss = 23.567F; // for float convention F i have to use 
            double jj = 34590.678;
            string name = "sudha";
            char ch = 'A';
            

            Console.WriteLine($"{kk}--{ss}--{jj}--{name}--{ch}");
            Console.ReadLine();

        }
    }
}


day 5 notes started 
-------------------
Certain methods will have the same name as that of class those methods are called as constructors and they will intilize the properties of  the class variables 
and we also have static constructors as well which will be called only one time eventhough we declare the constructor object many times 

In functions we have named paramters and optional parameters as well named means i can decide the order and as per the order i can passs values inside the function and 
optional means if i dont supply the function parameters and directly call the function then default or optional value which i had kept in function header that will be substituted 


using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandConstrcutors
{

    class Customer
    {
        public int customerid;
        public string custname;

        public Customer()//default constructor
        {
            Console.WriteLine("Default constructor");
            this.customerid = 1001;
            this.custname = "Suresh";
            Console.WriteLine($"{customerid}--{custname}");
                
        }
        static Customer()
        {
            Console.WriteLine("static constructor");
        }
        public Customer(int cid,string custname1)
        {
            Console.WriteLine("paramaized construcotr");
            this.customerid = cid;
            this.custname = custname1;
            Console.WriteLine($"{customerid}--{custname}");

        }
        
        public Customer(Customer c)
        {
            Console.WriteLine("Copy constructor");
            this.customerid = c.customerid;
            this.custname = c.custname;
            Console.WriteLine($"{customerid}--{custname}");
        }
    }
     class Program
    {
        public static void ShowMessage(int age =25,string name="Mr.X")//optional paramters
        {
            Console.WriteLine($"The person with name {name} is having age {age}");
        }
        static void Main(string[] args)
        {
            Customer defaultcons = new Customer();//default
            Customer defaultcons2 = new Customer();//default
            Customer paraconst = new Customer(1002,"sudha");
            Customer paraconst2 = new Customer(1003, "shanthi");//paramatized 
            Customer cc5 = new Customer(paraconst2);
            Customer cc6 = new Customer(defaultcons);
            ShowMessage(23, "Mahesh");
            ShowMessage(name: "suresh", age: 25);//named parameters as per my order ;
            ShowMessage();
            ShowMessage(name: "kiran");
            ShowMessage(29);
            Console.ReadLine();

        }
    }
}




Extension Methods :
------------------
Extension methods in C# are a powerful feature that allows you to "add" methods to existing types without modifying the original type or creating a new derived type.
This is particularly useful when you want to add functionality to classes that you don't have the source code for or can't modify (such as classes from the .NET framework).
How Extension Methods Work
Extension methods are static methods defined in static classes. They are called as if they were instance methods on the extended type.
The first parameter of an extension method specifies which type the method extends, and it is preceded by the this keyword.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethods
{

    public static class StringExtensions
    {
        // Extension method to check if a string is a palindrome
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            int i = 0;
            int j = str.Length - 1;

            while (i < j)
            {
                if (str[i] != str[j])
                    return false;
                i++;
                j--;
            }

            return true;
        }
    }
    public static class IntExtensions
    {
        // Extension method to check if an integer is odd
        public static bool IsOdd(this int number)
        {
            // A number is odd if it is not divisible by 2
            return number % 2 != 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string example1 = "madam";
            string example2 = "hello";

            // Using the extension method as if it were an instance method
            Console.WriteLine(example1.IsPalindrome()); // Output: True
            Console.WriteLine(example2.IsPalindrome()); // Output: False

            int number1 = 5;
            int number2 = 8;

            // Using the extension method IsOdd on integers
            Console.WriteLine($"{number1} is odd: {number1.IsOdd()}"); // Output: 5 is odd: True
            Console.WriteLine($"{number2} is odd: {number2.IsOdd()}"); // Output: 8 is odd: False

        }
    }
}



enumurations:
-------------
symbolic names given to integral constants is called enum 
here we can also say they are collection of related constants and it has a name and numeric data type it has number  of fileds each with name and value .

like weekdays--sun,mon,tuesday  are enumerations.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationDemo
{
    internal class Program
    {
        enum weekdays {sun,mon,tue,wed,thu,fri,sat };
        static void Main(string[] args)
        {
            Console.WriteLine($"{(int)weekdays.sun}");
            Console.ReadLine();
        }
    }
}

doing chnages in enums
---------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationDemo
{
    internal class Program
    {
        enum weekdays {sun=100,mon,tue,wed=34,thu,fri,sat };
        static void Main(string[] args)
        {
            Console.WriteLine($"{(int)weekdays.sun}");
            Console.WriteLine($"{(int)weekdays.mon}");
            Console.WriteLine($"{(int)weekdays.fri}");
            Console.ReadLine();
        }
    }
}


More modiifcation in code with date time clas 
-----------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationDemo
{
    internal class Program
    {
        enum weekdays {sun=100,mon,tue,wed=34,thu,fri,sat };
        static void Main(string[] args)
        {
            Console.WriteLine($"{(int)weekdays.sun}");
            Console.WriteLine($"{(int)weekdays.mon}");
            Console.WriteLine($"{(int)weekdays.fri}");
            // Get the current day of the week
            DayOfWeek currentDay = DateTime.Now.DayOfWeek;

            // Convert the current day to our Weekdays enum
            weekdays today = (weekdays)currentDay;

            Console.WriteLine($"Today is: {today}");

            // Check if today is a weekday or weekend
            if (today == weekdays.sat|| today == weekdays.sun)
            {
                Console.WriteLine("It's the weekend! Enjoy your day off.");
            }
            else
            {
                Console.WriteLine("It's a weekday. Time to work!");
            }
            Console.ReadLine();
        }
    }
}


omplete code with enums in employee also 

------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationDemo
{
    // Define the EmployeeType enum
    public enum EmployeeType
    {
        FullTime,
        PartTime,
        Contract
    }

    // Define the Employee class
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public EmployeeType Type { get; set; } // Enum field to store employee type  
    }
        internal class Program
    {

        enum weekdays {sun=100,mon,tue,wed=34,thu,fri,sat };
        static void Main(string[] args)
        {
            Console.WriteLine($"{(int)weekdays.sun}");
            Console.WriteLine($"{(int)weekdays.mon}");
            Console.WriteLine($"{(int)weekdays.fri}");
            // Get the current day of the week
            DayOfWeek currentDay = DateTime.Now.DayOfWeek;

            // Convert the current day to our Weekdays enum
            weekdays today = (weekdays)currentDay;

            Console.WriteLine($"Today is: {today}");

            // Check if today is a weekday or weekend
            if (today == weekdays.sat|| today == weekdays.sun)
            {
                Console.WriteLine("It's the weekend! Enjoy your day off.");
            }
            else
            {
                Console.WriteLine("It's a weekday. Time to work!");
            }
            Console.ReadLine();
        }
    }
}

Exception :
----------
An abnormal event that disrupts the normal flow of programming is called as an exception 
we can say run time error 


eg: you are trying to open a file which is not present an exception will come 


where there is a possiblity of error that code is kept in try block

and for to catch error we use catch block where we write user defined message in catch .

for one try block there can be multiple catch blocks based upon type of exceptions occur.

whether exception comes or not comes i want my code to be executed i use finally block 


try -->catch-->finally is okay 
try -->catch is okay 
try-->finally 

in between try and catch nothing should be used except comments // 

we can create our own exceptions and throw in .net there is no throws only throw is there in .net





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exceptiondemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(textBox1.Text);
            int b=Convert.ToInt32(textBox2.Text);
            int c = a / b;
            textBox3.Text = c.ToString();
        }
    }
}

modiifed code 1
-----------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exceptiondemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();
            }
            catch (DivideByZeroException ex)
            {

                MessageBox.Show("dont enter denominator as zero :" + ex.Message);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("dont enter charcters or special symbols :" + ex.Message);
            }



        }
    }
}


base class catch  exception always put it at the last 
------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exceptiondemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();
            }
            //int a; 
            catch (DivideByZeroException ex)
            {

                MessageBox.Show("dont enter denominator as zero :" + ex.Message);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("dont enter charcters or special symbols :" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("some genrral error " + ex.Message);
            }


        }
    }
}


because when child catch cannot handle then base clas wil  handle 
but dont do like this 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exceptiondemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();
            }
            //int a; 
            catch (Exception ex)
            {
                MessageBox.Show("some genrral error " + ex.Message);
            }

            catch (DivideByZeroException ex)
            {

                MessageBox.Show("dont enter denominator as zero :" + ex.Message);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("dont enter charcters or special symbols :" + ex.Message);
            }
           

        }
    }
}


error will come why u are putting me up when child catch block are there to handle either remove child blocks and keep only me or last only keep


now whether exception means run time error comes or does not comes i want my code to be executed then i will use finally block 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exceptiondemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();
            }
            //int a; 


            catch (DivideByZeroException ex)
            {

                MessageBox.Show("dont enter denominator as zero :" + ex.Message);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("dont enter charcters or special symbols :" + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("some genrral error " + ex.Message);
            }

            finally
            {
                MessageBox.Show("I am still alive ")
            }


        }
    }
}



These things  u try 



try -->catch-->finally is okay 
try -->catch is okay 
try-->finally is  also okay 

by commentinng the code of catch check try -->finally 

so like that checking remaining conditions also 

custom exception demo 
-------------------------
add one button and one extra text box 
i am creating axisbank exception 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Exceptiondemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();
            }
            //int a; 


            catch (DivideByZeroException ex)
            {

                MessageBox.Show("dont enter denominator as zero :" + ex.Message);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("dont enter charcters or special symbols :" + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("some genrral error " + ex.Message);
            }

            finally
            {
                MessageBox.Show("I am still alive ");
            }


        }
        public class AxisBankException : ApplicationException
        {
            public AxisBankException(string message) : base(message)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(textBox4.Text);
                if (age < 18)
                {
                    AxisBankException obj = new AxisBankException("AxisBankException:Age should be above 18 to open account");
                    throw obj;
                }
               else
                {
                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://www.axisbank.com/",
                        UseShellExecute = true
                    });
                }
            }
            catch (AxisBankException axisobj)
            {

                MessageBox.Show(axisobj.Message);
            }

           
        }
    }
}


exception demo in console 
---------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptiondemoinConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter value in a ...");
            int a = Convert.ToInt32(Console.ReadLine());
        L1: Console.WriteLine("enter value in b..");
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {
                int c = a / b;


                Console.WriteLine("the ddivision result is {0}", c);


            }
            //comments can come nothing 
            catch (DivideByZeroException ee)
            {

                Console.WriteLine("dont enter denominator as zero:" + ee.Message);
                goto L1;

            }
            catch (FormatException ee)
            {

                Console.WriteLine("dont enter chacters and special symbols: " + ee.Message);
                goto L1;
            }
            catch (Exception ee)
            {
                Console.WriteLine("some geenral error check it :" + ee.Message);
                goto L1;
            }

            finally
            {

                Console.WriteLine("I am still alive ...");
            }

            Console.ReadLine();
        }
    }
}









