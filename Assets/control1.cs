using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control1 : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator1;
    void Start()
    {
        //获取动画器组件
        animator1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator1.Play("go1");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator1.Play("no1");
        }

    }
}
