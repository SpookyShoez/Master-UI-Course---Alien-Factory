using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public Image previewImage;
    public Sprite[] characterSprites;
    public GameObject characterOptionsPrefab;
    public Transform charactersContainer;
    public Color[] colors;

    private void Start() {   
        foreach (Transform child in charactersContainer)
        {
            Destroy(child.gameObject);
        }
        SetupCharacters();
        CharacterClicked(0);
        ChangeColor(0);
    }

    public void CharacterClicked(int id)
    {
        previewImage.sprite = characterSprites[id];
        previewImage.SetNativeSize();
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

    public void ChangeColor(int option)
    {
        previewImage.color = colors[option];
    }
}

