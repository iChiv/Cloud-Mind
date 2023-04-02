using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcheck : MonoBehaviour
{
    RaycastHit hit;
    public GameObject _resume;
    public GameObject _exit;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject objBed;
    [SerializeField] GameObject bedUI;
    int layerMask = 1<<6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, 100 , layerMask))
        {
            if(hit.collider.gameObject == objBed)
            {
                if(Input.GetMouseButtonDown(0))
                {
                    bedUI.SetActive(true);
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
