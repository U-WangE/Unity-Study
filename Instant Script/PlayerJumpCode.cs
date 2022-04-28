using UnityEngine;
using System;

public class PlayerJumpCode : MonoBehaviour {
    
    Rigidbody rigid;
    private bool IsFloating;
    private float jumpPower = 4.5f;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        IsFloating = false;
    }

    void Update()
    {
        Jump();
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(!IsFloating)
            {
                IsFloating = true;
                rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            }
        }
    }
    

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Block"))  // 바닥 Block과 충돌 시 Jump
        {
            // point.y가 같은 경우 바닥면 충돌로 인식 (collider 자체의 x,y,z축 고정임으로 사용 가능한 방법)
            var firstContact = other.contacts[0].point.y;

            foreach(var contact in other.contacts)
            {
                if(Math.Round(contact.point.y, 1) != Math.Round(firstContact, 1))
                {
                    IsFloating = true;
                    return;
                }
            }

            IsFloating = false;
        }
    }
}