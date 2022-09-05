// See https://aka.ms/new-console-template for more information
using System.Text;

public class DiamondPrinter
{
    public string Print(char midPointCharacter)
    {
        var characterIndex = midPointCharacter - 'A' + 1;
        if(characterIndex == 1)
        {
            return "A";
        }

        var positionToPrintCharacterIn = characterIndex;
        var diamond = new StringBuilder();
        var depth = characterIndex * 2 - 1;
        var isPrintingBottomHalfOfDiamond = false;
        for (var index = 0; index < depth; index++)
        {
            var charactedInThisRow = (char)(isPrintingBottomHalfOfDiamond 
                ? 'A' + depth - index - 1 
                : 'A' + index);

            positionToPrintCharacterIn = isPrintingBottomHalfOfDiamond ? ++positionToPrintCharacterIn : --positionToPrintCharacterIn;
            
            var arrayWithSpaces = new string(' ', depth).ToCharArray();
            arrayWithSpaces[positionToPrintCharacterIn] = charactedInThisRow;
            if (arrayWithSpaces.Length > 1)
            {
                arrayWithSpaces[arrayWithSpaces.Length - positionToPrintCharacterIn - 1] = charactedInThisRow;
            }

            diamond.Append(arrayWithSpaces);
            isPrintingBottomHalfOfDiamond = isPrintingBottomHalfOfDiamond || 'A' + index == midPointCharacter;

            if (index + 1 != depth)
            {
                diamond.Append(Environment.NewLine);
            }
        }

        return diamond.ToString();
    }
}