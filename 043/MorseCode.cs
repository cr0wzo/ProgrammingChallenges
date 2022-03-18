namespace MyProject
{
    class MorseCode
    {   
        private static Dictionary<char, string> MorseChars;

        static MorseCode()
        {
            MorseChars = new Dictionary<char, string>();
            MorseChars.Add('A', ".-");
            MorseChars.Add('B', "-...");
            MorseChars.Add('C', "-.-.");
            MorseChars.Add('D', "-..");
            MorseChars.Add('E', ".");
            MorseChars.Add('F', "..-.");
            MorseChars.Add('G', "--.");
            MorseChars.Add('H', "....");
            MorseChars.Add('I', "..");
            MorseChars.Add('J', ".---");
            MorseChars.Add('K', "-.-");
            MorseChars.Add('L', ".-..");
            MorseChars.Add('M', "--");
            MorseChars.Add('N', "-.");
            MorseChars.Add('O', "---");
            MorseChars.Add('P', ".--.");
            MorseChars.Add('Q', "--.-");
            MorseChars.Add('R', ".-.");
            MorseChars.Add('S', "...");
            MorseChars.Add('T', "-");
            MorseChars.Add('U', "..-");
            MorseChars.Add('V', "...-");
            MorseChars.Add('W', ".--");
            MorseChars.Add('X', "-..-");
            MorseChars.Add('Y', "-.--");
            MorseChars.Add('Z', "--..");
            MorseChars.Add('1', ".----");
            MorseChars.Add('2', "..---");
            MorseChars.Add('3', "...--");
            MorseChars.Add('4', "....-");
            MorseChars.Add('5', ".....");
            MorseChars.Add('6', "-....");
            MorseChars.Add('7', "--...");
            MorseChars.Add('8', "---..");
            MorseChars.Add('9', "----.");
            MorseChars.Add('0', "-----");
        }

        public static string GetSequence(char character)
        {
            try
            {
                return MorseChars[character];
            } catch(KeyNotFoundException)
            {
                return System.Convert.ToString(character);
            }
        }
    }
}