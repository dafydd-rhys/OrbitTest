using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI2 : MonoBehaviour
{
    public GameObject Shop2;

    public void Show()
    {
        ShowHideUI.ShowUI(Shop2, 0.2f);
    }

    public void Hide()
    {
        ShowHideUI.HideUI(Shop2, 0.2f);
    }

}

