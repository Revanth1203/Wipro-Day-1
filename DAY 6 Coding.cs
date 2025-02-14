
Dialog Boxes :
-----------------
A dialog box is a window which prompt the user for an input to achieve a
specific task,for example the open dialog box prompts the user to select
a file and click the open button to perform the task of opening a file
,so dialog boxes are classified as common dialog boxes and custom dialog
boxes .common dialog boxes are defined by system.custom dialog boxes are
defined as per user requirements ,so some of system defined dialog boxes
which are nothing but one type of controls like timers etc are the
following.
so In visual C# ,the commondialog class is the base class for displaying
common dialog boxes.The classes that are inherited from commondialog
class have their corrresponding controls ,which u can add to a form from
the toolbox window .To include the relevant function of these classes to
a project you can either instantiate the relevant class or add relevant
controls to a form .
All these classses are inherited from commondialog class and overrride
the RunDialog ( ) method to create a specific dialog box .The RunDialog(
) method is automatically invoked when the user calls showDialog( )
method of relevant commonDialog( ) class.


1)colordialog box control
2)fontdialog box control
3)openfiledialog box control
4)savefiledialog box control




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace FileHandlinginWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
;        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           DialogResult res= fontDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        private void button4_Click(object sender, EventArgs e)
        {
             DialogResult res=openFileDialog1.ShowDialog();
              if(res == DialogResult.OK)
              {
                string file1=openFileDialog1.FileName;

                try
                {
                    fs = new FileStream(file1, FileMode.Open);
                    sr = new StreamReader(fs);
                    textBox1 .Text = sr.ReadToEnd();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }
              }

        }

        private void button5_Click(object sender, EventArgs e)
        {
           DialogResult res= saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string file2= saveFileDialog1.FileName;
                try
                {
                    fs = new FileStream(file2, FileMode.Create);
                    sw = new StreamWriter(fs);
                    sw.Write(textBox1.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string file3 = saveFileDialog1.FileName;
                try
                {
                    fs = new FileStream(file3, FileMode.Append);
                    sw = new StreamWriter(fs);
                    sw.Write(textBox1.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sw.Flush();
                    sw.Close();
                    fs.Close();
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DialogResult sourceResult = openFileDialog1.ShowDialog();
            if (sourceResult == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;

                DialogResult destResult = saveFileDialog1.ShowDialog();
                if (destResult == DialogResult.OK)
                {
                    string destFile = saveFileDialog1.FileName;

                    File.Copy(sourceFile, destFile, true);
                    MessageBox.Show("File copied successfully.");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                if (MessageBox.Show($"Are you sure you want to delete {filename}?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(filename);
                    MessageBox.Show("File deleted successfully.");
                }
            }
        }
    }
}


File handling in console 
---------------------------
add one file of txt into the project and go to proeprties of that file and make this
copy to output directory :always copy means from the drop down  do it and add some text data from lipsum.com 

from 3rd method copy the path of file in txt file and paste it in command prompt and execute the code 
it is same as windows only readdata we are using seek method means where to start and end etc 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHnadlinginConsole
{
    internal class Program
    {

        public static void readdata()
        {
            FileStream fs = null;
            StreamReader sr = null;
            fs = new FileStream(@"D:\GreatLearning4\Day6\Day6Projects\FileHnadlinginConsole\Wipro.txt",
                FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            //first try above then put 200 and begin it will come 
            // put 200 and say end nothing will come 
            // put -200 and say end from backward direction it will read 
            // here first take the psotion to begin and after leaving 100 read it okay 
            // in the same manner current psotion by default will be begining only so again it 
            // will go to begining as current and after leaving 100 prrint all 
            // now if i write end then cussor will go to end point and after 100 spaces it will read
            // where of course data 
            // wont be there so u can do -100 and say end then curose will go 100 inside from back side
            // and after that
            // we  will read so this is the logic          
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine($"{str}");
                str = sr.ReadLine();


            }
        }
        public static void writedata()
        {
            FileStream fs = new FileStream
                (@"D:\GreatLearning4\Day6\Day6Projects\FileHnadlinginConsole\Wipro.txt",
                FileMode.Append, FileAccess.Write);
            Console.WriteLine("enter something inside the file ");
            string input = Console.ReadLine();
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(input);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static void fileappend()
        {

            Console.WriteLine("Enter the file path where you want to save the text:");
            string filePath = Console.ReadLine();

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Append))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        Console.WriteLine("Enter the text you want to append:");
                        string textToAppend = Console.ReadLine();

                        sw.Write(textToAppend);
                        sw.Flush();
                    }

                    Console.WriteLine("Text appended successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("No file path provided.");
            }
        }

        public static void filecopy()
        {
            Console.WriteLine("Enter the source file path:");
            string sourceFilePath = Console.ReadLine();

            if (File.Exists(sourceFilePath))
            {
                Console.WriteLine("Enter the destination file path:");
                string destinationFilePath = Console.ReadLine();

                try
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    Console.WriteLine("File copied successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while copying the file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("The source file does not exist.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void filedelete()
        {
            Console.WriteLine("Enter the file path you want to delete:");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                Console.WriteLine($"Are you sure you want to delete {filePath}? (yes/no)");
                string confirmation = Console.ReadLine();

                if (confirmation?.ToLower() == "yes")
                {
                    try
                    {
                        File.Delete(filePath);
                        Console.WriteLine("File deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred while deleting the file: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("File deletion canceled.");
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            // readdata();
         //   writedata();
            fileappend();
          //  filecopy();
          //  filedelete();
            Console.ReadLine();
        }
    }
}




some links for refereing file handling :
----------------------------------------------

https://www.guru99.com/c-sharp-file-operations.html
https://www.completecsharptutorial.com/basic/c-file-handling-tutorial-with-complete-programming-example.php
https://www.studytonight.com/post/csharp-file-handling
https://www.knowledgehut.com/tutorials/csharp/csharp-file-handling


Collections:
------------
Collection means means collection of objects they are dynamic and they 
are actually classes and have lot of inbuilt methods defined in it 
we have two types of collections 

one is genric type : type safety is included you will use <T> kind of symbols 
to make the concept genric means general 

another is non generic type : anything can be added into the list like 
int ,double ,class obj ,char anything it can take and it will store in the form 
of objects

eg :Array list is non generic type when u are using non generic u have to use 
     var keyword why because while displaying different data types conflict will  occur 

   foreach( var ele in NonGenriccollection )
    {



   }
   
An ArrayList in C# is a non-generic collection that can store elements of any data type, unlike the strongly-typed List<T>
generic collection. ArrayList is found in the System.Collections namespace. It automatically resizes as you add more elements,
making it very flexible for situations where you do not know the size of the collection in advance or need to store different types of data.



using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList();
            obj.Add(1);
            obj.Add("raghu");
            obj.Add(true);
            obj.Add(DateTime.Now);
            int[] a = new int[3] { 12, 34, 56 };
            obj.AddRange(a);
            Console.WriteLine($"No of elements :{obj.Count}");
            Console.WriteLine($"\n capacity: {obj.Capacity}\n");
            foreach (var ele in obj)// here i had used var which means variant type what
                                    //it stores it becomes that data type so error will come if i use 
                                    // int ele here in loop 
            {
                Console.WriteLine($"{ele}  ");
                
            }
            int[] fourmore = new int[] { 10, 20, 30, 40 };
            obj.AddRange(fourmore);
            Console.WriteLine($"\nNo of elements :{obj.Count}");
            Console.WriteLine($"\n capacity: {obj.Capacity}\n");
            foreach (var ele in obj)// here i had used var which means variant type what
                                    //it stores it becomes that data type
            {
                Console.WriteLine($"{ele}  ");
                
            }
            Console.ReadLine();// here again press enter 
            obj.Insert(0, "first");
            obj.RemoveAt(3);
            int[] threemore = new int[] { 100, 200, 300};
            obj.InsertRange(4, threemore);
            Console.WriteLine($"\nNo of elements :{obj.Count}");
            Console.WriteLine($"\n capacity: {obj.Capacity}\n\n");
            foreach (var ele in obj)// here i had used var which means variant type what
                                    //it stores it becomes that data type
            {
                Console.WriteLine($"{ele}  ");
              
            }
            Console.ReadLine();
        }
    }
}



A Hashtable in C# is a collection that stores key-value pairs. It is similar to a dictionary but is not type-safe,
meaning it can store any object as both key and value. The Hashtable class is found in the System.Collections namespace.

Let's create a simple example to demonstrate how to use a Hashtable in C#. This example will cover adding, removing,
and retrieving items, as well as iterating through the Hashtable.

Scenario: Storing and Managing User Information
In this example, we will create a Hashtable to store user information, where the user ID (an integer) is the key, 
and the user name (a string) is the value. We will demonstrate basic operations like adding, accessing, modifying, 
and deleting items in the Hashtable.


using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongenericHashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a new Hashtable
            Hashtable users = new Hashtable();
            

            // Adding key-value pairs to the Hashtable
            users.Add(Console.ReadLine(),Console.ReadLine()); // only first value u are reading press enter to enter second value 
            users.Add(2, "Bob");
            users.Add(3, "Charlie");

            // Display all key-value pairs in the Hashtable
            Console.WriteLine("All users in the Hashtable:");
            foreach (DictionaryEntry entry in users)
            {
                Console.WriteLine($"User ID: {entry.Key}, User Name: {entry.Value}");
            }

            // Accessing an item using a key
            Console.WriteLine("\nAccessing user with ID 2:");
            if (users.ContainsKey(2))
            {
                Console.WriteLine($"User ID: 2, User Name: {users[2]}");
            }
            else
            {
                Console.WriteLine("User ID 2 not found.");
            }

            // Modifying an item in the Hashtable
            Console.WriteLine("\nModifying user with ID 3:");
            if (users.ContainsKey(3))
            {
                users[3] = "Chuck";
                Console.WriteLine($"User ID: 3, New User Name: {users[3]}");
            }

            // Removing an item from the Hashtable
            Console.WriteLine("\nRemoving user with ID 1:");
            if (users.ContainsKey(1))
            {
                users.Remove(1);
                Console.WriteLine("User ID 1 removed.");
            }

            // Display all key-value pairs in the Hashtable after removal
            Console.WriteLine("\nAll users in the Hashtable after removal:");
            foreach (DictionaryEntry entry in users)
            {
                Console.WriteLine($"User ID: {entry.Key}, User Name: {entry.Value}");
            }

            Console.ReadLine();
        }
    }
}

A SortedList in C# is a collection of key-value pairs that are sorted by the keys. It combines the features of a Hashtable and 
a SortedDictionary, where the elements are accessible by both key and index and are automatically sorted by the key. 
SortedList is part of the System.Collections namespace.

Let's create a simple example to demonstrate how to use a SortedList in C#. This example
will cover adding elements, accessing elements, modifying elements, removing elements, and iterating through the SortedList.

Scenario: Managing a Sorted List of Students
In this example, we will create a SortedList to store students' information where the key is the student ID (integer) 
and the value is the student name (string). The list will automatically sort students by their IDs.



using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongenericSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList students = new SortedList();

            // Adding elements to the SortedList
            students.Add(102, "Alice");
            students.Add(101, "Bob");
            students.Add(104, "Charlie");
            students.Add(103, "David");

            // Display all elements in the SortedList
            Console.WriteLine("All students in the SortedList:");
            foreach (DictionaryEntry entry in students)
            {
                Console.WriteLine($"Student ID: {entry.Key}, Student Name: {entry.Value}");
            }

            // Accessing elements by key
            Console.WriteLine("\nAccessing student with ID 101:");
            if (students.ContainsKey(101))
            {
                Console.WriteLine($"Student ID: 101, Student Name: {students[101]}");
            }
            else
            {
                Console.WriteLine("Student ID 101 not found.");
            }

            // Modifying an element
            Console.WriteLine("\nModifying student with ID 104:");
            if (students.ContainsKey(104))
            {
                students[104] = "Chuck";
                Console.WriteLine($"Student ID: 104, New Student Name: {students[104]}");
            }

            // Removing an element
            Console.WriteLine("\nRemoving student with ID 102:");
            if (students.ContainsKey(102))
            {
                students.Remove(102);
                Console.WriteLine("Student ID 102 removed.");
            }

            // Display all elements in the SortedList after removal
            Console.WriteLine("\nAll students in the SortedList after removal:");
            foreach (DictionaryEntry entry in students)
            {
                Console.WriteLine($"Student ID: {entry.Key}, Student Name: {entry.Value}");
            }

            // Accessing elements by index
            Console.WriteLine("\nAccessing student by index 0:");
            Console.WriteLine($"Student ID: {students.GetKey(0)}, Student Name: {students.GetByIndex(0)}");

            Console.ReadLine();
        }
    }
}

