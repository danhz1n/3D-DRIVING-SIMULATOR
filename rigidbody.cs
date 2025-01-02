using UnityEngine;

public class RigidbodyController : MonoBehaviour
{
  public float moveSpeed = 5f; // Tốc độ di chuyển
  public float jumpForce = 5f; // Lực nhảy
  private Rigidbody rb;

  void Start()
  {
    // Lấy thành phần Rigidbody của đối tượng
    rb = GetComponent<Rigidbody>();
  }

  void Update()
  {
    // Nhận đầu vào từ bàn phím
    float moveHorizontal = Input.GetAxis("Horizontal"); // Phím A/D hoặc Left/Right
    float moveVertical = Input.GetAxis("Vertical");     // Phím W/S hoặc Up/Down

    // Tạo vector di chuyển
    Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical) * moveSpeed;

    // Áp dụng di chuyển (theo hướng của Rigidbody)
    rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);

    // Nhảy khi nhấn phím Space
    if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
    {
      rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
  }

  // Kiểm tra đối tượng có chạm đất không
  bool IsGrounded()
  {
    return Physics.Raycast(transform.position, Vector3.down, 1.1f); // Tia raycast kiểm tra mặt đất
  }
}
