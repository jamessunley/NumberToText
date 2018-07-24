namespace NumbersToString
{
    public class TeenConverter : ITeensConverter
    {
        public string Convert(int number)
        {
            var teensMap = new[] { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            return teensMap[number - 11];
        }
    }
}