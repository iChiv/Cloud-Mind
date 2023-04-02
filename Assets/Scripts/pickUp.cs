using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] GameObject mainCam;
    int layerMask = 1 << 10 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit, 100 , layerMask))
        {
            if(hit.collider.gameObject != null)
            {
                //Debug.Log("Bingo!");
            }
        }
    }
}
