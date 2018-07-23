namespace NumbersToString
{
    public class UnitConverter : IUnitConverter
    {
        public string Convert(int number)
        {

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            
            //var tensMap = new[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                return unitsMap[number];           
           
        }
    }
}