/*
해당 코드 youtube 출처
https://www.youtube.com/watch?v=wqRwsW03JR4
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyborad : MonoBehaviour
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

        // KeyCode.Return : 키보드의 Enter 키와 같다
        // KeyCode.Escape : 키보드의 ESC 키와 같다

        // GetKeyDown : boolean 값
        // 키를 누를 때 호출 된다.
        // 한 번만 호출 된다.
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        // GetKey : boolean 값
        // 키보드 입력을 받으면 호출 된다.
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");

        // GetKeyUp : boolean 값
        // 키를 땔 때 호출 된다.
        // 한 번만 호출 된다.
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            Debug.Log("왼쪽 이동을 멈추었습니다.");

        /*------------------------------------------------------------------*/

        // Unity 지원 버튼 사용
        // Edit -> Project Setting -> Input Manager
        
        // Unity 지원 버튼 custom 시
        // ../ -> Axes -> Size
        // Size를 변경하면 추가로 생성되거나 삭제 된다.

        // ../ -> Axes -> Jump -> Name

        // 기를 모으거나 하는 동작에는 보통 Down키를 사용하지 않음
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");
        
        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");

        /*------------------------------------------------------------------*/

        // 횡이동, 종이동
        if (Input.GetButton("Horizontal")) {
            Debug.Log("횡 이동 중..."
            // Input.GetAxis : float 값
            // 부드러운 이동이 필요한 경우 사용
            // 수평, 수직 버튼 입력을 받을 때 반환
                + Input.GetAxis("Horizontal"));
        }

       if (Input.GetButton("Vertical")) {
            Debug.Log("종 이동 중..."
            // Input.GetAxisRaw : -1, 0, 1 값
            // 키값에 즉시 반응이 필요할 때 사용
                + Input.GetAxisRaw("Vertical"));
        }

        /*------------------------------------------------------------------*/


    }

}