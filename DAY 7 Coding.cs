 Dictionary demo 
--------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionarydemo
{
class Customer
    {
        public int CustomerID { set; get; }
        public string CustomerGenericName { set; get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            Dictionary<string,int> dicobj = new Dictionary<string,int>();
            Console.WriteLine("\n enter number of elements in the dictionary ...");
            int counter=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<counter;i++)
            {
                Console.WriteLine("enter key:");
                string key=Console.ReadLine();
                Console.WriteLine("enter value:");
                int value = Convert.ToInt32(Console.ReadLine());  
                dicobj.Add(key, value);
            }

            Console.WriteLine("\n Printing dictionary....");
            foreach(KeyValuePair<string,int> pair in dicobj)
            {
                Console.WriteLine($"{pair.Key}--{pair.Value}");
            }
            Console.WriteLine("which key is having largest length value");
            Console.WriteLine($"{dicobj.Values.Max()}");
            Dictionary<double, Customer> dicofcust = new Dictionary<double, Customer>()
            {
                {101.1,new Customer(){CustomerID=1001,CustomerName="Kumar"} }
                {101.2,new Customer(){CustomerID=1002,CustomerName="sita"} }
            };
            Console.WriteLine("\nprinting cusotmer dictionary:");
            foreach (var cusotmer in dicofcust)
            {
             
                Console.WriteLine($"{cusotmer.Key}:--->{cusotmer.Value.CustomerID},{cusotmer.Value.CustomerName}");
              

            }
            Console.ReadLine();

        }
    }
}


stack  demo 
---------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a stack of integers
            Stack<int> numberStack = new Stack<int>();

            // Push elements onto the stack
            numberStack.Push(10);
            numberStack.Push(20);
            numberStack.Push(30);
            numberStack.Push(40);

            // Print the elements in the stack
            Console.WriteLine("Elements in the stack:");
            foreach (int num in numberStack)
            {
                Console.WriteLine(num);
            }

            // Pop elements from the stack
            int poppedElement = numberStack.Pop();
            Console.WriteLine("Popped element: " + poppedElement);

            // Peek at the top element without removing it
            int topElement = numberStack.Peek();
            Console.WriteLine("Top element: " + topElement);

            // Print the updated stack
            Console.WriteLine("Remaining elements in the stack:");
            foreach (int num in numberStack)
            {
                Console.WriteLine(num);
            }

            Stack nongenricstack = new Stack();
            nongenricstack.Push("kiran");
            nongenricstack.Push(10);

            Console.ReadLine();

        }
    }
}


queue demo 
------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue of strings
            Queue<string> stringQueue = new Queue<string>();

            // Enqueue elements into the queue
            stringQueue.Enqueue("Alice");
            stringQueue.Enqueue("Bob");
            stringQueue.Enqueue("Charlie");
            stringQueue.Enqueue("David");

            // Print the elements in the queue
            Console.WriteLine("Elements in the queue:");
            foreach (string name in stringQueue)
            {
                Console.WriteLine(name);
            }

            // Dequeue elements from the queue
            string dequeuedElement = stringQueue.Dequeue();
            Console.WriteLine("Dequeued element: " + dequeuedElement);

            // Peek at the front element without removing it
            string frontElement = stringQueue.Peek();
            Console.WriteLine("Front element: " + frontElement);

            // Print the updated queue
            Console.WriteLine("Remaining elements in the queue:");
            foreach (string name in stringQueue)
            {
                Console.WriteLine(name);
            }
            Queue nongenericqueue = new Queue();
            nongenericqueue.Enqueue("kkkk");
            nongenericqueue.Enqueue(23);
            nongenericqueue.Enqueue(DateTime.Now);
            Console.ReadLine();

        }
    }
}


Delegates and Events :
----------------------
delegates are function pointers .delegate means getting work done .

when event is raised its corresponding delegate is called and that delegate will call the function .

delgate will have same return type and parameters of that function 

event --->delegate --->function 


public void add(int x, int y) is function 

syntax:
-------
public delegate retuntypeoffunction delegatename (parameters in function) 

public delegate void mydelegate(int x, int y) is the delegate for function add 


here name of delegate is mydelegate and it is having same return type of function add 
and same parameters .



Delegates are function pointers and delegate means getting work done (just telling meaning) 

