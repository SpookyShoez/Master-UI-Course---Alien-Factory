using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterOption : MonoBehaviour
{
    int id;
    CharacterManager characterManager;
    public Image characterImage;

    public void OnClick()
    {
        characterManager.CharacterClicked(id);
    }

    public void Initialize(CharacterManager characterManager, int id)
    {
        this.characterManager = characterManager;
        this.id = id;
        characterImage.sprite =characterManager.characterSprites[id];
    }
}
