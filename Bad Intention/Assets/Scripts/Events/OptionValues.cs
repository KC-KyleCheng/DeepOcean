using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class OptionValues
{
    public float health;
    public float wealth;
    public float population;
    public float morale;
    public float probability = 1;
    public bool hasSubsequentEvent = false;
    public Event subsequentEvent;
}
