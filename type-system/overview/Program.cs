using System;
using System.Linq;
using System.Collections.Generic;

namespace TypeSystemOverview
{
    // Class example
    public class MyClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public MyClass(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Record example
    public record MyRecord(string Name, int Age);

    // Struct example
    public struct MyStruct
    {
        public string Name;
        public int Age;

        public MyStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Generic class example
    public class MyGenericClass<T>
    {
        public T Value { get; set; }

        public MyGenericClass(T value)
        {
            Value = value;
        }

        public void DisplayValue()
        {
            Console.WriteLine($"Value: {Value}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Primitive types
            int intValue = 42;
            float floatValue = 3.14f;
            string stringValue = "Hello, World!";
            bool boolValue = true;

            Console.WriteLine($"Int: {intValue}, Float: {floatValue}, String: {stringValue}, Bool: {boolValue}");

            // Array example
            int[] intArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array: " + string.Join(", ", intArray));

            // Anonymous type example
            var anonymousType = new { Name = "Anonymous", Age = 30 };
            Console.WriteLine($"Anonymous Type - Name: {anonymousType.Name}, Age: {anonymousType.Age}");

            // Class example
            MyClass myClass = new MyClass("John Doe", 25);
            myClass.DisplayInfo();

            // Record example
            MyRecord myRecord = new MyRecord("Jane Doe", 28);
            Console.WriteLine($"Record - Name: {myRecord.Name}, Age: {myRecord.Age}");

            // Struct example
            MyStruct myStruct = new MyStruct("Struct Example", 35);
            myStruct.DisplayInfo();

            // Generic class example
            MyGenericClass<string> myGenericClass = new MyGenericClass<string>("Generic Value");
            myGenericClass.DisplayValue();

            // LINQ example
            var query = from item in intArray
                        where item % 2 == 0
                        select item;
            Console.WriteLine("LINQ Query Result: " + string.Join(", ", query));
        }
    }
}