namespace PhoneBookUI
{
    public class FrontColors
    {
        public static string OutputError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(error);
            Console.ResetColor();
            return error;
        }
        public static string OutputWarning(string warning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(warning);
            Console.ResetColor();
            return warning;
        }
        public static string OutputInfo(string information)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine(information);
            Console.ResetColor();
            return information;
        }
    }
}
