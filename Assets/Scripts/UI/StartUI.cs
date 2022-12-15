using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUI : MonoBehaviour
{

    public GameObject MenuUI;
    public GameObject ReturnButton;

    public void Show()
    {
        ShowHideUI.ShowUI(MenuUI, 0.2f); //show menu
        ShowHideUI.HideUI(ReturnButton, 0.2f); //hide button
    }

    public void Hide()
    {
        ShowHideUI.HideUI(MenuUI, 0.2f); //hide menu
        ShowHideUI.ShowUI(ReturnButton, 0.2f); //show button
    }

}
