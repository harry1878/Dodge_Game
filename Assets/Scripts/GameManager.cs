using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefab = null;
    public float waitTime = 0f;
    public float createTime = 0.1f;
    public int quantity = 1;

    private void Start()
    {
        waitTime = Time.time + createTime;
    }

    private void Update()
    {
        if(Time.time >= waitTime)
        {
            CreateMeteor();
            waitTime = Time.time + createTime;
        }
    }

    public void CreateMeteor()
    {
        for(int i = 1; i < quantity; ++i)
        {
            var meteor = Instantiate(prefab, transform).GetComponent<MeteorModule>();
            meteor.transform.position = new Vector3(
                Random.Range(1.7f, -1.7f), 2, 0);
        }
    }
}
