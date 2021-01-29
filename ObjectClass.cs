using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(this.gameObject);
        //Instantiate 는 object를 복제. 절대 update에 넣으면 안됨
        Destroy(this.gameObject);
        //destroy는 오브젝트를 제거함
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
