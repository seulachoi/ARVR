using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    int number01;
    int number02;
    int number03;

    // Start is called before the first frame update
    void Start()
    {
        number01 = 10;
        number02 = 20;
        number03 = 30;
        if (number01 == 10)
        {
            Debug.Log("number01 = 10");
        }

        if (number02 <= number01)
        {
            Debug.Log("number02 is bigger than number01");
        }
        else if (number02 <= number03)
        {
            Debug.Log("number03 is bigger than number02");
        }
        else
        {
            Debug.Log("number01 is bigger than number02");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
