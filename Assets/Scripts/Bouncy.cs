using UnityEngine;

public class Bouncy : MonoBehaviour
{
    [SerializeField] private float _bounceSpeed = 10.0f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        
        if (ball != null)
        {
            Vector2 forceDirection = -collision.contacts[0].normal;
            ball.AddForce(forceDirection * _bounceSpeed);
        }
    }
}
