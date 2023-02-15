using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = " ";
        //Get The reference using the reference class, then setting the final reference value to the scripture class "_reference" attribute
            Reference reference = new Reference();
            string refer = reference.GetMultVReference();
            Scripture scrip =new Scripture();
            scrip.SetfinalRefer(refer);
            // Word w =new Word();
            Console.Clear();
            scrip.DisplayComplScrip();
        while( answer!= "quit"){
            answer = Console.ReadLine();
            scrip.extractIndexFromScrip();
            scrip.HideWord();
            scrip.RenderedText();
            // Word w =new Word();
            //     w.setWord();
            
        //     scrip.HiddenWord();
        // }
        
    }
    
}}

