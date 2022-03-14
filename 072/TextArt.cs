using System;

namespace MyProject
{
    class TextArt
    {
        public static Dictionary<char, string[]> charDefinitions = new Dictionary<char, string[]>();

        static TextArt()
        {
            charDefinitions.Add('A', new string[] {" _ ", "(_|", "   "});
            charDefinitions.Add('B', new string[] {"|_ ", "|_)", "   "});
            charDefinitions.Add('C', new string[] {" _ ", "(_ ", "   "});
            charDefinitions.Add('D', new string[] {" _|", "(_|", "   "});
            charDefinitions.Add('E', new string[] {" _ ", "(/_", "   "});
            charDefinitions.Add('F', new string[] {" _", "|~", "  "});
            charDefinitions.Add('G', new string[] {" _ ", "(_|", " _|"});
            charDefinitions.Add('H', new string[] {"|_ ", "| |", "   "});
            charDefinitions.Add('I', new string[] {".", "|", " "});
            charDefinitions.Add('J', new string[] {" .", " |", "L|"});
            charDefinitions.Add('K', new string[] {"| ", "|<", "  "});
            charDefinitions.Add('L', new string[] {"|", "|", " "});
            charDefinitions.Add('M', new string[] {" _ _ ", "| | |", "     "});
            charDefinitions.Add('N', new string[] {" _ ", "| |", "   "});
            charDefinitions.Add('O', new string[] {" _ ", "(_)", "   "});
            charDefinitions.Add('P', new string[] {" _ ", "|_)", "|  "});
            charDefinitions.Add('Q', new string[] {" _ ", "(_|", "  |"});
            charDefinitions.Add('R', new string[] {" _", "| ", "  "});
            charDefinitions.Add('S', new string[] {" _", "_\\", "  "});
            charDefinitions.Add('T', new string[] {"_|_", " | ", "   "});
            charDefinitions.Add('U', new string[] {"   ", "|_|", "   "});
            charDefinitions.Add('V', new string[] {"  ", "\\/", "  "});
            charDefinitions.Add('W', new string[] {"  ", "VV", "  "});
            charDefinitions.Add('X', new string[] {"  ", "><", "  "});
            charDefinitions.Add('Y', new string[] {"  ", "\\/", "/ "});
            charDefinitions.Add('Z', new string[] {"__", "/_", "  "});
            charDefinitions.Add(' ', new string[] {"  ", "  ", "  "});
        }
    }
}