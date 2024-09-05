using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
      public float speed;
      public GameObject pointA;
      public GameObject pointB;
      private Rigidbody2D rb;
      private Transform currentPoint;
    
    int direction = 1;

       private void Update()
    {

   Vector2 point = currentPoint.position - transform.position;
   if(currentPoint == pointB.transform)
   {
    rb.velocity = new Vector2(speed, 0);
   }
   else 
   {
    rb.velocity = new Vector2(-speed, 0);
   }
    if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
    {
        flip();
        currentPoint = pointA.transform;
    }
    
    if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
    {
        flip();
        currentPoint = pointB.transform;
    }
    }
Vector2 currentMovementTarget()
{
    if (direction == 1)
    {
return startPoint.position;
    }
    else
    {
        return endPoint.position;
    }
}
   
private void flip()
{
    Vector3 localScale = transform.localScale;
    localScale.x *= -1;
    transform.localScale = localScale;
}

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }
    void Start()
    {
        
    }

    

}
