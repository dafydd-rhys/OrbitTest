using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageUI : MonoBehaviour
{
    public GameObject Stage;

    public void Show()
    {
        ShowHideUI.ShowUI(Stage, 0.2f);
    }

    public void Hide()
    {
        ShowHideUI.HideUI(Stage, 0.2f);
    }

}
