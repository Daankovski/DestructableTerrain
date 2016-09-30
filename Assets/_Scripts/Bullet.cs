using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    [SerializeField]
    private CircleCollider2D blastRadius;

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "ground") {
            coll.gameObject.GetComponent<Ground>().DestroyGround(blastRadius);
            Destroy(gameObject);
        }
    }
}
