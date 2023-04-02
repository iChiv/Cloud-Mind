using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainPlayer : MonoBehaviour
{
    public float speed;
    private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = speed * Time.deltaTime * 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
