using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyUI : MonoBehaviour
{
    public GameObject Buy;

    public void Show()
    {
        ShowHideUI.ShowUI(Buy, 0.2f);
    }

    public void Hide()
    {
        ShowHideUI.HideUI(Buy, 0.2f);
    }

}
