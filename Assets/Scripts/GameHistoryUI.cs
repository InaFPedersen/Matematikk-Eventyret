using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameHistoryUI : MonoBehaviour
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

    //Game History Del 1
    public void GH1Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel2);
    }

    //Game History Del 2
    public void GH2Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel3);
    }
    public void GH2Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel1);
    }

    //Game History Del 3
    public void GH3Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel4);
    }
    public void GH3Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel2);
    }

    //Game History Del 4
    public void GH4Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel5);
    }
    public void GH4Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel3);
    }

    //Game History Del 5
    public void GH5Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel6);
    }
    public void GH5Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel4);
    }

    //Game History Del 6
    public void GH6Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel7);
    }
    public void GH6Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel5);
    }

    //Game History Del 7
    public void GH7Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel8);
    }
    public void GH7Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel6);
    }

    //Game History Del 8
    public void GH8Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel9);
    }
    public void GH8Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel7);
    }

    //Game History Del 9
    public void GH9Yes()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel10ja);
    }
    public void GH9No()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel10nei);
    }
    public void GH9Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel8);
    }

    //Game History Del 10ja
    public void GH10jaNext()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Addisjon);
    }
    public void GH10jaBack()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel9);
    }
    public void GH10Addisjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Addisjon);
    }
    public void GH10Subtraksjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Subtraksjon);
    }
    public void GH10Multiplikasjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Multiplikasjon);
    }
    public void GH10Divisjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Addisjon);
    }

    //Game History Del 10nei
    public void GH10neiNext()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel12);
    }
    public void GH10neiBack()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel9);
    }

    //Game History Del 11 Common for all 4
    public void GH11HoppOver()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel12);
    }
    public void GH11Addisjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Addisjon);
    }
    public void GH11Subtraksjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Subtraksjon);
    }
    public void GH11Multiplikasjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Multiplikasjon);
    }
    public void GH11Divisjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Divisjon);
    }

    //Game History Del 11 Addisjon
    public void GH11AddisjonNext()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Subtraksjon);
    }
    public void GH11AddisjonBack()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel10ja);
    }
  
    //Game History Del 11 Subtraksjon
    public void GH11SubtraksjonNext()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Multiplikasjon);
    }
    public void GH11SubtraksjonBack()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel10ja);
    }

    //Game History Del 11 Multiplikasjon
    public void GH11MultiplikasjonNext()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Divisjon);
    }
    public void GH11MultiplikasjonBack()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel10ja);
    }

    //Game History Del 11 Divisjon
    public void GH11DivisjonNext()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel12);
    }
    public void GH11DivisjonBack()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel10ja);
    }

    //Game History Del 12
    public void GH12Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel13);
    }
    public void GH12Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel11Divisjon);
    }

    //Game History Del 13
    public void GH13Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel14);
    }
    public void GH13Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel12);
    }

    //Game History Del 14
    public void GH14Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel15Nei);
    }
    public void GH14Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel13);
    }
    public void GH14Nei()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel15Nei);
    }
    public void GH14Ja1()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel15Ja1);
    }
    public void GH14Ja2()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel15Ja2);
    }
    public void GH14Ja3()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel15Ja3);
    }
    public void GH14Ja4()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel15Ja4);
    }

    //Game History Del 15 nei
    public void GH15NeiNext()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Addisjon);
    }
    public void GH15NeiBack()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel14);
    }

    //Game History Del 15 ja1
    public void GH15Ja1Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Subtraksjon);
    }
    public void GH15Ja1Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel14);
    }

    //Game History Del 15 ja2
    public void GH15Ja2Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Multiplikasjon);
    }
    public void GH15Ja2Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel14);
    }

    //Game History Del 15 ja3
    public void GH15Ja3Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Divisjon);
    }
    public void GH15Ja3Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel14);
    }

    //Game History Del 15 ja4
    public void GH15Ja4Next()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Multiplikasjon);
    }
    public void GH15Ja4Back()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel14);
    }
    public void GH15Ja4Addisjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Addisjon);
    }
    public void GH15Ja4Subtraksjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Subtraksjon);
    }
    public void GH15Ja4Divisjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Divisjon);
    }

    //Game History Del 16 Common to all
    public void GH16Addisjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Addisjon);
    }
    public void GH16Subtraksjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Subtraksjon);
    }
    public void GH16Multiplikasjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Multiplikasjon);
    }
    public void GH16Divisjon()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Divisjon);
    }
    
    //Game History Del 16 Addisjon
    public void GH16AddisjonNext()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Subtraksjon);
    }
    public void GH16AddisjonBack()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel14);
    }

    //Game History Del 16 Subtraksjon
    public void GH16SubtraksjonNext()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel16Multiplikasjon);
    }
    public void GH16SubtraksjonBack()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel14);
    }
    
    //Game History Del 16 Multiplikasjon
    public void GH16MultiplikasjonNext()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel1);
    }
    public void GH16MultiplikasjonBack()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel14);
    }

    //Game History Del 16 Divisjon
    public void GH16DivisjonNext()
    {
        SceneManager.LoadScene((int)Scenes.MultiplikasjonDel1);
    }
    public void GH16DivisjonBack()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel14);
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
