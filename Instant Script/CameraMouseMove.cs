using UnityEngine;

public class CameraMouseMove : MonoBehaviour
{
    public Transform player;
    float turnSpeed;
    float xRotate;
    float yRotate;

    void Start()
    {
        turnSpeed = 1.7f;
        xRotate = 0.0f;
        yRotate = 0.0f;
    }

    void Update()
    {
        MoveWithPlayer();
        MouseRotation();
    }

    void MoveWithPlayer()
    {
        this.transform.position = player.position;
    }

    void MouseRotation()
    {
        if (Input.GetMouseButton(0))
        {
            // x축 회전
            float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
            // 회전 값 범위 제한
            xRotate = Mathf.Clamp(xRotate + xRotateSize, -35, 40);

            // y축 회전
            float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
            // 회전 값
            yRotate = transform.eulerAngles.y + yRotateSize;

            transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
        }
    }

}
