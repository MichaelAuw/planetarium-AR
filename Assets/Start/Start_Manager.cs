using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Start_Manager : MonoBehaviour
{

    public GameObject Return;

    //Highligh the last clicked Object
    public static int Highlight;
    public static bool Active;
    
    // Start is called before the first frame update
    public void SunClicked(){
        SceneManager.LoadScene("AR_Sun");
        Active = true;
        Highlight = 0;
    }

    public void MercuryClicked(){
        SceneManager.LoadScene("AR_Mercury");
        Active = true;
        Highlight = 1;
    }

    public void VenusClicked(){
        SceneManager.LoadScene("AR_Venus");
        Active = true;
        Highlight = 2;
    }

    public void EarthClicked(){
        SceneManager.LoadScene("AR_Earth");
        Active = true;
        Highlight = 3;
    }

    public void MarsClicked(){
        SceneManager.LoadScene("AR_Mars");
        Active = true;
        Highlight = 4;
    }

    public void JupiterClicked(){
        SceneManager.LoadScene("AR_Jupiter");
        Active = true;
        Highlight = 5;
    }

    public void SaturnClicked(){
        SceneManager.LoadScene("AR_Saturn");
        Active = true;
        Highlight = 6;
    }

    public void UranusClicked(){
        SceneManager.LoadScene("AR_Uranus");
        Active = true;
        Highlight = 7;
    }

    public void NeptuneClicked(){
        SceneManager.LoadScene("AR_Neptune");
        Active = true;
        Highlight = 8;
    }

    public void ReturnButton(){
        SceneManager.LoadScene("MainMenu");
    }
}
