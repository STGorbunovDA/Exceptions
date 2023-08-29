try
{
    double d = 0; //Исправлено объявление переменной d на double, чтобы избежать деления на 0.
    double catchedRes1 = intArray[8] / d;
    Console.WriteLine("catchedRes1 = " + catchedRes1);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Catching exception: " + e);
}