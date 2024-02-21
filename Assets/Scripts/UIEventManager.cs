using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEventManager : MonoBehaviour
{
    private bool play = false, settings = false, quit = false, backFromSettings = false;
    
    public delegate void ClickPlayAction();
    public static event ClickPlayAction OnClickedPlay;
    public delegate void ClickSettingsAction();
    public static event ClickSettingsAction OnClickedSettings;
    public delegate void ClickQuitAction();
    public static event ClickQuitAction OnClickedQuit;
    public delegate void ClickBackAction();
    public static event ClickBackAction OnClickedBack;

    void Update()
    {
        if (play)
        {
            if (OnClickedPlay != null)
                OnClickedPlay();
            play = false;
        }
        if (settings)
        {
            if (OnClickedSettings != null)
                OnClickedSettings();
            settings = false;
        }
        if (quit)
        {
            if (OnClickedQuit != null)
                OnClickedQuit();
            quit = false;
        }

        if (backFromSettings)
        {
            if (OnClickedBack != null)
                OnClickedBack();
            backFromSettings = false;
        }
        
    }

    public void BackFromSettingsTrigger()
    {
        backFromSettings = true;
    }

    public void PlayTrigger()
    {
        play = true;
    }
    
    public void SettingsTrigger()
    {
        settings = true;
    }
    
    public void QuitTrigger()
    {
        quit = true;
    }
}
