using System.Text;

public class DiamondPrinter
{
    public string Print(char midPointCharacter)
    {
        var characterIndex = midPointCharacter - 'A' + 1;
        var firstPositionToPrintCharacterIn = characterIndex;
        var diamond = new StringBuilder();
        var depth = characterIndex * 2 - 1;
        var isPrintingBottomHalfOfDiamond = false;
        for (var rowNumber = 0; rowNumber < depth; rowNumber++)
        {
            var charactedInThisRow = (char)(isPrintingBottomHalfOfDiamond 
                ? 'A' + depth - rowNumber - 1 
                : 'A' + rowNumber);

            firstPositionToPrintCharacterIn = isPrintingBottomHalfOfDiamond ? ++firstPositionToPrintCharacterIn : --firstPositionToPrintCharacterIn;
            
            var arrayWithSpaces = new string(' ', depth).ToCharArray();
            arrayWithSpaces[firstPositionToPrintCharacterIn] = charactedInThisRow;
            if (arrayWithSpaces.Length > 1)
            {
                arrayWithSpaces[arrayWithSpaces.Length - firstPositionToPrintCharacterIn - 1] = charactedInThisRow;
            }

            diamond.Append(arrayWithSpaces);
            isPrintingBottomHalfOfDiamond = isPrintingBottomHalfOfDiamond || 'A' + rowNumber == midPointCharacter;

            if (rowNumber + 1 != depth)
            {
                diamond.Append(Environment.NewLine);
            }
        }

        return diamond.ToString();
    }
}