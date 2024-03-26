namespace ProblemSolvingForInterview
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input= Console.ReadLine();

            if(IsPalindrome(input)) 
            {
                Console.WriteLine("String is palindromic");

            }
            else
            {
                Console.WriteLine("String is not palindromic");
            }
        }

        public static bool IsPalindrome (string c)
        {

            string normalizestring = "";

            foreach(char s in c)
            {
                if(char.IsLetterOrDigit(s)) 
                {
                    normalizestring += char.ToLower(s);
                }
            }

            for (int i = 0; i < normalizestring.Length / 2; i++)
            {
                if (normalizestring[i] != normalizestring[normalizestring.Length-i - 1])
                {
                    return false;
                }

            }
            return true;

        }
    }
}