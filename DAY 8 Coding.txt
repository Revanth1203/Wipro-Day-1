chat gpt answer :
-------------------
using System;

// Step 1: Define delegate type
public delegate int Operation(int a, int b);

class Program
{
    // Step 2: Implement delegate methods
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static int Divide(int a, int b)
    {
        return b == 0 ? throw new DivideByZeroException("Error: Division by zero is not allowed.") : a / b;
    }

    // Step 3: Implement callback mechanism
    public static void PerformOperation(int x, int y, Operation op)
    {
        try
        {
            int result = op(x, y);
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }

    static void Main(string[] args)
    {
        try
        {
            // Step 4: Input handling
            Console.WriteLine("Enter first number:");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Error: Invalid input. Please enter an integer.");
                return;
            }

            Console.WriteLine("Enter second number:");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Error: Invalid input. Please enter an integer.");
                return;
            }

            Console.WriteLine("Enter operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine()?.Trim().ToLower();

            // Step 5: Output handling
            Operation op = operation switch
            {
                "add" => Add,
                "subtract" => Subtract,
                "multiply" => Multiply,
                "divide" => Divide,
                _ => null
            };

            if (op == null)
            {
                Console.WriteLine("Invalid operation.");
                return;
            }

            PerformOperation(num1, num2, op);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}


so here some C# 7.0 and 8.0 features have been used which i have not told u yet so i had written the program in this manner in a easy way to 
understand 

code 2
----------
using System;

// Step 1: Define delegate type
public delegate int Operation(int a, int b);

class Program
{
    // Step 2: Implement delegate methods with normal method bodies
     // Implement delegate methods

     public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        if (b!=0)
        {
         return a / b;
        }
         else
         {
          throw new DivideByZeroException("Error: Division by zero is not allowed.");
       
         }
            
    }
    // Step 3: Implement callback mechanism
    public static int PerformOperation(int a, int b, Operation op)
    {
        return op(a, b); // Calls the delegate function dynamically
    }

    static void Main(string[] args)
    {
        try
        {
            // Step 4: Input handling
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine().ToLower();

            // Step 5: Assigning method to delegate using if-else (callback implementation)
            Operation op;
            if (operation == "add")
                op = Add;
            else if (operation == "subtract")
                op = Subtract;
            else if (operation == "multiply")
                op = Multiply;
            else if (operation == "divide")
                op = Divide;
            else
                throw new InvalidOperationException("Invalid operation");

            // Step 6: Execute the callback function (PerformOperation calls the selected method)
            int result = PerformOperation(num1, num2, op);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}


so in chatgpt code and my code both the cases the hidden test case is failing one is failing so i have to identify 
what is that hidden test cases now if i write it in normal method way it is failing when i am writing the methods 
in expression bodied way it is passing 

so final code from my code is modification is 


final code :
---------------
here in tha above code dont write in divide like this 

 throw new DivideByZeroException("Error: Division by zero is not allowed.");
 
 means remove error message let it be empty 
 
  throw new DivideByZeroException();// so then it will work ..
  
code :
------
using System;

// Step 1: Define delegate type
public delegate int Operation(int a, int b);

class Program
{
    // Step 2: Implement delegate methods with normal method bodies
     // Implement delegate methods

     public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        if (b!=0)
        {
         return a / b;
        }
         else
         {
          throw new DivideByZeroException();
       
         }
            
    }
    // Step 3: Implement callback mechanism
    public static int PerformOperation(int a, int b, Operation op)
    {
        return op(a, b); // Calls the delegate function dynamically
    }

    static void Main(string[] args)
    {
        try
        {
            // Step 4: Input handling
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine().ToLower();

            // Step 5: Assigning method to delegate using if-else (callback implementation)
            Operation op;
            if (operation == "add")
                op = Add;
            else if (operation == "subtract")
                op = Subtract;
            else if (operation == "multiply")
                op = Multiply;
            else if (operation == "divide")
                op = Divide;
            else
                throw new InvalidOperationException("Invalid operation");

            // Step 6: Execute the callback function (PerformOperation calls the selected method)
            int result = PerformOperation(num1, num2, op);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

Test Driven Development 
---------------------------

Test-Driven Development (TDD) is a software development practice where tests are written before the actual code is implemented.
The process follows three basic steps:

Write a test: Write a test for the functionality you want to implement.
Run the test: Run the test, which should fail because the functionality hasn't been implemented yet.
Write the code: Write the minimum amount of code to make the test pass.
Refactor: Improve the code structure without changing its behavior, and ensure the tests still pass.
Here’s a simple TDD demo using C# with NUnit as the testing framework.

Scenario: Implement a BankAccount class that supports deposits, withdrawals, and balance checking.

now first create a test project which is of NUnit and overrite the code which i had given below mainly the class you 
override 

first boilerplate (code which comes with template ) code will look like this 

namespace BankAccountTest
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

so in this add some code like this just overide the class in your namespace 

[TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void Deposit_ShouldIncreaseBalance_WhenAmountIsPositive()
        {
            var account = new BankAccount();
            account.Deposit(100);

            Assert.AreEqual(100, account.Balance);
        }

        [Test]
        public void Withdraw_ShouldDecreaseBalance_WhenSufficientBalance()
        {
            var account = new BankAccount();
            account.Deposit(100);
            account.Withdraw(50);

            Assert.AreEqual(50, account.Balance);
        }

        [Test]
        public void Withdraw_ShouldThrowException_WhenInsufficientBalance()
        {
            var account = new BankAccount();
            account.Deposit(50);

            Assert.Throws<InvalidOperationException>(() => account.Withdraw(100));
        }
    }

which will look like this 

namespace BankAccountTest
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void Deposit_ShouldIncreaseBalance_WhenAmountIsPositive()
        {
            var account = new BankAccount();
            account.Deposit(100);

            Assert.AreEqual(100, account.Balance);
        }

        [Test]
        public void Withdraw_ShouldDecreaseBalance_WhenSufficientBalance()
        {
            var account = new BankAccount();
            account.Deposit(100);
            account.Withdraw(50);

            Assert.AreEqual(50, account.Balance);
        }

        [Test]
        public void Withdraw_ShouldThrowException_WhenInsufficientBalance()
        {
            var account = new BankAccount();
            account.Deposit(50);

            Assert.Throws<InvalidOperationException>(() => account.Withdraw(100));
        }
    }

}

above i had used 8.0 .net core and i am seeing some error in red line for the above code 

now i have to write the minimum code so that red lines should not be there what u do is 

in the same area means dont create seperate project there only above write like this 


namespace BankAccountTest
{
    class BankAccount
    {

    }

    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void Deposit_ShouldIncreaseBalance_WhenAmountIsPositive()
        {
            var account = new BankAccount();
            account.Deposit(100);

            Assert.AreEqual(100, account.Balance);
        }

        [Test]
        public void Withdraw_ShouldDecreaseBalance_WhenSufficientBalance()
        {
            var account = new BankAccount();
            account.Deposit(100);
            account.Withdraw(50);

            Assert.AreEqual(50, account.Balance);
        }

        [Test]
        public void Withdraw_ShouldThrowException_WhenInsufficientBalance()
        {
            var account = new BankAccount();
            account.Deposit(50);

            Assert.Throws<InvalidOperationException>(() => account.Withdraw(100));
        }
    }

}

so here BankAccount class i created then new errors are coming where is deposit ,withdraw functions it is saying 

so again i will write the code like this inisde the BankAccount class 


namespace BankAccountTest
{
    class BankAccount
    {
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
            Balance -= amount;
        }
    }

    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void Deposit_ShouldIncreaseBalance_WhenAmountIsPositive()
        {
            var account = new BankAccount();
            account.Deposit(100);

            Assert.AreEqual(100, account.Balance);
        }

        [Test]
        public void Withdraw_ShouldDecreaseBalance_WhenSufficientBalance()
        {
            var account = new BankAccount();
            account.Deposit(100);
            account.Withdraw(50);

            Assert.AreEqual(50, account.Balance);
        }

        [Test]
        public void Withdraw_ShouldThrowException_WhenInsufficientBalance()
        {
            var account = new BankAccount();
            account.Deposit(50);

            Assert.Throws<InvalidOperationException>(() => account.Withdraw(100));
        }
    }

}

