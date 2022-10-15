using TMPro;
using UnityEngine;

public class ChangeTextColor : MonoBehaviour
{
    public TextMeshProUGUI text;

    public Color normalColor;
    public Color highlightedColor;

    public void Highlight()
    {
        text.color = highlightedColor;
    }

    public void Normal()
    {
        text.color = normalColor;
    }
}