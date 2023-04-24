using System.Text.Json;

class ETLLoader
{

    public ETLLoader(string FilePath)
    {
        LoadParserFile(FilePath);

    }

    private void LoadParserFile(string parserFile)
    {
        try
        {
            string jsonText = File.ReadAllText(parserFile);
            var jsonData = JsonSerializer.Deserialize<ParserFile>(jsonText);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Fehler: {e.Message}");
        }
    }
}