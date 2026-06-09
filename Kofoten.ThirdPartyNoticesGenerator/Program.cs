using Kofoten.ThirdPartyNoticesGenerator;

try
{
    return GenerateCommandParser.Parse(args).Execute();
}
catch (Exception ex)
{
    Console.WriteLine($"Critical failure: {ex.Message}");
    return 42;
}