Now all test cases are passing this is TDD we call test driven development ...

Explanation:
Balance: The Balance property holds the current balance of the account.
Deposit: Adds the deposit amount to the balance. Throws an exception if the deposit amount is not positive.
Withdraw: Decreases the balance if there are sufficient funds, otherwise throws an InvalidOperationException.

Step 3: Run the Tests and Verify (Test should pass now)
After implementing the BankAccount class, run the tests again. They should all pass because the methods now implement the expected behavior.


Step 4: Refactor the Code (Optional)
In TDD, after the tests pass, you can refactor the code to improve readability, maintainability, or performance while ensuring that the tests still pass.

For this example, no immediate refactoring is needed, but you might reorganize your code as your project grows.


Positive ,Negative and Edge test cases 
-------------------------------------------
Here are examples of creating complex test methods that handle multiple scenarios (positive, negative, and edge cases)
for NUnit, MSTest, and XUnit using C#. We will test a Calculator class that performs basic arithmetic.
Each test method will cover different scenarios: positive, negative, and edge cases.

   if vaid inputs are given and for that test case is written then it is positive test case 
  for invalid inputs the test cases which gets activated are negative test case 
  anything which is rounding like taking maximum value or least value those test casses are called edge test cases 
  below code tells that 


Here are examples of creating complex test methods that handle multiple scenarios (positive, negative, and edge cases) for NUnit, MSTest, 
and XUnit using C#. We will test a Calculator class that performs basic arithmetic. Each test method will cover different scenarios: positive, negative, and edge cases.

