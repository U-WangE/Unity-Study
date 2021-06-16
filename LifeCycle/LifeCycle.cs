/*
해당 코드 youtube 출처
https://www.youtube.com/watch?v=PyN3JkPTpAI&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=6
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

// 초기화 영역
    private void Awake() {
        // 장면 안에 오브젝트가 최초로 생성 될 때 실행 된다
        // Awake()
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }
 
    // 활성화 영역
    private void OnEnable() {
        // 초기화와 물리영역 사이에 위치
        // 오브젝트를 활성화(켜다)할 때 마다 실행 된다.
        Debug.Log("플레이어가 로그인했습니다.");
    }   

    private void Start() {
        // 업데이트 영역으로 들어가기 전에 최초로 실행되는 함수
        // Start()
        Debug.Log("사냥 장비를 챙겼습니다.");
    }


// 물리 엔진 영역
    private void FixedUpdate() {
        // 유니티 엔진이 물리 연산을 실행하기 전에 작동하는 함수
        // 고정된 주기로 실행된다.
        // CPU 사양과는 상관 없이 고정적으로 사용된다.
        // 1초에 약 50회 실행 됨
        Debug.Log("이동~"); 
    }


// 게임 로직 영역
    private void Update() {
        // 물리 연산에 관련된 로직을 제외한 주기적으로 변하는 로직를 넣을 때 사용
        // 환경에 따라서 실행 주기가 변할 수 있다.
        // 1초에 약 60회 실행 됨 (약 60 frame)
        Debug.Log("몬스터 사냥!");
    }

    private void LateUpdate() {
        // Updata영역의 로직들이 모두 실행 된 후 마지막으로 실행되는 함수
        // 보동 캐릭터를 따라가는 카메라, 로직의 후처리 등을 넣는다. 
        Debug.Log("경험치 획득.");
    }

    // 비 활성화 영역
    private void OnDisable() {
        // 오브젝트가 비 활성화 되거나, 삭제 될때 실행 된다.
        Debug.Log("플레이어가 로그아웃했습니다.");
    }


// 해체 영역
    private void OnDestroy() {
        // 오브젝트가 삭제 되기 직전에 실행한다.
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}