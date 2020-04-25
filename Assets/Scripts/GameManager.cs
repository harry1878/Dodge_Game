using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [NonSerialized] public bool isGameOver = false;
    public Text timerText;
    public Text levelText;

    public GameObject prefab = null;

    public float waitTime = 0f;
    public float createTime = 0.1f;
    private float range;
    public int quantity = 1;

    private void Start()
    {
        range = Camera.main.aspect;
        waitTime = Time.time + createTime;
    }

    private void Update()
    {
        if (Time.time >= waitTime)
        {
            CreateMeteor();
            waitTime = Time.time + createTime;
        }
    }

    public static void AddMeteor()
    {

    }

    public void CreateMeteor()
    {
        for(int i = 1; i < quantity; ++i)
        {
            var meteor = Instantiate(prefab, transform).GetComponent<MeteorModule>();
            meteor.transform.position = new Vector3(
                UnityEngine.Random.Range(-range, range), 2, 0);
        }
    }
}
