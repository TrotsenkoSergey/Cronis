using Binary.BitVectors;

namespace Strings;

public class PalindromStringBitVector
{
    public bool IsPermutationOfPalindrome(string str)
    {
        int[] lettersTable = CreateLettersTable(str); // получаем таблицу нечетных символов
        return lettersTable[0] == 0 || IsOnlyOneBitSet(lettersTable); // проверяем, что в ней 0 или 1 символ
    }

    private bool IsOnlyOneBitSet(int[] bitVector)
    {
        return (bitVector[0] & (bitVector[0] - 1)) == 0; // проверка, что только один бит установлен
    }

    private int[] CreateLettersTable(string str)
    {
        var bitVector = new BitVector(26); // нам нужно 26 бит, т.к. в алфавите 26 букв
        foreach (char letter in str) 
        {
            if (letter == ' ') continue;

            int letterCode = GetLetterCode(letter);
            if(bitVector.IsBitSet(letterCode))
                bitVector.UnSetBit(letterCode);
            else
                bitVector.SetBit(letterCode);
        }
        return bitVector.Value;
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
