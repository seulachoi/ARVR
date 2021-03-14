using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycast : MonoBehaviour
{
    public Image reticle;
    float timeElapsed;
    //using UnityEngine.UI 선언을 해주어야 Image UI를 쓸 수 있음

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        raycasting();
    }

    void raycasting()
    {
        RaycastHit hit;
        //변수 선언
        Vector3 forward = transform.TransformDirection(Vector3.forward * 1000);
        //TransformDirection 방향을 vector로 바꾸어주는 함수, forward 는 방향 (앞), 크기는 1000 으로 만들어서 vector3에 집어넣음
        if(Physics.Raycast(transform.position, forward, out hit))
        {
            timeElapsed = Time.deltaTime + timeElapsed;
            //Time.deltaTime은 한 프레임당 걸리는 시간을 측정, timeElapsed는 지금까지 지나온 시간, 3초가 지나면 fillAmount가 1이 될 수 있도록 3으로 나누어줌
            reticle.fillAmount = timeElapsed / 3;
            if(timeElapsed >= 3)
            {
                timeElapsed = 3;
                hit.transform.GetComponent<Button>().onClick.Invoke();
            }
            
            Debug.Log("hit!!!");
        }else
        {
            timeElapsed = timeElapsed - Time.deltaTime;
            reticle.fillAmount = timeElapsed / 3;
            if (timeElapsed <= 0) timeElapsed = 0; 
        }
        //if raycast가 충돌을 하면 --을 해라
        //hit.transform.GetComponent<Button>().onClick.Invoke(); -> Raycast가 충돌한 object의 button component에서 onClick을 실행해라
        //Raycast 는 bool로서 참/거짓을 return
        //근원지 transform.position에서 forward라는 방향으로, raycast가 충돌한 object의 값을 hit에 담는다. 즉, raycast가 부딪힌 cube의 정보가 hit에 담김
        //timeElapsed의 최소값은 0, 최대값은 3으로 제한해주어야 timeElapsed가 음수로 내려가지 않음 -> timeElapsed가 음수면 게이지가 증가하지 않으니까 최소값을 0으로 제한해야함
        Debug.DrawRay(transform.position, forward, Color.red);
        //DrawRay(근원지, 방향, 색상); raycast는 가상의 광선으로, 
    }
   
}
