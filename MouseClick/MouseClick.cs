/*
해당 코드 youtube 출처
https://www.youtube.com/watch?v=wqRwsW03JR4
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private void Update()
    {
        // Input : 게임 내 입력을 관리하는 클래스

        /*------------------------------------------------------------------*/

        // Input.anyKeyDown : boolean 값
        // 아무 입력을 최초로 받을 때 호출 됨 (마우스,키보드...)
        // 한 번만 호출 된다.
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        // Input.anyKey : boolean 값
        // 아무 입력을 받으면 호출 됨
        // 계속 누르고 있으면 계속 호출 된다.
        if (Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        /*------------------------------------------------------------------*/

        // GetMouseButton(int button) : boolean 값
        // int button : 0  마우스 왼쪽 버튼
        // int button : 1  마우스 오른쪽 버튼
        // 마우스 입력을 받으면 호출 된다.

        // GetMouseButtonDown(int button) : boolean 값
        // 마우스를 누를 때 호출 된다.
        // 한 번만 호출 된다.
        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");
        
        // GetMouseButton(int button) : boolean 값
        // 마우스 입력을 받으면 호출 된다.
        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");
        
        // GetMouseButtonUp(int button) : boolean 값
        // 마우스를 땔 때 호출 된다.
        // 한 번만 호출 된다.
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");

        /*------------------------------------------------------------------*/


    }

}