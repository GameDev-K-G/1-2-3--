using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    public GameManagerScript gameManager;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
           
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("arrow key was pressed");
                Destroy(this.gameObject);    
                gameManager.gameOver();        
            }
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
