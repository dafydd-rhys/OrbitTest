using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpUI : MonoBehaviour
{
    public GameObject HelpPanel;

    public void Show()
    {
        ShowHideUI.ShowUI(HelpPanel, 0.2f);
    }

    public void Hide()
    {
        ShowHideUI.HideUI(HelpPanel, 0.2f);
    }

}
