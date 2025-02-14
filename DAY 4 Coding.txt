Properties demo 
----------------
version 1 
--------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiesdemo
{
    class Customer
    {
        private int customerid;
        private string customername;
        public void setcustomerid(int k)
        {
            this.customerid = k;
        }
        public void setcustomername(string name1)
        {
            this.customername = name1;      
        }
        public int getcustomerid() 
         {
                return this.customerid; 
         }
        public string getcustomername()
        {
            return this.customername;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.setcustomerid(101);
            c1.setcustomername("sudha");
            Console.WriteLine($"{c1.getcustomerid()}---{c1.getcustomername()}");
            Console.ReadLine();
        }
    }
}

version 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiesdemo
{
    class Customer
    {
        private int customerid;
        private string customername;
        public int CUSTID  // using CUSTID proeprty u will fill customerid which is private 
        {
            set
            {
                customerid = value;//here value means externally u will put some value
            }
            get
            {
                return customerid;
            }
        }

        public string CUSTNAME
        {
            set
            {
                customername = value;
            }
            get
            {
                return customername;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.CUSTID = 101;//setting
            c1.CUSTNAME = "Ravi";
            Console.WriteLine($"{c1.CUSTID}--{c1.CUSTNAME}");
            Console.ReadLine();

        }
    }
}

Now i want to have only read only property means get i dont want set (version 3)
-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiesdemo
{
    class Customer
    {
        private int customerid;
        private string customername;
        public Customer(int custid1,string custname)
        {
            this.customerid = custid1;
            this.customername = custname;
                
        }
        public int CUSTID  // using CUSTID proeprty u will fill customerid which is private 
        {
         
            get
            {
                return customerid;
            }
        }

        public string CUSTNAME
        {
           
            get
            {
                return customername;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(101,"Mohan");
           
            Console.WriteLine($"{c1.CUSTID}--{c1.CUSTNAME}");
            Console.ReadLine();

        }
    }
}


I want only write proeprty i dont want to read it then (version 4)
------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiesdemo
{
    class Customer
    {
        private int customerid;
        private string customername;
      
        public int CUSTID  // using CUSTID proeprty u will fill customerid which is private 
        {
            set
            {
                customerid = value;//here value means externally u will put some value
            }
          
        }

        public string CUSTNAME
        {
            set
            {
                customername = value;
            }
          
        }

        public void displaycustomer()
        {
            Console.WriteLine($"{this.customerid}--{this.customername}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.CUSTID = 101;
            c1.CUSTNAME = "Mahesh";
            c1.displaycustomer();
     
            Console.ReadLine();

        }
    }
}

----------------------Auto Implemented proeprties ---------------------------

version 5
-----------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiesdemo
{
    class Customer
    {
        // internally it will create public proeprty and private variable with the same name 
        // short cut implementation of above properties latest things is using this only 
        public int  CustomerID { set; get; }
        public  string  CustomerName { set; get; }   
      
       

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.CustomerID = 101;
            c1.CustomerName = "Shanthi";
            Console.WriteLine($"{c1.CustomerID}--{c1.CustomerName}");

     
            Console.ReadLine();

        }
    }
}



Next come to the concept of static now ....

static is a modifier means how i am using that function it tells or how i am using that varibale it tells 

static mean it will not change 

we have static varibles and we have static functions 

so one static variable one program and on static function one program we will see 

Static :
---------
A static variable will remeber its value .It will not referesh for every call.

Inside a class if there are static variables and static methods then all the objects 
of that class will share those static variables and methods .

A static memeber of a class can be called directly using a classname

Inisde a static function by default all memebers are static but if u want to use 
a non static function inside a static function u need to declare an object of a class and use it .

You can call all static methods and varibles directly by using a classname.varibale or function if u are outsid of the class 




A static function is called implictly .

Below is program on static variable .

here non static methods are nothing but instance methods okay ..


static variable demo
-----------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staticvariabledemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class JointAccount
        {
         static   int balance = 10000;  // it shoudl be static 
            public void withdraw(int amt)
            {
                balance = balance - amt;
                MessageBox.Show("The Current balance : " + balance);
            }
        }
          private void button1_Click(object sender, EventArgs e)
          {
              JointAccount account = new JointAccount();
              account.withdraw(Convert.ToInt32(textBox1.Text));
          }

          private void button2_Click(object sender, EventArgs e)
          {
              JointAccount account = new JointAccount();
              account.withdraw(Convert.ToInt32(textBox1.Text));
        }
    }
}

