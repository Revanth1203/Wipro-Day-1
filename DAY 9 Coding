
Indexers
----------
C# indexers are usually known as smart arrays. A C# indexer is a class property that allows you to access a member variable of a class or struct using the
features of an array. In C#, indexers are created using this keyword. Indexers in C# are applicable on both classes and structs

Defining an indexer allows you to create a class like that can allows its items to be accessed an array.  Instances of that class


Properties in C# are named members that use access modifiers to set and retrieve values of fields declared in a secured manner.
Properties are used for abstracting and encapsulating access to a field of a class by defining only important actions and hiding their implementation. 
operties are invoked through a described name and can be declared as a static or an instance member.


Indexers in C# are data members that act as an array and allow you to access data within objects to be indexed in the same way. 
Indexers are always declared as instance members, never as static members. Indexers are implemented in the same way as properties,
except that the declaration of an indexer must have at least one parameter.

Syntax of creating an indexer in C#:

[access_modifier] [return_type] this [parameter]
{
  get 
  {
     // return value
  }
  set 
  {
    // return value
  }
}


Now i am using vscode in coding so create one folder in any drive with the name Day9Projects okay 

open this folder using vscode and then open terminal and write the following command from the terminal to create a console app in 

this folder 

PS D:\GreatLearning4\Day9\Day9Projects> dotnet new console -o indexerdemo --use-program-main 
The template "Console App" was created successfully.
   
Processing post-creation actions...
Restoring D:\GreatLearning4\Day9\Day9Projects\indexerdemo\indexerdemo.csproj:
  Determining projects to restore...
  Restored D:\GreatLearning4\Day9\Day9Projects\indexerdemo\indexerdemo.csproj (in 55 ms).
Restore succeeded.



dotnet new console -o indexerdemo --use-program-main

go to that folder cd ind* press enter 


now after going to the project 

open program.cs file and do the following coding in that one 


namespace indexerdemo;

 class abcd
{
    public int[] _numbers = new int[5];
}
class Program
{
    static void Main(string[] args)
    {
        abcd abcdobj = new abcd();
      //  abcdobj[0] = 230; // i want to do this which is not possible using class object array storing in member array some value 
    }
}

after putting the indexer remove commments 

