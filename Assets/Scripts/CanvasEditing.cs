using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasEditing : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    public GameObject canvas;
    // Start is called before the first frame update

    // Update is called once per frame
    public void ToggleCanvas()
    {
        if (canvas.activeSelf)
        {
            text.SetText("Active");
        }
        else
        {
            text.SetText("NotActive");
        }

        canvas.SetActive(!canvas.activeSelf);

        if (canvas.activeSelf)
        {
            text2.SetText("now active.");
        }
        else
        {
            text2.SetText("now inactive.");
        }
    }

}
