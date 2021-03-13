# 스티칭
> 여러개의 영상을 이어 붙이는 작업, 대부분의 시간이 할애되는 작업   
> 스티칭이 제대로 되지 않을 경우, 영상왜곡이 생겨 몰입감이 감소

# 스크린도어 효과 
> 360 영상으로 표현하다 보니, 픽셀을 나누는 수평수직 선이 보이는 영상   
> 4k 영상이라도, 360 영상을 만들 경우 스크린도어 효과로 인해 해상도가 저하됨 
> 
## Shader?
> object에 렌더링 해주는 매개체? 

## 360 영상에 play video 버튼 넣기 
> UI-Button생성   
> canvas에서 world space 선택 시, canvas를 이동할 수 있음  

## Raycast
```
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
            Debug.Log("hit!!!");
        }
        //Raycast 는 bool로서 참/거짓을 return
        //근원지 transform.position에서 forward라는 방향으로, raycast가 부딪힌 object의 값을 hit에 담는다. 즉, raycast가 부딪힌 cube의 정보가 hit에 담김
        Debug.DrawRay(transform.position, forward, Color.red);
        //DrawRay(근원지, 방향, 색상); raycast는 가상의 광선으로, 
    }
```
    
## TIL
-shader가 뭐지...?
