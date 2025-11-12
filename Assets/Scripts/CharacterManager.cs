using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public Image previewImage;
    public Sprite[] characterSprites;
    public GameObject characterOptionsPrefab;
    public Transform charactersContainer;

    private void Start() {   
        foreach (Transform child in charactersContainer)
        {
            Destroy(child.gameObject);
        }
        SetupCharacters();
    }

    public void CharacterClicked(int id)
    {
        previewImage.sprite = characterSprites[id];
    }

    void SetupCharacters()
    {
        for (int i = 0; i < characterSprites.Length; i++)
        {
            GameObject go = Instantiate(characterOptionsPrefab, charactersContainer);
            CharacterOption characterOption = go.GetComponent<CharacterOption>();
            characterOption.Initialize(this, i);
        }
    }
}

