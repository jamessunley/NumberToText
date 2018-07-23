namespace NumbersToString
{
    public class TeenConverter : ITeenConverter
    {
        public string Convert(int number)
        {
            var teensMap = new[] { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            return teensMap[number - 11];
        }
    }
}