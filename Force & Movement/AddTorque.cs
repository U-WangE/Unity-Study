/*
해당 코드 youtube 출처
https://www.youtube.com/watch?v=h_MA36TGFsc
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorque : MonoBehaviour
{
    Rigidbody rigid;

    private void Start() {

        // GetComponent<T>() : 자신의 T타입 컴포넌트를 가져옴.
        rigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        // AddTorque(Vec) : Vec 방향을 축으로 회전력이 생김
        
        // Vec의 z를 축으로 돈다.
        // rigid.AddTorque(Vector3.back);

        // Vec의 y를 축으로 돈다.
        rigid.AddTorque(Vector3.up);
    }
}