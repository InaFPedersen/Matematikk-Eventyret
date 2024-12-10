using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplicationStartUI : MonoBehaviour
{
    //Common for all scenes
    public void Home()
    {
        SceneManager.LoadScene((int)Scenes.StartScene);
    }
    public void EndGame()
    {
        Application.Quit();
    }

    //Multiplikasjon Del 1
    public void MS1Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel2);
    }
    public void MS1Rewind()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel1);
    }

    //Multiplikasjon Del 2
    public void MS2Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel3);
    }
    public void MS2Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel1);
    }

    //Multiplikasjon Del 3
    public void MS3Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel4);
    }
    public void MS3Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel2);
    }

    //Multiplikasjon Del 4
    public void MS4Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel4b);
    }
    public void MS4Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel3);
    }
    //Multiplikasjon Del 4b
    public void MS4bNext()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel5);
    }
    public void MS4bBack()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel4);
    }
    //Multiplikasjon Del 5
    public void MS5Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel6);
    }
    public void MS5Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel4b);
    }
    
    //Multiplikasjon Del 6
    public void MS6Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel7);
    }
    public void MS6Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel5);
    }

    //Multiplikasjon Del 7
    public void MS7Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel8);
    }
    public void MS7Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel6);
    }
    //Multiplikasjon Del 8
    public void MS8Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel1);
    }
    public void MS8Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel7);
    }
    public void MS8Nei()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel9);
    }

    //Multiplikasjon Del 9
    public void MS9Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel1);
    }
    public void MS9Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel8);
    }
    public enum Scenes
    {
        StartScene,
        Tutorial,
        Tutorial1,
        Tutorial2,
        GameHistoryDel1,
        GameHistoryDel2,
        GameHistoryDel3,
        GameHistoryDel4,
        GameHistoryDel5,
        GameHistoryDel6,
        GameHistoryDel7,
        GameHistoryDel8,
        GameHistoryDel9,
        GameHistoryDel10ja,
        GameHistoryDel10nei,
        GameHistoryDel11Addisjon,
        GameHistoryDel11Subtraksjon,
        GameHistoryDel11Multiplikasjon,
        GameHistoryDel11Divisjon,
        GameHistoryDel12,
        GameHistoryDel13,
        GameHistoryDel14,
        GameHistoryDel15Nei,
        GameHistoryDel15Ja1,
        GameHistoryDel15Ja2,
        GameHistoryDel15Ja3,
        GameHistoryDel15Ja4,
        GameHistoryDel16Addisjon,
        GameHistoryDel16Subtraksjon,
        GameHistoryDel16Multiplikasjon,
        GameHistoryDel16Divisjon,
        MultiplikasjonDel1,
        MultiplikasjonDel2,
        MultiplikasjonDel3,
        MultiplikasjonDel4,
        MultiplikasjonDel4b,
        MultiplikasjonDel5,
        MultiplikasjonDel6,
        MultiplikasjonDel7,
        MultiplikasjonDel8,
        MultiplikasjonDel9,
        MultiVSAddDel1,
        MultiVSAddDel2,
        MultiVSAddDel3,
        MultiVSAddDel4,
        MultiVSAddDel5,
        MultiVSAddDel6Ja,
        MultiVSAddDel6Nei,
        MultiVSAddDel7,
        MultiVSAddDel8,
        MultiVSAddDel9,
        MultiVSAddDel10,
        MultiVSAddDel11,
        MultiVSAddDel12Ja,
        MultiVSAddDel12Nei,
        MultiAddAktivitet1Lett,
        MultiAddAktivitet2Lett,
        MultiAddAktivitet3Lett,
        MultiAddAktivitet1Medium,
        MultiAddAktivitet2Medium,
        MultiAddAktivitet3Medium,
        MultiAddAktivitet1Hard,
        MultiAddAktivitet2Hard,
        MultiAddAktivitet3Hard,
        MultiVSAddDel13,
        MultiVSAddDel14,
    }
}