now add one test project of NUNIt of .net core 8.0 and in that replace my class and in namespace add Calculator class as shown below The test will test 
the Calculator class only 

1. NUnit Example: Complex Test Cases

Step 1: Create the Calculator Class

public class Calculator
{
    public int Divide(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException("Denominator cannot be zero.");
        }
        return numerator / denominator;
    }
}


Step 2: Create Test Class with Different Scenarios

using NUnit.Framework;
using System;

namespace NUnitTestDemo
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // Positive test case: normal division
        [Test]
        public void Divide_ShouldReturnCorrectResult_WhenInputsAreValid()
        {
            var result = _calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        // Negative test case: dividing by zero
        [Test]
        public void Divide_ShouldThrowDivideByZeroException_WhenDenominatorIsZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));// here if u put 10,2 it will fail //why it will take unproepr innput only as it is negative test case 
        }

        // Edge case: division resulting in a fraction (rounding down)
        [Test]
        public void Divide_ShouldRoundDown_WhenResultIsFraction()
        {
            var result = _calculator.Divide(5, 2);
            Assert.AreEqual(2, result); // Integer division, rounds down
        }

        // Edge case: very large numbers
        [Test]
        public void Divide_ShouldHandleLargeNumbers()
        {
            var result = _calculator.Divide(int.MaxValue, 1);
            Assert.AreEqual(int.MaxValue, result);
        }
    }
}


in the same test program calculalte is there final code 

namespace PositivenegativeEdgeTestcase
{
    public class Calculator
    {
        public int Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return numerator / denominator;
        }
    }



    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // Positive test case: normal division
        [Test]
        public void Divide_ShouldReturnCorrectResult_WhenInputsAreValid()
        {
            var result = _calculator.Divide(10,2);
            Assert.AreEqual(5, result);
        }

        // Negative test case: dividing by zero
        [Test]
        public void Divide_ShouldThrowDivideByZeroException_WhenDenominatorIsZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10,0));// here if u put 10,2 it will fail //why it will take unproepr innput only as it is negative test case 
        }

        // Edge case: division resulting in a fraction (rounding down)
        [Test]
        public void Divide_ShouldRoundDown_WhenResultIsFraction()
        {
            var result = _calculator.Divide(7,5);  // in calculator it will give 1.4 rounded to 1 which is matching expected 
            Assert.AreEqual(1, result); // Integer division, rounds down
        }

        // Edge case: very large numbers
        [Test]
        public void Divide_ShouldHandleLargeNumbers()
        {
            var result = _calculator.Divide(int.MaxValue, 1);
            Assert.AreEqual(int.MaxValue, result);
        }
    }
}


Mock Testing 
-------------
I am having two developers working on different codes developer 1 code is incomplete and developer 2 code is complete but developer 2 is depending on developer 1 
for executing its code so Tester cannot test incomplete code so to test incomplete code and make it pass temperorialy is called mock testing 
measn for time being using mock library i will add dummy data into develper code and make his code test pass as developr 2 is depemding on develoer 1 