in the above code balance shoud be static why because it is jointaccount and it should remebers previous value and it should be common for both 



static function demo (console app )
-----------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfunctiondemo
{
    class abcd
    {
        int a = 1;
        public void count()
        {
            a = a + 1;
            Console.WriteLine($"The value of a : {a}");
        }
    }
     class Program
    {
        static void Main(string[] args)
        {



        }
    }
}

bassic program above so now what i will do now 

Non static to static  outside the class declare the object and use it 
-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfunctiondemo
{
    class abcd
    {
        int a = 1;
        public void count()
        {
            a = a + 1;
            Console.WriteLine($"The value of a : {a}");
        }
    }
     class Program
    {
        static void Main(string[] args)
        {

            abcd obj = new abcd();
            obj.count();
            Console.ReadLine();

        }
    }
}


Non static to static inside the class we have to declare the object and use it like earleir 
----------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfunctiondemo
{
    class abcd
    {
        int a = 1;
        public void count()
        {
            a = a + 1;
            Console.WriteLine($"The value of a : {a}");
        }
        static void Main(string[] args)
        {

            abcd obj = new abcd();
            obj.count();
            Console.ReadLine();

        }
    }
     class Program
    {
       
    }
}


static to static within the class directly i can use function 
---------------------------------------------------------------
// but u can see that non static variable is used in static function count by declaring object okay means taking permission 
// as non static to static even in varibale we have to declare and use it means taking permisiion is declaring object 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfunctiondemo
{
    class abcd
    {
        int a = 1;
        public static void count()
        {
            abcd obj = new abcd();// here again non static variable is used in static function 
            obj.a = obj.a + 1;
            Console.WriteLine($"The value of a : {obj.a}");
        }
        static void Main(string[] args)
        {

           
           count();// drectly i can call 
            Console.ReadLine();

        }
    }
     class Program
    {
       
    }
}


static to static outisde the class we will class name 
-------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfunctiondemo
{
    class abcd
    {
        int a = 1;
        public static void count()
        {
            abcd obj = new abcd();// here again non static variable is used in static function 
            obj.a = obj.a + 1;
            Console.WriteLine($"The value of a : {obj.a}");
        }
      
    }
     class Program
    {
        static void Main(string[] args)
        {


            abcd.count();// static to static outside the class use classname
            Console.ReadLine();

        }
    }
}

finally all static  outside class 
----------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfunctiondemo
{
    class abcd
    {
        static int a = 1;
        public static void count()
        {
           
            a = a + 1;
            Console.WriteLine($"The value of a : {a}");
        }
      
    }
     class Program
    {
        static void Main(string[] args)
        {


            abcd.count();// static to static outside the class use classname
            Console.ReadLine();

        }
    }
}


finally all static  inside  class 
----------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticfunctiondemo
{
    class abcd
    {
        static int a = 1;
        public static void count()
        {
           
            a = a + 1;
            Console.WriteLine($"The value of a : {a}");
        }
        static void Main(string[] args)
        {


            count();// directy can be called 
            Console.ReadLine();

        }

    }
     class Program
    {
       
    }
}


inheritnce demo (multilevel)
----------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritancedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //multi level inheritance
        class Father
        {
            public void maruthicar()
            {
                MessageBox.Show("Maruthi car ...");
            }
        }
        class Son : Father
        {
            public void MBCar()
            {
                MessageBox.Show("Mercedes benz car...");
            }
        }
        class GrandSon:Son
        {
            public void BMWCar()
            {
                MessageBox.Show("BMW car....");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GrandSon grandSon = new GrandSon();
            grandSon.maruthicar();
            grandSon.MBCar();
            grandSon.BMWCar();

        }
    }
}

now hiearchical inheritance 
-----------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritancedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //multi level inheritance
        class Father
        {
            public void maruthicar()
            {
                MessageBox.Show("Maruthi car ...");
            }
        }
        class Son : Father
        {
            public void MBCar()
            {
                MessageBox.Show("Mercedes benz car...");
            }
        }
        class GrandSon:Father
        {
            public void BMWCar()
            {
                MessageBox.Show("BMW car....");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GrandSon grandSon = new GrandSon();
            grandSon.maruthicar();
            grandSon.BMWCar();
            Son son = new Son();
            son.maruthicar();
            son.MBCar();

        }
    }
}


