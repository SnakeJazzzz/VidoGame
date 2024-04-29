using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public UserInformation userInformation;
    public string buttonClickSoundName;



    void Start()
    {
        SoundManager.Instance.PlayMusic(SoundManager.Instance.musicClips[0], true); 
    }


    public void cambiarescena(string escena)
    {
        SceneManager.LoadScene(escena);
        SoundManager.Instance.PlaySFXByName(buttonClickSoundName);

    }


    
  

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