Now let us go with the concept of generics 
------------------------------------------

Generics:
---------
Generics means code reuse dont write the same code repeteadely put the code inside a method and call the method 
repeatedly which is called as generic method here <T> will be there and in that <T> if u say <int> then integer type only we have to use 
and in the same manner dont write the same method repeteadly put the methods inside a class and use the class repeteadly called as Generic class 
when you are using generics type safety is ensured


first version of program without genric method 
------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoonMethodandclass
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
        public static void swap(ref DateTime x, ref DateTime y)
        {
            DateTime temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static void swap(ref string st1, ref string st2)
        {
            string temp;
            temp = st1;
            st1 = st2;
            st2 = temp;
        }
        static void Main(string[] args)
        {

            int x = 10;
            int y = 20;
            Console.WriteLine("\n Before swapping integers");
            Console.WriteLine($"x={x}\n y={y}");
            swap(ref x, ref y);
            Console.WriteLine("\n after swapping integers");
            Console.WriteLine($"x={x}\n y={y}");

            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Now.AddDays(2);
            Console.WriteLine("\n Before swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");
            swap(ref date1, ref date2);
            Console.WriteLine("\n after swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");
            Console.ReadLine();
        }
    }
}


Now just observe above program 

for 3 types i had written 3 methods if 10 types are there ten methods i cannot write so i will write a genric method for this one 

