Using System:

namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int testOne = 5005;
            //should return 'true'
            int testTwo = 2398;
            //should return 'false'
            int testThree = 61016;
            //should return 'true'

            Console.WriteLine(PalTest(testOne));
            Console.WriteLine(PalTest(testTwo));
            Console.WriteLine(PalTest(testThree));
        }

        public static bool PalTest(int x)
        {
            string sOfX = x.ToString();
            char[] xArrey = sOfX.ToCharArray();
            string newSOfX = string.Empty;

            for(int i = xArrey.Length - 1; i > -1; i--)
            {
                newSOfX += xArrey[i];
            }
            if(sOfX == newSOfX) { return true; }
            else { return false; }
        }
        
    }
}