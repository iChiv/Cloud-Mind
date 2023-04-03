using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontroll : MonoBehaviour
{
    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Exit(){
        Application.Quit();
    }

    public void Resume(){
        Cursor.lockState = CursorLockMode.Locked;
    }
}
