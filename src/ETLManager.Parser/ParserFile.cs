public class ParserFileMain
{
    public string? ProcessName { get; set; }
    public List<ParserFileSource>? Source { get; set; }
    public List<ParserFileMapping>? Mapping { get; set; }
    public List<ParserFileTarget>? Target { get; set; }
}

public class ParserFileSource
{
    public string? SourceName { get; set; }
    public string? SourceType { get; set; }
}

public class ParserFileMapping
{
    public string? MappingName { get; set; }
}

public class ParserFileTarget
{
    public string? TargetName { get; set; }
    public string? TargetType { get; set; }
}