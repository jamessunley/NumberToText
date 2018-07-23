namespace NumbersToString
{
    public class NumberConverter : INumberConverter
    {
        public string Convert(int number)
        {

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var teensMap = new[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 10)
            {
                return unitsMap[number];
            }
            else if (number >= 10 && number < 20)
            {
                return teensMap[number - 10];
            }
            else return "twenty";
           
        }
    }
}