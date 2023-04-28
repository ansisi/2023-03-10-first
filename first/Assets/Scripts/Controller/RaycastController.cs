using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{

    public GameObject Monster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);      //화면에서의 2차뤈 마우스 좌표를 입력해서 3d카메라에서 ray를 만드는 함수
            RaycastHit hit;

            if(Physics.Raycast(cast, out hit))      //rast가 충돌 감지된 것을 hit로 돌려준다
            {
                if(hit.collider.tag == "Ground")            //Tag가 땅일 때
                {
                    GameObject temp = (GameObject)Instantiate(Monster);         //몬스터 프리팹을 생성하겠다
                    temp.transform.position = hit.point +new Vector3(0.0f, 1.0f, 0.0f);     //RaY충돌위치에
                }
               



                Debug.Log(hit.collider.name);       //오브젝트 이름을 출ㄹ력

                Debug.DrawLine(cast.origin, hit.point,Color.red,2.0f);      //ray가 쏴지는 것을 가시적으로 보여준다.
            }
        }
    }
}
