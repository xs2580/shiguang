using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class beer : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}

using UnityEngine.UI;

public class beer : MonoBehaviour
{
    // 目标UI界面（需在Inspector手动赋值）
    public GameObject Canvas2;

    // 点击时触发
    private void OnMouseDown()
    {
        // 隐藏当前UI（示例：假设当前UI为自身所在Canvas，可根据实际调整）
      //  gameObject.GetComponentInParent<Canvas>().enabled = false;

        // 显示目标UI
        if (Canvas2 != null)
        {
            Canvas2.SetActive(true);
        }
    }
}