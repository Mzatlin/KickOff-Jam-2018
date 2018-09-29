using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    public static PlayerManager player;
    private int health = 5;
    void Awake()
    {
        player = this;
    }
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

}
