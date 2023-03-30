using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Manager : MonoBehaviour
{

    public GameObject Earth;
    public GameObject Return;
    
    // Start is called before the first frame update
    public void SunClicked(){
      Application.LoadLevel("AR_Sun");
    }

    public void MercuryClicked(){
        Application.LoadLevel("AR_Mercury");
    }

    public void VenusClicked(){
        Application.LoadLevel("AR_Venus");
    }

    public void EarthClicked(){
        Application.LoadLevel("AR_Earth");
    }

    public void MarsClicked(){
        Application.LoadLevel("AR_Mars");
    }

    public void JupiterClicked(){
        Application.LoadLevel("AR_Jupiter");
    }

    public void SaturnClicked(){
        Application.LoadLevel("AR_Saturn");
    }

    public void UranusClicked(){
      Application.LoadLevel("AR_Uranus");
    }

    public void NeptuneClicked(){
        Application.LoadLevel("AR_Neptune");
    }

    public void ReturnButton(){
        Application.LoadLevel("MainMenu");
    }
}
