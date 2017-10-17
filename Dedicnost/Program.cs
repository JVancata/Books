using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> autori = new List<Author>();
            List<Book> seznamKnih = new List<Book>();// haha


            List<String> inputVypis = new List<string>()
            {
                "jméno autora: ", "příjmení autora: ", "jméno knihy: ", "počet stránek: "
            };
            List<String> inputEBook = new List<string>()
            {
                "URI: ", "velikost: "
            };
            List<String> typyKnih = new List<string>()
            {
                "Papírová kniha", "Elektronická kniha"
            };
            //List<String> input = new List<string>();
            //List<String> inputVypis = new List<string>(); 
            int ctr = 0;
            int bookType = 0;
            while (true)
            {
                if (ctr == 0)
                {
                    Console.WriteLine("Zadej typ knihy");
                    for (int i = 0; i < typyKnih.Count-1; i++)
                    {
                        Console.WriteLine(i+1 + typyKnih[i]);
                    }
                    string userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":

                            break;
                    }
                }
                List<String> input = new List<string>();
                Console.Write("Zadej "+inputVypis[ctr]);   
                input.Add(Console.ReadLine());
                //Console.WriteLine(ctr++);
                //seznamKnih.Add(new EBook(new Author("Matěj", "Rýgr"), 10, "knihycz.cz/?kniha=kniha", 1.3, "Kniha"));
                if (ctr>=inputVypis.Count)
                {
                    //seznamKnih.Add(new Author(input[0], input[1]), input[2]);
                    break;
                }
                ctr++;
            }
            
            //autori.Add(new Author("Matěj", "Rýgr"));
            //seznamKnih.Add(new EBook(autori[0], 10, "knihycz.cz/?kniha=kniha1", 1.3));
            //EBook ebook = new EBook(autori[0], 10, "knihycz.cz/?kniha=kniha1", 1.3);

            //Console.WriteLine(seznamKnih[0].Author.FirstName);
            /*for (int i = 0; i < 10; i++)
            {
                seznamKnih.Add(new EBook(autori[0], 10*i, "knihycz.cz/?kniha=kniha"+i, 1.3, "Kniha"+i));
                Console.WriteLine(seznamKnih[i].Name);
            }*/
        }
    }
}
