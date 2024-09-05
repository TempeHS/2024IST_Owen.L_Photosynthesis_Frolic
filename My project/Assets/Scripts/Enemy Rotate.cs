using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour
{

    float InputHorizontal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         if (InputHorizontal > 0)
    {
        gameObject.transform.localScale =new Vector3(1, 1, 1);
    }

    if (InputHorizontal < 0)
    {
        gameObject.transform.localScale =new Vector3(-1, 1, 1);
    }

    }
}
