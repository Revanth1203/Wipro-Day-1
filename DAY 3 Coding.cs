using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("\nprinting the array ...");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
        }
        static void Main(string[] args)
        {

            int[] aa1 = new int[] {12,34,56,33,45,90};//infinite array no limit
            int[] aa2 = new int[4] { 12, 34, 56, 90 };// finite array as 4 is limit
            // in both the above arrays i am declaring also and intilizing also there only 
            int[] aa3 = new int[4];// only declaring array array is there but empty 
            string[] names = new string[] { "ravi", "kumar", "sita" };
            char[] chars = new char[] { 'A', '*', 'D' };
            var names2= new string[] { "ravi", "kumar", "sita" };

            int[] a = new int[5];//declared but not read or intilized 
            //so now reading the array i want to do 
            Console.WriteLine("Enter values in array :");

            int i, j, sum = 0;
            for(i=0;i<a.Length;i++)
            {
                Console.Write($"Enter element {i + 1}:");
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            PrintArray(a);
            Console.Write("\n finding sum of elements in array :");
            for(i=0;i<a.Length;i++)
            {
                sum=sum +a[i];
            }
            Console.Write($"{sum}");
            Console.ReadLine();
        }
    }
}
I can use another loop to print the array which is foreach loop which is read only loop means i cannot modify the array if i am using 
for each loop but using for loop i can modify the array also let us see by putting some code in above programming whic i am doing 
----------------------------------------------------------------------------------
 Console.WriteLine("\n printing the array using for each loop");
 foreach(int ele in a)
 {
     Console.Write($"{ele}  ");
 }

Modiying the array 
----------------------
 Console.WriteLine("\n Modifying array using for loop");
 for(i=0;i<a.Length;i++)
 {
     a[i] = a[i] * 3;
 }
 PrintArray(a);
 
 searching an element in the array 
 ------------------------------------
  Console.WriteLine("\n Enter element to be searched in the array..");
 int ele1 = Convert.ToInt32(Console.ReadLine());
 int flag = 0;
 for(i=0;i<a.Length;i++)
 {
     if (a[i] == ele1)
     {
         Console.WriteLine($"The element {ele1} is found at position {i + 1}");
         flag = 1;
         break;
     }
    
 }
 if (flag == 0)
 {
     Console.WriteLine($"The element {ele1} is not found in the array..");
 }
 

sorting the array 
----------------------
 Console.WriteLine("\n Sorting the array ..");
 for(i=0;i<a.Length-1;i++)
 {
     for(j=i+1;j<a.Length;j++)
     {
         if (a[i]>a[j])
         {
             int temp;
             temp = a[i];
             a[i] = a[j];    
             a[j] = temp;
         }
     }
 }
 Console.WriteLine("\n after sorting printing the array..");
 PrintArray(a);  


