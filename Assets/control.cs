using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    void Start()
    {
        //获取动画器组件
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.Play("go");
        }
        if (Input.GetMouseButtonDown(1))
        {
            animator.Play("no");
        }

    }
}
