using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSetting : MonoBehaviour
{
    // ���� ���۵Ǹ� ���콺 Ŀ���� ȭ�� ���ʿ��� ����� ���ϰ� �ϰ� �ʹ�. 

    public CursorLockMode myLockMode = CursorLockMode.None;

    void Start()
    {

         Cursor.lockState = myLockMode;
        Cursor.visible = false;

    }

    void Update()
    {

    }
}
