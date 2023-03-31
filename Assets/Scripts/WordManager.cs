using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    public WordSpawner wordSpawner;

    private bool hasActiveWord;
    private Word activeWord;

    public AudioSource audioSource;
    public bool alreadyPlayed = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }



    public void AddWord()
    {
        
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);
        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
                if (!alreadyPlayed)
                {
                    audioSource.Play();
                }
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
        
    }

    public void RemoveWord(Word wordToRemove)
    {  // Check if the activeWord is the same as the wordToRemove
        if (hasActiveWord && activeWord == wordToRemove)
        {  // If true, set hasActiveWord to false since the active word is being removed
            hasActiveWord = false;
        }
        words.Remove(wordToRemove); // Remove the wordToRemove from the canvas.
    }

}
