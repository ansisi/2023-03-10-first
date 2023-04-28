using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rb;   //�����ٵ� ����
    private Transform player;       //�÷��̾� ��ġ �������� ���� ����
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  //������ �� �ڱ� �ڽ����� rigibodt�� �޾ƿ´�
        player = GameObject.FindGameObjectWithTag("Player").transform;  //scene���� player Tag�� ���� ������Ʈ�� �����ͼ� Tranform�� ����
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(rb.position, transform.position)> 5.0f)     //vector.3 distance <==�Ÿ��� �˷��ִ� �Լ�
        {
            Vector3 direction = (player.position - transform.position).normalized; ;        //�� ���͸� ���� nomalized �ϸ� ���� ���� �˷���
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);       //�÷��̾ ���ؼ� ������ speed�ӵ��� �̵�
        }    
    }
}
