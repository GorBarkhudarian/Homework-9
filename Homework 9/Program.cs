
int? a = null, b = null, c = null;
Solutions.Input(ref a, ref b, ref c);


var rootsClass = new Solution();
(double x1, double x2) = rootsClass.RootCalc((int)a, (int)b, (int)c);

Console.WriteLine("Class\n");

if (!(x1 == -1 || x2 == -1))
    Console.WriteLine($"First Root: {x1}\n" +
                        $"Second Root: {x2}\n");
else
    Console.WriteLine("No Solution. \n");


Solutions.Run();

public class Solution
{

    int a { get; set; }
    int b { get; set; }
    int c { get; set; }

    public (double val1, double val2) RootCalc(int a, int b, int c, double x1 = -1, double x2 = -1)
    {
        double discriminant;

        discriminant = b * b - 4 * a * c;

        if (discriminant == 0)
        {
            x1 = -b / (2.0 * a);
            x2 = x1;
            return (x1, x2);

        }
        else if (discriminant > 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return (x1, x2);
        }

        x1 = x2 = -1;
        return (x1, x2);

    }

}
public class Solutions
{
    public static void Input(ref int? a, ref int? b, ref int? c)
    {
        do
        {
            Console.Write("Input the value of a : ");

            try
            {
                a = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
           
            }


        } while (!(a > int.MinValue && a < int.MaxValue));

        do
        {
            Console.Write("Input the value of b : ");

            try
            {
                b = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
    
            }


        } while (!(b > int.MinValue && b < int.MaxValue));

        do
        {
            Console.Write("Input the value of c : ");

            try
            {
                c = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception)
            {
                  
            }


        } while (!(c > int.MinValue && c < int.MaxValue));
    }
    private static void SqrtRef(int a, int b, int c, ref double x1, ref double x2)
    {
        double discriminant;

        discriminant = b * b - 4 * a * c;

        if (discriminant == 0)
        {
            x1 = -b / (2.0 * a);
            x2 = x1;

        }
        else if (discriminant > 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

        }

    }
    private static (double, double) SqrtTuple(int a, int b, int c)
    {
        double discriminant;
        (double, double) roots;

        discriminant = b * b - 4 * a * c;

        if (discriminant == 0)
        {
            roots.Item1 = -b / (2.0 * a);
            roots.Item2 = roots.Item1;
            return roots;

        }
        else if (discriminant > 0)
        {
            roots.Item1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            roots.Item2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return roots;

        }

        return (-1, -1);

    }
    private static double[] SqrtArray(int a, int b, int c)
    {
        double discriminant;
        var arr = new double[2];

        discriminant = b * b - 4 * a * c;

        if (discriminant == 0)
        {
            arr[0] = -b / (2.0 * a);
            arr[1] = arr[0];
            return arr;

        }
        else if (discriminant > 0)
        {
            arr[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
            arr[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return arr;

        }

        arr[0] = arr[1] = -1;

        return arr;
    }

    public static void Run()
    {
        int? a = null, b = null, c = null;
        Input(ref a, ref b, ref c);

        double x1 = -1, x2 = -1;
        SqrtRef((int)a, (int)b, (int)c, ref x1, ref x2);
        Console.WriteLine("Ref\n");

        if (!(x1 == -1 || x2 == -1))
            Console.WriteLine($"First Root: {x1}\n" +
                             $"Second Root: {x2}\n");
        else
            Console.WriteLine("No Solution. \n");

       
        var rootsTuple = SqrtTuple((int)a, (int)b, (int)c);
        Console.WriteLine("Tuple\n");

        if (!(rootsTuple.Item1 == -1 || rootsTuple.Item2 == -1))
            Console.WriteLine($"First Root: {rootsTuple.Item1}\n" +
                             $"Second Root: {rootsTuple.Item2}\n");
        else
            Console.WriteLine("No Solution. \n");

       
        var rootsArray = SqrtArray((int)a, (int)b, (int)c);
        Console.WriteLine("Array\n");

        if (!(rootsArray[0] == -1 || rootsArray[1] == -1))
            Console.WriteLine($"First Root: {rootsArray[0]}\n" +
                             $"Second Root: {rootsArray[1]}\n");
        else
            Console.WriteLine("No Solution. \n");

    }
}