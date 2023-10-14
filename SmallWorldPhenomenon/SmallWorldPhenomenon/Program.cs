using System;
using System.Collections.Generic;
using System.IO;
namespace Small_World_Phenomenon
{
    class Program
    {
        static void Main(string[] args)
        {
            //For reading movie -actors
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("**Movie and its Actors**");
            Console.WriteLine("************************");
            try
            {
                StreamReader SR = new StreamReader(@"C:\Users\Ahmed Yosif\Desktop\SmallWorldPhenomenon\SmallWorldPhenomenon\Testcases\Sample\movies1.txt");
                string Line = SR.ReadLine();
                Dictionary<string, List<string>> Film_Act = new Dictionary<string, List<string>>();
                Dictionary<String, List<string>> Actors_Dic = new Dictionary<string, List<string>>();
                while (Line != null)
                {   
                    string[] Line_Split = Line.Split("/"); 
                    if (!Film_Act.ContainsKey(Line_Split[0]))
                    {
                        Film_Act.Add(Line_Split[0], new List<string>());
                    }
                    foreach (var i in Line_Split)
                    {
                        if (Line_Split[0] != i)
                        {
                            Film_Act[Line_Split[0]].Add(i);
                        }

                    }
                     
                    Line = SR.ReadLine();
                }
                Console.WriteLine("congrats all done...");
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            //pairs of Actors
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("**Pairs of Actors**");
            Console.WriteLine("************************");
            try
            {
                StreamReader SR = new StreamReader(@"C:\Users\Ahmed Yosif\Desktop\SmallWorldPhenomenon\SmallWorldPhenomenon\Testcases\Sample\queries1.txt");
                string Lines = SR.ReadLine();
                Dictionary<string, List<string>> Pairs_Act = new Dictionary<string, List<String>>();
                while (Lines != null)
                {
                    string[] Pairs_Split = Lines.Split("/");
                    if (!Pairs_Act.ContainsKey(Pairs_Split[0]))
                    {
                        Pairs_Act.Add(Pairs_Split[0], new List<string>());
                    }
                    else
                    {
                        Pairs_Act[Pairs_Split[0]].Add(Pairs_Split[1]);
                        Lines = SR.ReadLine();
                    }

                }

                Console.WriteLine("congrats all done..");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            try 
            {
                //Each Act --> His Movies
                StreamReader SR = new StreamReader(@"C:\Users\Ahmed Yosif\Desktop\SmallWorldPhenomenon\SmallWorldPhenomenon\Testcases\Sample\movies1.txt");
                string Lines = SR.ReadLine();
                Dictionary<string, List<string>> Act_Dic = new Dictionary<string, List<String>>();
               
                while (Lines != null)
                {
                    string[] Movie = Lines.Split("/");
                    foreach (var v in Movie)
                    {
                        if (!Act_Dic.ContainsKey(v) )
                        {
                            if (v != Movie[0])
                            {
                                Act_Dic.Add(v, new List<string>());
                                Act_Dic[v].Add(Movie[0]);
                            }
                        }
                        else
                        {
                            Act_Dic[v].Add(Movie[0]);
                        }

                         
                    }
                    Lines = SR.ReadLine();
                }
               foreach (KeyValuePair<string, List<string>>pair in Act_Dic)
               {
                   Console.WriteLine("Actor Name -->  {0}" , pair.Key);
                   foreach (var v in pair.Value)
                   {
                       Console.WriteLine(v);
                   }
               }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }

        }
 

    }
}