when ever event is raised event means any event like button click event etc and that event will call its corresponding delegate and
that delegate will call the function 

in windows application for every event like mouse move event ,button click event there is a corresponding delegate in
built provided but in console application there are no events only functions will be there and i will write delegate to the functions 

let us see the in built delegate in windows application 

this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
			// 


so here above EventHandler is the in built delegate over here 

now i will create my own delegates for console application and here events will be not be there okay 
here delegates are reference type they point to some thing and it is totally run time means run time it will 
point to function and execute the function 



event ---->delegate ---->function 


syntax:
-------
public delegate retuntypeoffunction delegatename (parameters in function) 

public delegate void mydelegate(int x, int y) is the delegate for function add 


void add(int x, int y) 
{


}

void substract(int x, int y) 
{


}

In delegates while creating return type of function should match with the function and no of paramters in side the 
function should match with  the numbers of parameters in the function then only it can point to that function 

so same deleagte pointing to multiple functions we call it as multi cast delegate 



delegate demo 1
-----------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatedemo1
{
    internal class Program
    {
        public static void add(int x, int y)
        {
            Console.WriteLine($"The sum is :{x + y}");
        }

        public static int substract(int x, int y)
        {
            return (x - y);
        }

        public static int multiply(int x, int y)
        {
            return (x * y);
        }
        static void Main(string[] args)
        {
        }
    }
}

after creating delegate for the function add code is like this 

  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatedemo1
{
    internal class Program
    {
        public static void add(int x, int y)
        {
            Console.WriteLine($"The sum is :{x + y}");
        }

        public static int substract(int x, int y)
        {
            return (x - y);
        }

        public static int multiply(int x, int y)
        {
            return (x * y);
        }

        // public delegate retuntypeoffunction delegatename(parameters in function)
        public delegate void mydelegate1(int x , int y);
        static void Main(string[] args)
        {
            mydelegate1 m1 = add;
            m1(12, 4);// running the delegate here 
            m1.Invoke(13, 6);// like this also okay 
            Console.ReadLine();

        }
    }
}

now another delegate i want to create for substract and multiply 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatedemo1
{
    internal class Program
    {
        public static void add(int x, int y)
        {
            Console.WriteLine($"The sum is :{x + y}");
        }

        public static int substract(int x, int y)
        {
            return (x - y);
        }

        public static int multiply(int x, int y)
        {
            return (x * y);
        }

        // public delegate retuntypeoffunction delegatename(parameters in function)
        public delegate void mydelegate1(int x , int y);
        public delegate int mydelegate2(int x, int y);
        static void Main(string[] args)
        {
            mydelegate1 m1 = add;
            m1(12, 4);// running the delegate here 
            m1.Invoke(13, 6);// like this also okay 
                             //    mydelegate1 m2=substract// not pointing becasue return type is different 
                             // so create another delegate 
            mydelegate2 m2 = substract;
          Console.WriteLine($"substration is :{m2(12, 4)}");
            //now multiply is also having same return type i can do multicasting of delegate
            m2 += multiply;// multicasting means same delegate pointing to multiple functions

            Console.WriteLine($"Multiplication is :{m2(12, 9)}");

            mydelegate2 m3 = substract;
            Console.WriteLine($"{m3(15, 5)}");
            m3 += multiply;
          //  m3 -= multiply;if i add this it will not do multiple but for the same number as i am calling again it will just do substraction 
            Console.WriteLine($"{m3(15, 5)}");
            Console.ReadLine();

        }
    }
}


anaonymous execution :
----------------------
A function which will not have any  name is called anomymous function and that function can be executed using delegate
  reference so let us see that one 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatedemo1
{
    internal class Program
    {
        //public static void add(int x, int y)
        //{
        //    Console.WriteLine($"The sum is :{x + y}");
        //}

        //public static int substract(int x, int y)
        //{
        //    return (x - y);
        //}

        //public static int multiply(int x, int y)
        //{
        //    return (x * y);
        //}

        // public delegate retuntypeoffunction delegatename(parameters in function)
        public delegate void mydelegate1(int x , int y);
        public delegate int mydelegate2(int x, int y);
        static void Main(string[] args)
        {
            mydelegate1 m1 = delegate (int x, int y)
            {
                Console.WriteLine($"The sum is :{x + y}");
            };
            m1(12, 4);// running the delegate here 
            m1.Invoke(13, 6);// like this also okay 
                             //    mydelegate1 m2=substract// not pointing becasue return type is different 
                             // so create another delegate 
            mydelegate2 m2 = delegate (int x, int y)
            {
                return (x - y);
            };
           Console.WriteLine($"substration is :{m2(12, 4)}");
            //now multiply is also having same return type i can do multicasting of delegate
            m2 += delegate (int x, int y)
            {
                return (x * y);
            };// multicasting means same delegate pointing to multiple functions

            Console.WriteLine($"Multiplication is :{m2(12, 9)}");

          
            Console.ReadLine();

        }
    }
}


