using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    [SerializeField] private float upForce;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask ground;
    [SerializeField] private float radius;

    private Rigidbody2D characterRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        characterRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, radius, ground);
        
        if (Random.Range(0, 500) < 5)
        {
            if (isGrounded)
            {
                characterRigidbody2D.AddForce(Vector2.up * upForce);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(groundCheck.position, radius);
    }
}
