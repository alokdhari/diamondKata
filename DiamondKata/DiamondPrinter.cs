using System.Text;

public class DiamondPrinter
{
    /// <summary>
    /// The character that will be the mid point of the diamond.
    /// </summary>
    private readonly char midPointCharacter;
    private readonly char emptySpaceCharacterToUse;

    /// <summary>
    /// Constuctor
    /// </summary>
    /// <param name="midPointCharacter"></param>
    public DiamondPrinter(char midPointCharacter, char emptySpaceCharacterToUse = ' ')
    {
        this.midPointCharacter = midPointCharacter;
        this.emptySpaceCharacterToUse = emptySpaceCharacterToUse;
    }

    /// <summary>
    /// Print the diamond using the initialized mid point character
    /// </summary>
    /// <returns></returns>
    public string Print()
    {
        var firstPositionToPrintCharacterIn = midPointCharacter - 'A' + 1;
        var diamond = new StringBuilder();
        var depthOfDiamond = firstPositionToPrintCharacterIn * 2 - 1;
        var isPrintingBottomHalfOfDiamond = false;

        for (var rowNumber = 0; rowNumber < depthOfDiamond; rowNumber++)
        {
            var currentCharactedToPrint = (char)(isPrintingBottomHalfOfDiamond
                ? 'A' + depthOfDiamond - rowNumber - 1
                : 'A' + rowNumber);

            firstPositionToPrintCharacterIn = isPrintingBottomHalfOfDiamond ? ++firstPositionToPrintCharacterIn : --firstPositionToPrintCharacterIn;
            
            var diamondRow = CreateDiamonRow(firstPositionToPrintCharacterIn, depthOfDiamond, currentCharactedToPrint);

            diamond.Append(diamondRow);

            if (rowNumber + 1 != depthOfDiamond)
            {
                diamond.Append(Environment.NewLine);
            }

            isPrintingBottomHalfOfDiamond = isPrintingBottomHalfOfDiamond || 'A' + rowNumber == midPointCharacter;
        }

        return diamond.ToString();
    }

    private string CreateDiamonRow(int firstPositionToPrintCharacterIn, int depth, char charactedInThisRow)
    {
        var arrayWithSpaces = new string(emptySpaceCharacterToUse, depth).ToCharArray();
        arrayWithSpaces[firstPositionToPrintCharacterIn] = charactedInThisRow;
        if (arrayWithSpaces.Length > 1)
        {
            arrayWithSpaces[arrayWithSpaces.Length - firstPositionToPrintCharacterIn - 1] = charactedInThisRow;
        }

        return new string(arrayWithSpaces);
    }
}