delegate version 3 with lamda expression:
------------------------------------------
//Lambda expression : 
//-------------------------
//some times u want to execute the function in a single line when 
//	u think that inside that function lot of code is not there then i will
//	make that function run using lambda expression and this is very much used
//			   in MVC programming and linq programming


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// check versions in code file for this program 
namespace delegatedemo1
{
    internal class Program
    {
        //public static void add(int x, int y)
        //{
        //    Console.WriteLine($"The sum is :{x + y}");
        //    Console.WriteLine("hai");
        //}

        //publi/c static int substract(int x, int y)
        //{
        //    return (x - y);
        //}

        //public static int multiply(int x, int y)
        //{
        //    return (x * y);
        //}

        // public delegate retuntypeoffunction delegatename(parameters in function)
        public delegate void mydelegate1(int x , int y);
        public delegate int mydelegate2(int x, int y);
        static void Main(string[] args)
        {

            mydelegate1 m1 = (x, y) => { Console.WriteLine($"The sum is :{x + y}"); Console.WriteLine("hai"); };
            m1(12, 5);
            mydelegate2 m2 = (x, y) => { return (x - y); };
            Console.WriteLine($"The substaction:{m2(12, 4)}");
            m2 += (x, y) => { return (x * y); };
            Console.WriteLine($"The multiplication:{m2(12, 4)}");
            
            Console.ReadLine();

        }
    }
}

Till Now i was doing console application where no event is there means only functions weere there
to that function i was pointing using deletagte and  i was executng the code in fuction now 
let us create one default event in console and event will now call a delegate and delegate will run to which function it is pointing .

  event -->delegate --->function 
delegate version 3 in console appllication wiht event:
------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventdelegatedemo
{
     class Program
    {
        public Program()
        {
            myevent = new mydelegate(testfuction);
                
        }
        public void testfuction ()
        {
            Console.WriteLine("function is called ...");
        }
        public delegate void mydelegate();
        public event mydelegate myevent;
        static void Main(string[] args)
        {
            Program pp = new Program();
            pp.myevent();
            //dynamically also u can write like this 

            new Program().myevent();
            Console.ReadLine();
        }
    }
}


In C#, Func, Action, and Predicate are built-in delegates that represent different types of methods. 
  They are commonly used for passing methods as parameters, providing a more functional programming style.

Func: A delegate that can take zero or more input parameters and must return a value.

Syntax: Func<T1, T2, TResult> where T1 and T2 are input types, and TResult is the return type.
Action: A delegate that can take zero or more input parameters but does not return a value.

Syntax: Action<T1, T2> where T1 and T2 are input types.
Predicate: A delegate that takes a single parameter and returns a bool.

Syntax: Predicate<T> where T is the input type.

suppose i am having functions like this in the program 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InBuiltdelgatesdemo
{
    internal class Program
    {
        public static void add(int a, float b, decimal k)
        {
            Console.WriteLine($"The sum is:{a + Convert.ToDecimal(b) + k}");
        }

        public static double add(int a, decimal b, double kk)
        {
            return (a + Convert.ToDouble(b) + kk);

        }

        public static bool checklength(string str)
        {
            if (str.Length > 10)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
        }
    }
}


