using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    public static string[] wordList = {   "sidewalk", "robin", "three", "protect", "periodic",
                                    "somber", "majestic", "jump", "pretty", "wound", "jazzy",
                                    "memory", "join", "crack", "grade", "boot", "cloudy", "sick",
                                    "mug", "hot", "tart", "dangerous", "mother", "rustic", "economic",
                                    "weird", "cut", "parallel", "wood", "encouraging", "interrupt",
                                    "guide", "long", "chief", "mom", "signal", "rely", "abortive",
                                    "hair", "representative", "earth", "grate", "proud", "feel",
                                    "hilarious", "addition", "silent", "play", "floor", "numerous",
                                    "friend", "pizzas", "building", "organic", "past", "mute", "unusual",
                                    "mellow", "analyse", "crate", "homely", "protest", "painstaking",
                                    "society", "head", "female", "eager", "heap", "dramatic", "present",
                                    "sin", "box", "pies", "awesome", "root", "available", "sleet", "wax",
                                    "boring", "smash", "anger", "tasty", "spare", "tray", "daffy", "scarce",
                                    "account", "spot", "thought", "distinct", "nimble", "practise", "cream",
                                    "ablaze", "thoughtless", "love", "verdict", "giant"    };

    static WordGenerator()
    {
        string path = "Assets/Resources/RandomWords.txt"; //path of file
        string content = File.ReadAllText(path); // reads everything in the file
        wordList = content.Split(new[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);
        //Splits each word in the text file for the array, in this instance, using spaces.
    }


    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
