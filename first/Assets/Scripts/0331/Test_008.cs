using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player
{
    private int hp = 100;                   //���� Hp�� Private �ϰ� ���� 100 �Է�   
    private int Power = 50;                     //���� Power �� Private �ϰ� ���� 50�Է�

    public void Attack()                //�޼ҵ� Attack ����
    {
        Debug.Log(this.Power + "�������� ������");
    }

    public void Damage(int damage)                   //�޼ҵ� Damage ����
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� �Ծ���. ");
    }

    public int GetHp()
    {
        return hp;
    }

}
public class Test_008 : MonoBehaviour
{

    public Text playerHp;               //player hp�� �����ִ� ui
    public Text player2Hp;                      //player2 hp�� �����ִ� ui


    Player mPlayer = new Player();              //PlayerŬ���� ����\<==
    Player mPlayer2 = new Player();              //Player2Ŭ���� ����\<==

    // Start is called before the first frame update
    void Start()
    {

        //mPlayer.Attack();                               //Player �޼ҵ� Attack ȣ��
        //mPlayer.Damage(30);                     //Player �޼ҵ� Damage ȣ��
       // Debug.Log(mPlayer.GetHp());                 //player ��hp �� �����ش�



    }

    // Update is called once per frame
    void Update()
    {
        playerHp.text = mPlayer.GetHp().ToString();             //player �� Hp�� UI�� ǥ��
        player2Hp.text = mPlayer2.GetHp().ToString();             //player2 �� Hp�� UI�� ǥ��



        if (Input.GetMouseButtonDown(0))                    //���� ���콺
        {
            mPlayer.Damage(1);              //player �޼ҵ� damage ȣ��
        }
        

        if (Input.GetMouseButtonDown(1))                    //������ ���콺
        {
            mPlayer2.Damage(1);              //player �޼ҵ� damage ȣ��
        }


    }
}

