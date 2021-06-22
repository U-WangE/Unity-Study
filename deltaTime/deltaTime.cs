/*
해당 코드 youtube 출처
https://www.youtube.com/watch?v=QGFaA3WYAwk
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deltaTime : MonoBehaviour
{
    // DeltaTime

    /*
    Time.deltaTime 사용 방법
    
    Translate : 벡터에 곱하기
        -> transform.Translate(Vec * Time.deltaTime);

    Vectro 함수 : 시간 매개변수에 곱하기
        -> Vectro3.Lerp(Vec1, Vec2, T * Time.deltaTime);
    */

    private void Start() {
        
    }

    private void Update() {
        // Time.deltaTime : 이전 프레임의 완료까지 걸린 시간
        //                              = 1 frame에 사용된 시간
        // deltaTime 값은 프레임이 적으면 크고, 프레임이 많으면 작음
        // : 컴퓨터의 사양에 상관 없이 나오는 값을 동일하게 만들어 준다.
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);
        transform.Translate(vec);
    }
}