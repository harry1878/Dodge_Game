using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorModule : MonoBehaviour
{
    public static MeteorModule Get { get; set; } = null;

    public Rigidbody2D MeteorRigid = null;

    private void Awake()
       => Get = this;

    private void Update()
    {
        if(transform.position.y == 0.26f)
        {
            Destroy(gameObject, 0.5f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject, 0.5f);
    }
}
