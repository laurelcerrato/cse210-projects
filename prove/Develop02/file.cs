using System.IO;
public class files
{
    public string _filename;
    public string _userfile;
    public List<string> Entry = new List<string>();

    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (string entry in Entry)
            {
                outputFile.WriteLine(entry);
            }

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