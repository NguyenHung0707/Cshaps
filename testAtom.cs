class test
{
    public static void Main(string[] args)
    {
        Atomic at = new Atomic();
        int i = 0;
        do
        {
            i++;
            at.accept();

        } while (i != 3);
        System.Console.WriteLine("------------------------------------");
        at.Display();
    }
}