using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField]
    GameObject menuPanel;

    private void Start()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void OpenMenuPanel()
    {
        menuPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
