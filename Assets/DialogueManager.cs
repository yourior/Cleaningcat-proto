using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour {

    private Queue<string> dialog;
    public Text nametext;
    public Text dialoguetext;
    // Use this for initialization
    void Start()
    {
        dialog = new Queue<string>();
    }

    
    public void StartDialogue (DialogText dialogue)
    {
       // Debug.Log("Start Dialog with " + dialogue.name);

        nametext.text = dialogue.name;
        
        dialog.Clear();

        foreach (string dialogs in dialogue.sentences)
        {
           dialog.Enqueue(dialogs);
        }
        Debug.Log(dialog.Count);

        DisplayNext();
    }

    public void DisplayNext()
    {
        Debug.Log(dialog.Count);

        if (dialog.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = dialog.Dequeue();

        dialoguetext.text = sentence;

    }

    public void EndDialogue()
    {
        dialoguetext.text = ("");
        nametext.text =("");
    }
 }


