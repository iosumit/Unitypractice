using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    int _health;
    int _power;
    string _name;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }
    public int Power
    {
        get
        {
            return _power;
        }
        set
        {
            _power = value;
        }
    }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public Player() { }
    public Player(int health, int power, string name)
    {
        Health = health;
        this._power = power;
        this._name = name;
    }

    public void info()
    {
        Debug.Log("Health : " + Health);
        Debug.Log("Power : " + Power);
        Debug.Log("name : " + Name);
    }

}
