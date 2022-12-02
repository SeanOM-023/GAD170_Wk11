using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBus : MonoBehaviour {

    private static EventBus _current;

    public static EventBus Current { get { return _current; } }

    private int lives = 3;


    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        } else {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    //Public function that returns the lives
    public int ReturnLives() {
        return lives;
    }

    //Public function that takes one life away
    public void RemoveLife() {
        lives--;
    }

    public event Action lightsGoOn;
    public void lightsGoOnTrigger() {
        lightsGoOn();
    }

    public event Action lightsGoOff;
    public void lightsGoOffTrigger() {
        lightsGoOff();
    }

}