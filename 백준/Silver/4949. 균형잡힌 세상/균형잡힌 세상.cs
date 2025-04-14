using System.Text;

namespace empty
{
    public class IsVPS
    {
        private char[] chars = new char[104];
        private int index = 0;
        private bool isVPSBool = true;

        public void GetString(string s)
        {
            foreach (char c in s)
            {
                GetChar(c);
            }
        }
        public void GetChar(char c)
        {
            if(c == '(' || c == '[')
            {
                chars[++index] = c;
            }
            else if(c == ')' && chars[index] == '(')
            {
                index--;
            }
            else if (c == ']' && chars[index] == '[')
            {
                index--;
            }
            else if( c==')' || c== ']')
            {
                isVPSBool = false;
            }
        }

        public string isVPS()
        {
            if (index == 0 && isVPSBool)
            {
                return /*index +*/ "yes" + "\n";
            }
            else
            {
                return /*index +*/ "no" + "\n";
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            while (true)
            {
                IsVPS isVPS = new IsVPS();
                string s = Console.ReadLine();
                if (s == ".") break;
                isVPS.GetString(s);
                stringBuilder.Append(isVPS.isVPS());

            }

            Console.Write(stringBuilder.ToString());
        }
    }
}

