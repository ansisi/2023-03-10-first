using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//if ���
public class Test_003 : MonoBehaviour
{
    public int herNum = 1;                 //���� herNum ���� �� 1�� �Է�
    // Start is called before the first frame update
    void Start()
    {
       

        if (herNum == 1)                    //���ǽ� herNum �� 1 �� ��� �ȿ� ������ �����Ѵ�.

        {
            Debug.Log ("ü���� 50 ȸ��");         //Console.Logâ�� â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�.

        }
        else
           {
            Debug.Log ("ü�� -50 ");         //Console.Logâ�� â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�.

        }


    }


























    // Update is called once per frame
    void Update()
    {
        
    }
}
