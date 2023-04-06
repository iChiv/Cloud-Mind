using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class levelCheck : MonoBehaviour
{
    //RaycastHit hit;
    [SerializeField] bool _finished = false;    
    public GameObject _event;
    public GameObject _f_bg;
    public GameObject _f_text;
    public GameObject _mainCam;

    public GameObject _l1;
    public GameObject _l2;
    public GameObject _l3;

    AudioSource _drop;
    public AudioClip _drop_c;

    float _time;

    public GameObject _f_jar;
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
    // Start is called before the first frame update
    void Start()
    {
        _drop = _f_jar.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_jar1_3.activeSelf&_jar1_4.activeSelf)
        {
            if(_jar2_3.activeSelf&_jar2_5.activeSelf)
            {
                if(_jar3_1.activeSelf&_jar3_2.activeSelf)
                {
                    _drop.PlayOneShot(_drop_c,0.5F);
                    _l1.GetComponent<DOTweenAnimation>().DOPlayBackwards();
                    _time += Time.deltaTime;
                    if(_time > 1)
                    {
                        _l2.GetComponent<DOTweenAnimation>().DOPlay();
                        _time =0;
                    }
                }
            }
        }

        if(_jar1_2.activeSelf&_jar1_3)
        {
            if(_jar2_1.activeSelf&_jar2_2.activeSelf&_jar2_5.activeSelf)
            {
                if(_jar3_2.activeSelf&_jar3_4.activeSelf)
                {
                    if(_jar4_1.activeSelf&_jar4_2.activeSelf&_jar4_3.activeSelf)
                    {
                        if(_jar5_4.activeSelf&_jar5_2.activeSelf&_jar5_5.activeSelf)
                        {
                            _drop.PlayOneShot(_drop_c,0.75F);
                            _l2.GetComponent<DOTweenAnimation>().DOPlayBackwards();
                            _time += Time.deltaTime;
                            if(_time > 1)
                            {
                                _l3.GetComponent<DOTweenAnimation>().DOPlay();
                                _time =0;
                            }
                        }
                    }
                }
            }
        }

        if(_jar1_2.activeSelf&_jar1_3)
        {
            if(_jar2_1.activeSelf&_jar2_2.activeSelf&_jar2_4.activeSelf)
            {
                if(_jar3_1.activeSelf&_jar3_5.activeSelf)
                {
                    if(_jar4_1.activeSelf&_jar4_2.activeSelf&_jar4_4.activeSelf)
                    {
                        if(_jar5_1.activeSelf&_jar5_2.activeSelf&_jar5_3.activeSelf)
                        {
                            _drop.PlayOneShot(_drop_c,1F);
                            _l3.GetComponent<DOTweenAnimation>().DOPlayBackwards();
                            _finished = true;
                        }
                    }
                }
            }
        }

        if(_finished)
        {
            
        }
    }
}
