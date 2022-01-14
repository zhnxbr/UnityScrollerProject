using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4f;
    private GameObject player;
    private Vector3 playerPos;
    Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;


        transform.LookAt(playerPos);
        Vector3 pos = Vector3.MoveTowards(transform.position, playerPos, speed * Time.fixedDeltaTime);
        rig.MovePosition(pos);
    }

    public void Defeat()
    {
        Destroy(gameObject);
    }
}
