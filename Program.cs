﻿//using System.Reflection.Metadata.Ecma335;
//class Program
//{
//    public static void Main(string[] args)
//    {
//    top:
//        try
//        {
//            Calculator calc = new Calculator();
//            calc.calculate();
//        }
//        catch (FormatException e)
//        {
//            Console.WriteLine("Format Exception......");
//            Console.WriteLine(e.ToString());
//        }
//        catch (OverflowException e)
//        {
//            Console.WriteLine("Overflow Exception......");
//            Console.WriteLine(e.ToString());
//        }
//        catch (DivideByZeroException e)
//        {
//            Console.WriteLine("divided by zero Exception......");
//            Console.WriteLine(e.ToString());
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine(e.ToString());
//        }
//        goto top;
//    }
//}
//class Calculator
//{
//     int num1, num2, result;
//    public int calculate()
//    {
//        Console.WriteLine("Enter first number: ");
//        num1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter second number: ");
//        num2 = Convert.ToInt32(Console.ReadLine());
//        result = num1 / num2;
//        Console.WriteLine("Result: {0}", result);
//        return 0;
//    }
//}

//try
//{
//    unchecked
//    {
//        int max = int.MaxValue;
//        Console.WriteLine(max);
//        int min = int.MinValue;
//        Console.WriteLine(min);
//        max++;
//        if (max == min)
//        {
//            Console.WriteLine("is equal");
//            Console.WriteLine(max - 1);
//        }
//    }
//}
//catch (OverflowException)
//{
//    Console.WriteLine("OverFlow Error");
//}
//class TestClass
//{
//    public TestClass()
//    {
//        Console.WriteLine("Hello Class Created");
//    }

//    public static void Main(string[] args)
//    {
//        TestClass[] TestArr = new TestClass[5];
//        for(int i=0;i<5; i++)
//        {
//            TestArr[i]=new TestClass();

//        }
//    }
//}

class student
{
public String ID, Name, Address, Phone;
    public int age;
    public student() //default constructor
    {
        ID = "A-00001";
        Name = "Mg Mg";
        Address = "Yangon";
Phone = "000001";
        age = 15;
        Console.WriteLine("Student Object is created");
         }
    public student(string id, string name, string address, string ph, int a) // argument constructor
    {
        ID = id;
        Name = name;
        Address = address;
        Phone = ph;
        age = a;
    }

public void study()
    {
        Console.WriteLine("Student {0} is studying", Name);
    }
}

