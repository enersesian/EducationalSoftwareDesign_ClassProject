using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CanvasUIFunctions : MonoBehaviour
{
    public Sprite[] spriteArray;
    public Image panelImage;
    public Color backgroundColor;
    public TMPro.TMP_Text introText;
    int introSequence;

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SetIntroSequence()
    {
        introSequence++;
        switch (introSequence)
        {
            case 1:
                panelImage.sprite = spriteArray[1];
                break;
            default:
                panelImage.sprite = null;
                panelImage.color = backgroundColor;
                break;
        }
        switch (introSequence)
        {
            case 2:
                introText.text = "Learn about the animals living around you";
                break;
            case 3:
                introText.text = "Contribute to real research about biodiversity and ecology";
                break;
            case 4:
                introText.text = "Become an ally to the creatures living in your backyard, school, and neighborhood";
                break;
            case 5:
                introText.text = "Watch your animals grow";
                break;
            case 6:
                introText.text = "Connect with other ally's and real wildlife researchers!";
                break;
        }
    }
}
