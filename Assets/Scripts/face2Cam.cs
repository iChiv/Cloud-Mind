using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class face2Cam : MonoBehaviour
{
    [SerializeField] Transform m_Cam;
    // Start is called before the first frame update
    void Start()
    {
        m_Cam = Camera.main.transform;
    }

    // Update is called once per frame
    void LateUpdate() 
    {
        if(m_Cam == null){
		return;
	}
	// 这里我的角色朝向和UI朝向是相反的，如果直接用LookAt()还需要把每个UI元素旋转过来。
	// 为了简单，用了下面这个方法。它实际上是一个反向旋转，可以简单理解为“负负得正”吧
	transform.rotation = Quaternion.LookRotation (transform.position - m_Cam.position);
    }
}
