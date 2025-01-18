namespace CharacterParser
{
    public class Name
    {
        public string? num;
        public string? name;
        public string? abvr;
    }

    public class Symbols
    {
        public Name? symbols;

        public static void LoadSymbols()
        {
            string symbolFile = @"./Assets/loc/en/symbols/0000.txt";
            _ = symbolFile;
        }
    }
}