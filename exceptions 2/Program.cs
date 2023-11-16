
try
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int x = a * b * c;
    Console.WriteLine(x);
}
catch (FormatException)
{
    Console.WriteLine("format exception, exit");
}
catch (ArgumentException)
{
    Console.WriteLine("argument exception, exit");
}
catch (OverflowException)
{
    Console.WriteLine("overflow exception, exit");
}
catch
{
    Console.WriteLine("non supported exception, exit");
}
