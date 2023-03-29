using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Manager : MonoBehaviour
{

    public GameObject Earth;
    public GameObject Return;
    
    // Start is called before the first frame update
    public void EarthClicked(){
        Application.LoadLevel("Earth");
    }

    public void ReturnButton(){
        Application.LoadLevel("MainMenu");
    }
}
