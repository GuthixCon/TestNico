using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sten = new stenen();
            var sax = new saxen();
            var påse = new påsen();
            var human = new human();
            var compcounter = 0;
            var counter = 0;
            string? answer = "";
            string? name = "";
            //yesok yes = new yesok();
            //yes.test1();
            int index = 0;

            Console.ForegroundColor = ConsoleColor.Red;



            List<object> list = new List<object>() { sten.sten, sax.sax, påse.påse };

            Console.WriteLine("Welcome this is sten, sax, påse, it's best of three");
            Console.WriteLine("Hi what is your name?");
            name = Console.ReadLine();
            Console.Clear();
            human.name = name;
            var keepplaying = true;


            while (keepplaying)
            {
                Random rand = new Random();
                index = rand.Next(list.Count);
                Console.WriteLine($"Hi {name}, please write either sten, sax or påse");
                answer = Console.ReadLine();
                Console.Clear();

                var companswer = list[index].ToString();

                //if (counter > 0)
                //{
                //    Console.WriteLine("Would you like to delete your progress? y/n");
                //    var ans = Console.ReadLine();
                //    if (ans == "y")
                //    {
                //        human.counter = 0;
                //        compcounter = 0;
                //    }
                //}
                counter++;
                Console.WriteLine($"Games: {counter}");
                if (answer != companswer)
                {
                    switch (answer)
                    {
                        case "sten":
                            if (companswer == "sax")
                            {
                                human.counter++;
                                Console.WriteLine($"you won {human.counter} - {compcounter}\nYou had {answer} \n computer had {companswer}.");
                            }
                            else
                            {
                                compcounter++;
                                Console.WriteLine($"You lost this round {human.counter} - {compcounter}\nYou had {answer} \n computer had {companswer}.");
                            }
                            break;
                        case "sax":
                            if (companswer == "påse")
                            {
                                human.counter++;
                                Console.WriteLine($"you won this round {human.counter} - {compcounter}\nYou had {answer} \n computer had {companswer}.");
                            }
                            else
                            {
                                compcounter++;
                                Console.WriteLine($"You lost this round {human.counter} - {compcounter}\nYou had {answer} \n computer had {companswer}");
                            }
                            break;
                        case "påse":
                            if (companswer == "sten")
                            {
                                human.counter++;
                                Console.WriteLine($"you won this round {human.counter} - {compcounter}\nYou had {answer} \n computer had {companswer} ");
                            }
                            else
                            {
                                compcounter++;
                                Console.WriteLine($"You lost this round {human.counter} - {compcounter}\nYou had {answer} \n computer had {companswer}");
                            }
                            break;
                        default:
                            Console.WriteLine(" \n you need to write either sten, sax, påse");
                            counter--;
                            break;

                    }
                }
                else
                {
                    Console.WriteLine($"You had the same \n You: {answer} - Computer: {companswer}");
                    counter--;
                }
                if (human.counter >= 3)
                {
                    Console.WriteLine(" \n congrats you won!");
                    break;
                }
                else if (compcounter >= 3)
                {
                    Console.WriteLine(" \n Sadly you lost");
                    break;
                }
            }
        }

        class human
        {
            public string name { get; set; }
            public int counter { get; set; }
        }


        class stenen
        {
            public string sten { get; set; } = "sten";
        }
        class saxen
        {
            public string sax { get; set; } = "sax";
        }
        class påsen
        {
            public string påse { get; set; } = "påse";
        }
    }
}