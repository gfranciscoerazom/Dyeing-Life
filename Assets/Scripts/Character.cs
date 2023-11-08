using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float upForce;
    private Rigidbody2D characterRigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        characterRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            characterRigidbody2D.AddForce(Vector2.up * upForce);
        }
    }
}
