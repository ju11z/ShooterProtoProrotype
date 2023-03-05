using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject DeathScreen;
    public GameObject Menu;

    public void ShowMenu() {
        Menu.SetActive(true);
    }

    public void HideMenu()
    {
        Menu.SetActive(false);
    }

    public void ShowDeathScreen(int health)
    {
        DeathScreen.SetActive(true);
    }
    public void HideDeathScreen()
    {
        DeathScreen.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        HideMenu();
        HideDeathScreen();
    }
    
}
