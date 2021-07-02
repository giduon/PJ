using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // 목표 : 마우스 드래그에 맞춰 오브젝트를 회전시킨다
    // 필요 요소 : 마우스 드래그 입력, 회전 방향, 속도 
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
        // 1. 마우스 입력을 받는다
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        // 입력값을 누적한다. 
        if (rotateX)
        {
            rotX += mx * rotSpeed * Time.deltaTime;
        }

        if (rotateY)
        {
            rotY += my * rotSpeed * Time.deltaTime;
        }

        // rotY의 값을 -60도 ~ 60도 사이로 제한한다.
        rotY = Mathf.Clamp(rotY, -60.0f, 60.0f);

        // 회전 벡터(오일러 각)를 만든다.
        Vector3 dir = new Vector3(-rotY, rotX, 0);

        transform.localEulerAngles = dir;
    }
}
