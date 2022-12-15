using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayPowerupUpgrade : MonoBehaviour
{

    public PowerupUpgrade upgrade;

    public TextMeshProUGUI title;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        string upgradeTitle = upgrade.upgradeName;
        Sprite upgradeImage = upgrade.image;

        title.text = upgradeTitle;
        image.sprite = upgradeImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