example developer 1 code is to check emp is there in database or not 

         developer 2 task if emp is there display emp details which he can do when he knows completely fromm developer1 that emp is there or not 




open one test project of Mstest of .net core 8 0 only now which will look like this 


namespace MockTestingDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

next add one class here like this in this namespace only 




namespace MockTestingDemo
{

    public class CheckEmployee
    {
        public virtual Boolean checkemp()
        {
            throw new NotImplementedException();
        }

       

    }
    public class ProcessEmployee
    {
        public int insertEmployee(CheckEmployee emp)// depending upon check emp class

        {
            emp.checkemp();
            // logic for implemting inseting employee using ado.net 


            return 1;

        }
    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

add Moq libary how to add 

right cick on dependencies and manage nugget packages go to browse tab and write Moq there and first package u install not compatible also means install it 


using Moq;            // add namespace here like this 
namespace MockTestingDemo
{

    public class CheckEmployee
    {
        public virtual Boolean checkemp()
        {
            throw new NotImplementedException();
        }

       

    }
    public class ProcessEmployee
    {
        public int insertEmployee(CheckEmployee emp)// depending upon check emp class

        {
            emp.checkemp();
            // logic for implemting inseting employee using ado.net 


            return 1;

        }
    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

By writing the code in test class whether i put expecetd value as true or false check emp is failing because code is not complete here 


using Moq;
namespace MockTestingDemo
{

    public class CheckEmployee
    {
        public virtual Boolean checkemp()
        {
            throw new NotImplementedException();
        }

       

    }
    public class ProcessEmployee
    {
        public int insertEmployee(CheckEmployee emp)// depending upon check emp class

        {
            emp.checkemp();
            // logic for implemting inseting employee using ado.net 


            return 1;

        }
    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CheckEmployee  checkobj = new CheckEmployee();
            Assert.AreEqual(false, checkobj.checkemp());// here for both  cases it is failing false and also for tue expected value as code is incomplete 
        }
    }
}



now i pass the check employee which is incomplete into Mock class and forecfully i will make him pass during that tme one object will be created that only i am using it 


using Moq;


namespace MockTestingDemo
{

    public class CheckEmployee
    {
        public virtual Boolean checkemp()
        {
            throw new NotImplementedException();
        }

       

    }
    public class ProcessEmployee
    {
        public int insertEmployee(CheckEmployee emp)// depending upon check emp class

        {
            emp.checkemp();
            // logic for implemting inseting employee using ado.net 


            return 1;

        }
    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           Mock<CheckEmployee> checkobj = new Mock<CheckEmployee>();
            checkobj.Setup(x => x.checkemp()).Returns(true);// forfully made true which will create one object 
            Assert.AreEqual(true, checkobj.Object.checkemp());// 
            ProcessEmployee proobj=new ProcessEmployee();
            Assert.AreEqual(1, proobj.insertEmployee(checkobj.Object));


        }
    }
}


c# 7.0 and 8.0 features 
-------------------------

Tupples and deconstruction 
--------------------------
namespace CSharp7and8ewFeature_TuplesandDeconstruction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a tuple it is a variable which will have multiple types 
            (string Name, int Age, bool IsActive) person = ("John doe", 30, true);

            //accessing person data 

            Console.WriteLine($"Name:{person.Name} ,Age:{person.Age},IsActive:{person.IsActive}");
            // like this below i cannot print 

            // Console.WriteLine($"Name:{Name} ,Age:{Age},IsActive:{IsActive}");

            // Using tuple deconstruction to unpack the tuple into variables
            var (name1, age1, isActive1) = person;

            // Accessing the deconstructed values
            Console.WriteLine($"Deconstructed - Name: {name1}, Age: {age1}, IsActive: {isActive1}");
            Console.ReadLine();
        }
    }
}


creating a tuple function and means earleir variabl was there now function will return multiple values 


namespace CSharp7and8ewFeature_TuplesandDeconstruction
{
    internal class Program
    {
        public static (string Name, int Age, bool IsActive) GetPersonInfo()
        {
            return ("Jane Doe", 25, false);
        }
        
