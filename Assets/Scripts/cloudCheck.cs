using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cloudCheck : MonoBehaviour
{
    [SerializeField]float _time_c;

    [SerializeField] float _time_target = 15;
    [SerializeField]int _seq_c;
    [SerializeField]int _seq_t;

    [SerializeField]bool _show_c = false;
    [SerializeField]bool _show_t = false;

    public GameObject _cloud1;
    public GameObject _cloud2;
    public GameObject _cloud3;

    public GameObject _text1;
    public GameObject _text2;
    public GameObject _text3;
    public GameObject _text4;
    public GameObject _text5;
    public GameObject _text6;
    public GameObject _text7;
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init(true);
        _time_c = 0;
        _seq_c = 1;
        _seq_t = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _time_c += Time.deltaTime;
        if(_time_c > _time_target&!_show_c)
        {
            if(_seq_c == 1)
            {
                _cloud1.GetComponent<DOTweenAnimation>().DOPlayForward();
            }
            
            if(_seq_c == 2)
            {
                _cloud2.GetComponent<DOTweenAnimation>().DOPlayForward();
            }
            
            if(_seq_c == 3)
            {
                _cloud3.GetComponent<DOTweenAnimation>().DOPlayForward();
            }

            _seq_c = _seq_c + 1;
            if(_seq_c == 4)
            {
                _seq_c = 1;
            }

            //_time_c = 0;
            _show_c = true;
        }
        else if(_time_c > _time_target & _show_c)
        {
            if(_seq_c == 2)
            {
                _cloud1.GetComponent<DOTweenAnimation>().DOPlayBackwards();
            }
            else if(_seq_c == 3)
            {
                _cloud2.GetComponent<DOTweenAnimation>().DOPlayBackwards();
            }
            else if(_seq_c == 1)
            {
                _cloud3.GetComponent<DOTweenAnimation>().DOPlayBackwards();
            }
            //_time_c = 0;
            _show_c = false;
        }

        if(_time_c > _time_target & !_show_t)
        {
            if(_seq_t == 1)
            {
                _text1.GetComponent<DOTweenAnimation>().DOPlay();
            }
            if(_seq_t == 2)
            {
                _text2.GetComponent<DOTweenAnimation>().DOPlay();
            }
            if(_seq_t == 3)
            {
                _text3.GetComponent<DOTweenAnimation>().DOPlay();
            }
            if(_seq_t == 4)
            {
                _text4.GetComponent<DOTweenAnimation>().DOPlay();
            }
            if(_seq_t == 5)
            {
                _text5.GetComponent<DOTweenAnimation>().DOPlay();
            }
            if(_seq_t == 6)
            {
                _text6.GetComponent<DOTweenAnimation>().DOPlay();
            }
            if(_seq_t == 7)
            {
                _text7.GetComponent<DOTweenAnimation>().DOPlayForward();
            }

            _seq_t +=1;
            _time_c = 0;
            _show_t = true;
        }
        else if(_time_c > _time_target & _show_t)
        {
            if(_seq_t == 2)
            {
                _text1.GetComponent<DOTweenAnimation>().DOPlayBackwards();
            }
            if(_seq_t == 3)
            {
                _text2.GetComponent<DOTweenAnimation>().DOPlayBackwards();
            }
            if(_seq_t == 4)
            {
                _text3.GetComponent<DOTweenAnimation>().DOPlayBackwards();
            }
            if(_seq_t == 5)
            {
                _text4.GetComponent<DOTweenAnimation>().DOPlayBackwards();
            }
            if(_seq_t == 6)
            {
                _text5.GetComponent<DOTweenAnimation>().DOPlayBackwards();
            }
            if(_seq_t == 7)
            {
                _text6.GetComponent<DOTweenAnimation>().DOPlayBackwards();
            }
            if(_seq_t > 7)
            {
                _text7.GetComponent<DOTweenAnimation>().DOPlayBackwards();
            }

            _show_t = false;
            _time_c = 0;
        }
    }
}
