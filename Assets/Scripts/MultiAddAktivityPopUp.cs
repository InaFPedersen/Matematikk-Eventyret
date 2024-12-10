using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MultiAddAktivityPopUp : MonoBehaviour
{
    //Felles variabler
    //Vinduene
    public GameObject popUpRett;
    public GameObject popUpFeil;
    public GameObject popUpVanskelighet;
    public GameObject popUpHelp;
    //Knappene
    public GameObject rettImage;
    public GameObject rettText;
    public GameObject rettNeste;
    public GameObject rettSkip;
    public GameObject feilImage;
    public GameObject feilText;
    public GameObject feilNeste;
    public GameObject feilAgain;
    public GameObject vhetImage;
    public GameObject vhetText;
    public GameObject vhet1;
    public GameObject vhet2;
    public GameObject helpImage;
    public GameObject helpText;
    public GameObject helpClose;
    

    //Felles åpne / lukke popup vindu
    public void Start()
    {
        popUpRett.SetActive(false);
        rettImage.SetActive(false);
        rettText.SetActive(false);
        rettNeste.SetActive(false);
        rettSkip.SetActive(false);
        popUpFeil.SetActive(false);
        feilImage.SetActive(false);
        feilText.SetActive(false);
        feilNeste.SetActive(false);
        feilAgain.SetActive(false);
        popUpHelp.SetActive(false);
        helpImage.SetActive(false);
        helpText.SetActive(false);
        helpClose.SetActive(false);
        popUpVanskelighet.SetActive(false);
        vhetImage.SetActive(false);
        vhetText.SetActive(false);
        vhet1.SetActive(false);
        vhet2.SetActive(false);
    }
    public void OpenPopUpRett()
    {
        popUpFeil.SetActive(false);
        feilImage.SetActive(false);
        feilText.SetActive(false);
        feilNeste.SetActive(false);
        feilAgain.SetActive(false);
        popUpHelp.SetActive(false);
        helpImage.SetActive(false);
        helpText.SetActive(false);
        helpClose.SetActive(false);
        popUpVanskelighet.SetActive(false);
        vhetImage.SetActive(false);
        vhetText.SetActive(false);
        vhet1.SetActive(false);
        vhet2.SetActive(false);
        popUpRett.SetActive(true);
        rettImage.SetActive(true);
        rettText.SetActive(true);
        rettNeste.SetActive(true);
        rettSkip.SetActive(true);
    }

    public void ClosePopUpRett()
    {
        popUpRett.SetActive(false);
        rettImage.SetActive(false);
        rettText.SetActive(false);
        rettNeste.SetActive(false);
        rettSkip.SetActive(false);
        popUpFeil.SetActive(false);
        feilImage.SetActive(false);
        feilText.SetActive(false);
        feilNeste.SetActive(false);
        feilAgain.SetActive(false);
        popUpHelp.SetActive(false);
        helpImage.SetActive(false);
        helpText.SetActive(false);
        helpClose.SetActive(false);
        popUpVanskelighet.SetActive(false);
        vhetImage.SetActive(false);
        vhetText.SetActive(false);
        vhet1.SetActive(false);
        vhet2.SetActive(false);
    }

    public void OpenPopUpFeil()
    {
        popUpRett.SetActive(false);
        rettImage.SetActive(false);
        rettText.SetActive(false);
        rettNeste.SetActive(false);
        rettSkip.SetActive(false);
        popUpHelp.SetActive(false);
        helpImage.SetActive(false);
        helpText.SetActive(false);
        helpClose.SetActive(false);
        popUpVanskelighet.SetActive(false);
        vhetImage.SetActive(false);
        vhetText.SetActive(false);
        vhet1.SetActive(false);
        vhet2.SetActive(false);
        popUpFeil.SetActive(true);
        feilImage.SetActive(true);
        feilText.SetActive(true);
        feilNeste.SetActive(true);
        feilAgain.SetActive(true);
    }

    public void ClosePopUpFeil()
    {
        popUpRett.SetActive(false);
        rettImage.SetActive(false);
        rettText.SetActive(false);
        rettNeste.SetActive(false);
        rettSkip.SetActive(false);
        popUpFeil.SetActive(false);
        feilImage.SetActive(false);
        feilText.SetActive(false);
        feilNeste.SetActive(false);
        feilAgain.SetActive(false);
        popUpHelp.SetActive(false);
        helpImage.SetActive(false);
        helpText.SetActive(false);
        helpClose.SetActive(false);
        popUpVanskelighet.SetActive(false);
        vhetImage.SetActive(false);
        vhetText.SetActive(false);
        vhet1.SetActive(false);
        vhet2.SetActive(false);
    }

    public void OpenPopUpHelp()
    {
        popUpRett.SetActive(false);
        rettImage.SetActive(false);
        rettText.SetActive(false);
        rettNeste.SetActive(false);
        rettSkip.SetActive(false);
        popUpFeil.SetActive(false);
        feilImage.SetActive(false);
        feilText.SetActive(false);
        feilNeste.SetActive(false);
        feilAgain.SetActive(false);
        popUpVanskelighet.SetActive(false);
        vhetImage.SetActive(false);
        vhetText.SetActive(false);
        vhet1.SetActive(false);
        vhet2.SetActive(false);
        popUpHelp.SetActive(true);
        helpImage.SetActive(true);
        helpText.SetActive(true);
        helpClose.SetActive(true);
    }

    public void ClosePopUpHelp()
    {
        popUpRett.SetActive(false);
        rettImage.SetActive(false);
        rettText.SetActive(false);
        rettNeste.SetActive(false);
        rettSkip.SetActive(false);
        popUpFeil.SetActive(false);
        feilImage.SetActive(false);
        feilText.SetActive(false);
        feilNeste.SetActive(false);
        feilAgain.SetActive(false);
        popUpHelp.SetActive(false);
        helpImage.SetActive(false);
        helpText.SetActive(false);
        helpClose.SetActive(false);
        popUpVanskelighet.SetActive(false);
        vhetImage.SetActive(false);
        vhetText.SetActive(false);
        vhet1.SetActive(false);
        vhet2.SetActive(false);
    }

 
    //Endre Vanskelighetsgrad
    public void OpenPopUpVanskelighet()
    {
        popUpRett.SetActive(false);
        rettImage.SetActive(false);
        rettText.SetActive(false);
        rettNeste.SetActive(false);
        rettSkip.SetActive(false);
        popUpFeil.SetActive(false);
        feilImage.SetActive(false);
        feilText.SetActive(false);
        feilNeste.SetActive(false);
        feilAgain.SetActive(false);
        popUpHelp.SetActive(false);
        helpImage.SetActive(false);
        helpText.SetActive(false);
        helpClose.SetActive(false);
        popUpVanskelighet.SetActive(true);
        vhetImage.SetActive(true);
        vhetText.SetActive(true);
        vhet1.SetActive(true);
        vhet2.SetActive(true);
    }

    public void ClosePopUpVanskelighet()
    {
        popUpRett.SetActive(false);
        rettImage.SetActive(false);
        rettText.SetActive(false);
        rettNeste.SetActive(false);
        rettSkip.SetActive(false);
        popUpFeil.SetActive(false);
        feilImage.SetActive(false);
        feilText.SetActive(false);
        feilNeste.SetActive(false);
        feilAgain.SetActive(false);
        popUpHelp.SetActive(false);
        helpImage.SetActive(false);
        helpText.SetActive(false);
        helpClose.SetActive(false);
        popUpVanskelighet.SetActive(false);
        vhetImage.SetActive(false);
        vhetText.SetActive(false);
        vhet1.SetActive(false);
        vhet2.SetActive(false);
    }
}
