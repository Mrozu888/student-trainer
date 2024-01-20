using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainCam;
    [SerializeField] private GameObject menuCam;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject PlayBtn;
    [SerializeField] private GameObject SettingsBtn;
    [SerializeField] private GameObject QuitBtn;
    public void PlayGame()
    {
        Debug.Log("PlayGame btn clicked!");
        mainCam.SetActive(true);
        menuCam.SetActive(false);
        this.gameObject.SetActive(false);
    }
    
    public void Settings()
    {
        Debug.Log("Settings btn clicked!");
        settingsPanel.SetActive(true);
        PlayBtn.SetActive(false);
        SettingsBtn.SetActive(false);
        QuitBtn.SetActive(false);
    }
    
    public void Quit()
    {
        Debug.Log("Quit btn clicked!");
        Application.Quit();
    }
}
