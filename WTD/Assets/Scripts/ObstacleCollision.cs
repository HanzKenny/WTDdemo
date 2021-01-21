using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    

   void OnCollisionEnter2D(Collision2D coll) {
         if (coll.gameObject.tag == "Obstacle")
         {
             Destroy(coll.gameObject);
         }
     }


}
