using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExMouseButton : MonoBehaviour
{
    public int Hp = 100;
    public Text textUI;

    // Update is called once per frame
    void Update()
    {
        textUI.text = "체력 : " + Hp.ToString();

        if (Input.GetMouseButtonDown(0))  //마우스 입력이 들어왔을 때
        {
            Hp -= 10;
            Debug.Log("체력 : " + Hp);          //체력확인을 위한 Debug.Log 함수
            if (Hp < 1)       //Hp가 0이하로 내려가면
            {
                textUI.text = "체력 : " + Hp.ToString();
                Destroy(gameObject);           //이 오브젝트를 파괴
            }
        }
    }
}
