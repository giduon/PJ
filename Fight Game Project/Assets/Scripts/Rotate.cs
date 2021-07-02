using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // ��ǥ : ���콺 �巡�׿� ���� ������Ʈ�� ȸ����Ų��
    // �ʿ� ��� : ���콺 �巡�� �Է�, ȸ�� ����, �ӵ� 
    public float rotSpeed = 120.0f;
    float rotX = 0;
    float rotY = 0;

    public bool rotateX = false;
    public bool rotateY = false;


    void Start()
    {

    }

    void Update()
    {
        // 1. ���콺 �Է��� �޴´�
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        // �Է°��� �����Ѵ�. 
        if (rotateX)
        {
            rotX += mx * rotSpeed * Time.deltaTime;
        }

        if (rotateY)
        {
            rotY += my * rotSpeed * Time.deltaTime;
        }

        // rotY�� ���� -60�� ~ 60�� ���̷� �����Ѵ�.
        rotY = Mathf.Clamp(rotY, -60.0f, 60.0f);

        // ȸ�� ����(���Ϸ� ��)�� �����.
        Vector3 dir = new Vector3(-rotY, rotX, 0);

        transform.localEulerAngles = dir;
    }
}
