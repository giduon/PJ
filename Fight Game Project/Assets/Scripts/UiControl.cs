using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiControl : MonoBehaviour
{
    // ���콺 ��ġ�� ���� UI�� ������ �ٲ�� 
    // Ŭ���� �ϸ� ������ �Ѵ�

    void Start()
    {
        
    }

    void Update()
    {
        // ���콺 ��ġ �ޱ�
        Vector2 mousePos = Input.mousePosition;
        

        // ���콺 ��ġ�� ������ ��
        if (mousePos.x > 0 && mousePos.y >540)
		{
            GameObject.Find("BtnUp").GetComponent<Image>().color = Color.blue;
            
            // ��Ŭ���� �ϸ� ���������� �ٲ��.
            if(Input.GetMouseButton(0))
			{
                GameObject.Find("BtnUp").GetComponent<Image>().color = Color.red;
            }
        }
        else
            GameObject.Find("BtnUp").GetComponent<Image>().color = Color.white;

        // ���콺 ��ġ ���ʾƷ� �� ��
        if (mousePos.x < 960 && mousePos.y < 540)
        {
            GameObject.Find("BtnL").GetComponent<Image>().color = Color.blue;
            // ��Ŭ���� �ϸ� ���������� �ٲ��.
            if (Input.GetMouseButton(0))
            {
                GameObject.Find("BtnL").GetComponent<Image>().color = Color.red;
            }
        }
        else
            GameObject.Find("BtnL").GetComponent<Image>().color = Color.white;

        // ���콺 ��ġ ������ �Ʒ� �� �� 
        if (mousePos.x > 960 && mousePos.y < 540)
        {
            GameObject.Find("BtnR").GetComponent<Image>().color = Color.blue;
            // ��Ŭ���� �ϸ� ���������� �ٲ��.
            if (Input.GetMouseButton(0))
            {
                GameObject.Find("BtnR").GetComponent<Image>().color = Color.red;
            }
        }
        else
            GameObject.Find("BtnR").GetComponent<Image>().color = Color.white;
    }
}
