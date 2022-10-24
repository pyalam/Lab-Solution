using System;

namespace Lab1Project //school name
{
  class class1 //parent class
    {
        public void testMethod()
        {
            Console.WriteLine("good boy");
        }

        public virtual void show()
        {
            Console.WriteLine("bad charatcter");
        }
    }
    class class2:class1   //child clas
    {
        public override void show()
        {
            //class2 objchild = new class2();
            //objchild.show();
            Console.WriteLine("Im in child class trying the bad character");
        }

        public void goodboymethodparent()
        {
            class2 objtest = new class2();
            objtest.testMethod();
        }
    }
}