for those functions i will create delegates and execute them like this 

  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InBuiltdelgatesdemo
{
    internal class Program
    {
        public static void add(int a, float b, decimal k)
        {
            Console.WriteLine($"The sum is:{a + Convert.ToDecimal(b) + k}");
        }

        public static double add(int a, decimal b, double kk)
        {
            return (a + Convert.ToDouble(b) + kk);

        }

        public static bool checklength(string str)
        {
            if (str.Length > 10)
                return true;
            else
                return false;
        }
        public delegate void mydelegate1(int a, float b, decimal k);
        public delegate double mydelegate2(int a, decimal b, double kk);
        public delegate bool mydelegate3(string str);
        static void Main(string[] args)
        {
            mydelegate1 m1 = add;
            m1(12, 34.5F, 345.34M);
            mydelegate2 m2 = add;
            mydelegate3 m3 = checklength;
           Console.WriteLine($"The additon is :{m2(12, 234.45M, 234.345)}");
            Console.WriteLine($"The string is having length more than 10 :{m3("Raghavendra")}");
            Console.ReadLine();

        }
    }
}


But some inbuilt delegates are given by .net i will use those


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InBuiltdelgatesdemo
{
    internal class Program
    {
        public static void add(int a, float b, decimal k)
        {
            Console.WriteLine($"The sum is:{a + Convert.ToDecimal(b) + k}");
        }

        public static double add(int a, decimal b, double kk)
        {
            return (a + Convert.ToDouble(b) + kk);

        }

        public static bool checklength(string str)
        {
            if (str.Length > 10)
                return true;
            else
                return false;
        }
       // public delegate void mydelegate1(int a, float b, decimal k);
       // public delegate double mydelegate2(int a, decimal b, double kk);
       // public delegate bool mydelegate3(string str);
        static void Main(string[] args)
        {
            
            Action<int,float,decimal> m1 = add;
            m1(12, 34.5F, 345.34M);
            Func<int,decimal,double,double> m2 = add;
            Predicate<string> m3 = checklength;
           Console.WriteLine($"The additon is :{m2(12, 234.45M, 234.345)}");
            Console.WriteLine($"The string is having length more than 10 :{m3("Raghavendra")}");
            Console.ReadLine();

        }
    }
}



extra code for in built generic delegate using lambda expression 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbuiltgenericdelegatedemo2
{
    internal class Program
    {

        //public bool findeven(int number)
        //{
        //    if(number%2==0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        static void Main(string[] args)
        {
            // Func example: Takes two integers and returns their sum
            Func<int, int, int> sumFunc = (a, b) => a + b;
            int result = sumFunc(5, 10);
            Console.WriteLine($"Sum using Func: {result}");  // Output: 15

            // Action example: Takes a string and prints a message
            Action<string> printMessage = (message) => Console.WriteLine($"Message using Action: {message}");
            printMessage("Hello from Action!");

            // Predicate example: Checks if a number is even
            Predicate<int> isEven = (number) =>
            {
                if (number % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            // Use Predicate with List.FindAll to find all even numbers

            List<int> evenNumbers = numbers.FindAll(isEven);
            Console.WriteLine("Even numbers using Predicate: " + string.Join(", ", evenNumbers));
            Console.ReadLine();
        }
    }
}


Tessting 
--------------

Testing Means I want to test the code which i have written correctly or not .Here developer only will write the test cases .
The code which i have to test that code's dll is added into testing program
and it is tested .


Testing ensures that the code which i had written is correct or not as per requirement 

There are many testing framework avaiable like nunit,xunit and Microsoft .net testing 

The testing which we do on code is also called as white box testing 


Here three A's  there 


Arrange : here what i have to test and with what to test is arranged here

Act : here actual coding of testing is written which will writen either true or false


Assert : Here i will asset means compare the values whether expected value is equal to actual value 
         which is coming from above fuction 

create a class library project of .net framework and write the code like this ..

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrengthMeter
{
    public class  PassWordStrength
    {
        public static int GetPasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return 0;
            }
            int result = 0;
            if (password.Length > 8)
            {
                result = result + 1;
            }
            if (password.Any(char.IsUpper))
            {
                result = result + 1;
            }

            if (password.Any(char.IsLower))
            {
                result = result + 1;
            }
            string specialchars = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specarray = specialchars.ToCharArray();
            foreach (char c in specarray)
            {
                if (password.Contains(c))
                {
                    result = result + 1;
                }
            }
            if (password.Any(char.IsDigit))
            {
                result = result + 1;
            }

            return result;


        }
    }
}


Build the libarary to create the dll file 

