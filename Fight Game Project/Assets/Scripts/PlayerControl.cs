using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // WASD입력을 받아 플레이어를 움직이고 싶다.
    // 필요 요소 : 키 입력, 방향, 속도 

    // 이동 속도 설정
    float moveSpeed = 5.0f;
    CharacterController cc;

    // 중력 크기
    public float gravity = -10.0f;
    float yVelocity = 0;

    void Start()
    {
        cc = transform.GetComponent<CharacterController>();
    }

    void Update()
    {
        // 1. 키 입력을 받는다
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 2. 입력 받은 방향으로 이동한다.
        // 벡터 설정, 속도 
        Vector3 dir = new Vector3(h, 0, v);

        // 정규화
        dir.Normalize();

        // 방향 벡터를 카메라의 방향을 기준으로 재설정한다.
        dir = Camera.main.transform.TransformDirection(dir);

        // 중력 값을 적용한다.
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        // P= P0 * vt
        // transform.position += moveSpeed * dir * Time.deltaTime;
        cc.Move(dir * moveSpeed * Time.deltaTime);

        // 대쉬
        if (Input.GetButtonDown("Fire3"))
        {
            moveSpeed = 30.0f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = 5.0f;
        }
    }
}
