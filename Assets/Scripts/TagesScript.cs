using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TagesScript : MonoBehaviour {

    public Text tage;
    public Text anzAufträge;
    public AuftragsController auftragsController ;
    public float Taggeschwiendigkeit = 1;

    public int tag ;

    public void Init()
    {
       
        tag = 0;
        tage.text = "Tag: " + tag;
        InvokeRepeating("Wiederholung", Taggeschwiendigkeit, Taggeschwiendigkeit);
        anzAufträge.text = "Es gibt " + auftragsController.anzAufträge + " Aufträge";
    }

    void Wiederholung()
    {
        tag++;
        tage.text = "Tag: " + tag;
        auftragsController.Auftrageüberprüfen();
        anzAufträge.text = "Es gibt " + auftragsController.anzAufträge + " Aufträge";
        auftragsController.Abarbeiten();
    }

}
