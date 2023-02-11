using System;
public class Scripture
{
    public string _scripture = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life";
    
    public Scripture(string reference, string scripture = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life")
    {;
        List <string> _word = new List<string>();
        string[] splittedscrip = scripture.Split(" ");
        foreach (string words in splittedscrip) {
        _word.Add(words);
        foreach(string w in _word){
            Console.WriteLine(w);
        }
        }
    }} 