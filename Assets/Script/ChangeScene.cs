﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int scene;
    public void changeScene(int scene) {
        SceneManager.LoadScene(scene);
    }

    public void ClickExit() {
        Application.Quit();
    }
}
