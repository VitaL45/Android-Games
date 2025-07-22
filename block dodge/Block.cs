using UnityEngine;

public class Block : MonoBehaviour
{
    void Update() {
        if (transform.position.y < -6f) {
            Destroy(gameObject);
        }
    }
}
