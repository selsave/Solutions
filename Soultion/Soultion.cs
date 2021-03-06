namespace DiverseSpace
{
     public class Soultion
    {
        public string solution(int A, int B, int C)
        {
            if  ( A < 0 || A > 100 || B < 0 || B > 100 || C < 0 || C > 100)
            {
                throw new System.ArgumentOutOfRangeException("A B C value range between 0 to 100");
            }
            if (!((A + B + C) > 0))
            {
                throw new System.ArgumentException("Sum of A B C values  should be greater than 0");
            }
            System.Text.StringBuilder output = new System.Text.StringBuilder();
            char characterAlreadyUsed = ' ';

            while (true)
            {
                char currentChar = ' ';
                if (characterAlreadyUsed != 'a' && A > 0 && (A >= B || characterAlreadyUsed == 'b') && (A >= C || characterAlreadyUsed == 'c'))
                {
                    currentChar = 'a';
                    A--;
                }
                else if (characterAlreadyUsed != 'b' && B > 0 && (B >= C || characterAlreadyUsed == 'c'))
                {
                    currentChar = 'b';
                    B--;
                }
                else if (characterAlreadyUsed != 'c' && C > 0)
                {
                    currentChar = 'c';
                    C--;
                }
                if (currentChar == ' ')
                    break;
                if (output.Length > 0 && currentChar == output[output.Length - 1])
                {
                    characterAlreadyUsed = currentChar;
                }
                else
                {
                    characterAlreadyUsed = ' ';
                }
                output.Append(currentChar);
            }

            return output.ToString();
        }
    }
}