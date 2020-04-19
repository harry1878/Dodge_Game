using UnityEngine;

public class Meteor : MonoBehaviour
{
    public GameObject particle = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Tile")||
            collision.CompareTag("Player"))
        {
            var p = Instantiate(particle, transform.position, Quaternion.identity, null);
            Destroy(p, 2f);
            Destroy(gameObject);
        }
    }

}
