using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameUI : MonoBehaviour
{
    public GameObject InGame;
    public TextMeshProUGUI gems;

    public void Update()
    {
        gems.text = PlayerPrefs.GetInt("GemCount", 0).ToString();
    }

    public void Show()
    {
        ShowHideUI.ShowUI(InGame, 0.2f);
    }

    public void Hide()
    {
        ShowHideUI.HideUI(InGame, 0.2f);
    }

}
