using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MultiVSAddUI : MonoBehaviour
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

    //Multiplikasjon VS Addisjon Del 1
    public void MVA1Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel2);
    }
    public void MVA1Rewind()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel1);
    }

    //Multiplikasjon VS Addisjon Del 2
    public void MVA2Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel3);
    }
    public void MVA2Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel1);
    }

    //Multiplikasjon VS Addisjon Del 3
    public void MVA3Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel4);
    }
    public void MVA3Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel2);
    }

    //Multiplikasjon VS Addisjon Del 4
    public void MVA4Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel5);
    }
    public void MVA4Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel3);
    }

    //Multiplikasjon VS Addisjon Del 5
    public void MVA5Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel6Ja);
    }
    public void MVA5Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel4);
    }
    public void MVA5Nei()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel6Nei);
    }

    //Multiplikasjon VS Addisjon Del 6Ja
    public void MVA6JaNext()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel7);
    }
    public void MVA6JaBack()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel5);
    }

    //Multiplikasjon VS Addisjon Del 6Nei
    public void MVA6NeiNext()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel7);
    }
    public void MVA6NeiBack()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel5);
    }

    //Multiplikasjon VS Addisjon Del 7
    public void MVA7Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel8);
    }
    public void MVA7Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel5);
    }
    
    //Multiplikasjon VS Addisjon Del 8
    public void MVA8Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel9);
    }
    public void MVA8Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel7);
    }

    //Multiplikasjon VS Addisjon Del 9
    public void MVA9Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel10);
    }
    public void MVA9Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel8);
    }

    //Multiplikasjon VS Addisjon Del 10
    public void MVA10Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel11);
    }
    public void MVA10Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel9);
    }

    //Multiplikasjon VS Addisjon Del 11
    public void MVA11Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel12Ja);
    }
    public void MVA11Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel10);
    }
    public void MVA11Nei()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel12Nei);
    }

    //Multiplikasjon VS Addisjon Del 12Ja
    public void MVA12JaNext()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Lett);
    }
    public void MVA12JaBack()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel11);
    }
    public void MVA12JaLett()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Lett);
    }
    public void MVA12JaMedium()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Medium);
    }
    public void MVA12JaHard()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Hard);
    }

    //Multiplikasjon VS Addisjon Del 12Nei
    public void MVA12NeiNext()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Lett);
    }
    public void MVA12NeiBack()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel11);
    }
    public void MVA12NeiStart()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel1);
    }
    
    //--------------------------------------------------------------------------------------------------------
    //SkipAktivity
    public void SkipAktivity()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel13);
    }

    //Aktivitet 1 Lett
    public void A1LettBack()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel12Ja);
    }
    public void A1LettNeste()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet2Lett);
    }
    //Aktivitet 2 Lett
    public void A2LettNeste()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet3Lett);
    }
    //Aktivitet 3 Lett
    public void A3LettNeste()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Medium);
    }
   

    //Aktivitet 1 Medium
    public void A1MediumBack()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel12Ja);
    }
    public void A1MediumNeste()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet2Medium);
    }
    //Aktivitet 2 Medium
    public void A2MediumNeste()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet3Medium);
    }
    

    //Aktivitet 3 Medium
    public void A3MediumNeste()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Hard);
    }
    //Aktivitet 1 Vanskelig
    public void A1HardBack()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel12Ja);
    }
    public void A1HardNeste()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet2Hard);
    }
    //Aktivitet 2 Vanskelig
    public void A2HardNeste()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet3Hard);
    }
    //Aktivitet 3 Vanskelig
    public void A3HardNeste()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel13);
    }
    

    //Endre vanskelighetsgrad
    public void ToMedium()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Medium);
    }
    public void ToHard()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Hard);
    }
    public void ToLett()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Lett);
    }

    //Multiplikasjon VS Addisjon Del 13
    public void MVA13Next()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel14);
    }
    public void MVA13Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel12Ja);
    }
    public void MVA13Lett()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Lett);
    }
    public void MVA13Medium()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Medium);
    }
    public void MVA13Hard()
    {
        SceneManager.LoadScene((int)Scenes.MultiAddAktivitet1Hard);
    }

    //Multiplikasjon VS Addisjon Del 14
    public void MVA14Back()
    {
        SceneManager.LoadScene((int)Scenes.MultiVSAddDel13);
    }

    //------------------------------------------------------------------------------------------------
    

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
