using CommandLine;

namespace Involved.Cv.Database
{
    public class Options
    {
        [Option('c', "connectionString", Required = true, HelpText = "ConnectionString of DB to migrate")]
        public string ConnectionString { get; set; }

        [Option('r', "reset", Required = false, HelpText = "Resets entire database")]
        public bool Reset { get; set; }

        [Option('s', "seed", Required = false, HelpText = "Seeds data")]
        public bool Seed { get; set; }
    }
}
