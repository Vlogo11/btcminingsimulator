using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Resulotion : MonoBehaviour
{

    [SerializeField] GameObject optionPanel;

    public void GoToOptions()
    {
        optionPanel.SetActive(true);
    }

    public void OnPlayClicked()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR    
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    List<int> widths = new List<int>() {320, 800, 1280, 1920};
    List<int> heights = new List<int>() {240, 480, 720, 1080};

    public void SetScreenSize(int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen);
    }

    public void SetFullScreen(bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }
}