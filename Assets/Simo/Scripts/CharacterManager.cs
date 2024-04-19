using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{


    public GameObject Character0;
    public GameObject Character1;
    public GameObject Character2;
    public GameObject Character3;

    int currentChara = 0;
    public GameObject currentCharacter;

    public Vector3 positionInstantiation;
    public bool gameLoop = true;

    private void Update()
    {
        if(currentCharacter == null)
        {
            if(gameLoop)
            CheckGamestate();
        }
    }

    void CheckGamestate()
    {
        //Check if all metrosex have sexed
        if(currentChara == 5)
        {
            GameEnd();
        }


        //currentCharacter set in there
        CheckCharacterList(currentChara);

        currentChara++;

        GameObject.Instantiate<GameObject>(currentCharacter, positionInstantiation, Quaternion.identity);
    }

    void GameEnd()
    {
        gameLoop = false;
        Debug.Log("You are one metrosexual");
    }

    void CheckCharacterList(int characterID)
    {
        if(characterID == 0)
        {
            currentCharacter = Character0;
        }
        else if (characterID == 1)
        {
            currentCharacter = Character1;
        }
        else if (characterID == 2)
        {
            currentCharacter = Character2;
        }
        else if (characterID == 3)
        {
            currentCharacter = Character3;
        }
    }
}
