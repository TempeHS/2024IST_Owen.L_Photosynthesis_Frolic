using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform TutEnemy;
     public Transform startPoint;
      public Transform endPoint;
      public float speed = 1.5f;
    
    int direction = 1;

       private void Update()
    {
       Vector2 target = currentMovementTarget();

       TutEnemy.position = Vector2.Lerp(TutEnemy.position, target, speed * Time.deltaTime); 

       float distance = (target - (Vector2)TutEnemy.position).magnitude;

       if(distance <= 0.1f)
    {
        direction *= -1;
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
   
    private void OnDrawGizmos()
    {
        if(TutEnemy!=null && startPoint!=null && endPoint!=null)
        {
            Gizmos.DrawLine(TutEnemy.transform.position,startPoint.position);
            Gizmos.DrawLine(TutEnemy.transform.position,endPoint.position);
        }
    }
    void Start()
    {
        
    }

    

}
