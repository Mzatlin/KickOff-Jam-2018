using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    public static PlayerManager player;
    private int currenthealth = 5;
    private int currentspeed = 30;
    void Awake()
    {
        player = this;
    }
    public int Health
    {
        get
        {
            return currenthealth;
        }
        set
        {
            currenthealth = value;
        }
    }
    public int Speed
    {
        get
        {
            return currentspeed;
        }
        set
        {
            currentspeed = value;
        }
    }

}
