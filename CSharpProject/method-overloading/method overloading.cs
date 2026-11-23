
using System;

namespace MethodOverridingVirtualAndOverride
{
    class baseClass
    {
        public virtual void show()
        {
            Console.WriteLine("Base class");
        }
    }

    class derived : baseClass
    {
        // 'show()' is 'override' here
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }

    class Dog
    {
        static void Main(string[] args)
        {
            baseClass obj;
            obj = new baseClass();
            obj.show();

            obj = new derived();
            obj.show();
        }
    }
}
