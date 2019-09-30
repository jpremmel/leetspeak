namespace Translator
{
    public class Leetspeak
    {
        public string Translate(string input)
        {
            char[] inputArray = input.ToCharArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (char.ToLower(inputArray[i]) == 'e')
                {
                    inputArray[i] = '3';
                }
                else if (char.ToLower(inputArray[i]) == 'o')
                {
                    inputArray[i] = '0';
                }
            }


            string leetspeak = string.Join("", inputArray);
            return leetspeak;
        }
    }
}