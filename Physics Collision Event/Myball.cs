/*
해당 코드 youtube 출처
https://www.youtube.com/watch?v=salZ7t98xi8
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myball : MonoBehaviour
{
    Rigidbody rigid;

    private void Start() {
        rigid = GetComponent<Rigidbody>();
    }

    // 이동
    private void FixedUpdate() {
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
                                    0,
                                        Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    // 콜라이더가 계속 충돌하고 있을 때 호출
    // Collider : OnTrigger는 Collider가 겹쳤는지를 판단,
    //                          Collider의 정보만 알 수 있다.
    private void OnTriggerStay(Collider other) {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up, ForceMode.Impulse);
    }
}