using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private void FixedUpdate()
    {
        transform.Translate(_moveSpeed * Time.deltaTime, 0, 0);
    }
}
