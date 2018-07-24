namespace NumbersToString
{
    public class ConverterFlow : IConverterFlow
    {
        private readonly IUnitConverter _unitConverter;
        private readonly ITeensConverter _teensConverter;
        private readonly ITensConverter _tensConverter;

        public ConverterFlow(IUnitConverter unitConverter, ITeensConverter teensConverter, ITensConverter tensConverter)
        {
            _unitConverter = unitConverter;
            _teensConverter = teensConverter;
            _tensConverter = tensConverter;
        }

        public string Convert(int number)
        {
            string word = "";
            
            if (number <= 10)
            {
                word += _unitConverter.Convert(number);
            }
            else if (number > 10 && number < 20)
            {
                word += _teensConverter.Convert(number);
            }
            else if (number >= 20)
            {
                word += _tensConverter.Convert(number);
                if((number % 10) > 0)
                {
                    word += " " + _unitConverter.Convert(number % 10);
                }
            }
            return word;
        }
    }
}