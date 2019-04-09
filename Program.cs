using System;
using System.Collections.Generic;

namespace dictionary
{


    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("BEP", "Be everywhere poppin");
            stocks.Add("DES", "Destiny");
            stocks.Add("MAN", "Mancave place");

            stocks.Add("GE", "get everywhere");





            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();


            purchases.Add(new Dictionary<string, double>() { { "GE", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "GE", 580.98 } });
            purchases.Add(new Dictionary<string, double>() { { "GE", 406.34 } });

            purchases.Add(new Dictionary<string, double>() { { "CAT", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "DES", 580.98 } });
            purchases.Add(new Dictionary<string, double>() { { "DES", 406.34 } });




            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            /*
               Iterate over the purchases and record the valuation
               for each stock.
            */
            foreach (Dictionary<string, double> purchase in purchases)
            {
                foreach (KeyValuePair<string, double> stock in purchase)
                {
                    // Does the full company name key already exist in the `stockReport`?
                    if (!stockReport.ContainsKey(stocks[stock.Key]))
                    {
                        stockReport.Add(stocks[stock.Key], stock.Value);
                    }
                    else
                    {
                        stockReport[stocks[stock.Key]] += stock.Value;
                    }
                }
            }
            // Now that the report dictionary is populated, display the final results.

            foreach (KeyValuePair<string, double> item in stockReport)
            {
                Console.WriteLine($"The position in {item.Key} is worth {item.Value}");
            }






            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };

            //Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the
            //name of a planet that it has visited. The key of the dictionary will be the planet name, and the value will be the spacecraft.



            List<Dictionary<string, string>> planetProbes = new List<Dictionary<string, string>>();
            planetProbes.Add(new Dictionary<string, string>() { { "Mercury", "space craft 1" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Mercury", "space craft 2" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Mercury", "space craft 3" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Mars", "space craft 4" } });
            planetProbes.Add(new Dictionary<string, string>() { { "Mars", "space craft 5" } });
            // Iterate over planetList, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet,
            //  which satellites have visited which planet.

            // iterate planets
            foreach (string planet in planetList)
            {
                List<string> matchingProbes = new List<string>();

                foreach (Dictionary<string, string> probe in planetProbes) // iterate planetProbes
                {
                    if (probe.ContainsKey(planet))
                    {
                        matchingProbes.Add(probe[planet]);
                    }
                }

                Console.WriteLine($"For {planet}: ships {String.Join("; ", matchingProbes)} landed");

            }

            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach (KeyValuePair<string, List<string>> listPairedToWord in idioms)
            {
                Console.WriteLine($"{listPairedToWord.Key}: {String.Join(" ", listPairedToWord.Value)}");
            }



            // create a dictionary with key value pairs to represent words (key) and its definition (value)
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // add several words and their definition
            wordsAndDefinitions.Add("Cohort 30", "Pretty damn cool cohort");
            wordsAndDefinitions.Add("Awesome", "Cohort 30 learning C#");

            // use square bracket lookup to get the definition of a specific word

            // loop over dictionary to get the following output: "The definition of [WORD] is [DEFINITION]"
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
            }

        }
    }
}



