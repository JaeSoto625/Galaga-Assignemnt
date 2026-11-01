using UnityEngine;
using TMPro;
using System.Diagnostics;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class demo : MonoBehaviour
{
    public TextMeshProUGUI textbox;

    public void OnClick()
    {
        textbox.text = "Hello Fall Class of 2026!";
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
