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
            Console.Title = "Opel smrad";
            
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
            List<String> inputBook = new List<string>()
            {
                "Weight: ", "Stock: "
            };
            List<String> typyKnih = new List<string>()
            {
                "Papírová kniha", "Elektronická kniha"
            };
            //List<String> input = new List<string>();
            //List<String> inputVypis = new List<string>(); 
            int ctr = 0;
            int bookType = 0;
            int maxInputs = 0;
            List<String> input = new List<string>();
            while (true)
            {
                if (ctr == 0)
                {
                    for (int i = 0; i <= typyKnih.Count - 1; i++)
                    {
                        int a = i;
                        Console.WriteLine(a + 1 + ". " + typyKnih[i]);
                    }
                    while (bookType == 0)
                    {                        
                        Console.Write("Zadej číslo typu knihy: ");
                        string userInput = Console.ReadLine();
                        switch (userInput)
                        {
                            case "1":
                                bookType = 1;
                                maxInputs = inputBook.Count;
                                break;
                            case "2":
                                bookType = 2;
                                maxInputs = inputEBook.Count;
                                break;
                            default:                               
                                break;
                        }
                    }
                    Console.WriteLine("Zapisuješ: " + typyKnih[bookType - 1]);
                    maxInputs += inputVypis.Count;


                }
                if (ctr < inputVypis.Count)
                {
                    Console.Write("Zadej " + inputVypis[ctr]);
                }
                else if (ctr < maxInputs)
                { 
                    switch (bookType)
                    {
                        case 1:
                            Console.Write("Zadej " + inputBook[ctr - inputVypis.Count]);
                            break;
                        case 2:
                            Console.Write("Zadej " + inputEBook[ctr - inputVypis.Count]);
                            break;
                    }
                }
                else
                {
                    /*Console.Write("Chceš pokračovat? A/N: ");
                    string continueInput = Console.ReadLine();
                    if (continueInput.ToLower() == "a")
                    {

                    }*/
                    switch (bookType)
                    {
                        case 1://book
                            seznamKnih.Add(new PaperBook(new Author(input[0], input[1]), int.Parse(input[3]), input[2], int.Parse(input[4]), int.Parse(input[5]) ));
                            break;
                        case 2://ebook
                            seznamKnih.Add(new EBook(new Author(input[0], input[1]), int.Parse(input[5]), input[2], double.Parse(input[4]), input[3]) );
                            break;
                    }
                    
                }
                
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
            Console.WriteLine(seznamKnih[0]);
            
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
