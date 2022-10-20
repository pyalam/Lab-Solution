using System;

namespace Lab1Project //school name
{ 
    internal class GrandParentClass  //parent class or base class
    {
       protected int x;
       protected int y;

        public void parentmethod()
        {
            Console.WriteLine("Hello im from paremt class method");
        }
    }
    internal class fatherClass: GrandParentClass  //child class
    {
        static void Main(string[] args) // method names
        {
            Console.WriteLine("Hello World!");

            // if else else if 

            //int i = 10;

            //int j = 20;

            //if (i < j)
            //{
            //    Console.WriteLine("i is less than j");
            //}
            //if(i > j)
            //{
            //    Console.WriteLine("i is greater than j");
            //}

            //int i = 20, j = 20;
            //if (i > j)
            //{
            //    //condition1
            //    Console.WriteLine(" i is greatr than j");
            //}
            //else if (i < j)
            //{
            //    Console.WriteLine(" i is less  than j");
            //}
            //else
            //{
            //    Console.WriteLine(" i is equal to j");
            //}

            // switch 

            //int x = 100;

            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine(" value of x is 1");
            //        break;
            //        case 2:
            //        Console.WriteLine(" value of x is 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("value of x is 3");
            //        break;
            //    case 4:
            //        Console.WriteLine(" value of x is 4");
            //        break;
            //    case 10:
            //        Console.WriteLine("value of x is 10");
            //        break;
            //   default: Console.WriteLine(" value does not meet the switch condition");
            //        break;
            //}


            // for loop //for each loop
            // for (int i =0; i< 10; i++)
            //{
            //    Console.WriteLine("value of i {0}",i);
            //}

            //int x = 0;
            //while (x < 10)
            //{
            //    Console.WriteLine("value of x is {0}", x);
            //    x++;
            //}

            // while loop 
            //do while loop

            //foreachloop

            //string[] cities = { "Dallas", "Chicago", "Milawaukee", "Houston" };
            //foreach(var dummycity in cities)
            //{
            //    Console.WriteLine(dummycity);
            //}

            //test labobjectobj = new test();

            //labobjectobj.Paramstring = "This is setting up parameter information";

            //labobjectobj.LabTesting("Hey Im calling you from main method");

            fatherClass obj = new fatherClass();
            obj.x = 100;
            obj.y = 200;
            obj.parentmethod();
            

        }
    }
    class childclass:fatherClass
    {

        public void childMethod()
        {
            Console.WriteLine("Im in  child class");

            childclass objectnew = new childclass();
            string[] argsarray = { "test2", "test3" };
            //Main(
            //    argsarray);// father method

            objectnew.parentmethod();// grand father method;

            objectnew.x = 100;// grand father properties

            objectnew.y = 200;// grand father property


        }

    }
}
