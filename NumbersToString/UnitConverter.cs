namespace NumbersToString
{
    public class UnitConverter : IUnitConverter
    {
        public string Convert(int number)
        {
            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

                return unitsMap[number];
        }
    }
}