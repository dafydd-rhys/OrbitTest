using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpUI : MonoBehaviour
{
    public GameObject Help;

    public void Show()
    {
        ShowHideUI.ShowUI(Help, 0.2f);
    }

    public void Hide()
    {
        ShowHideUI.HideUI(Help, 0.2f);
    }

}