namespace indexerdemo;
class abcd
{
    public int[] _numbers = new int[5];

    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < _numbers.Length)
            {
                return _numbers[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }
        set
        {
            if (index >= 0 && index < _numbers.Length)
            {
                _numbers[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

        }


    }

}
class Program
{
    static void Main(string[] args)
    {
        abcd abcdobj = new abcd();
        abcdobj[0] = 230;
    }
}

further code
-------------
namespace indexerdemo;
class abcd
{
    public int[] _numbers = new int[5];

    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < _numbers.Length)
            {
                return _numbers[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }
        set
        {
            if (index >= 0 && index < _numbers.Length)
            {
                _numbers[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

        }


    }

}
class Program
{
    static void Main(string[] args)
    {
        abcd abcdobj = new abcd();
        abcdobj[0] = 230;
        abcdobj[1] = 330;
        abcdobj[2] = 230;
        abcdobj[3] = 330;
        abcdobj[4] = 230;
        //  abcdobj[5] = 230;// error here 
        Console.WriteLine($"{abcdobj[4]}");
    //    Console.WriteLine($"{abcdobj[5]}");


    }
}



now from the terminal dotnet build 

then dotnet run do it 



Now final code i will put where i have written a method for desplay also if i display indexer code then my code will not work so 

namespace indexerdemo;
class abcd
{
    public int[] _numbers = new int[5];

    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < _numbers.Length)
            {
                return _numbers[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }
        set
        {
            if (index >= 0 && index < _numbers.Length)
            {
                _numbers[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

        }


    }

    public void displaynumbers()
    {
        for (int i = 0; i < _numbers.Length; i++)
        {
            Console.WriteLine($"Index {i}:{_numbers[i]}");
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        abcd abcdobj = new abcd();
        abcdobj[0] = 230;
        abcdobj[1] = 330;
        abcdobj[2] = 230;
        abcdobj[3] = 330;
        abcdobj[4] = 230;
        //  abcdobj[5] = 230;// error here 
        Console.WriteLine($"{abcdobj[4]}");
        //    Console.WriteLine($"{abcdobj[5]}");//not possible error 

        abcdobj.displaynumbers();


    }
}


Attributes 
--------------
Here attribute means a complex functionality means a class where u have written some code or some logic 
so that class functionality i will convert into attribute means in square bracket i will just write the class name 

[classname] like this and where u subsitte or put this tag on top of any class or a method the logic of that 
attribute class is implemented without writing the logic because logic is already written and converted into
an object of attribute we have to just substiute or put on top of the method okay 


An attribute is a declarative tag that is used to convey information to runtime about the behaviors of various elements like classes, methods,
structures, enumerators, assemblies etc. in your program. You can add declarative information to a program by using an attribute.
A declarative tag is depicted by square ([ ]) brackets placed above the element it is used for.

Attributes are used for adding metadata, such as compiler instruction and other information such as comments, description, methods 
and classes to a program. The .Net Framework provides two types of attributes: the pre-defined attributes and custom built attributes.

Specifying an Attribute
Syntax for specifying an attribute is as follows −

[attribute(positional_parameters, name_parameter = value, ...)]
element
Name of the attribute and its values are specified within the square brackets, before the element to which the attribute is applied. 
Positional parameters specify the essential information and the name parameters specify the optional information.

Now first create a class libray project and convert it into attribute and consume that attribute 


code for classlibray project which has been converted to attribute 


Now let us create a class library project in vscode so what is command  to write that class libary

cd ..

come to the main Day9Projects write the belwo commannd

dotnet new classlib -n ClassLibrary1


now it will be created and now go to that project cd Class*

dotnet build  


PS D:\GreatLearning4\Day9\Day9Projects> cd Class*
PS D:\GreatLearning4\Day9\Day9Projects\ClassLibrary1> dotnet build
  Determining projects to restore...
  All projects are up-to-date for restore.
  ClassLibrary1 -> D:\GreatLearning4\Day9\Day9Projects\ClassLibrary1\bin\Debug\net8.0\ClassLibrary1.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.62

so the code will look like ths after clicking explorer winndow and going inside that file 

namespace ClassLibrary1;

public class Class1
{

}

now change the code like this just override the class functionality let the namepace be there 

[AttributeUsage(AttributeTargets.Method)]
    public class AddNumbers :Attribute
    {
        private int _num1;
        private int _num2;

        public AddNumbers(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public int Add()
        {
            return _num1 + _num2;
        }
        public int Substract()
        {

            return _num1 - _num2;
        }
    }

again do dotnet build 

dont do run as main method is not there 

next come back to main folder which Day9Project from there creaete one console app with the name sampledemo


cd ..    to main folder 

from the main folder 


dotnet new console -o sampledemo --use-program-main 


now come to folder sampledemo 

from there u have to add reference of ClassLibrary1 dll so 


dotnet add reference ../ClassLibrary1/ClassLibrary1.csproj  // type this command from sampledemo 


in .csproj click u can see the referecne added 


<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\ClassLibrary1\ClassLibrary1.csproj" />
  </ItemGroup>

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>


now come to program.cs and write this code which i am giving 



namespace sampledemo;
using ClassLibrary1;
using System.Reflection;

public class Calaculator
{
    [AddNumbers(5, 3)]
    public void operation()
    {

    }
}
class Program
{
    static void Main(string[] args)
    {
        Type calctype = typeof(Calaculator);
        MethodInfo method = calctype.GetMethod(nameof(Calaculator.operation));
        AddNumbers attribute = (AddNumbers)method.GetCustomAttribute(typeof(AddNumbers));
        if (attribute != null)
        {
            int result = attribute.Add();
            int result2 = attribute.Substract();
            Console.WriteLine($"The result of addition is {result}");
            Console.WriteLine($"The result of substraction is {result2}");

        }
    }
}


Threads
----------
A thread is the smallest unit of code containing sequence of instructions 
    that gets executed to define a unique flow of control and path of execution
    of a program.
  
   example of multithreaded process is internet explorer.
 
   we generally go for threads when we have to deal large and complex applications.

 * Inside the process there are threads so a process that is made up of one thread is called 
 * single threaded process.
 * A process containg two or more threads in it is called multithreaded process.
 * Example of this is web browser i.e internet explorer so within the web browser
 * u can print the page and scroll also so in one process there are mutiple threads.
 * when we do multithreading time is saved as we simaltaneously execute the application.
 * every program has one thread...u can create more threads if necessary.
 * problem with single threaded application is that possibily lengthy activities must
 * complete before other activities can begin and that may be inportant
 * so user feeels that he has spend lot of time.
 * so he goes for multithreading.
 *A memeory is allocated to processs not for thread.
 * 
 * Multitasking is the ability to execute more than one task at a time.
 * multitasking is of two types:
 * 1.process based multitasking
 * 2.Thread based multitasking
 * 
 * 1 example is dos coommand open and running program in editor.
 * 2.text editor is a single process and in that two threads are running.
 * one is of wrting to file and another s printing.
 * These are light weight process.
 * 
 * four advantages of multithreading:
 * 
 * 1.improved performance.
 * 2.minized system resources because same address space is shared by different threads.
 * 3.simaltanues acces due to  quick contxt switching
 * 4.program structure simplification.beacuse task is shared.
 * 
 * 
 * disadvantages:
 * 
 * 1.race condition leads to corruption of data ...producer and consumer problem example
 * 2.deadlock condition happens when two threads wait for each other to complete thir operation.
 * 3.lock starvation.:execution of thread is postponed due to low priority
 * 
 * 
 * Multithreading is platform dependent or os dependent because each time the order or sequence of
 * output changes.
 * 
 * so implement concurency also we go for threads.
 * human body si also example of concurrency we do breathing,smiling,etc 
 * ada was the first language to implement concurrency.
 * c,c++  are example of single threaded languages it wont support multithreading.
 * 
 * garbage collector  is the lowest  priority thread.
 * 
 * 
 * 
 * 
 * 
 * 
 
 go to main folder which is Day9Projects 
 
 type console app command and give name as ThreadExample 
 
 
 
 dotnet new console -o ThreadExample --use-program-main 


namespace ThreadExample;

class Program
{
    public static void Fun1()
    {
        for (int i = 1; i < 20; i++)
        {
            Console.WriteLine("Func1() writes {0}", i);
        }

    }

    public static void Fun2()
    {
        for (int j = 20; j > 0; j--)
        {
            Console.WriteLine("Func2() writes {0}", j);
        }

    }
    static void Main(string[] args)
    {
        Console.WriteLine("Start of the main function ");
        Fun1();
        Fun2();
        Console.WriteLine("End of main()");
    }
}


execute this code 

Start of the main function 
Func1() writes 1
Func1() writes 2
Func1() writes 3
Func1() writes 4
Func1() writes 5
Func1() writes 6
Func1() writes 7
Func1() writes 8
Func1() writes 9
Func1() writes 10
Func1() writes 11
Func1() writes 12
Func1() writes 13
Func1() writes 14
Func1() writes 15
Func1() writes 16
Func1() writes 17
Func1() writes 18
Func1() writes 19
Func2() writes 20
Func2() writes 19
Func2() writes 18
Func2() writes 17
Func2() writes 16
Func2() writes 15
Func2() writes 14
Func2() writes 13
Func2() writes 12
Func2() writes 11
Func2() writes 10
Func2() writes 9
Func2() writes 8
Func2() writes 7
Func2() writes 6
Func2() writes 5
Func2() writes 4
Func2() writes 3
Func2() writes 2
Func2() writes 1
End of main()


so the above program is running systematically as per the sequence okay .
Now there is a delegate in System.Threading.ThreadStart that may reference any method which has the void return type and which takes no arguments 

public delegate void ThreadStart();

here u cannot create your own delegate u have to use given by them 

so same prgram i will execute use Threads 


namespace ThreadExample;
using System.Threading;
class Program
{
    public static void Fun1()
    {
        for (int i = 1; i < 20; i++)
        {
           
            Console.WriteLine("Func1() writes {0}", i);
        }

    }

    public static void Fun2()
    {
        for (int j = 20; j > 0; j--)
        {
            
            Console.WriteLine("Func2() writes {0}", j);
        }

    }
   
    static void Main(string[] args)
    {
        Thread first = new Thread(new ThreadStart(Fun1));
        Thread second = new Thread(new ThreadStart(Fun2));
        Console.WriteLine("Start of the main function ");
        second.Priority = ThreadPriority.Highest;
        first.Priority = ThreadPriority.Lowest;
        second.Start();
        first.Start();
       
        Console.WriteLine("End of main()");
    }
}



come to main folder now i am doing web application mainly razor web application 

write the following command from the main fodler which is Day9Projects

dotnet new razor -n MyRazorApp

after this go to cd MyR*

do dotnet build 

and do dotnet run 

u will see one server path and copy that path in any browser  to see the default website 

PS D:\GreatLearning4\Day9\Day9Projects> cd MyR*
PS D:\GreatLearning4\Day9\Day9Projects\MyRazorApp> dotnet build
  Determining projects to restore...
  All projects are up-to-date for restore.
  MyRazorApp -> D:\GreatLearning4\Day9\Day9Projects\MyRazorApp\bin\Debug\net8.0\MyRazorApp.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:03.31
PS D:\GreatLearning4\Day9\Day9Projects\MyRazorApp> dotnet run
Building...
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5028
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: D:\GreatLearning4\Day9\Day9Projects\MyRazorApp
warn: Microsoft.AspNetCore.HttpsPolicy.HttpsRedirectionMiddleware[3]
      Failed to determine the https port for redirect.




http://localhost:5028  paste this in browser your url not mine

go to index.cshtml page and do this coding in it 


@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";

    int k;
}
@{

    int a = 10;
    int b = 20;
    int c = a + b;

}

<div class="text-center">
    <marquee>
        <h1 class="display-4">Welcome</h1>
    </marquee>
    <p>Learn about <a href="https://learn.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
    <h2>Welcome to Wipro and the value for c is @c </h2>
</div>


any chnage do dotnet build and dotnet run and open the broswer and paste the url 


here it is caled .cshtml becasue i can put or embeed c# code along with desing 

now i want to configure one website in my project means any html css static website into my prject 

now if u want to configure htmltemplates.net  website into asp.net core what to do 

--->add index.html page and images folder into wwwroot folder 
---> add css file into css folder of asp.net core website 
--->then from run the website and after port /index.html you can see the website 



Next now on hyerlink i want to call the same above website so first i will add razor page into Pages folder and give it a name
Purple.cshtml

so the command to add razor page frmm the MyRazorApp path type this command


dotnet new page -n Purple -o Pages

it will lookk like this 



@page
@model MyApp.Namespace.PurpleModel
@{
}

now dont delete the code just below it add all the code of index.html page which is there in wwwwroot folder into it means in Purple.cshtml page



@page
@model MyApp.Namespace.PurpleModel
@{
}
<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <title>Template 15</title>
    <meta name="description" content="A description of your website">
    <meta name="keywords" content="keyword1, keyword2, keyword3">
    <link href="css/style.css" rel="stylesheet" type="text/css">
</head>

<body>

    <div id="wrapper">

        <div id="header">
            <h1>Enter Site Title</h1>
            <p>Enter Site Slogan</p>
        </div>

        <div id="page_content">

            <div class="navigation">
                <ul>
                    <li><a href="#">Home</a></li>
                    <li><a href="#">Contact</a></li>
                    <li><a href="#">New Page 1</a></li>
                    <li><a href="#">New Page 2</a></li>
                    <li><a href="#">New Page 3</a></li>
                    <li><a href="#">New Page 4</a></li>
                </ul>
            </div>

            <div class="left_section">
                <div class="common_content">
                    <h2>About</h2>
                    <hr>
                    <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.
                        Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus
                        mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa
                        quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo,
                        rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium.
                        Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend
                        tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante,
                        dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet.
                        Quisque rutrum. Aenean imperdiet.</p>
                    <br>
                </div>

                <div class="top_content border_none">
                    <div class="column_one">
                        <h2>Introductions</h2>
                        <p>Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam
                            rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet
                            adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id,
                            lorem. Maecenas nec odio et ant</p>
                        <br>
                        <p><a href="#" class="btn">More</a></p>
                    </div>
                    <div class="column_two border_left">
                        <h2>Welcome</h2>
                        <p>Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam
                            rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet
                            adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id,
                            lorem. Maecenas nec odio et ant</p>
                        <br>
                        <p><a href="#" class="btn">More</a></p>
                    </div>
                </div>
            </div>

            <div class="right_side_bar">

                <div class="col_1">
                    <h1>Main Menu</h1>
                    <div class="box">
                        <ul>
                            <li><a href="#">Menu Item 1</a></li>
                            <li><a href="#">Menu Item 2</a></li>
                            <li><a href="#">Menu Item 3</a></li>
                            <li><a href="#">Menu Item 4</a></li>
                            <li><a href="#">Menu Item 5</a></li>
                            <li><a href="#">Menu Item 6</a></li>
                            <li><a href="#">Menu Item 7</a></li>
                            <li><a href="#">Menu Item 8</a></li>
                            <li><a href="#">Menu Item 9</a></li>
                        </ul>
                    </div>
                </div>

                <div class="col_1">
                    <h1>Resources</h1>
                    <div class="box">
                        <p>Enter Block content here...</p>
                        <br>
                        <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo Lorem ipsum dolor
                            sit amet, consectetuer adipiscing elit. Aenean commodo</p>
                    </div>
                </div>

            </div>

            <div class="clear"></div>

            <!--start footer from here-->
            <div id="footer">Copyright &copy; 2014. Design by <a href="http://www.htmltemplates.net"
                    target="_blank">HTML Templates</a><br>

                <!--DO NOT remove footer link-->
                <!--Template designed by--><a href="http://www.htmltemplates.net"><img src="images/footer.gif"
                        class="copyright" alt="http://www.htmltemplates.net"></a>
            </div>

            <!--/. end footer from here-->
        </div>

    </div>

</body>

</html>


now go to shared folder _Layout.cshtml page 

and add this hyperlink like this by copying same above code privay link and give name as Purple 


  <li class="nav-item">
      <a class="nav-link text-dark" asp-area="" asp-page="/Privacy">Privacy</a>
  </li>
  <li class="nav-item">
      <a class="nav-link text-dark" asp-area="" asp-page="/Purple">Purple</a>
  </li>


Now build and  run the website and clike the purple link u will see the desing of Purple link page 


Now let us learn about layouts in asp.net core razor pages 



layouts means common design I am having _layout page in shared folder all pages which i am creating are using this layout 
as header and footer with navigatio in header and how do i know all are using _Layout.cshtml page 
go to view start file it is written there that all pages should use that 

@{
    Layout = "_Layout";
}


Now in layout page one tag will be there @RenderBody tag here only  one renderbody tag will be there which will dislay child data desing only 
when i clik home home disign will be shown though this  @RenderBody tag only ...and privacy will show its desing using  @RenderBody tag only 
in layout where u keep this tag at that postion only i can see child desing alogn with the parent desing who is parent here _layout 


now i want to use my own layout now means all pages should use my layout they should not use _layout or few page should use my layout and some 
can use .net _layout 

let us create my own layout so add one layoutpage in shared fodler means copy _Layout.cshtml page and paste it again in same shared folder 
and delete all data inside it and also rename the file as _MyLayout.cshtml.

in that page add this design 

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
</head>
<body>
    <div style="background-color:yellow;color:red;width:100%;height:100px">
        <h1>This is header </h1>
    </div>
    <div>
        @RenderBody()
    </div>
    <div style="background-color:fuchsia;color:red;width:100%;height:100px">
        <h1>This is footer </h1>
    </div>
</body>
</html>

Now go  to view start file and change the name as _MyLayout


                                                                
 @{
    Layout = "_MyLayout";
}
                                                         
                                                                
       Now run the pages means run website all will use your layout 
       
 http://localhost:5028/index
http://localhost:5028/Privacy
http://localhost:5028/Purple

  so give the paths like this u can see all pages are using your design as layout 
  
  now i want to overrite Purple and Index page to not to use _MyLayout  okay then i will do like this 
                                                                
 @model IndexModel
@{
    ViewData["Title"] = "Home page";
    int k;
    Layout = "_Layout";
}                                                       
                                                                
                                                                
  and same thing write for Purple page also 
        
        
    @page
@model RazorDemo.Pages.BlueModel
@{
    Layout = "_Layout";
    }
	
	

Now again run the same urls and seee therir master layouts 


 http://localhost:5028/index
http://localhost:5028/Privacy
http://localhost:5028/Purple



Now i want to do some programming and want to display the programming code output in razor page 
-------------------------------------------------------------------------------------------------
Now i will create a product class and on that i will add service functions like adding the product and displaying all products so collection classs i will use here 

In the project create one folder Models and add one class like this below 
how--> right click on Models folder and --->add  file where C# and next say---> class and then in top down it will ask for name give name 
Product and then namespaces will be automatically created 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRazorApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}


In the project add then in Pages fodler add one folder with name service   and in that add one class with the name ProductService
same as above and copy the internal code means inside class copy code 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyRazorApp.Models;

namespace MyRazorApp.Pages.service
{
    public class ProductService
    {
        private static List<Product> products = new List<Product>
     {
         new Product { Id = 1, Name = "Product 1", Price = 10.0m },
         new Product { Id = 2, Name = "Product 2", Price = 20.0m },
         new Product { Id = 3, Name = "Product 3", Price = 30.0m },
     };

        public List<Product> GetAll()
        {
            // Return the list of all products
            return products;
        }




    }
}
	
register the ProductService class in middleware means request pipeline which is nothing but Program.cs



   builder.Services.AddSingleton<MyRazorApp.Pages.service.ProductService>();


// means after this line   builder.Services.AddRazorPages();


Now add one folder in Pages folder which is Products folder  and in that add one class and there again selct razor and drop down write name 
	as ProductIndex and say enter 

 
.cshtml 
----------
@page
@model MyRazorApp.Pages.Products.ProductIndex
@{
    ViewData["Title"] = "ProductIndex";
}

<h1>@ViewData["Title"]</h1>

<div>
    
</div>

and .cs file will look lik this 
	using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyRazorApp.Pages.Products
{
    public class ProductIndex : PageModel
    {
        private readonly ILogger<ProductIndex> _logger;

        public ProductIndex(ILogger<ProductIndex> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}


and then in ProductIndex.cs  file write this code 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyRazorApp.Pages.service;
using MyRazorApp.Models;

namespace MyRazorApp.Pages.Products
{
    public class ProductIndex : PageModel
    {
        private readonly ILogger<ProductIndex> _logger;
        private readonly ProductService _productService;

        public ProductIndex(ILogger<ProductIndex> logger, ProductService productservice)
        {
            _logger = logger;
            this._productService = productservice;
        }

       

        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _productService.GetAll();
        }
    }
}
now in .cshtml of productindex define the code 

@page
@model MyRazorApp.Pages.Products.ProductIndex
@{
    ViewData["Title"] = "ProductIndex";
    Layout="_Layout";
}

<h1>@ViewData["Title"]</h1>
<h2>Product List</h2>


<table class="table">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Price</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var product in Model.Products)
        {
            <tr>
                <td>@product.Id</td>
                <td>@product.Name</td>
                <td>@product.Price</td>

            </tr>
        }
    </tbody>
</table>

and url u have to give is 
	    http://localhost:5028/Products/ProductIndex
provinding link in layout 
---------------------------
   <li class="nav-item">
      <a class="nav-link text-dark" asp-area="" asp-page="/Purple">Purple</a>
  </li>
  <li class="nav-item">
      <a class="nav-link text-dark" asp-area="" asp-page="Products/ProductIndex">Product</a>
  </li>





secuirty in razor pages of static files 
--------------------------------------
suppose i dont want  to give permission to the end user to use .json file or .config files through 
middle ware means request pipe line i can make 
the access of that page forbidden

add in the project right click and add one file just file and give name like this sensitive.json and say enter 

and then add this data into this fie 

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

and now go to program .cs file and after app.UseStaticFiles();  write this code 

 app.Use(async (context, next) =>
 {
     var requestPath = context.Request.Path.Value;

     // Prevent access to sensitive config and json files
     if (requestPath.EndsWith(".config") || requestPath.EndsWith(".json"))
     {
         context.Response.StatusCode = 403; // Forbidden
         await context.Response.WriteAsync("Access to this file type is restricted.");
     }
     // Check for directory traversal
     else if (requestPath.Contains(".."))
     {
         context.Response.StatusCode = 400; // Bad Request
         await context.Response.WriteAsync("Invalid request path.");
     }
     else
     {
         await next();
     }
 });
 
 now call the project 
 
 https://localhost:7069/sensitive.json
 
 you will get the access restricted ...
 
  
 

