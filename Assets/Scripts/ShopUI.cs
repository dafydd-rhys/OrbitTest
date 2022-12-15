using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    public GameObject Shop;

    public void Show()
    {
        ShowHideUI.ShowUI(Shop, 0.2f);
    }

    public void Hide()
    {
        ShowHideUI.HideUI(Shop, 0.2f);
    }

}
