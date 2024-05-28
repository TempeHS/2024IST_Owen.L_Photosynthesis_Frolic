using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform TutEnemy;
     public Transform startPoint;
      public Transform endPoint;
    
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

    
    void Update()
    {
        
    }
}
