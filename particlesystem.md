# Particle System
> 자연 입자의 움직임을 코드로 짜지 않고 이용할수있도록 제공하는 Unity 상의 기술   
- 물이 찰랑거리는, 바람이 부는, 불 효과 등   
- component의 particle창에서 사이즈, 속도, 모양, 크기 등 세부 사항을 조절할 수 있음   

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameObject ExpObj;

    private void OnTriggerEnter(Collider other)
    {
        ExpObj.SetActive(true);
        transform.GetComponent<MeshRenderer>().enabled = false;
        //스크립트를 연결해놓은 asset의 component에 접근해서, 해당 컴포넌트를 꺼버림으로써 그래픽 효과를 지움->사라지는 것처럼 표현
        Invoke("DestObj", 2);
        //문자열로 지정한 함수를 2초 후에 호출;Invoke가 아니라 바로 Destroy를 한다면 폭발effect가 적용될 시간 없이 asset이 사라지기 때문에 시간차를 두고 Destroy 적용함
        //Destroy(this.gameObject);
    }

    void DestObj()
    {
        Destroy(this.gameObject);
    }

}
```

# Scene 구성
> Unity 등 게임은 하나의 씬으로 구성   
> 게임 scene, 메뉴 scene 을 따로 구성
- UI에서 Button 과 같은 object을 생성 시, canvas의 자식 요소로 생성됨
- EventSystem을 통해 입력/출력을 실행

## button에 함수 연결하기 
1. script에 함수를 작성 
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
```
2. buttonmanager라는 empty object를 생성 / 이미 scene창에 있는 play button이 아니라 별개의 object
3. buttonmanager object에 script를 연결해주기 (inspector창에 drag)
4. play button의 on click 부분에 buttonmanager object를 연결 *script를 연결하는게 아님*
