using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public GameState gameState;

    public Text healthPercentText;
    public Text wealthPercentText;
    public Text populationPercentText;
    public Text moralePercentText;

    public Slider healthSlider;
    public Slider wealthSlider;
    public Slider populationSlider;
    public Slider moraleSlider;

    public Text eventDescription;
    public Text heartDescription;
    public Text diamondDescription;
    public Text spadeDescription;
    public Text clubDescription;

    private float healthPercent, wealthPercent, populationPercent, moralePercent;

    void Start()
    {
        healthPercent = 1;
        wealthPercent = 1;
        populationPercent = 1;
        moralePercent = 1;
    }

    void Update()
    {
        updatePlayerState();
        updateEvent(); 
    }

    private void updatePlayerState()
    {
        healthPercent = gameState.currentHealth / gameState.maxHealth;
        wealthPercent = gameState.currentWealth / gameState.maxWealth;
        populationPercent = gameState.currentPopulation / gameState.maxPopulation;
        moralePercent = gameState.currentMorale / gameState.maxMorale;

        // update slider
        healthSlider.value = healthPercent;
        wealthSlider.value = wealthPercent;
        populationSlider.value = populationPercent;
        moraleSlider.value = moralePercent;

        // update text
        healthPercentText.text = (int)(healthPercent*100) + "%";
        wealthPercentText.text = (int)(wealthPercent * 100) + "%";
        populationPercentText.text = (int)(populationPercent * 100) + "%";
        moralePercentText.text = (int)(moralePercent * 100) + "%";
    }

    private void updateEvent()
    {
        eventDescription.text = gameState.currentEvent.eventDescription;
        heartDescription.text = gameState.currentEvent.heartDescription;
        diamondDescription.text = gameState.currentEvent.diamondDescription;
        spadeDescription.text = gameState.currentEvent.spadeDescription;
        clubDescription.text = gameState.currentEvent.clubDescription;
    }
}
