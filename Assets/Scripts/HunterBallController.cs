using UnityEngine;

public class HunterBallController : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, _speed 
            * Time.deltaTime);
    }
    public void ChangeDirection()
    {
        _speed = -(_speed);
    }
}
