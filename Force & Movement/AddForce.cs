/*
해당 코드 youtube 출처
https://www.youtube.com/watch?v=h_MA36TGFsc
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    Rigidbody rigid;

    private void Start() {

        // GetComponent<T>() : 자신의 T타입 컴포넌트를 가져옴.
        rigid = GetComponent<Rigidbody>();

        /*
        AddForce(Vec) : Vec의 방향과 크기로 힘을 준다.
        ForceMode : 힘을 주는 방식 (가속, 무게 반영)
              -> Acceleration, Force, Impulse, VerocityChange가 있다.
                    Mass : 무게 값이 클수록 움직이는데 많은 힘이 필요하다.
        */

            
        // 점프 시에 가장 많이 쓰는 형식
        // rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    private void FixedUpdate() {
        // space bar 클릭시 점프
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        // 키보드 방향키 입력
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
                                    0,
                                        Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
    }
}