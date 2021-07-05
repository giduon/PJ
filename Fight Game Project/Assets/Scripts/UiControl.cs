using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiControl : MonoBehaviour
{
    // 마우스 위치에 따라 UI의 색상이 바뀌고 
    // 클릭을 하면 공격을 한다

    void Start()
    {
        
    }

    void Update()
    {
        // 마우스 위치 받기
        Vector2 mousePos = Input.mousePosition;
        

        // 마우스 위치가 위쪽일 때
        if (mousePos.x > 0 && mousePos.y >540)
		{
            GameObject.Find("BtnUp").GetComponent<Image>().color = Color.blue;
            
            // 좌클릭을 하면 빨간색으로 바뀐다.
            if(Input.GetMouseButton(0))
			{
                GameObject.Find("BtnUp").GetComponent<Image>().color = Color.red;
            }
        }
        else
            GameObject.Find("BtnUp").GetComponent<Image>().color = Color.white;

        // 마우스 위치 왼쪽아래 일 때
        if (mousePos.x < 960 && mousePos.y < 540)
        {
            GameObject.Find("BtnL").GetComponent<Image>().color = Color.blue;
            // 좌클릭을 하면 빨간색으로 바뀐다.
            if (Input.GetMouseButton(0))
            {
                GameObject.Find("BtnL").GetComponent<Image>().color = Color.red;
            }
        }
        else
            GameObject.Find("BtnL").GetComponent<Image>().color = Color.white;

        // 마우스 위치 오른쪽 아래 일 때 
        if (mousePos.x > 960 && mousePos.y < 540)
        {
            GameObject.Find("BtnR").GetComponent<Image>().color = Color.blue;
            // 좌클릭을 하면 빨간색으로 바뀐다.
            if (Input.GetMouseButton(0))
            {
                GameObject.Find("BtnR").GetComponent<Image>().color = Color.red;
            }
        }
        else
            GameObject.Find("BtnR").GetComponent<Image>().color = Color.white;
    }
}