complete code 
-----------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{

     public  class Customer
      {
          public int  customerid;
          public string customername;
      }
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("\nprinting the array ...");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
        }
        static void Main(string[] args)
        {

            int[] aa1 = new int[] {12,34,56,33,45,90};//infinite array no limit
            int[] aa2 = new int[4] { 12, 34, 56, 90 };// finite array as 4 is limit
            // in both the above arrays i am declaring also and intilizing also there only 
            int[] aa3 = new int[4];// only declaring array array is there but empty 
            string[] names = new string[] { "ravi", "kumar", "sita" };
            char[] chars = new char[] { 'A', '*', 'D' };
            var names2= new string[] { "ravi", "kumar", "sita" };

            int[] a = new int[5];//declared but not read or intilized 
            //so now reading the array i want to do 
            Console.WriteLine("Enter values in array :");

            int i, j, sum = 0;
            for(i=0;i<a.Length;i++)
            {
                Console.Write($"Enter element {i + 1}:");
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            PrintArray(a);
            Console.Write("\n finding sum of elements in array :");
            for(i=0;i<a.Length;i++)
            {
                sum=sum +a[i];
            }
            Console.Write($"{sum}");
            Console.WriteLine("\n printing the array using for each loop");
            foreach(int ele in a)
            {
                Console.Write($"{ele}  ");
            }
            Console.WriteLine("\n Modifying array using for loop");
            for(i=0;i<a.Length;i++)
            {
                a[i] = a[i] * 3;
            }
            PrintArray(a);
            Console.WriteLine("\n Enter element to be searched in the array..");
            int ele1 = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for(i=0;i<a.Length;i++)
            {
                if (a[i] == ele1)
                {
                    Console.WriteLine($"The element {ele1} is found at position {i + 1}");
                    flag = 1;
                    break;
                }
               
            }
            if (flag == 0)
            {
                Console.WriteLine($"The element {ele1} is not found in the array..");
            }
            Console.WriteLine("\n Sorting the array ..");
            for(i=0;i<a.Length-1;i++)
            {
                for(j=i+1;j<a.Length;j++)
                {
                    if (a[i]>a[j])
                    {
                        int temp;
                        temp = a[i];
                        a[i] = a[j];    
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n after sorting printing the array..");
            PrintArray(a);
            Console.WriteLine("\n using in built function of Array class i can reverse the array");
            Array.Reverse(a);
            Console.WriteLine("\n after reversing printing the array");
            PrintArray(a);
                 PrintArray(a);
          //   int[] aa5 = new int[3];
             Customer[] custlist=new Customer[3];
            Console.ReadLine();
        }
    }
}

Final complete code 
-----------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
     public  class Customer
    {
        public int  customerid;
        public string customername;
    }
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("\nprinting the array ...");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
        }
        static void Main(string[] args)
        {

            int[] aa1 = new int[] {12,34,56,33,45,90};//infinite array no limit
            int[] aa2 = new int[4] { 12, 34, 56, 90 };// finite array as 4 is limit
            // in both the above arrays i am declaring also and intilizing also there only 
            int[] aa3 = new int[4];// only declaring array array is there but empty 
            string[] names = new string[] { "ravi", "kumar", "sita" };
            char[] chars = new char[] { 'A', '*', 'D' };
            var names2= new string[] { "ravi", "kumar", "sita" };

            int[] a = new int[5];//declared but not read or intilized 
            //so now reading the array i want to do 
            Console.WriteLine("Enter values in array :");

            int i, j, sum = 0;
            for(i=0;i<a.Length;i++)
            {
                Console.Write($"Enter element {i + 1}:");
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            PrintArray(a);
            Console.Write("\n finding sum of elements in array :");
            for(i=0;i<a.Length;i++)
            {
                sum=sum +a[i];
            }
            Console.Write($"{sum}");
            Console.WriteLine("\n printing the array using for each loop");
            foreach(int ele in a)
            {
                Console.Write($"{ele}  ");
            }
            Console.WriteLine("\n Modifying array using for loop");
            for(i=0;i<a.Length;i++)
            {
                a[i] = a[i] * 3;
            }
            PrintArray(a);
            Console.WriteLine("\n Enter element to be searched in the array..");
            int ele1 = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for(i=0;i<a.Length;i++)
            {
                if (a[i] == ele1)
                {
                    Console.WriteLine($"The element {ele1} is found at position {i + 1}");
                    flag = 1;
                    break;
                }
               
            }
            if (flag == 0)
            {
                Console.WriteLine($"The element {ele1} is not found in the array..");
            }
            Console.WriteLine("\n Sorting the array ..");
            for(i=0;i<a.Length-1;i++)
            {
                for(j=i+1;j<a.Length;j++)
                {
                    if (a[i]>a[j])
                    {
                        int temp;
                        temp = a[i];
                        a[i] = a[j];    
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n after sorting printing the array..");
            PrintArray(a);
            Console.WriteLine("\n using in built function of Array class i can reverse the array");
            Array.Reverse(a);
            Console.WriteLine("\n after reversing printing the array");
            PrintArray(a);
         //   int[] aa5 = new int[3];
            Customer[] custlist=new Customer[3];
            Console.WriteLine("\n Enter Customer details ");
            for(i=0;i<custlist.Length;i++)
            {
                Customer c = new Customer();
                Console.WriteLine($"Enter Customer {i + 1} details");
                Console.WriteLine("Enter customer id :");
                c.customerid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter customer name:");
                c.customername = Console.ReadLine();
                custlist[i] = c;

            }
            Console.WriteLine("\n printing the customer array");
            foreach(Customer cust in custlist)
            {
                Console.WriteLine($"{cust.customerid}--{cust.customername}");
            }
            Console.ReadLine();
        }
    }
}

Assignment do it 
--------------------
in the above customer class try to update and delete the customer ask the id and update name and again ask the id and delete the customer from the array 

2d array demo
--------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2darraydemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0;
            Console.WriteLine("----------------------------");
            for(i=1;i<=5;i++)
            {
                for(j=1;j<=i; j++)
                {
                    Console.Write($"{j}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
            int[,] a = new int[3,3];//declaring 2d array 
           
            int[,,] aa = new int[3, 3, 3];// 3d array where height is also there 

            Console.WriteLine("enter elements in 2d array..");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"enter [{i + 1},{j + 1}] element:");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nPrinting an array");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]}  ");

                }
                Console.Write("\n");
            }

            Console.WriteLine("\n sum of elelemts in matrix");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    sum = sum + a[i, j];
                }

            }
            Console.WriteLine($"\nn the sum is {sum}");
            // if u dont know the length of 2 d aaary 

            Console.WriteLine("enter array elements in 2d array ");
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"enter [{i + 1},{j + 1}] element :  ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.ReadLine();
        }
    }
}

