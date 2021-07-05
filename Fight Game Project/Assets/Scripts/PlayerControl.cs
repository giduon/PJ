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

    // �߷� ũ��
    public float gravity = -10.0f;
    float yVelocity = 0;

    void Start()
    {
        cc = transform.GetComponent<CharacterController>();
    }

    void Update()
    {
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

        // �뽬
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
