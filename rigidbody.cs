using UnityEngine;

public class RigidbodyController : MonoBehaviour
{
  public float moveSpeed = 5f; 
  public float jumpForce = 5f; 
  private Rigidbody rb;

  void Start()
  {
   
    rb = GetComponent<Rigidbody>();
  }

  void Update()
  {
    
    float moveHorizontal = Input.GetAxis("Horizontal"); 
    float moveVertical = Input.GetAxis("Vertical");     
   
    Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical) * moveSpeed;

    
    rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);

  
    if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
    {
      rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
  }


  bool IsGrounded()
  {
    return Physics.Raycast(transform.position, Vector3.down, 1.1f); // Tia raycast kiểm tra mặt đất
  }
}
