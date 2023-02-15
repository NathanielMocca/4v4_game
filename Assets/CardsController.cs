using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardsController : MonoBehaviour
{
    public CardsController instance;
    public TMP_Text[] CardTexts;

    public CardsController GetCardsController()
    {
        return this;
    }

    // Start is called before the first frame update
    void Start()
    {
        CardTexts[0].text = "一號牌";
        CardTexts[1].text = "二號牌";
        CardTexts[2].text = "三號牌";
        CardTexts[3].text = "四號牌";
    }

    public void SetCardText(int i, string txt)
    {
        CardTexts[i].text = txt;
    }
}
