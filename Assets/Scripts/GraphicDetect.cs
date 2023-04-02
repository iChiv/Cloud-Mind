using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GraphicDetect : MonoBehaviour
{
    public Transform origin;   //射线起点
    public Button _resume; 
     public Button _exit;    //开始按钮
    public LineRenderer line;  
    Vector3 endPoint;          //LineRender结束点
    // Start is called before the first frame update
    void Start()
    {
        _resume.onClick.AddListener(delegate ()
        {
            Debug.Log("Game Start");
        });
        endPoint = line.GetPosition(1);
        
        _exit.onClick.AddListener(delegate ()
        {
            Debug.Log("Game Start");
        });
        endPoint = line.GetPosition(1);
 
    // Update is called once per frame
    void Update()
    {
       // Physics
        RaycastHit hit;
        //需要设置射线检测层
        if (Physics.Raycast(origin.position, origin.forward, out hit,50))
        {
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("UI"))
            {
                //将轮廓组件显示
                _resume.gameObject.GetComponent<Outline>().enabled = true;
                //将世界坐标转换为Local
                line.SetPosition(1,line.transform.InverseTransformPoint( hit.point));
                if (Input.GetMouseButtonDown(0)) 
                {
                    //自动执行按钮对应的回调函数
                    ExecuteEvents.Execute<IPointerClickHandler>(_resume.gameObject,
                        new PointerEventData(EventSystem.current), 
                        ExecuteEvents.pointerClickHandler);
                }  
            }
        }
        else {
            _resume.gameObject.GetComponent<Outline>().enabled = false;
            line.SetPosition(1,endPoint);
        }
    }
    }}
