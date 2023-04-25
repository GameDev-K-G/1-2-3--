using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerMove : MonoBehaviour
{
    [SerializeField] string triggeringTag;

     private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
           
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)  || Input.GetKey(KeyCode.LeftArrow)  || Input.GetKey(KeyCode.RightArrow))
            {                // Debug.Log("Up or down arrow key was pressed");
        
                // Debug.Log("Up or down arrow key was pressed");
                //  Destroy(hit.collider.gameObject);
                Destroy(other.gameObject);

            
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