-------------Jagged array -----------------
when i want to decide at run time in each row different  number of columns then jagged array 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, j;
            int[][] jgArray = new int[4][];
            jgArray[0] = new int[2] { 12, 45 };
            jgArray[1] = new int[3] { 11, 33, 56 };
            jgArray[2] = new int[1] { 100 };
            jgArray[3] = new int[5] { 11, 22, 33, 44, 55 };

            Console.WriteLine("\n Displaying jagged array ...");
            for(i=0;i<jgArray.Length;i++)
            {
                Console.WriteLine($"I am in row :{i + 1} and having {jgArray[i].Length} elements");
                for(j=0;j<jgArray[i].Length;j++)
                {
                    Console.WriteLine($"{jgArray[i][j]}");
                }
            }

            Console.ReadLine();
        }
    }
}


-------------------if u want to read this jagged array also then this program-------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray
{
     class Program
    {
        static void Main(string[] args)
        {
            int[][] jgArray=new int[4][];
            int i, j;

            //jgArray[0] = new int[2] { 12, 34 };
            //jgArray[1] = new int[1] { 1000 };
            //jgArray[2] = new int[4] { 20,78,14,76 };
            //jgArray[3] = new int[3] { 11,33,51};
            
            Console.WriteLine("read from the user ..");
            for (i = 0; i < jgArray.Length; i++)
            {
                Console.WriteLine($"\n I am in row :{i + 1} asking u to enter  ");
                   
                Console.WriteLine("\nenter columns or elemnts in the row ");
                int colsize = Convert.ToInt32(Console.ReadLine());
                jgArray[i] = new int[colsize];
                for (j = 0; j < jgArray[i].Length; j++)
                {
                    Console.WriteLine($"\nenter element at [{i+1},{j+1}]");
                    jgArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            //displayng jagged array 
            Console.WriteLine("\n displaying jagged array ");
            for(i=0;i<jgArray.Length;i++)
            {
                Console.WriteLine($"I am in row : {i + 1} an having {jgArray[i].Length}");
                for(j=0;j<jgArray[i].Length;j++)
                {
                    Console.WriteLine($"{jgArray[i][j]}  ");
                }
            }

            Console.ReadLine();
        }
    }
}

string builder demo 
-------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    internal class Program
    {
        public static void equalsexamples()
        {
            string s1 ="hello";
            string s2 = "hello";
            string s3 = "kkk";
            
            Console.WriteLine($"s1: {s1} (HashCode: {s1.GetHashCode()})");
            // here hello is stored in same address when ever i create a same varibale 
            // it will stored in pool ..
            // and when two pointers point actually they are poininting to same adress 
            // proff is hashcode here 
            //== will check the direction and equals will check the content 
            
            Console.WriteLine($"s2: {s2} (HashCode: {s2.GetHashCode()})");
           
            Console.WriteLine($"{s1.Equals(s2)}");
            Console.WriteLine($"{s1 == s2}");
            s1 =s3;
            Console.WriteLine($"{s1 == s2}");
          
          
            Console.WriteLine($"{s1 == s3}");

        }
        public static void concat1(string s1)
        {
            string st = " world";
            s1 = s1 + st;
        }

        public static void concat2(StringBuilder  sb1)
        {
            sb1.Append(" Everyone");
        }
        static void Main(string[] args)
        {
            //string is immutable means string i cannot change them but i can override them within themselves 
            //string is reference type and small string or capital String is same only same methods refflect 
            string  orginal = "Raghavendra";
            string k= orginal.Substring(0, 6);// orginal string is undergone operation of substring
            Console.WriteLine($"The orginal string is {orginal} (HashCode: {orginal.GetHashCode()} ");// it has not changed and it is in some address
            Console.WriteLine($"The extracted string is {k} (HashCode: {k.GetHashCode()}");// it is extracted string 
            // i can override the string and even after overriding it will change the address
            //
           

            orginal = orginal.Substring(0, 5); //override i am doing but it will store it in new address 
            Console.WriteLine($"New String: {orginal} (HashCode: {orginal.GetHashCode()})");
            // so here lot of memory is wasted as we are created many string object it shoudl be like 
            // that one time we have to create the object and in that object only we have to append the data 

            string fname;
            string mname;
            string lname;

            Console.WriteLine("enter firstname :");
            fname=Console.ReadLine();
            Console.WriteLine("enter middle name :");
            mname = Console.ReadLine();
            Console.WriteLine("Enter last name ");
            lname = Console.ReadLine();

            string fullname = fname + " " + mname + " " + lname;

            Console.WriteLine($"{fullname}");
            string fullname2 = string.Concat(fname, " ", mname, " ", lname);
            Console.WriteLine($"{fullname2.ToUpper()}");
            Console.WriteLine("Enter new fname to be replced ");
            string newfname = Console.ReadLine();
            Console.WriteLine($"The new full name is {fullname.Replace(fname, newfname)}");

            StringBuilder sb=new StringBuilder("Mohan ");
            
            sb.Append("kumar ");
            sb.Append("Mishra");
            Console.WriteLine($"{sb.ToString()}");
            // another example showing string is immutable and string builder is mutable 
            string s1 = "Hello";
            StringBuilder sb2 = new StringBuilder("hai ");
            concat1(s1);
            concat2(sb2);
            Console.WriteLine($"{s1}--{sb2}");
            equalsexamples();


            string[] weekdays =
                new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            // i want the output like this 
            // Monday ,Tuesday ,Wednesday ,Thursday,Friday ,Saturday and Sunday but it will not happen as it is
            // immutable 
            // it will if i overrdie the array but wihtout overrding i want to  modify means i will keept this array 
            // in string buildwer and will modify 

            StringBuilder sb3 = new StringBuilder();
            for (int i = 0; i < weekdays.Length; i++)
            {
                sb3.Append(weekdays[i]);
                if (i < weekdays.Length - 2)
                {
                    sb3.Append(',');// while displaying 
                }
                else if (i == weekdays.Length - 2)
                {
                    sb3.Append(" and ");
                }
            }
            Console.WriteLine(sb3.ToString());
            Console.ReadLine();

        }
    }
}



Access Modifiers 
-----------------
Access Modifiers or specifiers :
---------------------------------
private ,public ,protected ,internal and protected internal 

so this comes under encapsulation data hiding which part of the program i want to show 
and which i want to hide is decided by these access specifiers in the program .


private : directly cannot access this u need set and get methods (Be defualt it is private if u dont give any access specifier )

public : can be accessible outside the class 

protected : only sub class can access the variable defined as protected in base class 

internal : you can access within the assembly or within the namespace only .

protected internal : you can access across assembly but it should be inherited .

when u have an entry point function like main .exe file will be created and when 
you have normal class a dll file will be created . so you cannot execute dll file it can be used as an component in some other program or in an exe.

so in this what u do 	create an or add a project of new as clas library and
inside that class create a varibale as internal and try to access it using adding refernce and
including namespace also then also it will not highlight and same thing making it protected internal and 
inheriting in main progam the class then 	it will highlight eventhough u are from seperate assembly .

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class abcd
    {
        private int a;
        public int b=2;
        protected int c=3;

        public void seta(int k)
        {
            this.a = k;
        }

        public int geta()
        {
            return this.a;
        }

    }
     class Program:abcd
    {
        static void Main(string[] args)
        {
            abcd abcdobj = new abcd();
            Program pp = new Program();
            //and see which can be accessed which cannot 
            // i can touch and display b using both class objects as it is public 
            Console.WriteLine($"b i can touch using base class obj and display {abcdobj.b}");
            Console.WriteLine($"b i can touch using sub class obj and display {pp.b}");
            // i cannot do this 
            //abcdobj.a  // error private...
            //pp.a // error private
            // abcdobj.c // error only sub class can use even it is there in main class 
            Console.WriteLine($"c i can touch using sub class obj and display {pp.c}");
           // Console.WriteLine($"{abcd.c}"); //error

            pp.seta(1);
            Console.WriteLine($"{pp.geta()}");
            Console.ReadLine();

        }
    }
}


