using System;
using System.Collections;

namespace CSharpBasicsPractice
{
    public class AccessSpecifiers
    {
        private void Test1()
        {
            Console.WriteLine("Private Method");
        }

        internal void Test2()
        {
            Console.WriteLine("Internal Method");
        }

        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }

        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal Method");
        }

        public void Test5()
        {
            Console.WriteLine("Public Method");
        }

        public void CallAllTests()
        {
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
        }
    }


    // outside class (inherited class)
    public class AcessTest : AccessSpecifiers
    {
        public void Test()
        {
            AcessTest acessTest = new AcessTest();
            //acessTest.Test1() // cant call as it is private
            acessTest.Test2();
            acessTest.Test3();
            acessTest.Test4();
            acessTest.Test5();
        }
    }

    public class ThirdClass
    {
        public void Test()
        {
            AccessSpecifiers asp = new AccessSpecifiers();
            asp.Test5();
            asp.Test2();
            asp.Test4();
            //asp.Test3(); //we cant call as it is protected and it is not a inherited class
        }
    }
}


