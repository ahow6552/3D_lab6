using UnityEngine;
using UnityEngine.UI;

public class ButtonFunction : MonoBehaviour {
    
    void Start () {
        this.GetComponent<Button>().onClick.AddListener(DoSomething1);
        //如果這支程式碼附在一個有Button component的物件上
        //他會讀取Button，並且在Button上面加一個method
        //在你點擊該該Button的時候執行你設定的method
    }

    public void DoSomething1 () {
         print("this button is on clicked."); 
    }
}

