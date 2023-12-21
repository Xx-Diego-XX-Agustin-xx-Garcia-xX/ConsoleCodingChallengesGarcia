using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class ConsoleCodingChallenges
{
    static void Main()
    {
        int a;
        Console.WriteLine("Hello World. My name is Diego Agustin Garcia and today I have a variety of programs to select from. Simply enter an integer corresponding to the program here: ");
        a = Convert.ToInt32(Console.ReadLine());
        switch(a)
        {
            case 1:
                Sum(0, 0);
                break;
            case 2:
                MinutesToSeconds(0);
                break;
            case 3:
                Zeration(0);
                break;
            case 4:
                CircuitPower(0, 0);
                break;
            case 5:
                CalculateAge(0);
                break;
            case 6:
                TriangleArea(0, 0);
                break;
            case 7:
                AtMostZero(0);
                break;
            case 8:
                SumHundred(0, 0);
                break;
            case 9:
                IsEqual(0, 0);
                break;
            case 10:
                GiveSomething("");
                break;
            case 11:
                InvertBoolean(true);
                break;
            case 12:
                HoursToSeconds(0);
                break;
            case 13:
                PolygonAngle(0);
                break;
            case 14:
                NameString("");
                break;
            case 15:
                BooleanAndBoolean(true, true);
                break;
            case 16:
                BasketballPoints(0, 0);
                break;
            case 17:
                RectanglePerimeter(0, 0);
                break;
            case 18:
                HelloName("");
                break;
            case 19:
                AnimalLegCounter(0, 0, 0);
                break;
            case 20:
                FootballPoints(0, 0, 0);
                break;
            case 21:
                MonthName(0);
                break;
            case 22:
                int[] b = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                FindMinMax(b);
                break;
            case 23:
                int[] c = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                FindAbsoluteSum(c);
                break;
            case 24:
                CalculateExponent(0, 0);
                break;
            case 25:
                ArrayLength(0);
                break;
            case 26:
                HammingLength("", "");
                break;
            default:
                Console.WriteLine("ERROR. Integer value is not equal to a current program.");
                Restart("");
                break;
        }
    }
    public static int Sum(int a, int b)
    {
        Console.WriteLine("Enter an integer here: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second integer here: ");
        b = Convert.ToInt32(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine("The sum of " + a + " and " + b + " is equal to " + sum);
        Restart("");
        return 0;
    }
    public static int MinutesToSeconds(int a)
    {
        Console.WriteLine("Enter an integer that represents minutes here: ");
        a = Convert.ToInt32(Console.ReadLine());
        int seconds = a * 60;
        Console.WriteLine(a + " minutes is equal to " + seconds + " seconds");
        Restart("");
        return 0;
    }
    public static int Zeration(int a)
    {
        Console.WriteLine("Enter an addend here: ");
        a = Convert.ToInt32(Console.ReadLine());
        int sum = a + 1;
        Console.WriteLine(a + " plus one is equal to " + sum);
        Restart("");
        return 0;
    }
    public static int CircuitPower(int a, int b)
    {
        Console.WriteLine("Enter a quantity of voltage here: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a quantity of current here: ");
        b = Convert.ToInt32(Console.ReadLine());
        int power = a * b;
        Console.WriteLine("When the voltage is equal to " + a + " and the current is equal to " + b + ", the current power is equal to " + power);
        Restart("");
        return 0;
    }
    public static int CalculateAge(int a)
    {
        Console.WriteLine("Enter your age in years here: ");
        a = Convert.ToInt32(Console.ReadLine());
        int days = a * 365;
        Console.WriteLine("A person who is " + a + " years old has lived at least " + days + " days");
        Restart("");
        return 0;
    }
    public static double TriangleArea(double a, double b)
    {
        Console.WriteLine("Enter an integer for the length of the triangle here:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter an integer for the height of the triangle here:");
        b = Convert.ToInt32(Console.ReadLine());
        double area = (a * b) / 2;
        Console.WriteLine("A triangle with a length of " + a + " and a height of " + b + " will have an area that is equal to " + area + " units squared.");
        Restart("");
        return 0;
    }
    public static int AtMostZero(int a)
    {
        bool atMostZero;
        Console.WriteLine("Enter an integer here: ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a <= 0)
        {
            atMostZero = true;
            Console.WriteLine("The statement that " + a + " is less than or equal to 0 is " + atMostZero);
        }
        else
        {
            atMostZero = false;
            Console.WriteLine("The statement that " + a + " is less than or equal to 0 is " + atMostZero);
        }
        Restart("");
        return 0;
    }
    public static int SumHundred(int a, int b)
    {
        Console.WriteLine("Enter a first integer here:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second integer here:");
        b = Convert.ToInt32(Console.ReadLine());
        int sum = a + b;
        bool sumHundred;
        if (sum < 100)
        {
            sumHundred = true;
            Console.WriteLine("The statement that " + sum + " is less than 100 is " + sumHundred);
        }
        else
        {
            sumHundred = false;
            Console.WriteLine("The statement that " + sum + " is less than 100 is " + sumHundred);
        }
        Restart("");
        return 0;
    }
    public static int IsEqual(int a, int b)
    {
        Console.WriteLine("Enter a first integer here: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second integer here:");
        b = Convert.ToInt32(Console.ReadLine());
        bool isEqual;
        if (a == b)
        {
            isEqual = true;
            Console.WriteLine("The statement that " + a + " is equal to " + b + " is " + isEqual);
        }
        else
        {
            isEqual = false;
            Console.WriteLine("The statement that " + a + " is equal to " + b + " is " + isEqual);
        }
        Restart("");
        return 0;
    }
    public static string GiveSomething(string a)
    {
        Console.WriteLine("Enter a value into the function in the form of a string here: ");
        a = Console.ReadLine();
        Console.WriteLine("Something " + a);
        Restart("");
        return "";

    }
    public static bool InvertBoolean(bool a)
    {
        bool inverse = true;
        Console.WriteLine("Enter a Boolean value (\"true\" or \"false\") here: ");
        a = Convert.ToBoolean(Console.ReadLine());
        if (a == true)
        {
            inverse = !inverse;
        }
        Console.WriteLine("The inverse of " + a + " is equal to " + inverse);
        Restart("");
        return true;
    }
    public static int HoursToSeconds(int a)
    {
        Console.WriteLine("Enter the hour of the day here: ");
        a = Convert.ToInt32(Console.ReadLine());
        int seconds = a * 3600;
        Console.WriteLine(a + " hours are eequal to " + seconds + " seconds");
        Restart("");
        return 0;
    }
    public static int PolygonAngle(int a)
    {
        Console.WriteLine("Enter a number that represents the amount of sides on a polygon: ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a < 3)
        {
            Console.WriteLine("ERROR. Integer value is below the minimum side number of a polygon");
        }
        else
        {
            int angles = (a - 2) * 180;
            Console.WriteLine("The angles of a polygon with " + a + " sides when added equal " + angles + " degrees");
        }
        Restart("");
        return 0;
    }
    public static string NameString(string a)
    {
        Console.WriteLine("Enter your first name here: ");
        a = Console.ReadLine();
        string surname = " Garcia";
        Console.WriteLine(a + surname);
        Restart("");
        return "";
    }
    public static bool BooleanAndBoolean(bool a, bool b)
    {
        bool result = false;
        Console.WriteLine("Enter a Boolean value (\"true\" or \"false\") here: ");
        a = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Enter a second Boolean value here: ");
        b = Convert.ToBoolean(Console.ReadLine());
        if (a == true && b == true)
        {
            result = true;
            Console.WriteLine("The statement that both " + a + " and " + b + " are true is " + result);
        }
        else
        {
            result = false;
            Console.WriteLine("The statement that both " + a + " and " + b + " are true is " + result);
        }
        Restart("");
        return true;
    }
    public static int BasketballPoints(int a, int b)
    {
        int points = 0;
        Console.WriteLine("Enter the number of 2-pointers scored in a basketball game here: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of 3-pointers scored in a basketball game here: ");
        b = Convert.ToInt32(Console.ReadLine());
        if (a < 0 || b < 0)
        {
            Console.WriteLine("ERROR. Integer value is below the minimum number of points that can be scored in a basketball game.");
        }
        else
        {
            points = (a * 2) + (b * 3);   
        }
        Console.WriteLine(points + " points were scored in this basketball game.");
        Restart("");
        return 0;
    }
    public static double RectanglePerimeter(double a, double b)
    {
        double sides = 0;
        double perimeter = 0;
        Console.WriteLine("Enter the length of a rectangle here");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the breadth of a rectangle here");
        b = Convert.ToDouble(Console.ReadLine());
        if (a <= 0 || b <= 0)
        {
            Console.WriteLine("ERROR");
        }
        else
        {
            perimeter = 2 * (a + b);
            Console.WriteLine("A rectangle with a length of " + a + " and a breadth of " + b + " has a perimeter that is equal to " + perimeter);
        }
        Restart("");
        return 0;
    }
    public static string HelloName(string a)
    {
        Console.WriteLine("Enter your name here: ");
        a = Console.ReadLine();
        Console.WriteLine("Hello " + a);
        Restart("");
        return "";
    }
    public static int AnimalLegCounter(int a, int b, int c)
    {
        int legs = 0;
        Console.WriteLine("Enter the number of chickens as an integer here:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of cows as an integer here:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of pigs as an integer here:");
        c = Convert.ToInt32(Console.ReadLine());
        if (a < 0 || b < 0 || c < 0)
        {
            Console.WriteLine("ERROR. Integer value is below the minimum number of animals that can exist.");
        }
        else
        {
            legs = (a * 2) + (b * 4) + (c * 4);
            Console.WriteLine("The amount of legs on " + a + " chickens " + b + " cows, and " + c + " pigs is equal to " + legs);
        }
        Restart("");
        return 0;
    }
    public static int FootballPoints(int a, int b, int c)
    {
        Console.WriteLine("Input the amount of successes, ties, and failures during a football season here: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        int points = (a * 3) + (b * 1) + (c * 0);
        Console.WriteLine("A football team that has succeeded " + a + " times, failed " + c + " times, and tied " + b + " times has scored " + points + " points.");
        Restart("");
        return 0;
    }
    public static int MonthName(int a)
    {
        Console.WriteLine("Input a number corresponding to a month here: ");
        a = Convert.ToInt32(Console.ReadLine());
        switch(a)
        {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("Febuary");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("Novemeber");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("ERROR. There are no more than 12 months in a year.");
                break;
        }
        Restart("");
        return 0;
    }
    public static int FindMinMax(int[] a)
    {
        Console.WriteLine("Input  10 integers to be measured from minimum to maximum here: ");
        a[0] = Convert.ToInt32(Console.ReadLine());
        a[1] = Convert.ToInt32(Console.ReadLine());
        a[2] = Convert.ToInt32(Console.ReadLine());
        a[3] = Convert.ToInt32(Console.ReadLine());
        a[4] = Convert.ToInt32(Console.ReadLine());
        a[5] = Convert.ToInt32(Console.ReadLine());
        a[6] = Convert.ToInt32(Console.ReadLine());
        a[7] = Convert.ToInt32(Console.ReadLine());
        a[8] = Convert.ToInt32(Console.ReadLine());
        a[9] = Convert.ToInt32(Console.ReadLine());
        int min = a[0];
        int max = a[9];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < min)
            {
                a[i] = min;
            }
            else if (a[i] > max)
            {
                a[i] = max;
            }
        }
        Console.WriteLine("In this array, the most minimal value is " + min + " and the most maximal value is " + max);
        Restart("");
        return 0;
    }
    public static int FindAbsoluteSum(int[] a)
    {
        Console.WriteLine("Input at most 10 integers to determine the sum of their absolute values: ");
        a[0] = Convert.ToInt32(Console.ReadLine());
        a[1] = Convert.ToInt32(Console.ReadLine());
        a[2] = Convert.ToInt32(Console.ReadLine());
        a[3] = Convert.ToInt32(Console.ReadLine());
        a[4] = Convert.ToInt32(Console.ReadLine());
        a[5] = Convert.ToInt32(Console.ReadLine());
        a[6] = Convert.ToInt32(Console.ReadLine());
        a[7] = Convert.ToInt32(Console.ReadLine());
        a[8] = Convert.ToInt32(Console.ReadLine());
        a[9] = Convert.ToInt32(Console.ReadLine());
        int b = (int)MathF.Abs(a[0]);
        int c = (int)MathF.Abs(a[1]);
        int d = (int)MathF.Abs(a[2]);
        int e = (int)MathF.Abs(a[3]);
        int f = (int)MathF.Abs(a[4]);
        int g = (int)MathF.Abs(a[5]);
        int h = (int)MathF.Abs(a[6]);
        int i = (int)MathF.Abs(a[7]);
        int j = (int)MathF.Abs(a[8]);
        int k = (int)MathF.Abs(a[9]);
        int sum = b + c + d + e + f + g + h + i + j + k;
        Console.WriteLine("The sum of the absolute values of " + a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + " is equal to " + sum);
        return 0;
    }
    public static int CalculateExponent(int a, int b)
    {
        Console.WriteLine("Input 2 integers that will be used to calculate the base and exponent here: ");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        int power = (int)MathF.Pow(a, b);
        Console.WriteLine(a + " raised to the power of " + b + " is equal to " + power);
        Restart("");
        return 0;
    }
    public static int ArrayLength(int a)
    {
        Console.WriteLine("Input an integer that is less than or equal to 10 to be used as the value of an array here: ");
        a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 1:
                int[] b = { 0 };
                MultiplyByLength(b);
                break;
            case 2:
                int[] c = { 0, 0 };
                MultiplyByLength(c);
                break;
            case 3:
                int[] d = { 0, 0, 0 };
                MultiplyByLength(d);
                break;
            case 4:
                int[] e = { 0, 0, 0, 0 };
                MultiplyByLength(e);
                break;
            case 5:
                int[] f = { 0, 0, 0, 0, 0 };
                MultiplyByLength(f);
                break;
            case 6:
                int[] g = { 0, 0, 0, 0, 0, 0 };
                MultiplyByLength(g);
                break;
            case 7:
                int[] h = { 0, 0, 0, 0, 0, 0, 0 };
                MultiplyByLength(h);
                break;
            case 8:
                int[] i = { 0, 0, 0, 0, 0, 0, 0, 0 };
                MultiplyByLength(i);
                break;
            case 9:
                int[] j = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                MultiplyByLength(j);
                break;
            case 10:
                int[] k = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                MultiplyByLength(k);
                break;
            default:
                Console.WriteLine("ERROR: Integer value exceeds limitations of MultiplyByLength function");
                break;
        }
        return 0;
    }
    public static string MultiplyByLength(int[] a)
    {
        string b = "[ ";
        Console.WriteLine("Input an array of up to 10 integers here:");
        for(int i = 0; i <= a.Length - 1; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine()) * a.Length;
            b += "" + a[i] + " ";
        }
        Console.WriteLine(b + "]");
        return "";
    }
    public static string HammingLength(string a, string b)
    {
        int hammingLength = 0;
        Console.WriteLine("Input 2 strings with a length of any number necessary to calculate the hamming distance here: ");
        a = Console.ReadLine();
        b = Console.ReadLine();
        char[] aArray = a.ToCharArray();
        char[] bArray = b.ToCharArray();
        for(int i = 0; i <= aArray.Length - 1; i++)
        {
            if(aArray[i] != bArray[i])
            {
                hammingLength += 1;
            }
        }
        Console.WriteLine("The hamming distance separating string " + a + " and string " + b + " is equal to " + hammingLength);
        Restart("");
        return "";
    }
    public static string Restart(string a)
    {
        string restartKey = "RESTART";
        Console.WriteLine("The restart key is RESTART");
        Console.WriteLine("To restart the function insert the restart key here: ");
        a = Console.ReadLine();
        if (a == restartKey)
        {
            Main();
        }
        else
        {
            Console.WriteLine("ERROR. The restart key was not equal to the specified restart key");
            Restart("");
        }
        return "";
    }
}