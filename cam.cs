using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  public Transform target;  // Đối tượng mà camera sẽ theo dõi
  public Vector3 offset;    // Khoảng cách giữa camera và đối tượng
  public float smoothSpeed = 0.125f;  // Tốc độ làm mượt camera

  void LateUpdate()
  {
    // Tính toán vị trí mới của camera
    Vector3 desiredPosition = target.position + offset;
    Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

    // Cập nhật vị trí camera
    transform.position = smoothedPosition;

    // Nếu cần, bạn có thể thêm chức năng xoay camera để luôn nhìn vào đối tượng
    transform.LookAt(target);
  }
}
