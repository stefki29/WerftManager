using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameControler : MonoBehaviour {

    SpielClassList spielClassList;

    public int SpielerGeld
    {
        get
        {
            return spielClassList.spielList.geld;
        }
        set
        {
            if (value < 0)
            {
                spielClassList.spielList.geld = spielClassList.spielList.geld - value;
            }
            else
            {
                spielClassList.spielList.geld = spielClassList.spielList.geld + value;
            }
        }   
       

    }
    public int motoren
    {
        get
        {
            return spielClassList.spielList.motoren;
        }
        set
        {
            if (value < 0)
            {
                spielClassList.spielList.motoren = spielClassList.spielList.motoren - value;
            }
            else
            {
                spielClassList.spielList.motoren = spielClassList.spielList.motoren + value;
            }
        }


    }
    public int bäder
    {
        get
        {
            return spielClassList.spielList.bäder;
        }
        set
        {
            if (value < 0)
            {
                spielClassList.spielList.bäder = spielClassList.spielList.bäder - value;
            }
            else
            {
                spielClassList.spielList.bäder = spielClassList.spielList.bäder + value;
            }
        }


    }



    // Use this for initialization
    void Start () {
        spielClassList = AssetDatabase.LoadAssetAtPath("Assets/Lists/SpielList.asset", typeof(SpielClassList)) as SpielClassList;
       
	}
	
}
