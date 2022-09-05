// See https://aka.ms/new-console-template for more information
public class DiamondPrinter
{
    public string Print(char midPointCharacter)
    {
        var characterIndex = midPointCharacter - 'A' + 1;
        if(characterIndex == 1)
        {
            return "A";
        }

        throw new NotImplementedException();
    }
}