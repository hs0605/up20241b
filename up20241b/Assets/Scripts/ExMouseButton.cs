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
        textUI.text = "ü�� : " + Hp.ToString();

        if (Input.GetMouseButtonDown(0))  //���콺 �Է��� ������ ��
        {
            Hp -= 10;
            Debug.Log("ü�� : " + Hp);          //ü��Ȯ���� ���� Debug.Log �Լ�
            if (Hp < 1)       //Hp�� 0���Ϸ� ��������
            {
                textUI.text = "ü�� : " + Hp.ToString();
                Destroy(gameObject);           //�� ������Ʈ�� �ı�
            }
        }
    }
}
