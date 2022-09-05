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

        var diamond = new StringBuilder();
        var depth = characterIndex * 2 - 1;
        var isPrintingBottomHalfOfDiamond = false;
        for (var index = 0; index < depth; index++)
        {
            var charToEnter = (char)(isPrintingBottomHalfOfDiamond 
                ? 'A' + depth - index - 1 
                : 'A' + index);
            diamond.Append(charToEnter);
            if(charToEnter != 'A')
            {
                diamond.Append(charToEnter);
            }

            isPrintingBottomHalfOfDiamond = isPrintingBottomHalfOfDiamond || 'A' + index == midPointCharacter;
        }

        return diamond.ToString();
    }
}