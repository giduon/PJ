using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // WASD�Է��� �޾� �÷��̾ �����̰� �ʹ�.
    // �ʿ� ��� : Ű �Է�, ����, �ӵ� 

    // �̵� �ӵ� ����
    float moveSpeed = 5.0f;
    CharacterController cc;

    bool isDash = false;
   

    // �߷� ũ��
    public float gravity = -10.0f;
    float yVelocity = 0;

    void Start()
    {
        cc = transform.GetComponent<CharacterController>();
    }

    void Update()
    {
        //�뽬
        dash();


        // 1. Ű �Է��� �޴´�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 2. �Է� ���� �������� �̵��Ѵ�.
        // ���� ����, �ӵ� 
        Vector3 dir = new Vector3(h, 0, v);

        // ����ȭ
        dir.Normalize();

        // ���� ���͸� ī�޶��� ������ �������� �缳���Ѵ�.
        dir = Camera.main.transform.TransformDirection(dir);

        // �߷� ���� �����Ѵ�.
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        // P= P0 * vt
        // transform.position += moveSpeed * dir * Time.deltaTime;
        cc.Move(dir * moveSpeed * Time.deltaTime);

        // �뽬�� �����ϰ� �ʹ�.
        // leftshift�� ������ �� �����̰� �ִ� �������� ���� �� ������ �̵��� �� �� �ӵ��� ���ƿ��� �ʹ�. 

        void dash()
		{
            if (Input.GetButtonDown("Fire3") && isDash == false)
            {
                moveSpeed = 20.0f;
                print("a");
                isDash = true;
            }
            
            
		}
      
    }
}
