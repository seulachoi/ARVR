using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10, 10, 10);
        //연결된 transform의 값을 101010으로 정해라 
        transform.rotation = Quaternion.Euler(30, 60, 90);
        //unity의 좌표계는 quarternion 4원소값을 이용하여 각도를 표현 계산하기 때문
        transform.localScale = new Vector3(10, 10, 10);

        Debug.Log("x = " + transform.position.x);
        Debug.Log("Local x = " + transform.position.x); 
        //local이 붙으면 부모요소를 기준으로 계산
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward);
        transform.Rotate(Vector3.up);
    }
}
