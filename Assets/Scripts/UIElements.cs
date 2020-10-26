using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIElements : MonoBehaviour
{
    public Image panelImage;
    public Slider blueSlider;

    public void ButtonClicked()
    {
        panelImage.color = Color.red;
        blueSlider.value = 0f;
    }

    public void TogglePanelVisible(bool newPanelVisbility)
    {
        panelImage.enabled = newPanelVisbility;
    }

    public void SetPanelBlueAmount(float newBlueAmount)
    {
        panelImage.color = new Color(panelImage.color.r, panelImage.color.g, newBlueAmount, panelImage.color.a);
    }
}
