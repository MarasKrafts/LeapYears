namespace LeapYears
{
    internal class TwentyLeapYears
    {
        static void Main(string[] args)
        {
            int currentYear = DateTime.Now.Year;

            Console.WriteLine("Next 20 Leap Years:");
            for (int i = 1; i <= 20; i++)
            {
                while (!IsLeapYear(currentYear))
                {
                    currentYear++;
                }

                Console.WriteLine(currentYear);
                currentYear++;
            }

            Console.ReadLine();
        }


        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
