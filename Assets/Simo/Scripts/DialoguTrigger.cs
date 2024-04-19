using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialoguTrigger : MonoBehaviour
{
    [SerializeField] private List<dialogueString> dialogueStrings = new List<dialogueString>();

    private bool hasSpoken = false;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Cock");
        if(collision.CompareTag("Character") && !hasSpoken)
        {
            collision.GetComponent<DialogueManager>().DialogueStart(dialogueStrings);
            hasSpoken = true;
        }
    }
}

[System.Serializable]
public class dialogueString
{
    public string text;
    public bool isEnd;

    [Header("Branch")]
    public bool isQuestion;
    public string answerOption1;
    public string answerOption2;
    public int optionIndex1Jump;
    public int optionIndex2Jump;

    [Header("TriggerEvent")]
    public UnityEvent startDialogueEvent;
    public UnityEvent endDialogueEvent;
}

