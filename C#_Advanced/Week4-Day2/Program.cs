namespace Week4_Day2
{
    internal class Program
    {
        public enum enumMonthes
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            enumMonthes currentMonth = enumMonthes.May;
            Console.WriteLine(currentMonth);           
            Console.WriteLine((int)currentMonth);
        }
    }
}
