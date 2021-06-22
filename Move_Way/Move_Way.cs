/*
해당 코드 youtube 출처
https://www.youtube.com/watch?v=wqRwsW03JR4
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Way : MonoBehaviour
{
    Vector3 target = new Vector3(3, 1.5f, 0);

    private void Update()
    {

        // 1. MoveTowards(현재 위치, 목표 위치, 속도)
        //      -> 등속 이동
        /*
        transform.position = 
            Vector3.MoveTowards(transform.position, target, 0.1f);
        */

        /*------------------------------------------------------------------*/

        // 2. SmoothDamp(현재 위치, 목표 위치, 참조 속도, 속도)
        //      -> 부드러운 감속 이동, 마지막 매개변수에 반비례하여 속도 증가
        /*
        Vector3 velo = Vector3.zero;
        
        // ref : 참조 접근 -> 실시간으로 바뀌는 값 적용 가능
        //          -> 인자 값을 참조로 받는다.
        transform.position = 
            Vector3.SmoothDamp(transform.position,
                                    target, ref velo, 0.5f);
        */

        /*------------------------------------------------------------------*/

        // 3. Lerp : 선형 보간
        //      , SmoothDamp보다 감속 시간이 길다.
        //      -> 마지막 매개변수에 비례하여 속도 증가 (범위 0 ~ 1)
        /*
        transform.position =
            Vector3.Lerp(transform.position,
                                    target, 0.05f);
        */

        /*------------------------------------------------------------------*/

        // 4. Slerp : 구면 선형 보간
        //      , 호를 그리며 이동
        /*
        transform.position = 
            Vector3.Slerp(transform.position,
                                    target, 0.05f);
        */
    }
}