using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class targetCollider : DefaultTrackableEventHandler
{
    public static targetCollider instance;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        moveTarget();
    }
    public void moveTarget()
    {
        Vector3 temp;
        temp.x = Random.Range(-48f,48f);
        temp.y = Random.Range(10f,50f);
        temp.z = Random.Range(-48f,48f);
        transform.position = new Vector3(temp.x, temp.y, temp.z);
        if (DefaultTrackableEventHandler.trueFalse == true)
        {
            RaycastController.instance.playSound(0);
        }
    }
}
