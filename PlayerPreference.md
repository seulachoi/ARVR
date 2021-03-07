# player preference
> 사용자가 특정 선택지를 선택할 수 있도록 (우주선 선택 해서 선택한 우주선으로 게임을 할 수 있도록)
- PlayerPrefs.SetInt("이름표", 값)   
  이름표와 값을 설정하여 해당 이름표의 값을 호출 
  
  ```
  public class selectShip : MonoBehaviour
{
    public void sparrow1()
    {
        PlayerPrefs.SetInt("ShipType", 1);
        SceneManager.LoadScene("GameScene");
    }

    public void sparrow2()
    {
        PlayerPrefs.SetInt("ShipType", 2);
        SceneManager.LoadScene("GameScene");
    }
    ```
    
   - PlayerPrefs.GetInt("이름표", 값)   
  해당 이름표의 값을 호출 
  ```
  public class selectedShip : MonoBehaviour
{
    public GameObject ship01;
    public GameObject ship02;

    // Start is called before the first frame update
    void Start()
    {
        //시작하자마자 PlayerPrefs SetInt로 설정한 ShipType을 불러내서, 값이 1이면 1번째 Ship을 보이도록 SetActive를 true로 변경하도록
        if(PlayerPrefs.GetInt("ShipType") == 1)
        {
            ship01.SetActive(true);
        }

        if (PlayerPrefs.GetInt("ShipType") == 2)
        {
            ship02.SetActive(true);
        }
    }
    ```
