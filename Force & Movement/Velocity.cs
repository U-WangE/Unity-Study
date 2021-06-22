/*
해당 코드 youtube 출처
https://www.youtube.com/watch?v=h_MA36TGFsc
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    Rigidbody rigid;

    private void Start() {

        // GetComponent<T>() : 자신의 T타입 컴포넌트를 가져옴.
        rigid = GetComponent<Rigidbody>();

        // velocity : 현재 이동 속도

        // Start 내에서는 한 번만 적용

        // 오른쪽으로 이동
        // rigid.velocity = Vector3.right;

        // 왼쪽으로 이동
        // rigid.velocity = Vector3.left;

        // Vector3(2, 4, 3) 방향으로 이동
        // rigid.velocity = new Vector3(2, 4, 3);

    }

    // Unity 에서는 물리 현상에 관한 코드는 FixedUpdate에 작성하는 것을 추천
    private void FixedUpdate() {

        // 계속 힘을 받아 속도를 유지한다.
        // 전방으로 이동
        // rigid.velocity = Vector3.forward;
    }

    private void Update() {

        // Update에 놓게 되면 계속 힘을 받아 속도를 유지한다.
        // Vector3(2, 4, 3) 방향으로 이동
        // rigid.velocity = new Vector3(2, 4, 3);
    }
}