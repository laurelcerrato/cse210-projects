using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "a";
        //Get The reference using the reference class, then setting the final reference value to the scripture class "_reference" attribute
            Reference reference = new Reference();
            string refer = reference.GetMultVReference();
            Scripture scrip =new Scripture();
            scrip.SetfinalRefer(refer);
            scrip.RenderedText();
        while(answer != "quit"){
            answer = Console.ReadLine();
            Console.Clear();
            scrip.RenderedText();
            scrip.extractWordFromScrip();
            Word w =new Word();
                w.returnedword();
            
        //     scrip.HiddenWord();
        // }
        
    }
    
}}