next multiple inheritance is not possible and using base class obje sub class function is not called 
------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritancedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        class Father
        {
            public void maruthicar()
            {
                MessageBox.Show("Maruthi car ...");
            }
        }
        class Son : Father
        {
            public void MBCar()
            {
                MessageBox.Show("Mercedes benz car...");
            }
        }
        class GrandSon:Son//,Father //not possible multiple inheirtance 
        {
            public void BMWCar()
            {
                MessageBox.Show("BMW car....");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GrandSon grandSon = new GrandSon();
            Father fobj = new Father();
            // remove comments and check 
            //fobj.MBCar() // error not possible
            //fobj.BMWCar() // error not possible
            Son sobj = new Son();
            //sobj.BMWCar(); //errro not possible
        }
    }
}


I don't want to overrdie the sub class or i dont want to inherit i dont want other classes to inheirt me then i will make that class as sealed class 
---------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritancedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //multi level inheritance
       sealed class Father
        {
            public void maruthicar()
            {
                MessageBox.Show("Maruthi car ...");
            }
        }
     sealed   class Son : Father
        {
            public void MBCar()
            {
                MessageBox.Show("Mercedes benz car...");
            }
        }
        class GrandSon:Son//,Father not possible 
        {
            public void BMWCar()
            {
                MessageBox.Show("BMW car....");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GrandSon grandSon = new GrandSon();
            Father fobj = new Father();
            // remove comments and check 
            //fobj.MBCar() // error not possible
            //fobj.BMWCar() // error not possible
            Son sobj = new Son();
            //sobj.BMWCar(); //errro not possible
        }
    }
}


you can see error coming in program 

In this .net wont support multiple inheritance due to ambiguity problem.
another limitation  of inheritance is that using the base class object i cant call the sub class function.
objectofbaseclass.functionofsubclass  not possible.

so to overcome first limitation means using base class object i want to call sub class function i will go for abstract class 
and to overcome multiple inheritance which is not possibe i will use interfaces 

so code will be written slowly in abstract class and interface considernig some  scenarios 

syntaxes of abstarct class and interfaces 
-------------------------------------------
syntax:
--------
public abstract class class_name
{
 public  abstract void function_name(parameters list);
 public void function_name( )
  {

  }

}


Interface :
-----------
A pure abstract class is called interface means all the functions inside an interface are by default abstract .we go for interfaces mainly to increase security in programs.

syntax:
-------
interface Interface_name
{
 void function_name1(parmeters_list);
 void function_name2(parmeters_list);

}


code 
--------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstractclassandinterfacedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Polygon
        {
            public void testfunction()
            {
                MessageBox.Show("**************************");
            }
            public abstract void area(int a, int b);// abstarct method 
        }
      class Triangle:Polygon
      {

      }
      class Rectangle:Polygon
      {

      }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


try to override the functionlity graphically by putting cursor and then put your own code for the same concpet of area


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstractclassandinterfacedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Polygon
        {
            public void testfunction()
            {
                MessageBox.Show("**************************");
            }
            public abstract void area(int a, int b);// abstarct method 
        }

        class Triangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of Triangle is :" + 0.5 * a * b);
            }
        }
        class Rectangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of rectangle is :" + (a * b));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // use the base class obj sub classfucntion 
            //  Polygon obj = new Polygon();// error i cannot create an object of abstract class 
            // becuse abstarct class is having partial method means incomplete methoods 
            // i cannot create an object by i can create object reference means

            Polygon obj;// it is a car without a petrol 
            obj = new Triangle();// allocating memory of trianngle class in base class only putting petrol
            obj.area(12, 3);
            obj=new Rectangle();// it can allocate memeory of rectanglealso 
            obj.area(12, 4);
            obj.testfunction();
            // now i can use base class refercne object and i can call sub class function which 
            //is happening here first limitiation of inheritnace is overcome 

        }
    }
}

now another class comes square he is asking me to implement area() in polygon class so for that class area 
the logic is different so triangle and rectangle though they dont want it they have to override it and implement it 
and have to implment so for squre we have to use seperate abstract class 


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstractclassandinterfacedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Polygon
        {
            public void testfunction()
            {
                MessageBox.Show("**************************");
            }
            public abstract void area(int a, int b);// abstarct method 
            public abstract void area(int s);
        }

        class Triangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of Triangle is :" + 0.5 * a * b);
            }
        }
        class Rectangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of rectangle is :" + (a * b));
            }
        }

        class square
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // use the base class obj sub classfucntion 
            //  Polygon obj = new Polygon();// error i cannot create an object of abstract class 
            // becuse abstarct class is having partial method means incomplete methoods 
            // i cannot create an object by i can create object reference means

            Polygon obj;// it is a car without a petrol 
            obj = new Triangle();// allocating memory of trianngle class in base class only putting petrol
            obj.area(12, 3);
            obj=new Rectangle();// it can allocate memeory of rectanglealso 
            obj.area(12, 4);
            obj.testfunction();
            // now i can use base class refercne object and i can call sub class function which 
            //is happening here first limitiation of inheritnace is overcome 

        }
    }
}

