using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNav : MonoBehaviour
{
    public void LoadSplash()  { SceneManager.LoadScene("Splash"); }
    public void LoadGuide()   { SceneManager.LoadScene("Guide"); }
    public void LoadPlay()    { SceneManager.LoadScene("Play"); }
    public void LoadResults() { SceneManager.LoadScene("Results"); }
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
