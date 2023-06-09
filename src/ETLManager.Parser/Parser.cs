using System.Text.Json;

class ETLLoader
{
    public ParserFileMain? parserFileData;
    public ETLLoader(string FilePath)
    {
        LoadParserFile(FilePath);
    }

    private void LoadParserFile(string parserFile)
    {
        try
        {
            string? jsonText = File.ReadAllText(parserFile);
            parserFileData = JsonSerializer.Deserialize<ParserFileMain>(jsonText)!;
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Failure: {e.Message}");
        }
        finally
        {
            Console.WriteLine("ParserFile Loaded");
        }
    }
}