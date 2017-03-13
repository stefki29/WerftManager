using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class AuftragsClass {

    public enum KomponentenID : int
    {
        Motor = 0x000,
        Bad = 0x000

    }

    public string auftragsname = "Neuer Auftrag";
    public string kunde = "AIDA";
    public string auftragsID = "000-000-000";
    
    public int Bezahlung = 100;
    public int strafe = 80;
    public int Zeit = 10;
    public int verstricheneZeit = 0;


    public int[] Komponenten = new int[10];


}
