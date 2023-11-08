using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 8f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
    }
}
