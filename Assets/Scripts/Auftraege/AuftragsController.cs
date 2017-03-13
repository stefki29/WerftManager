using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AuftragsController : MonoBehaviour {
    AuftragsClassList auftragsClassList;
    public int anzAufträge = 0;
    public List<AuftragsClass> test;

    private void Start()
    {
        
        auftragsClassList = AssetDatabase.LoadAssetAtPath("Assets/Lists/AuftraegeList.asset", typeof(AuftragsClassList)) as AuftragsClassList;
        anzAufträge = auftragsClassList.auftragsList.Count;
    }

    public void Auftrageüberprüfen()
    {
        if (auftragsClassList.auftragsList.Count == 3)
        {
            test.Add(auftragsClassList.auftragsList[0]);
            AuftragLöschen(0);
        }
        else
        {
            Auftragerzeugen();
        }
        anzAufträge = auftragsClassList.auftragsList.Count;

    }

    void Auftragerzeugen()
    {
        AuftragsClass neuerAuftrag = new AuftragsClass();
        neuerAuftrag.auftragsname = "Neues Kreuzfahrtschiff";
        neuerAuftrag.auftragsID = AuftragsIDErzeugen();
        neuerAuftrag.Bezahlung = 10000;
        neuerAuftrag.Komponenten[(int)AuftragsClass.KomponentenID.Motor] = 5;
        auftragsClassList.auftragsList.Add(neuerAuftrag);

    }

    void AuftragLöschen(int index)
    {
        auftragsClassList.auftragsList.RemoveAt(index);

    }

   public void ErzeugeNeuerAuftragsListe()
    {
        auftragsClassList = AuftragsListeErzeugen.Create();
        if(auftragsClassList)
        {
            auftragsClassList.auftragsList = new List<AuftragsClass>();
        }

     
    }

    string AuftragsIDErzeugen()
    {
        string id;
        id = Random.Range(0, 9).ToString();
        id += Random.Range(0, 9).ToString();
        id += Random.Range(0, 9).ToString();
        id += "-";
        id += Random.Range(0, 9).ToString();
        id += Random.Range(0, 9).ToString();
        id += Random.Range(0, 9).ToString();
        id += "-";
        id += Random.Range(0, 9).ToString();
        id += Random.Range(0, 9).ToString();
        id += Random.Range(0, 9).ToString();
        return id;
    }


}
