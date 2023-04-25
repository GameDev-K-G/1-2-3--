using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyEnemy : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    public GameManagerScript gameManager;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(this.gameObject);  
            Destroy(other.gameObject);      
            gameManager.gameOver();  
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
