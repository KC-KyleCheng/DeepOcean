using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Event")]
public class Event : ScriptableObject
{
    public string eventName;
    public string reporter;
    public string eventDescription;

    public string heartDescription;
    public string diamondDescription;
    public string spadeDescription;    
    public string clubDescription;

    public string heartResult;
    public string diamondResult;
    public string spadeResult;
    public string clubResult;

    public OptionValues[] heartValues;
    public OptionValues[] diamondValues;
    public OptionValues[] spadeValues;
    public OptionValues[] clubValues;
}