then add one test project into the solution and provide refercne of this dll file to it

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordStrengthMeter;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange 
            string password = "Rajesh#123";
            int expected = 4;

            //act

            int actual=PassWordStrength.GetPasswordStrength(password);

            //assert

            Assert.AreEqual(expected, actual);

        }
    }
}

Now another class library proejct i will create and will use Nunit ,Xunit and MSTest of .net core ..8.0 

  Introduction to different other  types of  Unit Testing in C#:
-------------------------------------------------------------
Unit testing is the process of testing individual units or components of an application in isolation to ensure that they function as expected. 
  In C#, unit tests are typically written using frameworks like NUnit, MSTest, or XUnit. Here,
  I'll provide a basic understanding of unit testing using NUnit as an example.

Key Concepts:
Test Framework: NUnit, MSTest, or XUnit provide the infrastructure for writing and running tests.
Assertions: Assertions are used to verify that the expected output matches the actual output of a unit.
Test Suites: A collection of related test cases.
Test Runner: A tool or part of the framework that executes the tests and provides feedback on whether they passed or failed.


First create a class Library project of .net core with version 8.0 give name as ArthematicOpsAndOther
 
so it will look like this 

namespace ArthematicOpsAndOther
{
    public class Class1
    {

    }
}

Now into the namespace add this below code and you will see the code like this just override the class 

  namespace ArthematicOpsAndOther
{
    public class  Calculate
    {

        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1 , int num2)
        {
            int result;
            if(num1 > num2)
            {
                result = num1 - num2;
            }
            else
            {
                result=num2-num1;
            }
            return result;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2) 
        {
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException ex)
            {
                throw ex;
            }
            return result;
        
        
        }

        public  int GetPasswordStrength(string password)
        {

            if (string.IsNullOrEmpty(password))
            {
                return 0;
            }

            int result = 0;
            if (password.Length > 8)
            {
                result = result + 1;
            }
            if (password.Any(char.IsUpper))
            {
                result = result + 1;
            }
            if (password.Any(char.IsLower))
            {
                result = result + 1;
            }
            string specialchars = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specarrray = specialchars.ToCharArray();
            foreach (char c in specarrray)
            {
                if (password.Contains(c))
                {
                    result = result + 1;
                }

            }

            if (password.Any(char.IsDigit))
            {
                result = result + 1;
            }

            return result;

        }



    }
}


Now build the project once then dll file or u can see the u will find the dll in 

D:\GreatLearning4\Day7\Day&Projects\ArthematicOpsAndOther\bin\Debug\net8.0

as per my laptop 

now i will 

open new test project of .net core only on NUnit if Nunit is not there in the template use 
Nunit3  something will be there u can use it 

so intially u will see the code default one like this 

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}

Now in this above code add reference means go to dependenis and from there add reference  of dll of arhtmeaticopsandother and include namespace 

so in assemblies fodler dll will be added as it is .net core dll  is stored in assemblies folder 

which will look like this 

using ArthematicOpsAndOther;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}

Now to this code only overiride the class code means inside namespace paste the code along with [textfixture ]

