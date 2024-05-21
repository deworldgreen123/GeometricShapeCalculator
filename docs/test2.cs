using System;

class Program {
    public static void Main (string[] args) {
        Point myPoint = new Point(0, 0);
        Form myForm = new Form();
        Test1(myPoint, myForm);
        Console.WriteLine(myPoint.X);   // 0
        Console.WriteLine(myForm.Text); // "Hello, World!"

        Test2(ref myPoint, ref myForm);
        Console.WriteLine(myPoint.X);   // 200
        Console.WriteLine(myForm.Text); // Unhandled Exception
    }

    static void Test1(Point p, Form f)
    {
        p.X = 100;
        f.Text = "Hello, World!";
        f = null;
    }

    static void Test2(ref Point p, ref Form f)
    {
        p.X = 200;
        f.Text = "Bye, World!";
        f = null;
    }

    public struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Form
    {
        public String Text { get; set; }
    }
}