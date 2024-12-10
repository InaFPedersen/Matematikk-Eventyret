﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartSceneUI : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene((int)Scenes.GameHistoryDel1);
    }

    public void Tutorial()
    {
        SceneManager.LoadScene((int)Scenes.Tutorial);
    }

    public void EndGame()
    {
        Application.Quit();
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
