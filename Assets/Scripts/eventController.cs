using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        hideCursor();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            showCursor();
        }
    }

    public void hideCursor()
    {
        Cursor.visible =false;
    }

    public void showCursor()
    {
        Cursor.visible = true;
    }
}
