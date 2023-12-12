namespace UnitTests.ServiceClient.Data.FileLoaderTest;

public static class FileLoaderHelper
{
    public static void CreateFile()
    {
        File.WriteAllText("data.csv","");
    }

    public static void DeleteFile()
    {
        File.Delete("data.csv");
    }

    public static void SeedData(string data)
    {
        File.AppendAllText("data.csv", $"{data}\n");
    }
}