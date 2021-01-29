using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(100, 100, 100), 0.1f);
        //나의 위치 transform.position에서 100 100 100 으로 이동해라 , time
        transform.position = Vector3.Lerp(transform.position, new Vector3(10, 10, 10), 0.001f);
    }
}
