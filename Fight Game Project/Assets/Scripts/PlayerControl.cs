using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // WASD�Է��� �޾� �÷��̾ �����̰� �ʹ�.
    // �ʿ� ��� : Ű �Է�, ����, �ӵ� 

    // �̵� �ӵ� ����
    float moveSpeed = 5.0f;


    void Start()
    {
        
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

        // P= P0 * vt
        transform.position += moveSpeed * dir * Time.deltaTime;
    }
}
