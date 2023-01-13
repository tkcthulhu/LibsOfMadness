using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This is a basic C# program that I am using to learn the language! Based on MadLibs, this should be pretty fun!
      */


      // Let the user know that the program is starting:

      Console.WriteLine("Initialize Program: Libs of Madness");

      // Give the Mad Lib a title:
      string title = "The Takeover";

      Console.WriteLine(title);
      // Define user input and variables:

      Console.WriteLine("Please enter your answers to the prompts.");

      Console.WriteLine("A name: ");
      string name1 = Console.ReadLine();

      Console.WriteLine("An adjective: ");
      string adjective1 = Console.ReadLine();

      Console.WriteLine("Another adjective: ");
      string adjective2 = Console.ReadLine();

      Console.WriteLine("An animal: ");      
      string animal = Console.ReadLine();

      Console.WriteLine("A noun: ");
      string noun1 = Console.ReadLine();

      Console.WriteLine("A verb: ");
      string verb1 = Console.ReadLine();

      Console.WriteLine("An instrument: ");
      string instrument = Console.ReadLine();

      Console.WriteLine("Another adjective: ");
      string adjective3 = Console.ReadLine();

      Console.WriteLine("Another name: ");
      string name2 = Console.ReadLine();

      Console.WriteLine("A location: ");
      string location1 = Console.ReadLine();

      Console.WriteLine("Another Location: ");
      string location2 = Console.ReadLine();

      Console.WriteLine("Another noun: ");
      string noun2 = Console.ReadLine();

      Console.WriteLine("Another noun");
      string noun3 = Console.ReadLine();

      Console.WriteLine("A year in the future: ");
      string number = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name1} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {noun1}s in stores. They began to {verb1} to the rhythm of the {instrument}, which made all the {animal}s very {adjective3}. Concerned, {name1} texted {name2}, who flew {location1} to {location2} and dropped {noun2} in a puddle of frozen {noun3}. {name1} woke up in the year {number}, in a world where {animal}s ruled the world.";

      // Print the story:

      Console.WriteLine(story);

    }
  }
}
