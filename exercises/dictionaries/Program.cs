﻿using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string> ();

            // Add several more words and their definitions
            wordsAndDefinitions.Add ("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add ("Fantastic", "The feeling after reading an awesome comic");
            wordsAndDefinitions.Add ("Womp Womp", "The feeling when something is a total bummer");
            wordsAndDefinitions.Add ("RAWR", "The feeling whe you want to smash something");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine (wordsAndDefinitions.GetValueOrDefault ("Awesome"));
            Console.WriteLine (wordsAndDefinitions.GetValueOrDefault ("Womp Womp"));
            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions) {
                Console.WriteLine ($"The definition of {word.Key} is {word.Value}.");
            }
        }
    }
}