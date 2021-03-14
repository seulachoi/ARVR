# LoadScene 의 기능을 구현하기 위한 Button 구현하기 
- canvas-button에서 Onclick()이벤트 생성 
- 바로 c# 스크립트를 연결하는 것이 아니라, empty object를 생성한 후 empty object에 script를 연결한 후 
- Onclick()이벤트에 해당 object를 연결함

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager1 : MonoBehaviour
{
    public void toVideoScene()
    {
        SceneManager.LoadScene("360Video");
    }
}

```
