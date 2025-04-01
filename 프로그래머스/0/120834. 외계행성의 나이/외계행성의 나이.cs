public class Solution {
    public string solution(int age) 
        {
            int num1 = age / 1000;
            int num2 = age % 1000 / 100;
            int num3 = age % 1000 % 100 / 10;
            int num4 = age % 1000 % 100 % 10;


            string char1 = "", char2 = "", char3 = "", char4 = "";

            switch (num1)
            {
                case 0: char1 = "a"; break;
                case 1: char1 = "b"; break;
                case 2: char1 = "c"; break;
                case 3: char1 = "d"; break;
                case 4: char1 = "e"; break;
                case 5: char1 = "f"; break;
                case 6: char1 = "g"; break;
                case 7: char1 = "h"; break;
                case 8: char1 = "i"; break;
                case 9: char1 = "j"; break;

            }
            switch (num2)
            {
                case 0: char2 = "a"; break;
                case 1: char2 = "b"; break;
                case 2: char2 = "c"; break;
                case 3: char2 = "d"; break;
                case 4: char2 = "e"; break;
                case 5: char2 = "f"; break;
                case 6: char2 = "g"; break;
                case 7: char2 = "h"; break;
                case 8: char2 = "i"; break;
                case 9: char2 = "j"; break;

            }
            switch (num3)
            {
                case 0: char3 = "a"; break;
                case 1: char3 = "b"; break;
                case 2: char3 = "c"; break;
                case 3: char3 = "d"; break;
                case 4: char3 = "e"; break;
                case 5: char3 = "f"; break;
                case 6: char3 = "g"; break;
                case 7: char3 = "h"; break;
                case 8: char3 = "i"; break;
                case 9: char3 = "j"; break;

            }
            switch (num4)
            {
                case 0: char4 = "a"; break;
                case 1: char4 = "b"; break;
                case 2: char4 = "c"; break;
                case 3: char4 = "d"; break;
                case 4: char4 = "e"; break;
                case 5: char4 = "f"; break;
                case 6: char4 = "g"; break;
                case 7: char4 = "h"; break;
                case 8: char4 = "i"; break;
                case 9: char4 = "j"; break;

            }
            string answer;
            if (num1 == 0 && num2 == 0 && num3 == 0)
            {
                answer = $"{char4}";

            }
            else if (num1 == 0 && num2 == 0)
            {
                answer = $"{char3}{char4}";
            }
            else if (num1 == 0)
            {
                answer = $"{char2}{char3}{char4}";
            }
            else
            {
                answer = $"{char1}{char2}{char3}{char4}";
            }
            return answer;
        }
}