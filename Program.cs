// See https://aka.ms/new-console-template for more information
using System;

namespace Textogago
{
   
   class Program 
   {  
    static void Main(string[] args)
    {
        List<string> frase = new List<string>();

        for (int i = 0; i < 12; i++)
        {   
            
            if(frase.Count < 6){
                Console.WriteLine();
                Console.WriteLine($"{i+1}-Por favor insira uma frase");
                 string texto =  Console.ReadLine();
                frase.Add(texto);
            }
            else if(frase.Count >= 6 && frase.Count <= 12)
            {
                Console.WriteLine("Você deseja adicionar mais uma frase? sim / nao");
                string tof = Console.ReadLine();
                string ToF = Convert.ToString(tof);

              
                 if ( ToF == "sim")
                {
                    Console.WriteLine($"{i}-Por favor insira uma frase");
                    string txt = Console.ReadLine();
                    frase.Add(txt);
                    Console.WriteLine();
                } 
                else  if (ToF == "não" || ToF == "nao")
                {
                    Console.WriteLine();
                    Console.WriteLine("Resultado:");
                    foreach(string f in frase)
                    {
                        string newfrase = f.Replace("pa", "papapapa");
                        Console.WriteLine(newfrase);
                         Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Não Entendi! Por favor digite s - para sim ou n - para não");
                } 
            }    
            else if(frase.Count == 12)
            {
                Console.WriteLine("Você inseriu 12 frases. Este é o limite dado a cada usuário");
                Console.WriteLine();
                Console.WriteLine("Resultado:");
                Console.WriteLine();
                foreach(string f in frase)
                {
                    string newfrase = f.Replace("pa", "papapapa");
                    Console.WriteLine(newfrase);
                }
                break;
            }

              
                
        }
           
        }
    }
}
