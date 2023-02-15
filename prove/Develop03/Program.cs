using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = " ";
        //Get The reference using the reference class, then 
        //setting the final reference value to the scripture class "_reference" attribute
            Reference reference = new Reference();
            string refer = reference.GetMultVReference();
            Scripture scrip =new Scripture();
            scrip.SetfinalRefer(refer);
            Console.Clear();
            scrip.DisplayComplScrip();
        while(answer != "quit"){
            answer = Console.ReadLine();
            Console.Clear();
            scrip.setwords();            
            scrip.finalText();
            Console.WriteLine("\nPress enter to continue or type quit to finish");
            }        
    }
    
}