so in visual studio  if i do this i will get error in triangle or rectangle not error they have to override another area which is not of 
theri interest so i am asking square class to use another polygon base class of abstract to override it 



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstractclassandinterfacedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Polygon2
        {
            public abstract void area(int s);
        }
        public abstract class Polygon
        {
            public void testfunction()
            {
                MessageBox.Show("**************************");
            }
            public abstract void area(int a, int b);// abstarct method 
          //  public abstract void area(int s);
        }

        class Triangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of Triangle is :" + 0.5 * a * b);
            }
        }
        class Rectangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of rectangle is :" + (a * b));
            }
        }

        class square : Polygon2
        {
            public override void area(int s)
            {
                MessageBox.Show("The area of square is :"+(s*s));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // use the base class obj sub classfucntion 
            //  Polygon obj = new Polygon();// error i cannot create an object of abstract class 
            // becuse abstarct class is having partial method means incomplete methoods 
            // i cannot create an object by i can create object reference means

            Polygon obj;// it is a car without a petrol 
            obj = new Triangle();// allocating memory of trianngle class in base class only putting petrol
            obj.area(12, 3);
            obj=new Rectangle();// it can allocate memeory of rectanglealso 
            obj.area(12, 4);
            obj.testfunction();
            // now i can use base class refercne object and i can call sub class function which 
            //is happening here first limitiation of inheritnace is overcome 
            Polygon2 obj2;
            obj2 = new square();
            obj2.area(12);

        }
    }
}


now a new shape will come he is telling that he wants to implment area of rectangle also
and square also include those mehtods he is telling new shape 

so i will try like this 

 class NewShape:Polygon,Polygon2
 {

 }
 
 I have to do like this because both functionlities are present in different class i have to do 
 multiple inheitance which is not possible there red line is there i can override one functionlity 
 but red line will still show because multiple inheitance is not supported in C#
 
  class NewShape : Polygon, Polygon2
 {
     public override void area(int a, int b)
     {
         throw new NotImplementedException();
     }
 }
 
 still red line is showing as multiple inheritance is not supported 




so what to do ????
use interface 

Interface :
-----------
A pure abstract class is called interface means all the functions inside an interface are by default abstract .we go for interfaces mainly to increase security in programs.

syntax:
-------
interface Interface_name
{
 void function_name1(parmeters_list);
 void function_name2(parmeters_list);

}
so created like this two interfaces in the program 
------------------------------------------------------
  interface A
  {
      // never use public in interface as by default it is public only 
     // int a;//cannot declare varibale 
       int a1 { set; get; }// can declare proepties i will not do anything wiht this a1 variable 
      //public void testfunction()  //error 
      //{
      //    MessageBox.Show("**************************");
      //}
      void area(int a, int b);

  }

  interface B
  {
      void area(int s);
  }

now i will write the full code where newshape will implemnt multiple interfaces 
----------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstractclassandinterfacedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Polygon2
        {
            public abstract void area(int s);
        }
        public abstract class Polygon
        {
            public void testfunction()
            {
                MessageBox.Show("**************************");
            }
            public abstract void area(int a, int b);// abstarct method 
          //  public abstract void area(int s);
        }

        class Triangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of Triangle is :" + 0.5 * a * b);
            }
        }
        class Rectangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of rectangle is :" + (a * b));
            }
        }

        class square : Polygon2
        {
            public override void area(int s)
            {
                MessageBox.Show("The area of square is :" + (s * s));
            }
        }

        //class NewShape : Polygon, Polygon2
        //{
        //    public override void area(int a, int b)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        interface A
        {
            // never use public in interface as by default it is public only 
           // int a;//cannot declare varibale 
           //  int a1 { set; get; }// can declare proepties 
            //public void testfunction()
            //{
            //    MessageBox.Show("**************************");
            //}
            void area(int a, int b);

        }

        interface B
        {
            void area(int s);
        }
        class NewShape : A, B
        {
           
            public void area(int a, int b)
            {
                MessageBox.Show("The are of rectangle is :" + (a * b));
            }

            public void area(int s)
            {
                MessageBox.Show("The area of square is :" + (s * s));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // use the base class obj sub classfucntion 
            //  Polygon obj = new Polygon();// error i cannot create an object of abstract class 
            // becuse abstarct class is having partial method means incomplete methoods 
            // i cannot create an object by i can create object reference means

            Polygon obj;// it is a car without a petrol 
            obj = new Triangle();// allocating memory of trianngle class in base class only putting petrol
            obj.area(12, 3);
            obj=new Rectangle();// it can allocate memeory of rectanglealso 
            obj.area(12, 4);
            obj.testfunction();
            // now i can use base class refercne object and i can call sub class function which 
            //is happening here first limitiation of inheritnace is overcome 
            Polygon2 obj2;
            obj2 = new square();
            obj2.area(12);

            A aobj;
            aobj = new NewShape();
            aobj.area(12, 34);
            B bobj;
            bobj = new NewShape();
            bobj.area(5);

        }
    }
}