[TestFixture]
    public class Tests
    {
        private Calculate _calculate;

        [SetUp]
        public void Setup()
        {
            // Initialize the Calculate object before each test
            _calculate = new Calculate();
        }

        [Test]
        public void Addition()
        {
            int actual = _calculate.Addition(20, 30);
            int expected = 50;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtraction()
        {
            int actual = _calculate.Subtract(30, 20);
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiplication()
        {
            int actual = _calculate.Multiplication(20, 30);
            int expected = 600;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideWithException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculate.Divide(12,0));
        }

        [Test]
        public void Divide()
        {
            int actual = _calculate.Divide(12, 4);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        //[TestCase("", 0)] // Empty password
        //[TestCase("12345", 1)] // Digits only
        //[TestCase("password123", 2)] // Lowercase + digits
       // [TestCase("Password123", 3)] // Uppercase + lowercase + digits
        [TestCase("Password@123", 5)] // Special char + uppercase + lowercase + digits
        public void GetPasswordStrength_ShouldReturnExpectedStrength(string password, int expectedStrength)
        {
            int result = _calculate.GetPasswordStrength(password);
            Assert.AreEqual(expectedStrength, result);
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
            _calculate = null;
        }
    }

final test code will look like this 

using ArthematicOpsAndOther;
namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private Calculate _calculate;

        [SetUp]
        public void Setup()
        {
            // Initialize the Calculate object before each test
            _calculate = new Calculate();
        }

        [Test]
        public void Addition()
        {
        
            
            int actual = _calculate.Addition(20, 30);
            int expected = 50;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtraction()
        {
            int actual = _calculate.Subtract(30, 20);
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiplication()
        {
            int actual = _calculate.Multiplication(20, 30);
            int expected = 600;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivideWithException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculate.Divide(12,0));
        }

        [Test]
        public void Divide()
        {
            int actual = _calculate.Divide(12, 4);
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        //[TestCase("", 0)] // Empty password
        //[TestCase("12345", 1)] // Digits only
        //[TestCase("password123", 2)] // Lowercase + digits
       // [TestCase("Password123", 3)] // Uppercase + lowercase + digits
       // [TestCase("Password@123",4)] // Special char + uppercase + lowercase + digits
        public void GetPasswordStrength_ShouldReturnExpectedStrength(string password, int expectedStrength)
        {
            int result = _calculate.GetPasswordStrength(password);
            Assert.AreEqual(expectedStrength, result);
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
            _calculate = null;
        }
    }



}

run the test cases and see it is the syntax for unit testing ...

Now add another test project of xUnit and addd dll of same code and paste the below code which i have given into the namespace 

Xunit usage :
-------------
using ArthematicsOpsandOther;
namespace TestProject2
{
    public class CalculateTests
    {
        private readonly Calculate _calculator;

        public CalculateTests()
        {
            _calculator = new Calculate();
        }

        [Fact]
        public void Addition_ShouldReturnCorrectSum()
        {
            int result = _calculator.Addition(5, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectResult_WhenNum1IsGreater()
        {
            int result = _calculator.Subtract(10, 3);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectResult_WhenNum2IsGreater()
        {
            int result = _calculator.Subtract(3, 10);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Multiplication_ShouldReturnCorrectProduct()
        {
            int result = _calculator.Multiplication(5, 4);
            Assert.Equal(20, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            int result = _calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ShouldThrowDivideByZeroException_WhenDividingByZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }

        //[Theory]
        //[InlineData("", 0)] // Empty password
        //[InlineData("12345", 1)] // Digits only
        //[InlineData("password123", 2)] // Lowercase + digits
        //[InlineData("Password123", 3)] // Uppercase + lowercase + digits
        [InlineData("Password@123", 5)] // Special char + uppercase + lowercase + digits
        public void GetPasswordStrength_ShouldReturnExpectedStrength(string password, int expectedStrength)
        {
            int result = _calculator.GetPasswordStrength(password);
            Assert.Equal(expectedStrength, result);
        }
    }

}


Now add MsUnit test project it is not .net framework it is .net core only 8.0 and same add reference and same add clas 

MSUnit
---------
using ArthematicsOpsandOther;
namespace TestProject3
{
    [TestClass]
    public class CalculateTests
    {
        private Calculate _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculate();
        }

        [TestMethod]
        public void Addition_ShouldReturnCorrectSum()
        {
            int result = _calculator.Addition(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectResult_WhenNum1IsGreater()
        {
            int result = _calculator.Subtract(10, 3);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectResult_WhenNum2IsGreater()
        {
            int result = _calculator.Subtract(3, 10);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Multiplication_ShouldReturnCorrectProduct()
        {
            int result = _calculator.Multiplication(5, 4);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            int result = _calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ShouldThrowDivideByZeroException_WhenDividingByZero()
        {
            _calculator.Divide(10, 0);
        }

        //[DataTestMethod]
        //[DataRow("", 0)] // Empty password
        //[DataRow("12345", 1)] // Digits only
        //[DataRow("password123", 2)] // Lowercase + digits
        //[DataRow("Password123", 3)] // Uppercase + lowercase + digits
        [DataRow("Password@123", 4)] // Special char + uppercase + lowercase + digits
        public void GetPasswordStrength_ShouldReturnExpectedStrength(string password, int expectedStrength)
        {
            int result = _calculator.GetPasswordStrength(password);
            Assert.AreEqual(expectedStrength, result);
        }
    }

}