add one class with the name Helper.cs in the project and add one generic method like this ...here T means any type is allowed 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoonMethodandclass
{
    class Helper
    {
        public static void swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

    }
}

then comment the methods in program.cs 

and use Helper clas method for all three functions 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoonMethodandclass
{
    internal class Program
    {
        //public static void swap(ref int x, ref int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void swap(ref DateTime x, ref DateTime y)
        //{
        //    DateTime temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void swap(ref string st1, ref string st2)
        //{
        //    string temp;
        //    temp = st1;
        //    st1 = st2;
        //    st2 = temp;
        //}
        static void Main(string[] args)
        {

            int x = 10;
            int y = 20;
            Console.WriteLine("\n Before swapping integers");
            Console.WriteLine($"x={x}\n y={y}");

            Helper.swap<int>(ref x, ref y);
            Console.WriteLine("\n after swapping integers");
            Console.WriteLine($"x={x}\n y={y}");

            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Now.AddDays(2);
            Console.WriteLine("\n Before swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");
           Helper.swap<DateTime>(ref date1, ref date2);
            Console.WriteLine("\n after swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");
            Console.ReadLine();
        }
    }
}

Now i want to add another method of genric to add any kind of numers so whenn try that i will get some errors so at that i will use a
keyword which is dynamic to solve my requirement 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoonMethodandclass
{
    class Helper
    {
        public static void swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static T add<T>(T x, T y)
        {
            dynamic x1 = x;
            dynamic y1 = y;
            T sum;
            sum = x1 + y1;
            return sum;
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoonMethodandclass
{

    
    internal class Program
    {
        //public static void swap(ref int x, ref int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void swap(ref DateTime x, ref DateTime y)
        //{
        //    DateTime temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void swap(ref string st1, ref string st2)
        //{
        //    string temp;
        //    temp = st1;
        //    st1 = st2;
        //    st2 = temp;
        //}
        static void Main(string[] args)
        {

            int x = 10;
            int y = 20;
            Console.WriteLine("\n Before swapping integers");
            Console.WriteLine($"x={x}\n y={y}");

            Helper.swap<int>(ref x, ref y);
            Console.WriteLine("\n after swapping integers");
            Console.WriteLine($"x={x}\n y={y}");

            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Now.AddDays(2);
            Console.WriteLine("\n Before swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");
           Helper.swap<DateTime>(ref date1, ref date2);
            Console.WriteLine("\n after swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");

            double dd1 = 123.45;
            double dd2 = 234.567;
           Console.WriteLine($"The sum of double types :{Helper.add<double>(dd1, dd2)}");

            Console.WriteLine($"The sum of ints types :{Helper.add<int>(x,y)}");

            Console.ReadLine();
        }
    }
}

Now i want to go with genric class means <T> i will shift to class level it means all methods in that class should 
folow the type provided by the class so add another class Helper2 in the same code 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoonMethodandclass
{
    class Helper
    {
        public static void swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static T add<T>(T x, T y)
        {
            
            dynamic x1 = x;
            dynamic y1 = y;
            T sum;
            sum = x1 + y1;
            return sum;
        }

    }

    class Helper2<T>
    {
        public static void swap(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static T add(T x, T y)
        {

            dynamic x1 = x;
            dynamic y1 = y;
            T sum;
            sum = x1 + y1;
            return sum;
        }
    }
}

and main method code will chenage like this observer comments see helper2 i had used it here 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemoonMethodandclass
{

    
    internal class Program
    {
        //public static void swap(ref int x, ref int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void swap(ref DateTime x, ref DateTime y)
        //{
        //    DateTime temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void swap(ref string st1, ref string st2)
        //{
        //    string temp;
        //    temp = st1;
        //    st1 = st2;
        //    st2 = temp;
        //}
        static void Main(string[] args)
        {

            int x = 10;
            int y = 20;
            Console.WriteLine("\n Before swapping integers");
            Console.WriteLine($"x={x}\n y={y}");

           // Helper.swap<int>(ref x, ref y);
             Helper2<int>.swap(ref x, ref y);
            Console.WriteLine("\n after swapping integers");
            Console.WriteLine($"x={x}\n y={y}");

            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Now.AddDays(2);
            Console.WriteLine("\n Before swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");
            //  Helper.swap<DateTime>(ref date1, ref date2);
            Helper2<DateTime>.swap(ref date1, ref date2);
            Console.WriteLine("\n after swapping dates");
            Console.WriteLine($"date1={date1}\n date2={date2}");

            double dd1 = 123.45;
            double dd2 = 234.567;
         //  Console.WriteLine($"The sum of double types :{Helper.add<double>(dd1, dd2)}");

          //  Console.WriteLine($"The sum of ints types :{Helper.add<int>(x,y)}");

            Console.WriteLine($"The sum of double types :{Helper2<double>.add(dd1, dd2)}");

            Console.WriteLine($"The sum of ints types :{Helper2<int>.add(x, y)}");


            Console.ReadLine();
        }
    }
}

now let us work on genric collections which is generic list 
-----------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListDemo
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public static List<Customer> retrive()
        {
            List<Customer> list = new List<Customer>()
            {
              new Customer{CustomerID=101,CustomerName="sita"},
              new Customer{CustomerID=102,CustomerName="suresh"},
              new Customer{CustomerID=103,CustomerName="mahesh"}

            };
            return list;
        }

        public static void PrintCustomers(List<Customer> clist)
        {
            Console.WriteLine("\n Printing customers...");
            foreach (Customer c in clist)
            {
                Console.WriteLine($"{c.CustomerID}--{c.CustomerName}");
            }
        }
        public static void insertcustomer(Customer customer,List<Customer> clist)
        {
            clist.Add(customer);
        }
        public static Customer findcustomer(int custid1,List<Customer> clist)
        {
            Customer customerfound = null;
            foreach (Customer c in clist)
            {
                if (c.CustomerID == custid1)
                {
                    customerfound = c;
                    break;
                }
            }
            return customerfound;
        }

        public static void updatecustomer(int cid,List<Customer> clist)
        {
            for(int i=0;i<clist.Count;i++)
            {
                if(clist[i].CustomerID == cid)
                {
                    Console.WriteLine("enter new name:");
                    string newname=Console.ReadLine();
                    clist[i].CustomerName = newname;
                }
            }
        }

        public static void  deletecustomer(int cid, List<Customer> clist)
        {
            for (int i = 0; i < clist.Count; i++)
            {
                if (clist[i].CustomerID == cid)
                {
                    clist.RemoveAt(i);
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 12, 34, 55, 61, 29, 40 };
            List<double> numbers2 = new List<double>();
            numbers2.Add(123.23);
            numbers2.AddRange(new double[] { 111.11, 222.22, 333.33 });
            Console.WriteLine("\n displaying numbers");
            foreach(int number in numbers)
            {
                Console.Write($"{number}  ");
            }
            Console.WriteLine("\n displaying numbers2");
            foreach (double number in numbers2)
            {
                Console.Write($"{number}  ");
            }
            List<string> boysnames = new List<string>() { "kiran", "karthik", "mahesh", "suresh" };
            var girlnames = new List<string>();
            girlnames.Add("sudha");
            girlnames.AddRange(new string[] { "sita", "shanthi", "priya", "suman" });

            Console.WriteLine("\n\n displaying boys ");
            foreach (string boy in boysnames)
            {

                Console.WriteLine($"{boy}");

            }
            Console.WriteLine("\n displaying girls");
            foreach (string girl in girlnames)
            {

                Console.WriteLine($"{girl}");
            }
            int[] aa2 = new int[] { 12, 13, 23, 12, 34, 67, 23, 89, 91, 66, 71, 67 };
            // remove duplicate elelements from the array and give it to me 
            List<int> result = new List<int>();
            foreach(int number in aa2)
            {
                bool found = false;
                foreach(int resultitem in result)
                {
                    if (resultitem == number)
                    {
                        found = true;
                        break;

                    }
                   
                   
                }
                if (!found)
                {
                    result.Add(number);
                }
            }
            Console.WriteLine("\n after removing duplicate elements:");
            foreach (int k in result)
            {
                Console.Write($"{k} ");
            }
            Console.WriteLine("\n customer coding started...");
            List<Customer> custlist = Customer.retrive();
            Customer.PrintCustomers(custlist);
            Console.WriteLine("\n enter the customer to be added in the list");
            Customer c4 = new Customer()
            {
                CustomerID = 104,
                CustomerName="sharavan"
            };
            Customer.insertcustomer(c4, custlist);
            Customer.PrintCustomers(custlist);
            Console.WriteLine("\n enter the id of customer to be found ");
            int cusotmerid1=Convert.ToInt32(Console.ReadLine());
           Customer cusomergot= Customer.findcustomer(cusotmerid1, custlist);
            if(cusomergot!=null)
            {
                Console.WriteLine($"The customer with id {cusomergot.CustomerID} is having name :{cusomergot.CustomerName}");
            }
            else
            {
                Console.WriteLine("\n cusotmer not available");
            }
            Console.WriteLine("\n enter the id of customer whos name u want to change ");
            int customerid2 = Convert.ToInt32(Console.ReadLine());
            Customer.updatecustomer(customerid2, custlist);
            Customer.PrintCustomers(custlist);
            Console.WriteLine("\n enter the id of customer whos name u want to delete ");
            int customerid3 = Convert.ToInt32(Console.ReadLine());
            Customer.deletecustomer(customerid3, custlist);
            Customer.PrintCustomers(custlist);

            Console.ReadLine();
        }
    }
}
