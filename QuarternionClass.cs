using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuarternionClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Quarternion x = " + transform.rotation.x);
        Debug.Log("Degree x =" + transform.eulerAngles.x);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(180, 0, 0), 0.01f);
        //현재 회전값에서 목표 회전값까지 
        //목표값은 quaternion.Euler(x,x,x) 값으로 주어야 함, 이때 transform 창의 360도 각도는 아님
    }
}
