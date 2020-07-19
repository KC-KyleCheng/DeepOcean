using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Cards;

    public static GameObject onTimeCard;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Cards.childCount == 3)
        {
            Cards.GetComponent<RectTransform>().anchoredPosition = new Vector2(475, -441);
        }
        else if (Cards.childCount == 4)
        {
            Cards.GetComponent<RectTransform>().anchoredPosition = new Vector2(325, -441);
        }
    }
}
