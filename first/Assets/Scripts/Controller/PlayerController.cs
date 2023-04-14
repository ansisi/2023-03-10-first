using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1.0f;             //�̵��ӵ����� ����
    public GameObject PlayerPivot;      //�÷��̾� �Ǻ� ����
    Camera viewCamera;          //ī�޶� ���� ���� �������� ���� ����
    Vector3 velocity;           //�̵����� ���� �� ������
    public ProjectileController projectileController;          //�߻� ��Ʈ�� Ŭ���� ����
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        viewCamera = Camera.main;           //�� ��� ī�޶� �Է�
    }

    // Update is called once per frame
    void Update()
    {
        //����� 2d -> �ΰ��� 3d ��ǥ ��ȯ (���콺�� 3d�� ��� �ִ���
      Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
        //�ٶ� ��ġ�� ����ϱ� ���ؼ� ������Ʈy�� ��ǥ����(�ٴ��� x,z��
        Vector3 targetPosition = new Vector3(mousePos.x, transform.position.y, mousePos.z);   
        //�޾ƿ� �Ǻ��� ���콺�� ���� �Ѵ�
        PlayerPivot.transform.LookAt(targetPosition, Vector3.up);
        //wasd �� ȭ��ǥ �̵� or �����ϴ� �̵��Է� ���� (Horizontal, vertical)
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * moveSpeed;
  
        if(Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();          
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
        // GetComponent -> �ҽ��� �ִ� ���� ������Ʈ���� <>�ȿ� �ִ� ���۳�Ʈ ����
        //������ �� ���� �̵���ġ ���� moveposition �Լ��� ����
    }

}
