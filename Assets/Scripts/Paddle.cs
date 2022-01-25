using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;

    public float movementSpeed = 10.0f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void ResetPosition()
    {
        _rigidbody.transform.position = new Vector3(_rigidbody.transform.position.x, 0f, 0f);
        _rigidbody.velocity = Vector2.zero;
    }
}