add a new project of class libary let the name be same dont change 

and there just declaing one internal varibale d ;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        internal int d = 4; 
    }
}

now from earier program i want to touch and print d variable which is internal 
for that i will build and add referecne and will try to touch and print d variable 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace AccessModifiers
{
    class abcd
    {
        private int a;
        public int b=2;
        protected int c=3;

        public void seta(int k)
        {
            this.a = k;
        }

        public int geta()
        {
            return this.a;
        }

    }
     class Program:abcd
    {
        static void Main(string[] args)
        {
            abcd abcdobj = new abcd();
            Program pp = new Program();
            //and see which can be accessed which cannot 
            // i can touch and display b using both class objects as it is public 
            Console.WriteLine($"b i can touch using base class obj and display {abcdobj.b}");
            Console.WriteLine($"b i can touch using sub class obj and display {pp.b}");
            // i cannot do this 
            //abcdobj.a  // error private...
            //pp.a // error private
            // abcdobj.c // error only sub class can use even it is there in main class 
            Console.WriteLine($"c i can touch using sub class obj and display {pp.c}");
           // Console.WriteLine($"{abcd.c}"); //error

            pp.seta(1);
            Console.WriteLine($"{pp.geta()}");
            // even after adding referecne of dll i cannot touch and print d varibale

            //pp.d;
            //abcdobj.d;

            Console.ReadLine();

        }
    }
}