Final Note is that you can at a time can inherit with one class that can be abstarct class but you can implment many  interfaces so this is golden line 
This is also possible that one abstarct class and one interface u can use it but both abstarct class u cannot use it 


compile time polymorphism 
-------------------------------------

function overloading 
--------------------
Function overloading
---------------------
 functions having same name but no of arguments ,type of arguments ,order of arguments differs 
and retrn tye will also change

void     add (int x, int y)
 int   add (int x, float f,double kk) 
double    add (int x, decimal kk )


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionoverloading_compiletimepoly
{

    class abcd
    {
        public void add(int x, int y)
        {
            Console.WriteLine($"The sum is {x + y}");
        }
        // not a overloaded method below 
        //public int add(int y, int k)
        //{
        //    return (x + k);
        //}

        public double add(int k,decimal ss,double jj)
        {
            return (k + Convert.ToDouble(ss) + jj);
        }

        public decimal add(float k, decimal ss, double jj)
        {
            return (Convert.ToDecimal(k) + ss+Convert.ToDecimal(jj));
        }
    }

    class cde :abcd
    {
        public void add(int kk,char ch)
        {
            Console.WriteLine($"The sum is :{kk+ch} ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            cde cde = new cde();
            cde.add(12, 34);
            cde.add(12, 'A');
            Console.WriteLine($"The sum is {cde.add(12.34F, 123.34M, 345.567)}");
            Console.WriteLine($"The sum is {cde.add(123, 345.56M, 345.567)}");
            Console.ReadLine();
            
        }
    }
}


In C#, a virtual method is a method that can be overridden in a derived class. When a method is declared as virtual in a base class, it allows a derived 
class to provide its own implementation of the method.

The virtual keyword is useful in modifying a method, property, indexer, or event. When you have a function defined in a class that you
want to be implemented in an inherited class(es), you use virtual functions. The virtual functions could be implemented differently in different
inherited class and the call to these functions will be decided at runtime.

The following is a virtual function

public virtual int area() { }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualfunctions
{
    class BaseClass
    {
        public void display()
        {
            Console.WriteLine("Base class display..");
        }
    }
    class SubClass :BaseClass
    {
        public void display()
        {
            Console.WriteLine("Sub Class class display..");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass objbase;
            objbase = new SubClass();
            objbase.display();
            Console.ReadLine();
        }
    }
}


for the above code i should get sub class display but i am getting baseclass display this is because 
when the base class and subclass are having same function then base class funciton will hide sub clas function 
so what we have to do we have to make base class function as virtual 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualfunctions
{
    class BaseClass
    {
        public virtual void display()
        {
            Console.WriteLine("Base class display..");
        }
    }
    class SubClass :BaseClass
    {
        public override void display()
        {
            Console.WriteLine("Sub Class class display..");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass objbase;
            objbase = new SubClass();
            objbase.display();
            Console.ReadLine();
        }
    }
}


But what is the differnce between abstract class and virtual functions both casses i am overrding can you spot the difference 

in abstarct class sub class should compulsory override it otherwsie errro will come but in virtual functions you may override or you may not

error will not come example below code 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualfunctions
{
    class BaseClass
    {
        public virtual void display()
        {
            Console.WriteLine("Base class display..");
        }
    }
    class SubClass :BaseClass
    {
        //public override void display()
        //{
        //    Console.WriteLine("Sub Class class display..");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass objbase;
            objbase = new SubClass();
            objbase.display();
            Console.ReadLine();
        }
    }
}

above i commneted the code i am not getting error same thing you will get error in abstract class  okay means u have to implment it 




