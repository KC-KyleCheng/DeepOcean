using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameState")]
public class GameState : ScriptableObject
{
    public float maxHealth;
    public float maxWealth;
    public float maxPopulation;
    public float maxMorale;
    public float currentHealth;
    public float currentWealth;
    public float currentPopulation;
    public float currentMorale;

    public Event currentEvent;
}