Now i want to access d now if u inherit then u can access and that variable should be protected internal 

Now i want to access d now if u inherit then u can access and that variable should be protected internal 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
       protected internal int d = 4;
    }
}

again build once class library as change in code has happened 

now let us go to acces modider code


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace AccessModifiers
{
    class abcd
    {
        private int a;
        public int b=2;
        protected int c=3;

        public void seta(int k)
        {
            this.a = k;
        }

        public int geta()
        {
            return this.a;
        }

    }
     class Program:Class1 //abcd
    {
        static void Main(string[] args)
        {
            abcd abcdobj = new abcd();
            Program pp = new Program();
            //and see which can be accessed which cannot 
            // i can touch and display b using both class objects as it is public 
            Console.WriteLine($"b i can touch using base class obj and display {abcdobj.b}");
            //  Console.WriteLine($"b i can touch using sub class obj and display {pp.b}");
            // i cannot do this 
            //abcdobj.a  // error private...
            //pp.a // error private
            // abcdobj.c // error only sub class can use even it is there in main class 
            //   Console.WriteLine($"c i can touch using sub class obj and display {pp.c}");
            // Console.WriteLine($"{abcd.c}"); //error

            //  pp.seta(1);
            // Console.WriteLine($"{pp.geta()}");
            // even after adding referecne of dll i cannot touch and print d varibale


            //abcdobj.d;

            Console.WriteLine($"Now i can touch and print {pp.d}");

            Console.ReadLine();

        }
    }
}


if pp.d is not working what u do delete dll build once again and add it refercne agai 









