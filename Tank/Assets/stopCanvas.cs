using UnityEngine;
using UnityEngine.SceneManagement;
public class stopCanvas : MonoBehaviour {
    

    public void btnContinuteOnClick()
    {
        Constants.stopflag = false;
        Constants.canvas.gameObject.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        
    }

    public void btnQuitOnClick()
    {
        Application.Quit();
    }

    public void btnNewGameOnClick()
    {
        Constants.stopflag = false;
        Constants.canvas.gameObject.SetActive(false);
        SceneManager.LoadScene(Constants.StartSceneName);
    }
    
}
