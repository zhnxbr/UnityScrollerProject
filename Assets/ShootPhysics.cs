using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    public float spd = 10f;
    public Rigidbody rb;
    void Start()
    {
        rb.velocity = transform.right * spd;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        Enemy enemy = collider.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.Defeat();
        }
        Destroy(gameObject);

        
    }
}
