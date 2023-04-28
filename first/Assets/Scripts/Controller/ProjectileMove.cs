using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 launchDirection;

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;   //�߻�ü �̵� �ӵ�
       transform.Translate(launchDirection * moveAmount);//�ش� �������� �̵�
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);           //�浹���Ͼ� ���� �̸��� �����´�,

        if (collision.gameObject.name == "Wall")
        {
            GameObject temp = this.gameObject;          //�� �ڽ��� �����ͼ� temp�� �Է��Ѵ�
            Destroy(temp);                  //��ٷ� �ı��Ѵ�.
        } 
        
        if (collision.gameObject.tag == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;          //�� �ڽ��� �����ͼ� temp�� �Է��Ѵ�
            Destroy(temp);                  //��ٷ� �ı��Ѵ�.
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Wall")
        {
            GameObject temp = this.gameObject;          //�� �ڽ��� �����ͼ� temp�� �Է��Ѵ�
            Destroy(temp);                  //��ٷ� �ı��Ѵ�.
        }

        if (other.gameObject.tag == "Monster")
        {
            other.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;          //�� �ڽ��� �����ͼ� temp�� �Է��Ѵ�
            Destroy(temp);                  //��ٷ� �ı��Ѵ�.
        }
    }
}