        static void Main(string[] args)
        {
            //create a tuple it is a variable which will have multiple types 
            (string Name, int Age, bool IsActive) person = ("John doe", 30, true);

            //accessing person data 

            Console.WriteLine($"Name:{person.Name} ,Age:{person.Age},IsActive:{person.IsActive}");
            // like this below i cannot print 

            // Console.WriteLine($"Name:{Name} ,Age:{Age},IsActive:{IsActive}");

            // Using tuple deconstruction to unpack the tuple into variables
            var (name1, age1, isActive1) = person;

            // Accessing the deconstructed values
            Console.WriteLine($"Deconstructed - Name: {name1}, Age: {age1}, IsActive: {isActive1}");

            // Returning a tuple from a function
            var personInfo = GetPersonInfo();
            Console.WriteLine($"From Function - Name: {personInfo.Name}, Age: {personInfo.Age}, IsActive: {personInfo.IsActive}");

            // Deconstructing tuple returned from a function
            var (personName, personAge, personIsActive) = GetPersonInfo();
            Console.WriteLine($"From Deconstruction - Name: {personName}, Age: {personAge}, IsActive: {personIsActive}");


            Console.ReadLine();
        }
    }
}

Pattern matching 
----------------

using System;

namespace Csharp7and8Newfeatures_patternmatching
{

    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            object[] items = { "Hello", 42, 3.14, new Person("John", "Doe"), null };

            // i want to go or touch each elelement and do modiifcation to this element 
            //so using for loop i can do but for loop is there which will take only one 
            // type but i can use foreach loop and can use var but for each loop is 
            // read only loop 
            // so i can do patern matching here like this below code 

            foreach(var item in items)
            {
                //pattern matching using switch expression
                string result = item switch
                {
                    string s => $"String  is of length:{s.Length}:{s}",
                    int i => $"Integer: {i}",
                    double d=> $"Double : {d}",
                    Person p => $"Person :{p.FirstName} {p.LastName}",
                    null => "Null value",
                    _ => "Unknown type"
                };
                Console.WriteLine(result);
                
            }
            Console.ReadLine();
        }
    }
}

Now i will add another class employee and checkemployee function
in that based on value of proeprty i will do pattern matching taking age 

using System;

namespace Csharp7and8Newfeatures_patternmatching
{

    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        public static void CheckEmployee(Employee employee)
        {
            // Matching properties of an object using pattern matching
            string result = employee switch
            {
                { Age: >= 30, FirstName: "Alice" } => "Alice is at least 30 years old.",
                { Age: < 30 } => "Employee is under 30 years old.",
                _ => "Other employee"
            };
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            object[] items = { "Hello", 42, 3.14, new Person("John", "Doe"), null };

            // i want to go or touch each elelement and do modiifcation to this element 
            //so using for loop i can do but for loop is there which will take only one 
            // type but i can use foreach loop and can use var but for each loop is 
            // read only loop 
            // so i can do patern matching here like this below code 

            foreach(var item in items)
            {
                //pattern matching using switch expression
                string result = item switch
                {
                    string s => $"String  is of length:{s.Length}:{s}",
                    int i => $"Integer: {i}",
                    double d=> $"Double : {d}",
                    Person p => $"Person :{p.FirstName} {p.LastName}",
                    null => "Null value",
                    _ => "Unknown type"
                };
                Console.WriteLine(result);
                
            }
            var employee = new Employee { FirstName = "Alice", LastName = "Smith", Age = 12 };
            CheckEmployee(employee);
            Console.ReadLine();
        }
    }
}

Local functions 
--------------------
namespace CSharp7And8newfeatures_Localfunctions
{
    internal class Program
    {

        public static int CalculateFactorial(int number)
        {
            // Local function to calculate factorial recursively
            int Factorial(int n)
            {
                if (n <= 1)
                    return 1;
                return n * Factorial(n - 1); // Recursion
            }

            return Factorial(number); // Call the local function
        }

        // A method demonstrating a local function that captures variables from the outer scope
        public static int CalculateSumWithLocalFunction(int x, int y)
        {
            // Local function capturing outer variables
            int Add()
            {
                return x + y; // x and y are captured from the outer method
            }

            return Add(); // Call the local function
        }
        static void Main(string[] args)
        {
            //functions which are present insdie another function means with body they 
            //are present and taking the values of parent function and inside the parent only i 
            // am giving a call if u give call then only it is called 
            Console.WriteLine("Starting the demo of local functions.");

            // Call the method that uses local functions
            int result = CalculateFactorial(5);
            Console.WriteLine($"Factorial of 5 is: {result}");

            // Call the method that demonstrates capturing variables from the outer scope
            int sum = CalculateSumWithLocalFunction(3, 4);
            Console.WriteLine($"Sum of 3 and 4 is: {sum}");



            Console.WriteLine("End of demo.");
            Console.ReadLine();
        }
    }
}

