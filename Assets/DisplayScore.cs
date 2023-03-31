using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public static int wordsTyped;

    public Text typedWords;


    // Start is called before the first frame update
    void Start()
    {
        typedWords.text = Word.wordsTyped.ToString();
    }
}
