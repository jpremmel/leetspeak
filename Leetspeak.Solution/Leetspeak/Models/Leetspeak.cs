namespace Translator
{
    public class Leetspeak
    {
        public string Translate(string input)
        {
            char[] inputArray = input.ToCharArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == 'e')
                {
                    inputArray[i] = '3';
                }
            }


            string leetspeak = string.Join("", inputArray);
            return leetspeak;
        }
    }
}