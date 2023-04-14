using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 launchDirection;         //�߻� ���� ���� ����
    public GameObject projectile;           //�߻�ü ������ ����
    // Start is called before the first frame update
   public void FireProjectile()         //�߻� �Լ� ����

    {
        GameObject temp = (GameObject)Instantiate(projectile);      //�߻�ü �������� ������Ű�� TEMP�� �Է�
                                                                    //Instantiate�Լ��� gameobject
        temp.transform.position = this.gameObject.transform.position;
        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;

        Destroy(temp, 10f);     //�߻�ü ���� ���� 10�� �� �������


    }

  
    
}