out type paramters 
---------------------
Let us take one swap demo which we have done earlier where ref is used refercne type 

namespace Csharp7And8newfeatures_outtypeparamterdemo
{
    internal class Program
    {
        public static void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            // here press enter two times to see the result 
            int x = 10; int y = 20; 
            Console.WriteLine("\nBefore swapping");
            Console.WriteLine($"X={x} \n Y={y}");
            Program.swap(ref x, ref y);
            Console.WriteLine("\nafter swapping");
            Console.ReadLine();
            Console.WriteLine($"X={x} \n Y={y}");
            Console.ReadLine();
        }
    }
}


In the above program i am using ref so out is like ref onnly but they are not intilized like ref they are empty variables 
so grocery shop example going to shop buying things giving your  own bag for storing grocieris is out but if they are 
giving bag it is ref 

so i am sending empty variables in a call and i am intilizing in function so 


	namespace Csharp7And8newfeatures_outtypeparamterdemo
{
    internal class Program
    {
        public static void swap(out int x, out int y)
        {
        
          //what to swap so provide values here so 
            x = 10;
            y = 20;
            Console.WriteLine("\nBefore swapping");
            Console.WriteLine($"X={x} \n Y={y}");
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            // here press enter two times to see the result 
            int x, y;// as out variables cannot be initlazed as  u are sending them as out in 
            // function call ..
          //  int x = 10; int y = 20; 
            //Console.WriteLine("\nBefore swapping");
            //Console.WriteLine($"X={x} \n Y={y}");
            Program.swap(out x, out y);
            Console.WriteLine("\nafter swapping");
            Console.ReadLine();
            Console.WriteLine($"X={x} \n Y={y}");
            Console.ReadLine();
        }
    }
}


Discard demo
--------------
i want to forget some proeprties while doing destructuring the object

namespace C__newfeature_Discardemo
{
    internal class Program
    {
        static (string Name,int Age,bool IsActive) GetPersonInfo()
        {
            return ("John Doe", 30, true);
        }
        static void Main(string[] args)
        {
            var person = GetPersonInfo();
            Console.WriteLine($"Name:{person.Name},Age:{person.Age},IsActive:{person.IsActive}");

            var (name, age, isactive) = person;
            Console.WriteLine($"Name:{name},Age:{age},IsActive:{isactive}");

            // i want to destructure also also want to ignore some value like age 

            var (name1,_, isactive1) = person;
            Console.WriteLine($"Name:{name1},IsActive:{isactive1}");

            Console.ReadLine();
        }
    }
}

Expression bodided demo
-----------------------
suppose i have to program like this below leaving namespace copy only classes 

namespace Charp7and8features_expressionbodied
{
   
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Method
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        // Read-only property
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        // Finalizer (destructor)
        ~Person()
        {
            Console.WriteLine("Person object is being destroyed.");
        }
        
        public static void add(int a ,int b)
        {
        Console.WriteLine($"The sum is {a+b}");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new person using expression-bodied constructor
            var person = new Person("John", "Doe");

            // Using expression-bodied method
            Console.WriteLine($"Full Name (method): {person.GetFullName()}");

            // Using expression-bodied property
            Console.WriteLine($"Full Name (property): {person.FullName}");



            // Destructor will run at the end when the program terminates
        }
    }
}


using expression bodided 
---------------------------
// here added code for add also 
namespace C__newfeatures_Expressionbodieddemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor
        public Person(string firstName, string lastName) => (FirstName, LastName) = (firstName, lastName);


        // Method
        public string GetFullName() => $"{FirstName} {LastName}";


        // Read-only property
        public string FullName => $"{FirstName}--{LastName}";


        // Finalizer (destructor)
        ~Person() => Console.WriteLine("Person object is being destroyed.");

        //add method usng expression bodied 
        public static  void add(int a, int b) => Console.WriteLine($"The sum is {a + b}");

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new person using expression-bodied constructor
            var person = new Person("John", "Doe");

            // Using expression-bodied method
            Console.WriteLine($"Full Name (method): {person.GetFullName()}");

            // Using expression-bodied property
            Console.WriteLine($"Full Name (property): {person.FullName}");

            Person.add(12, 45);

            // Destructor will run at the end when the program terminates
        }
    }
}

