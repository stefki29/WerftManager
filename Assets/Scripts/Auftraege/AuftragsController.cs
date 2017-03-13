using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
public class AuftragsController : MonoBehaviour {
    AuftragsClassList auftragsClassList;
    public int anzAufträge = 0;
    public int auftragsNummer = 0;
    public bool wirdverarbeitet = false;
    public List<AuftragsClass> test;

    public Text auftrag;
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

   public void Abarbeiten()
    {
        if(wirdverarbeitet == true)
        {
            if(auftragsClassList.auftragsList[auftragsNummer].Zeit == auftragsClassList.auftragsList[auftragsNummer].verstricheneZeit)
            {
                Debug.Log("Es werden " + auftragsClassList.auftragsList[auftragsNummer].Bezahlung + " € ihrem Konto gut geschrieben");
                
                wirdverarbeitet = false;
                auftrag.text = "Der Auftrag :" + auftragsClassList.auftragsList[auftragsNummer].auftragsID + " wurde Fertig gestellt";
                AuftragLöschen(auftragsNummer);
            }
            else
            {
                auftrag.text = "Der Auftrag :" + auftragsClassList.auftragsList[auftragsNummer].auftragsID + " wird bearbeitet";
                auftragsClassList.auftragsList[auftragsNummer].verstricheneZeit++;
                Debug.Log("Der auftrag benötigt noch " + (auftragsClassList.auftragsList[auftragsNummer].Zeit - auftragsClassList.auftragsList[auftragsNummer].verstricheneZeit));
            }

        }
    }

    public void Auftragstarten(int index)
    {
        if(wirdverarbeitet == true)
        {

        }
        else
        {
            auftragsNummer = index;
            wirdverarbeitet = true;
            Abarbeiten();
            
        }

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
