namespace CharacterReplacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Character Replacement";
            Console.WriteLine("Type string for process repleacement\n" +
                "type chars to be repleaced\n" +
                "type new chars\n" +
                "type exit for close program\n" +
                "press enter for start");
            while (Console.ReadLine()?.Trim() != "exit")
            {
                Console.WriteLine("Processing");
                var str = Console.ReadLine();
                var oldChar = Console.ReadLine();
                var newChar = Console.ReadLine();
                if (str == null || oldChar == null || newChar == null)
                    throw new Exception("invalid data");
                Console.WriteLine(str.Replace(oldChar, newChar));
                Console.WriteLine("Type 'exit' for close program press enter for another repleacement");
            }
        }
    }
}