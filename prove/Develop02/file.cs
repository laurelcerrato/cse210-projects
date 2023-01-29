using System.IO;
public class Files
{
    public string _filename;
    public string _userfile;
    public List<string> Entry = new List<string>();

    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine($"Date: {Entry[0]}\nQuestion: {Entry[1]}\nAnswer: {Entry[2]}");

    }}
    public void LoadFile()
    {
        string fileName = _userfile;
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            }
    }

}