using UnityEngine;
using System.Collections;
 using System.Threading.Tasks;

 public class Rotator : MonoBehaviour
  {
     
    bool rotate;
     void Start () {
        transform.Rotate (new Vector3 (0, 0, 180));

     }
     void Update () {
     
         if(!rotate)
         {
             this.StartCoroutine(RotateObject());
         }
     }
     IEnumerator RotateObject()
     {
        rotate=true;
        yield return new WaitForSeconds(4.5f);
        transform.Rotate (new Vector3 (0, 0, 180));

        rotate = false;
     }
    

     
 }
 