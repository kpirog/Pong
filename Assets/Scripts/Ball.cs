using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 200.0f;
    
    private Rigidbody2D _rigidbody;

    private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();

    private void Start()
    {
        AddRandomForce();
    }

    private void AddRandomForce()
    {
        float x = Random.value < 0.5f ? UnityEngine.Random.Range(-1.0f, -0.5f) : UnityEngine.Random.Range(0.5f, 1.0f);
        float y = Random.value < 0.5f ? -1.0f : 1.0f;

        Vector2 forceDirection = new Vector2(x, y);
        _rigidbody.AddForce(forceDirection * _movementSpeed);
    }
}
