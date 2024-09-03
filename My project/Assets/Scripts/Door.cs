using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform door;
     public Transform startPoint;
      public Transform endPoint;
     public float speed = 5f;
    
    int direction = 1;

      private void Update()
    {
       Vector2 target = currentMovementTarget();

       door.position = Vector2.Lerp(door.position, target, speed * Time.deltaTime); 

       float distance = (target - (Vector2)door.position).magnitude;

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
        if(door!=null && startPoint!=null && endPoint!=null)
        {
            Gizmos.DrawLine(door.transform.position,startPoint.position);
            Gizmos.DrawLine(door.transform.position,endPoint.position);
        }
    }
    void Start()
    {
        
    }

    

}

