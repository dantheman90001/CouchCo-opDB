using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject HUD;

    private void OnTriggerEnter(Collider collidedObject)
    {
        if (collidedObject.tag == "Player")
        {
            HUD.GetComponent<HealthController>().ReduceLifeByTag(this.tag);
        }
    }
}
