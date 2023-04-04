using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jarCheck : MonoBehaviour
{
    RaycastHit _jarHit;
    int layerMask = 1 <<10;
    public GameObject mainCam;
    public GameObject _jar1;
    public GameObject _jar2;
    public GameObject _jar3;
    public GameObject _jar4;
    public GameObject _jar5;

    public GameObject _jar1_1;
    public GameObject _jar1_2;
    public GameObject _jar1_3;
    public GameObject _jar1_4;
    public GameObject _jar1_5;
    public GameObject _jar2_1;
    public GameObject _jar2_2;
    public GameObject _jar2_3;
    public GameObject _jar2_4;
    public GameObject _jar2_5;
    public GameObject _jar3_1;
    public GameObject _jar3_2;
    public GameObject _jar3_3;
    public GameObject _jar3_4;
    public GameObject _jar3_5;
    public GameObject _jar4_1;
    public GameObject _jar4_2;
    public GameObject _jar4_3;
    public GameObject _jar4_4;
    public GameObject _jar4_5;
    public GameObject _jar5_1;
    public GameObject _jar5_2;
    public GameObject _jar5_3;
    public GameObject _jar5_4;
    public GameObject _jar5_5;

    public GameObject _jar_pill_1;
    public GameObject _jar_pill_2;
    public GameObject _jar_pill_3;
    public GameObject _jar_pill_4;
    public GameObject _jar_pill_5;

    public GameObject _pill1;
    public GameObject _pill2;
    public GameObject _pill3;
    public GameObject _pill4;
    public GameObject _pill5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out _jarHit, 20 , layerMask))
        {
            if(_jarHit.collider.gameObject == _jar_pill_1&Input.GetMouseButtonDown(0)){
                _pill1.SetActive(true);
                _pill2.SetActive(false);
                _pill3.SetActive(false);
                _pill4.SetActive(false);
                _pill5.SetActive(false);
            }
            else if(_jarHit.collider.gameObject == _jar_pill_2&Input.GetMouseButtonDown(0))
            {
                _pill1.SetActive(false);
                _pill2.SetActive(true);
                _pill3.SetActive(false);
                _pill4.SetActive(false);
                _pill5.SetActive(false);
            }
            else if(_jarHit.collider.gameObject == _jar_pill_3&Input.GetMouseButtonDown(0))
            {
                _pill1.SetActive(false);
                _pill2.SetActive(false);
                _pill3.SetActive(true);
                _pill4.SetActive(false);
                _pill5.SetActive(false);
            }
            else if(_jarHit.collider.gameObject == _jar_pill_4&Input.GetMouseButtonDown(0))
            {
                _pill1.SetActive(false);
                _pill2.SetActive(false);
                _pill3.SetActive(false);
                _pill4.SetActive(true);
                _pill5.SetActive(false);
            }
            else if(_jarHit.collider.gameObject == _jar_pill_5&Input.GetMouseButtonDown(0))
            {
                _pill1.SetActive(false);
                _pill2.SetActive(false);
                _pill3.SetActive(false);
                _pill4.SetActive(false);
                _pill5.SetActive(true);
            }
        }

        if(Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out _jarHit, 20 , layerMask))
        {
            if(_jarHit.collider.gameObject == _jar1&Input.GetMouseButtonDown(0))
            {
                if(_pill1.activeSelf)
                {
                    _jar1_1.SetActive(true);
                }
                else if(_pill2.activeSelf)
                {
                    _jar1_2.SetActive(true);
                }
                else if(_pill3.activeSelf)
                {
                    _jar1_3.SetActive(true);
                }
                else if(_pill4.activeSelf)
                {
                    _jar1_4.SetActive(true);
                }
                else if(_pill5.activeSelf)
                {
                    _jar1_5.SetActive(true);
                }
            }
            if(_jarHit.collider.gameObject == _jar2&Input.GetMouseButtonDown(0))
            {
                if(_pill1.activeSelf)
                {
                    _jar2_1.SetActive(true);
                }
                else if(_pill2.activeSelf)
                {
                    _jar2_2.SetActive(true);
                }
                else if(_pill3.activeSelf)
                {
                    _jar2_3.SetActive(true);
                }
                else if(_pill4.activeSelf)
                {
                    _jar2_4.SetActive(true);
                }
                else if(_pill5.activeSelf)
                {
                    _jar2_5.SetActive(true);
                }
            }
            if(_jarHit.collider.gameObject == _jar3&Input.GetMouseButtonDown(0))
            {
                if(_pill1.activeSelf)
                {
                    _jar3_1.SetActive(true);
                }
                else if(_pill2.activeSelf)
                {
                    _jar3_2.SetActive(true);
                }
                else if(_pill3.activeSelf)
                {
                    _jar3_3.SetActive(true);
                }
                else if(_pill4.activeSelf)
                {
                    _jar3_4.SetActive(true);
                }
                else if(_pill5.activeSelf)
                {
                    _jar3_5.SetActive(true);
                }
            }
            if(_jarHit.collider.gameObject == _jar4&Input.GetMouseButtonDown(0))
            {
                if(_pill1.activeSelf)
                {
                    _jar4_1.SetActive(true);
                }
                else if(_pill2.activeSelf)
                {
                    _jar4_2.SetActive(true);
                }
                else if(_pill3.activeSelf)
                {
                    _jar4_3.SetActive(true);
                }
                else if(_pill4.activeSelf)
                {
                    _jar4_4.SetActive(true);
                }
                else if(_pill5.activeSelf)
                {
                    _jar4_5.SetActive(true);
                }
            }
            if(_jarHit.collider.gameObject == _jar5&Input.GetMouseButtonDown(0))
            {
                if(_pill1.activeSelf)
                {
                    _jar5_1.SetActive(true);
                }
                else if(_pill2.activeSelf)
                {
                    _jar5_2.SetActive(true);
                }
                else if(_pill3.activeSelf)
                {
                    _jar5_3.SetActive(true);
                }
                else if(_pill4.activeSelf)
                {
                    _jar5_4.SetActive(true);
                }
                else if(_pill5.activeSelf)
                {
                    _jar5_5.SetActive(true);
                }
            }
        }
    }
}
