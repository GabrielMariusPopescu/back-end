namespace MicroService4Net.Example
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var microService = new MicroService();
            microService.Run(args);
        }
    }
}
