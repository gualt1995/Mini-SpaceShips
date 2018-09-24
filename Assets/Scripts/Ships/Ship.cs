using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : Object {

    public string shipname;
    public float speed;
    public int capacity;
    public float armor;

    public Ship(string nm,float sp,int cap,float ar)
    {
        shipname = nm;
        speed = sp;
        capacity = cap;
        armor = ar;
    }
}
