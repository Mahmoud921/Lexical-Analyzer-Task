using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your C code:");
        string code = "";
        string line;
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            code += line + "\n";
        }

        // Define keywords
        string[] keywords = {
            "int", "float", "char", "double", "if", "else", "for", "while", "do",
            "return", "main", "void", "string", "include", "printf", "scanf"
        };

        string[] operators = { "+", "-", "*", "/", "=", ">", "<", ">=", "<=", "++", "--", "==" };
        string[] specialChars = { "(", ")", "{", "}", "[", "]", ",", ";", ":" };

        // Pattern matches everything
        string pattern = @"(//.*?$|/\*.*?\*/|""[^""]*""|'[^']*'|==|>=|<=|\+\+|--|[+\-*/=><(){}\[\],;:]|\b\d+\b|\b[a-zA-Z_]\w*\b)";
        MatchCollection matches = Regex.Matches(code, pattern, RegexOptions.Singleline | RegexOptions.Multiline);

        foreach (Match match in matches)
        {
            string token = match.Value.Trim();
            if (string.IsNullOrEmpty(token)) continue;

            // Comments
            if (Regex.IsMatch(token, @"^(//|/\*)"))
            {
                Console.WriteLine($"<COMMENT, {token}>");
            }
            // Strings and characters
            else if (Regex.IsMatch(token, @"^("".*""|'.*')$"))
            {
                Console.WriteLine($"<CHARACTER, {token}>");
            }
            // Keywords
            else if (Array.Exists(keywords, kw => kw == token))
            {
                Console.WriteLine($"<KEYWORD, {token}>");
            }
            // Operators
            else if (Array.Exists(operators, op => op == token))
            {
                Console.WriteLine($"<OPERATOR, {token}>");
            }
            //Special characters
            else if (Array.Exists(specialChars, sc => sc == token))
            {
                Console.WriteLine($"<SPECIAL CHARACTER, {token}>");
            }
            //Identifiers
            else if (Regex.IsMatch(token, @"^[a-zA-Z_]\w*$"))
            {
                Console.WriteLine($"<IDENTIFIER, {token}>");
            }
            // Numbers
            else if (Regex.IsMatch(token, @"^\d+$"))
            {
                Console.WriteLine($"<NUMBER, {token}>");
            }
            // Unknowns
            else
            {
                Console.WriteLine($"<UNKNOWN, {token}>");
            }
        }
    }
}
