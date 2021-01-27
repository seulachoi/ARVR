    // Start is called before the first frame update, start에서 함수를 선언해줘야 함수를 쓸 수 있음
    void Start()
    {
        //addition(10,20);
        //addition(20,30);
        //start 에서 함수의 인자를 설정함
        Debug.Log(addition02(10, 20));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //함수를 선언하는 과정, ()안에서 인자를 각각 선언 
    //int 와 void는 자료형을 나타냄 
    int addition02(int number01, int number02)
    {
        answer = number01 + number02;
        return answer;
    }

    void addition(int number01, int number02)
    {
        answer = number01 + number02;
        Debug.Log(answer);
        if (answer < 20)
        {
            Debug.Log("answer is smaller than 20");
        }
        else if (answer == 20)
        {
            Debug.Log("answer is 20");
        }
        else
        {
            Debug.Log(answer);
        }
