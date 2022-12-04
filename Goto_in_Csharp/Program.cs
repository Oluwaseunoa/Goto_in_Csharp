class Program
{
    static void Main()
    {
        int i = 1;
        System.Console.WriteLine("Sola");
        System.Console.WriteLine("Tayo");
        System.Console.WriteLine("Dare");
        mylabel:
        System.Console.WriteLine("Seun");
        System.Console.WriteLine("Funke");
        System.Console.WriteLine("Segun");
        i++;
        if(i <= 5)
        {
            goto mylabel;
        }
        System.Console.WriteLine("Kunle");
        System.Console.WriteLine("Ayinke");

        System.Console.ReadKey();
    }
}