Asynchronus Programming
----------------------------
Asynchronus programming means between delays i want to do some other work also genrally  it will not happen so if i make the function async then it will wait
and allow other to do some other work during wait time .

every async method should have await defiend in it okay ..




Two buttons and two labels 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Before dealy";
            //   for (int i = 0; i < 10000; i++) ;
            Task.Delay(10000).Wait();
            label2.Text = "after delay";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("say hello..");
        }
    }
}


second version 
----------------
in the above program i click button 2 and then want to click button1 which it is not allowing 10sec delay is there in that time i 
cannot do any work so i will convert above program to asynchronus means the button 2 code is making delay so that fuction i will make 
it async so add a keyword async to function and any function which is async will have to wait for some time giving preference to other works
so once async method is there then inside it await keyword shoudl be used 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asynchonusprogrammingdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("say hello..");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Before dealy";
            await Task.Delay(10000);
            label2.Text = "after delay";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
         
         +label2.Text = "";
        }
    }
}

Reflection :
____________
I want to see the code which is written behind the exe file which i cannot see means i want to know what functions are used 
so to do that i use reflection .

C# has got three interelated powerful features: runtime type identification, 
reflection, and attributes. Runtime type ID is the mechanism that lets you identify a type during 
the execution of a program. Reflection is the feature that enables you to obtain information about 
a type. Using this information, you can construct and use objects at runtime. This feature is very 
powerful because it lets a program add functionality dynamically, during execution. An attribute 
describes a characteristic of some element of a C# program. For example, you can specify 
attributes for classes, methods, and fields, among others. Attributes can be interrogated at 
runtime, and the attribute information obtained. Attributes use both runtime type identification 
and reflection.

Testing a Type with is 
You can determine if an object is of a certain type by using the is operator. Its general form is 
shown here: 
•  expr is type  
Here, expr is an expression whose type is being tested against type. If the type of expr is the same 
as, or compatible with, type, then the outcome of this operation is true. Otherwise, it is false. 
Thus, if the outcome is true, expr can be cast to type.  


create one consoleapplication of .net framework 
and include the classes what i have given below means put the class in the namespaces means above program class but within your namespace 

public abstract class Song
    {
        public void ResumeSong()
        {
            Console.WriteLine("Song Playing..");
        }
        abstract public Song PlaySong { get; set; }
        abstract public bool StopSong { get; set; }
        abstract public bool RemoveSong { get; set; }
        abstract public int SongCount { get; set; }
    }
    class A
    {

    }
    class B : A
    {

    }
    class MyClass
    {
        int x;
        int y;
        public MyClass()
        {

        }
        public MyClass(int i, int j)
        {
            x = i;
            y = j;
        }

        public MyClass(MyClass c)
        {
            this.x = c.x;
            this.y = c.y;
        }

        public int sum()
        {
            return x + y;
        }

        public bool isBetween(int i)
        {
            if (x < i && i < y) return true;
            else return false;
        }

        public void set(int a, int b)
        {
            x = a;
            y = b;
        }

        public void set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }

        public void show()
        {
            Console.WriteLine(" x: {0}, y: {1}", x, y);
        }
    }

