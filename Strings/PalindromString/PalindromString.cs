namespace Strings;

public class PalindromString
{
    public bool IsPermutationOfPalindrome(string str)
    {
        bool[] lettersTable = new bool[26]; // всего 26 букв английского алфавита
        int oddLettersCount = 0;
        foreach (char letter in str) 
        { 
            if (letter == ' ') continue;
            int letterCode = GetLetterCode(letter); // получим код в пределах от 0 до 26

            lettersTable[letterCode] = !lettersTable[letterCode];

            if (lettersTable[letterCode]) oddLettersCount++;
            else oddLettersCount--;
        }
        return oddLettersCount <= 1; // т.к. палиндром может быть как с четным количеством букв (т.е. 0)
                                     // так и с нечетным (т.е. 1)   
                                     // все остальное > 1 - не палиндром
    }

    private int GetLetterCode(char letter)
    {
        int aCode = 'a';
        int zCode = 'z';
        int letterCode = letter;
        if (letterCode < aCode || letterCode > zCode) 
        {
            throw new IndexOutOfRangeException("The letter is not in range from 'a' to 'z'.");
        }

        return letterCode - aCode;
    }
}
