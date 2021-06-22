/*
해당 코드 youtube 출처
https://www.youtube.com/watch?v=wqRwsW03JR4
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Object_2 : MonoBehaviour
{
    private void Start()
    {

    }

    private void Update() {

        // 오브젝트 횡, 종 이동
        /*------------------------------------------------------------------*/

        // 부드럽게 이동
        /*
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0);
        */
        // 중간 값 없이 1, 0, -1
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0);

        transform.Translate(vec);

        /*------------------------------------------------------------------*/
    }
}