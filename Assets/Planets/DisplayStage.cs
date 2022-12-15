using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayStage : MonoBehaviour
{

    public FlickRocket rocket;
    public int rocketNumber;

    public TextMeshProUGUI title;
    public TextMeshProUGUI cost;
    public TextMeshProUGUI speed;
    public TextMeshProUGUI delay;
    public TextMeshProUGUI accuracy;
    public Image image;


    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        string upgradeTitle = rocket.rockets[rocketNumber].name;
        string upgradeCost = rocket.rockets[rocketNumber].cost.ToString();
        //string upgradeSpeed = rocket.rockets[rocketNumber].speed.ToString();
        //string upgradeDelay = rocket.rockets[rocketNumber].delay.ToString();
        //string upgradeAccuracy = rocket.rockets[rocketNumber].accuracy.ToString();
        Sprite upgradeImage = rocket.rockets[rocketNumber].image;

        title.text = upgradeTitle;
        cost.text = upgradeCost;
        //speed.text = $"Speed - {upgradeSpeed}";
        //delay.text = $"Delay - {upgradeDelay}";
        //accuracy.text = $"Accuracy - {upgradeAccuracy}";
        image.sprite = upgradeImage;
    }

    void Update()
    {

    }
}
