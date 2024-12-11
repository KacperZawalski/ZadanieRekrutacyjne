namespace ZadanieRekrutacyjne.Validation
{
    public class ChooseProductInputValidation
    {
        public bool Validate(string input, int maxRange)
        {
            return input.Length == 2
                && (input.EndsWith('r') || input.EndsWith('a'))
                && Char.IsDigit(input[0])
                && int.Parse(input[0].ToString()) >= 1 && int.Parse(input[0].ToString()) <= maxRange;
        }
    }
}
