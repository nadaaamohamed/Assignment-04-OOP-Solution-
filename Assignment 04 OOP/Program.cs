namespace Assignment_04_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q1.Write a class named Calculator that contains a method named Add. Overload the Add method to:

            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(1,2));
            //Console.WriteLine(calculator.Add(2.2,4.3));
            //Console.WriteLine(calculator.Add(1,2,3));

            #endregion
            #region Q2.Create a class named Rectangle with the following constructors
            //Rectangle rectangle = new Rectangle(3);
            //Console.WriteLine(rectangle);
            //Rectangle rectangle1 = new Rectangle(3, 4);
            //Console.WriteLine(rectangle1);
            //Rectangle rectangle2 = new Rectangle();
            //Console.WriteLine(rectangle2);
            #endregion
            #region Q3.Define a class Complex Number that represents a complex number with real and imaginary parts.

            //Complex c1 = new Complex { Real = 4, Imag = 3 };
            //Complex c2 = new Complex { Real = 1, Imag = 2 };
            //Complex c3 = c1 + c2;
            //Console.WriteLine($"Real: {c3.Real}, Imag: {c3.Imag}");
            //Complex c4 = c1 - c2;
            //Console.WriteLine($"Real: {c4.Real}, Imag: {c4.Imag}");
            //Complex ?c5 =  null;
            //Complex c6 = c1 + c5;
            //Console.WriteLine($"Real: {c6.Real}, Imag: {c6.Imag}");
            #endregion
            #region Q4.a) Create a base class named Employee with method That Work as it prints    "Employee is  working".
            // b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
            //*Ensure that the Manager class also calls the Work method of the Employee class within its Overridden method.
            //Employee emp01 = new Employee();
            // emp01.Work();
            //  Employee emp02 = new Manager();
            //  emp02.Work();
            #endregion
            #region Q5.a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".
            //b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.
            //C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.
            //Then explain the difference between using override and new (using binding behavior)

            //BaseClass baseClass = new BaseClass();
            //baseClass.DisplayMessage();
            //BaseClass baseClass1 = new DerivedClass1();
            //baseClass1.DisplayMessage(); //Dynamic Binding - Run_Time Binding
            //                             //Message from DerivedClass1 
            //                             //Override keyword is used to override the base class method in the derived class.
            //BaseClass baseClass2 = new DerivedClass2(); 
            //baseClass2.DisplayMessage();//Static Binding - Compile Time Binding
            //                            //Message from BaseClass
            //                            //New keyword is used to hide the base class method in the derived class.


            #endregion

            #endregion
            #region Part 02
            #region Q1.1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
            Duration duration = new Duration(1, 10, 5);
            Duration duration1 = new Duration(1, 10, 5);
            //Console.WriteLine(duration.ToString());

            //Duration D2=new Duration(3600);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());

            Console.WriteLine(duration+duration1);

            #endregion
            #endregion

        }
    }
}
