using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuLogic : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject creditsMenu;
    [SerializeField] GameObject levelSelect;
    [SerializeField] GameObject optionsMenu;

    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        creditsMenu.SetActive(false);
        levelSelect.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void ShowCreditsMenu()
    {
        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);
        levelSelect.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void ShowLevelSelect()
    {
        mainMenu.SetActive(false);
        creditsMenu.SetActive(false);
        levelSelect.SetActive(true);
        optionsMenu.SetActive(true);
    }

    public void ShowOptionsMenu()
    {
        mainMenu.SetActive(false);
        creditsMenu.SetActive(false);
        levelSelect.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Test level");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif  
    }
}
