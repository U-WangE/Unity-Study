using UnityEngine;

public class PlayerForwardMove : MonoBehaviour
{
    public Transform mainCamera;

    float moveSpeed;
    
    void Start()
    {
        moveSpeed = 1.6f;
    }

    void Update()
    {
        ForwardMove();
    }

    // 시점 전방으로 이동
    void ForwardMove()
    {
        if(!IsDeath)
        {
            Vector3 moveDirection = new Vector3(
                Mathf.Sin(mainCamera.transform.eulerAngles.y * Mathf.Deg2Rad),
                    0,
                        Mathf.Round(Mathf.Cos(mainCamera.transform.eulerAngles.y * Mathf.Deg2Rad) * 100) / 100  // Use Round -> Deg2Rad의 Cos(90) 오류 수정용
            );

            transform.position += Input.GetAxis("Vertical") * moveDirection * moveSpeed * Time.deltaTime;
        }
    }
}