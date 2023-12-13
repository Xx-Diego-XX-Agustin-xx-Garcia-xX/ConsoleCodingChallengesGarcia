using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class ConsoleCodingChallenges
{
    static void Main()
    {
        Console.WriteLine("Hello World");
        HammingLength("", "");
    }
    public static int Sum(int a, int b)
    {
        Console.WriteLine("Enter an integer here: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second integer here: ");
        b = Convert.ToInt32(Console.ReadLine());
        int sum = a + b;
        Console.WriteLine("The sum of " + a + " and " + b + " is " + sum);
        return 0;
    }
    public static int ConvertSeconds(int minutes)
    {
        Console.WriteLine("Enter an integer that represents minutes here: ");
        minutes = Convert.ToInt32(Console.ReadLine());
        int seconds = minutes * 60;
        Console.WriteLine(minutes + " minutes is equal to " + seconds + " seconds");
        return 0;
    }
    public static int PlusOne(int addend)
    {
        Console.WriteLine("Enter an addend here: ");
        addend = Convert.ToInt32(Console.ReadLine());
        int onesum = addend + 1;
        Console.WriteLine(addend + " plus one is equal to " + onesum);
        return 0;
    }
    public static int CircuitPower(int voltage, int current)
    {
        Console.WriteLine("Enter a quantity of voltage here: ");
        voltage = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a quantity of current here: ");
        current = Convert.ToInt32(Console.ReadLine());
        int power = voltage * current;
        Console.WriteLine("When the voltage is equal to " + voltage + " and the current is equal to " + current + ", the current power is equal to " + power);
        return 0;
    }
    public static int CalculateAge(int years)
    {
        Console.WriteLine("Enter your age in years here: ");
        years = Convert.ToInt32(Console.ReadLine());
        int days = years * 365;
        Console.WriteLine("A person who is at least " + years + " years old has lived at least " + days + " days");
        return 0;
    }
    public static double TriangleArea(double x, double y)
    {
        Console.WriteLine("Enter an integer for the length of the triangle here:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter an integer for the height of the triangle here:");
        y = Convert.ToInt32(Console.ReadLine());
        double area = (x * y) / 2;
        Console.WriteLine("A triangle with a length of " + x + " and a height of " + y + " when rounded will have an area of " + area + " units squared.");
        return 0;
    }
    public static int AtMostZero(int integer)
    {
        bool atMostZero;
        Console.WriteLine("Enter an integer here: ");
        integer = Convert.ToInt32(Console.ReadLine());
        if (integer <= 0)
        {
            atMostZero = true;
            Console.WriteLine("The statement that " + integer + " is less than or equal to 0 is " + atMostZero);
        }
        else
        {
            atMostZero = false;
            Console.WriteLine("The statement that " + integer + " is less than or equal to 0 is " + atMostZero);
        }
        return 0;
    }
    public static int SumHundred(int addendX, int addendY)
    {
        Console.WriteLine("Enter a first integer here:");
        addendX = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second integer here:");
        addendY = Convert.ToInt32(Console.ReadLine());
        int sumXY = addendX + addendY;
        bool sumHundred;
        if (sumXY < 100)
        {
            sumHundred = true;
            Console.WriteLine("The statement that " + sumXY + " is less than 100 is " + sumHundred);
        }
        else
        {
            sumHundred = false;
            Console.WriteLine("The statement that " + sumXY + " is less than 100 is " + sumHundred);
        }
        return 0;
    }
    public static int IsEqual(int i, int j)
    {
        Console.WriteLine("Enter a first integer here:");
        i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second integer here:");
        j = Convert.ToInt32(Console.ReadLine());
        int ij = i + j;
        bool isEqual;
        if (i == j)
        {
            isEqual = true;
            Console.WriteLine("The statement that " + i + " is equal to " + j + " is " + isEqual);
        }
        else
        {
            isEqual = false;
            Console.WriteLine("The statement that " + i + " is equal to " + j + " is " + isEqual);
        }
        return 0;
    }
    public static string GiveMeSomething(string something)
    {
        Console.WriteLine("Give the function something in the form of a string: ");
        something = Console.ReadLine();
        Console.WriteLine("Something" + something);
        return "";

    }
    public static bool Reverse(bool state)
    {
        bool unstate;
        Console.WriteLine("Insert either a ''true'' or ''false'' value here: ");
        state = Convert.ToBoolean(Console.ReadLine());
        if (state == true)
        {
            unstate = false;
            Console.WriteLine(unstate);
        }
        else if (state == false)
        {
            unstate = true;
            Console.WriteLine(unstate);
        }
        else
        {
            Console.WriteLine("error");
        }
        return true;
    }
    public static int HoursIntoSeconds(int hours)
    {
        Console.WriteLine("Enter the hour of the day here: ");
        hours = Convert.ToInt32(Console.ReadLine());
        int seconds = hours * 3600;
        Console.WriteLine(hours + " hours are eequal to " + seconds + " seconds");
        return 0;
    }
    public static int PolygonAngle(int sides)
    {
        Console.WriteLine("Enter a number that represents the amount of sides on a polygon: ");
        sides = Convert.ToInt32(Console.ReadLine());
        if (sides < 3)
        {
            Console.WriteLine("error");
        }
        else
        {
            int angles = (sides - 2) * 180;
            Console.WriteLine("The angels of a polygon with " + sides + " sides when added equal " + angles + " degrees");
        }
        return 0;
    }
    public static string NameString(string name)
    {
        Console.WriteLine("Enter your first name here: ");
        name = Console.ReadLine();
        string result = (" Garcia");
        Console.WriteLine(name + result);
        return "";
    }
    public static bool BooleanAndBoolean(bool aBoolean, bool bBoolean)
    {
        bool result = false;
        Console.WriteLine("Enter a Boolean value (\"true\" or \"false\") here: ");
        aBoolean = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Enter a second Boolean value here: ");
        bBoolean = Convert.ToBoolean(Console.ReadLine());
        if (aBoolean == true && bBoolean == true)
        {
            result = true;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(result);
        }
        return true;
    }
    public static int BasketballPoints(int bPoints, int cPoints)
    {
        Console.WriteLine("Input the number of 2-pointers scored: ");
        bPoints = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the number of 3-pointers scored: ");
        cPoints = Convert.ToInt32(Console.ReadLine());
        if (bPoints < 0 || cPoints < 0)
        {
            Console.WriteLine("ERROR");
        }
        else
        {
            int yPoints = bPoints * 2;
            int zPoints = cPoints * 3;
            int points = yPoints + zPoints;
            Console.WriteLine(points + " points were scored in this basketball game.");
        }
        return 0;
    }
    public static double RectanglePerimeter(double x, double z)
    {
        double sides = 0;
        double perimeter = 0;
        Console.WriteLine("Insert the length of a rectangle here");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insert the breadth of a rectangle here");
        z = Convert.ToDouble(Console.ReadLine());
        if (x <= 0 || z <= 0)
        {
            Console.WriteLine("ERROR");
        }
        else
        {
            sides = x + z;
            perimeter = 2 * sides;
            Console.WriteLine("A rectangle with a length of " + x + " and a breadth of " + z + " has a perimeter of " + perimeter);
        }
        return 0;
    }
    public static string HelloName(string name)
    {
        Console.WriteLine("Insert your name here: ");
        name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
        return "";
    }
    public static int AnimalLimbCounter(int poultry, int bovine, int porcine)
    {
        string restartKey;
        int totalAnimalLimbs = 0;
        Console.WriteLine("Input the number of chickens as an integer here:");
        poultry = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the number of cows as an integer here:");
        bovine = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the number of pigs as an integer here:");
        porcine = Convert.ToInt32(Console.ReadLine());
        if (poultry < 0 || bovine < 0 || porcine < 0)
        {
            Console.WriteLine("ERROR: You cannot have negative animals");
            Console.WriteLine("To restart input RESTART into the console");
            restartKey = Console.ReadLine();
            if (restartKey == ("RESTART"))
            {
                Main();
            }
            else
            {
                Console.WriteLine("ERROR: Restart key is not equal to RESTART");
            }
        }
        else
        {
            totalAnimalLimbs = (poultry * 2) + (bovine * 4) + (porcine * 4);
            Console.WriteLine("If you have " + poultry + " chickens, " + bovine + " cows, and " + porcine + " pigs, you would have " + totalAnimalLimbs + " limbs from each animal, excluding wings.");
        }
        return 0;
    }
    public static int FootballPoints(int success, int tie, int failure)
    {
        Console.WriteLine("Input the amount of successes, ties, and failures during a football season here: ");
        success = Convert.ToInt32(Console.ReadLine());
        failure = Convert.ToInt32(Console.ReadLine());
        tie = Convert.ToInt32(Console.ReadLine());
        int points = (success * 3) + (tie * 1) + (failure * 0);
        Console.WriteLine("A football team that has succeeded " + success + " times, failed " + failure + " times, and tied " + tie + " times has scored " + points + " points.");
        return 0;
    }
    public static int MonthName(int month)
    {
        Console.WriteLine("Input a number corresponding to a month here");
        month = Convert.ToInt32(Console.ReadLine());
        switch(month)
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
        return 0;
    }

    public static int FindMinMax(int[] sort)
    {
        Console.WriteLine("Input at most 10 integers to be measured from minimum to maximum");
        sort[0] = Convert.ToInt32(Console.ReadLine());
        sort[1] = Convert.ToInt32(Console.ReadLine());
        sort[2] = Convert.ToInt32(Console.ReadLine());
        sort[3] = Convert.ToInt32(Console.ReadLine());
        sort[4] = Convert.ToInt32(Console.ReadLine());
        sort[5] = Convert.ToInt32(Console.ReadLine());
        sort[6] = Convert.ToInt32(Console.ReadLine());
        sort[7] = Convert.ToInt32(Console.ReadLine());
        sort[8] = Convert.ToInt32(Console.ReadLine());
        sort[9] = Convert.ToInt32(Console.ReadLine());
        int min = sort[0];
        int max = sort[9];
        for (int i = 0; i < sort.Length; i++)
        {
            if (sort[i] < min)
            {
                sort[i] = min;
            }
            else if (sort[i] > max)
            {
                sort[i] = max;
            }
        }
        Console.WriteLine("In this array, the most minimal value is " + min + " and the most maximal value is " + max);
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