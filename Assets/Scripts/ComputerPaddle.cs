using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    
    private void FixedUpdate()
    {
        if(ball.velocity.x > 0f) //pilka leci w prawo
        {
            if(transform.position.y < ball.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * movementSpeed);
            }
            else if(transform.position.y > ball.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * movementSpeed);
            }
        }
        else if(ball.velocity.x < 0f)// pilka leci w lewo
        {
            if (transform.position.y < 0)
                _rigidbody.AddForce(Vector2.up * movementSpeed);
            else if (transform.position.y > 0)
                _rigidbody.AddForce(Vector2.down * movementSpeed);
        }
    }
}
