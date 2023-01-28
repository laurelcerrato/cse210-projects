using System.IO;
public class files{
    public string _filename;

    public void SaveFile()
    {
        string fileName = _filename;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("");
        }


    }
    public void LoadFile()
    {
        string fileName = _filename;
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
            }
    }

    public void CreateFileName()
    {
        string fileName = _filename;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("");
        }
    }
}