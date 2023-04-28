using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rb;   //리지바디 선언
    private Transform player;       //플레이어 위치 가져오기 위해 선언
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  //시작할 때 자기 자신으리 rigibodt를 받아온다
        player = GameObject.FindGameObjectWithTag("Player").transform;  //scene에서 player Tag를 가진 오브젝트를 가져와서 Tranform을 참조
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(rb.position, transform.position)> 5.0f)     //vector.3 distance <==거리를 알려주는 함수
        {
            Vector3 direction = (player.position - transform.position).normalized; ;        //두 벡터를 빼로 nomalized 하면 방향 값을 알려줌
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);       //플레이어를 향해서 성정한 speed속도로 이동
        }    
    }
}
