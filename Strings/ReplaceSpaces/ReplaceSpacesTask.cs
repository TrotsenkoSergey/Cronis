using System.Text;

namespace Strings;

public class ReplaceSpacesTask
{
    public string ReplaceSpacesWrapper(string str, int trueLength)
    {
        char[] strAsArr = str.ToCharArray();
        ReplaceSpaces(strAsArr, trueLength);
        return new string(strAsArr);
    }

    private void ReplaceSpaces(char[] strAsArr, int trueLength)
    {
        int tailLetterIndex = strAsArr.Length;
        for (int i = trueLength - 1; i != 0; i--) 
        {
            int phraseLetterIndex = i;
            if (strAsArr[phraseLetterIndex] != ' ')
            {
                strAsArr[tailLetterIndex - 1] = strAsArr[phraseLetterIndex];
                tailLetterIndex--;
            }
            else 
            {
                strAsArr[tailLetterIndex - 1] = '0';
                strAsArr[tailLetterIndex - 2] = '2';
                strAsArr[tailLetterIndex - 3] = '%';
                tailLetterIndex -= 3;
            }
        }
    }

    public string ReplaceSpacesMy(string s, int length)
    {
        StringBuilder sb = new();
        int i = 0;
        for (i = 0; i < length; i++)
        {
            if (char.IsWhiteSpace(s[i])) 
                sb.Append("%20");
            else 
                sb.Append(s[i]);
        }
        return sb.ToString();
    }
}
