namespace TodoManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            todoManager tm = new todoManager();
            tm.Add(new Todo("cleaning", 5, 1));
            tm.Add(new Todo("Learning", 8, 2));
            tm.Add(new Todo("cooking", 1, 2));

            tm.DisplayAll();


        }
    }
}
