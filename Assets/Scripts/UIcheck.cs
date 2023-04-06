using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcheck : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject _player;
    [SerializeField] GameObject objBed;
    [SerializeField] GameObject bedUI;

    [SerializeField] GameObject roll;
    [SerializeField] GameObject crystal;
    [SerializeField] GameObject coin;
    [SerializeField] GameObject info;
    [SerializeField] GameObject info1;
    [SerializeField] GameObject info2;
    [SerializeField] GameObject info3;
    int layerMask = 1<<6;
    [SerializeField] float checkDistance = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, checkDistance , layerMask))
        {
            if(hit.collider.gameObject == objBed)
            {
                if(Input.GetMouseButtonDown(0))
                {
                    bedUI.SetActive(true);
                    mainCam.GetComponent<MouseLook>().enabled = false;
                    _player.GetComponent<playerMove>().enabled =false;
                    Cursor.lockState = CursorLockMode.Confined;
                }
            }
            if(hit.collider.gameObject == roll)
            {
                if(Input.GetMouseButtonDown(0))
                {
                    mainCam.GetComponent<MouseLook>().enabled = false;
                    info.SetActive(true);
                    info1.SetActive(true);
                }
                
            }
            if(hit.collider.gameObject == crystal)
            {
                if(Input.GetMouseButtonDown(0))
                {
                    mainCam.GetComponent<MouseLook>().enabled = false;
                    info.SetActive(true);
                    info2.SetActive(true);
                }
            }
            if(hit.collider.gameObject == coin)
            {
                Debug.Log("!!!!");
                if(Input.GetMouseButtonDown(0))
                {
                    mainCam.GetComponent<MouseLook>().enabled = false;
                    info.SetActive(true);
                    info3.SetActive(true);
                }
            }

        }

        if(info.activeSelf&Input.anyKeyDown)
        {
            mainCam.GetComponent<MouseLook>().enabled = true;
            info.SetActive(false);
            info1.SetActive(false);
            info2.SetActive(false);
            info3.SetActive(false);
        }

        
    }
}
