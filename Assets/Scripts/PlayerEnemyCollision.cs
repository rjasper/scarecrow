using UnityEngine;
using System.Collections;

public class PlayerEnemyCollision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D other = collision.collider;

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Contact");

            // TODO trigger player death
        }
    }

}
