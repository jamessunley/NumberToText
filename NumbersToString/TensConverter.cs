namespace NumbersToString
{
    public class TensConverter : ITensConverter
    {
        public string Convert(int number)
        {
            var tensMap = new[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            return tensMap[number/10 - 2];
        }
    }
}