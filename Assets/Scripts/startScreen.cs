using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class startScreen : MonoBehaviour
{
    public GameObject _startBg;
    public GameObject _logo;
    public GameObject _focus;
    public GameObject _level1;

    public GameObject _event;
    float time = 0;

    public GameObject _mainCam;
    bool _start = true;
    // Start is called before the first frame update
    void Start()
    {
        _mainCam.GetComponent<MouseLook>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown&_start)
        {
            _startBg.GetComponent<DOTweenAnimation>().DOPlay();
            _logo.GetComponent<DOTweenAnimation>().DOPlay();
            time += Time.deltaTime;
            _level1.GetComponent<DOTweenAnimation>().DOPlay();
            _startBg.SetActive(false);
            _logo.SetActive(false);
            _focus.SetActive(true);
            _start = false;
            _mainCam.GetComponent<MouseLook>().enabled = true;
            _event.GetComponent<cloudCheck>().enabled = true;
            
        }
    }
}
