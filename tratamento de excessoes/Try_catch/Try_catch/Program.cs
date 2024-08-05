namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            try
            {
                Console.WriteLine(array[3]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Exceção capturada: {e.Message}");
            }
        }
    }
}