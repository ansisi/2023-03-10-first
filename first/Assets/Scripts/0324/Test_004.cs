using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_004 : MonoBehaviour
{
    public int hp = 180;                 //���� herNum ���� �� 1�� �Է�
    public Text textUI;
    public Text hpTextUI;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //���ǹ����� ���콺 �Է� ���� 0�μ��� ���� ���콺
        {
            hp += 10;
        }
        if (Input.GetMouseButtonDown(1))  //���ǹ����� ���콺 �Է� ���� 1�μ��� ������ ���콺
        {
            hp -= 10;
        }


        if (hp<= 50)
        {
              //  Debug.Log("���� !");
            textUI.text = "���� !";
        }
            else if (hp >= 200)
        {
                //Debug.Log("���� !");
            textUI.text = "���� !";
        }
            else
            {

             //   Debug.Log("��� !");
            textUI.text = "��� !";
        }

              hpTextUI.text = "HP :" + hp.ToString();   //ToString w������ ���ڿ��� �ٲ��ִ� �Լ� ("HP  : ����")
    }
    
}
