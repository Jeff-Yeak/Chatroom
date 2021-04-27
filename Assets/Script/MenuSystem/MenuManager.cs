using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Panel currentPanel = null;

    private List<Panel> panelHistory = new List<Panel>();
    

    private void Start()
    {
        SetupPanels();
    }

    private void SetupPanels()
    {
        Panel[] panels = GetComponentsInChildren<Panel>();

        foreach (Panel panel in panels)
            panel.Setup(this);

        currentPanel.Show();
    }

    public void GoToNextScene()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Test1"))
        {
            SceneManager.LoadScene("Test2");
        }
    }

    public void GotoSignIn()
    {
        SceneManager.LoadScene("Login-Scene");
    }
    public void GoToPrevious()
    {
        if (panelHistory.Count == 0)
        {
            OVRManager.PlatformUIConfirmQuit();
            return;
        }
        int lastIndex = panelHistory.Count - 1;
        SetCurrent(panelHistory[lastIndex]);
        panelHistory.RemoveAt(lastIndex);
    }
    public void GoToPreviousForLogin()
    {
        if (panelHistory.Count == 0)
        {
            SceneManager.LoadScene("Test1");
        }
        int lastIndex = panelHistory.Count - 1;
        SetCurrent(panelHistory[lastIndex]);
        panelHistory.RemoveAt(lastIndex);
    }
    public void SetCurrentWithHistory(Panel newPanel)
    {
        panelHistory.Add(currentPanel);
        SetCurrent(newPanel);
    }


    private void SetCurrent(Panel newPanel)
    {
        currentPanel.Hide();
        currentPanel = newPanel;
        currentPanel.Show();
    }
   
}
