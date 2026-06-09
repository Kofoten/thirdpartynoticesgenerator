using Kofoten.SimpleCli;

namespace Kofoten.ThirdPartyNoticesGenerator;

public class GenerateCommand : ICliCommand
{
    [CliArgument(0, nameof(AssetsPath), Description = "Path to project.assets.json")]
    public required string AssetsPath { get; init; }

    [CliArgument(1, nameof(OutputPath), Description = "Path to output ThirdPartyNotices.txt")]
    public required string OutputPath { get; init; }

    [CliArgument(2, nameof(FallbackDirectory), Description = "Directory containing fallback licenses")]
    public required string FallbackDirectory { get; init; }

    public int Execute()
    {
        throw new NotImplementedException();
    }
}
