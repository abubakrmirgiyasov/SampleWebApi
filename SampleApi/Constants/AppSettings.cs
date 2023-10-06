#nullable disable

namespace SampleApi.Constants;

public class AppSettings
{
    public ConnectionStrings ConnectionStrings { get; set; }
}

public class ConnectionStrings
{
    public string SqlServerConnection { get; set; }
}