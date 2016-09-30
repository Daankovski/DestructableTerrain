using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour {

    [SerializeField]
    private GameObject ObjectToSpawn;
		
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 1f;
            Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(ObjectToSpawn, objectPos, Quaternion.identity);
        }
	}
}
