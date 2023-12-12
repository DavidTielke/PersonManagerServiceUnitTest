namespace ServiceClient.Data;

public class FileLoader : IFileLoader
{
    public string[] LoadLines()
    {
        var lines = System.IO.File.ReadAllLines("data.csv");
        return lines;
    }
}