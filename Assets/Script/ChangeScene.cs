using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int scene;
    public AudioSource clickSound;
    public void changeScene(int scene) {
        clickSound.Play();
        SceneManager.LoadScene(scene);
    }

    public void ClickExit() {
        Application.Quit();
    }
}
