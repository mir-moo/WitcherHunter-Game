using UnityEngine;

public class AvoidShieldController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(Constants.Tags.WitcherShieldTag))
        {
            Destroy(collision.gameObject);
        }
    }
}