which will look like this after adding 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{

    public abstract class Song
    {
        public void ResumeSong()
        {
            Console.WriteLine("Song Playing..");
        }
        abstract public Song PlaySong { get; set; }
        abstract public bool StopSong { get; set; }
        abstract public bool RemoveSong { get; set; }
        abstract public int SongCount { get; set; }
    }
    class A
    {

    }
    class B : A
    {

    }
    class MyClass
    {
        int x;
        int y;
        public MyClass()
        {

        }
        public MyClass(int i, int j)
        {
            x = i;
            y = j;
        }

        public MyClass(MyClass c)
        {
            this.x = c.x;
            this.y = c.y;
        }

        public int sum()
        {
            return x + y;
        }

        public bool isBetween(int i)
        {
            if (x < i && i < y) return true;
            else return false;
        }

        public void set(int a, int b)
        {
            x = a;
            y = b;
        }

        public void set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }

        public void show()
        {
            Console.WriteLine(" x: {0}, y: {1}", x, y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

Now i will do coding in main program where i will use reflection namespce classes 

using System.Reflection;  // add this namespace in order to use reflection functions and classes 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ReflectionDemo
{

    public abstract class Song
    {
        public void ResumeSong()
        {
            Console.WriteLine("Song Playing..");
        }
        abstract public Song PlaySong { get; set; }
        abstract public bool StopSong { get; set; }
        abstract public bool RemoveSong { get; set; }
        abstract public int SongCount { get; set; }
    }
    class A
    {

    }
    class B : A
    {

    }
    class MyClass
    {
        int x;
        int y;
        public MyClass()
        {

        }
        public MyClass(int i, int j)
        {
            x = i;
            y = j;
        }

        public MyClass(MyClass c)
        {
            this.x = c.x;
            this.y = c.y;
        }

        public int sum()
        {
            return x + y;
        }

        public bool isBetween(int i)
        {
            if (x < i && i < y) return true;
            else return false;
        }

        public void set(int a, int b)
        {
            x = a;
            y = b;
        }

        public void set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }

        public void show()
        {
            Console.WriteLine(" x: {0}, y: {1}", x, y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();  
            B b = new B();
            if(a is A)
            {
                Console.WriteLine("a is the object of A class ");
            }
            if(b is A)
            {
                Console.WriteLine("b is in A becasue derived from A");
            }
            // suppose i want to types of .net framework assembllies
            Type t = typeof(StreamWriter);
            Console.WriteLine($"{t.FullName}");
            Type t2 = typeof(Song);
            if(t2.IsClass)
            {
                Console.WriteLine("yes it is a class");
            }
            if(t2.IsAbstract)
            {
                Console.WriteLine("yes it is abstract");
            }
            else
            {
                Console.WriteLine("it is concnrete class");
            }

            Type tt = typeof(MyClass);
            Console.WriteLine($"checking methods in {tt.Name} class");
            Console.WriteLine("Methods involved....");
            Console.WriteLine("---------------------");
             MethodInfo[] mi= tt.GetMethods(BindingFlags.Instance |
                BindingFlags.Public | BindingFlags.DeclaredOnly);
            foreach (MethodInfo m in mi)
            {
                Console.Write($"{m.ReturnType.Name}  {m.Name}(");
                ParameterInfo[] pi = m.GetParameters();
                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write($"{pi[i].ParameterType.Name} {pi[i].Name}");
                    if (i + 1 < pi.Length)
                    {
                        Console.Write(",");
                    }
                  
                   
                }
                Console.WriteLine(")");
                Console.WriteLine();
            }
            //for reading all constructors in my class MyClass 
            ConstructorInfo[] ci = tt.GetConstructors(BindingFlags.Instance |
                BindingFlags.Public | BindingFlags.DeclaredOnly);

            // for constructors
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("constructors involved ..");
            foreach (ConstructorInfo c in ci)
            {
                Console.Write($" {c.Name}(");
                ParameterInfo[] pi1 = c.GetParameters();
                for (int i = 0; i < pi1.Length; i++)
                {
                    Console.Write($"{pi1[i].ParameterType.Name}  {pi1[i].Name}");
                    if (i + 1 < pi1.Length) Console.Write(" ,");
                }
                Console.WriteLine(")");
                Console.WriteLine();
            }
            // for song getting the type and read its properties as per the lab question 
            Console.WriteLine("\n..reading the song proeprties which is lab 1 question");
            Type ts = typeof(Song);

            PropertyInfo[] pif = ts.GetProperties(BindingFlags.DeclaredOnly |
                               BindingFlags.Instance |
                               BindingFlags.Public);

            Console.WriteLine("\nvirtual proeprties in song class ");
            Console.WriteLine("----------------------------------");
            foreach (PropertyInfo p in pif)
            {
                Console.Write($"{p.Name}  (type  ");

                if (p.PropertyType.IsClass)
                {
                    Console.Write($"{p.PropertyType.Name} )\n");
                }
                else
                {
                    Console.Write($"{p.PropertyType} )\n");
                }

            }

            Console.ReadLine();

        }
    }
}

if u want to know graphically without writing a code inside the exe what classes and method have been used then
goto visual studio command promt and type the command as  ILDASM and then open file and open any dll file of application 
u can see in ILDASM all the metods and constructors inside it .



