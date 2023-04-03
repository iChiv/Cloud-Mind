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
            if(hit.collider.gameObject.layer == LayerMask.NameToLayer("UI"))
            {
                Debug.Log("!!!");
                //if(hit.collider.gameObject = _resume)
                //hit.collider.gameObject.GetComponent<Outline>.enabled = true;

            }
        }
    }
}
