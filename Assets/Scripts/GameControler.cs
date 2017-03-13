using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour {

    float TageDauer = 5;
    public TagesScript tagesscript;
	// Use this for initialization
	void Start () {
        tagesscript.Init();
	}
	
    void Tagewiederholung()
    {
       
    }
}
