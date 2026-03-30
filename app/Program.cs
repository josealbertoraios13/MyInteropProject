using System;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        var math = new Math();
        double result = math.Sum(5.0, 3.0);
        double difference = math.Subtract(5.0, 3.0);
        double product = math.Multiply(5.0, 3.0);
        double quotient = math.Divide(5.0, 3.0);
        double power = math.Power(5.0, 3.0);
        double squareRoot = math.SquareRoot(25.0);

        Console.WriteLine($"The sum of 5.0 and 3.0 is: {result}");
        Console.WriteLine($"The difference of 5.0 and 3.0 is: {difference}");
        Console.WriteLine($"The product of 5.0 and 3.0 is: {product}");
        Console.WriteLine($"The quotient of 5.0 and 3.0 is: {quotient}");
        Console.WriteLine($"The power of 5.0 and 3.0 is: {power}");
        Console.WriteLine($"The square root of 25.0 is: {squareRoot}");
    }
}

public class Math
{
    [DllImport("libwrapper.so", EntryPoint = "create")] 
    static extern IntPtr create();

    [DllImport("libwrapper.so", EntryPoint = "destroy")] 
    static extern void destroy(IntPtr math);

    [DllImport("libwrapper.so", EntryPoint = "native_sum")] 
    static extern double native_sum(IntPtr math, double num1, double num2);

    [DllImport("libwrapper.so", EntryPoint = "native_subtract")]
    static extern double native_subtract(IntPtr math, double num1, double num2);

    [DllImport("libwrapper.so", EntryPoint = "native_multiply")]
    static extern double native_multiply(IntPtr math, double num1, double num2);

    [DllImport("libwrapper.so", EntryPoint = "native_divide")]
    static extern double native_divide(IntPtr math, double num1, double num2);

    [DllImport("libwrapper.so", EntryPoint = "native_power")]
    static extern double native_power(IntPtr math, double base_value, double exponent_value);

    [DllImport("libwrapper.so", EntryPoint = "native_square_root")]
    static extern double native_square_root(IntPtr math, double num);

    private IntPtr nativeMath;

    public Math()
    {
        nativeMath = create();
    }

    ~Math()
    {
        destroy(nativeMath);
    }

    public double Sum(double num1, double num2)
    {
        return native_sum(nativeMath, num1, num2);
    }

    public double Subtract(double num1, double num2)
    {
        return native_subtract(nativeMath, num1, num2);
    }

    public double Multiply(double num1, double num2)
    {
        return native_multiply(nativeMath, num1, num2);
    }

    public double Divide(double num1, double num2)
    {
        return native_divide(nativeMath, num1, num2);
    }

    public double Power(double base_value, double exponent_value)
    {
        return native_power(nativeMath, base_value, exponent_value);
    }

    public double SquareRoot(double num)
    {
        return native_square_root(nativeMath, num);
    }

}