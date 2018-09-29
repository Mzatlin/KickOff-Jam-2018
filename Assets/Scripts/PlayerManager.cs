using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerManager : MonoBehaviour {
    public static PlayerManager player;
    public event Action OnDie = delegate { };
    private int currenthealth = 5;
    private int currentspeed = 80;
    private bool isDead = false;
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
            if (currenthealth < 1)
            {
                isDead = true;
            }
            else
            {
                currenthealth = value;
            }
        }
    }
    public int Speed
    {
        get
        {
            return currentspeed/currenthealth;
        }
        set
        {
            currentspeed = value;
        }
    }
    
    public bool IsDead
    {
        get
        {
            return isDead;
        }
        set
        {
            isDead = value;
            OnDie();
        }
    }

}
