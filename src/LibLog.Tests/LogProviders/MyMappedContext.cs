namespace LibLog.Logging.LogProviders
{
    using LogLevel = YourRootNamespace.Logging.LogLevel;

    internal class MyMappedContext
    {
        public int ThirtySeven => 37;

        public string Name { get; set; } = "World";

        public LogLevel Level { get; set; } = LogLevel.Trace;

        public override string ToString()
        {
            return Name;
        }
    }
}