using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otherball : MonoBehaviour
{
    // 오브젝트의 재질 접근은 MeshRenderer를 통해서 한다.

    MeshRenderer mesh;
    Material mat;
   // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }
    
    // OnCollisionEnter : 물리적 충돌이 시작할 때 호출되는 함수
    // Collision : 충돌 정보를 가지고 있는 클래스
    private void OnCollisionEnter(Collision collision) {
        
        // Color : 기본 색상 클래스 (0 ~ 1)
        // Color32 : 255 색상 클래스
        if (collision.gameObject.name == "Myball")
            mat.color = new Color(0, 0, 0);
    }

    // OnCollisionStay : 물리적 충돌이 계속 일어나고 있을 때 호출되는 함수
    private void OnCollisionStay(Collision collision) {
        
    }

    // OnCollisionExit : 물리적 충돌이 끝났을 때 호출되는 함수
    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.name == "Myball")
            mat.color = new Color(1, 1, 1);
    }

}
