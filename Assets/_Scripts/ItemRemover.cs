using UnityEngine;
using System.Collections;

public class ItemRemover : MonoBehaviour {

    void OnTriggerExit2D(Collider2D coll) {
        Destroy(coll.gameObject);
    }
}
