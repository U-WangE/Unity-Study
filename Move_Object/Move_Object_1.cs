/*
해당 코드 youtube 출처
https://www.youtube.com/watch?v=wqRwsW03JR4
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Object_1 : MonoBehaviour
{
    private void Start()
    {

        // 오브젝트 위치 이동
        /*------------------------------------------------------------------*/

        // 스칼라 값 : 순수한 값
        // 벡터 값 : 방향과 그에 대한 크기 값
        // Vector3 : 3차원 벡터 값
        // Vector2 : 2차원 벡터 값
        int number = 4; // 스칼라 값
        Vector3 vec = new Vector3(1, 0, 0); // 벡터 값

        // 오브젝트를 만들면 transform은 기본 컴포넌트다.
        // Transform tr; 과 같이 선언할 필요가 없다.
        // Translate : 벡터 값을 현재 위치에 더해주는 함수
        //      -> 기존 위치에서 얼마 만큼 이동을 하는 지를 나타낸다
        transform.Translate(vec);

        /*------------------------------------------------------------------*/

    }

    private void Update() {

        /*------------------------------------------------------------------*/

        // 오브젝트 이동
        Vector3 vec = new Vector3(0, 0.01f, 0);
        transform.Translate(vec);
        
        /*------------------------------------------------------------------*/
    }
}