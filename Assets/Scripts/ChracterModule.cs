using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChracterModule : MonoBehaviour
{
    public Animator animator = null;
    public Rigidbody2D rigid = null;
    public Image hpBar = null;
    public float speed = 50f;
    public float maxHp = 8;

    private float currentHp;

    public int Hit { get; set; } = 0;

    private void Start()
    {
        currentHp = maxHp;
        hpBar.fillAmount =  1f;
    }

    private void Update()
    {
        if(Hit == 1) 
        if (transform.position.x < -1.75f)
        {
            transform.position = new Vector3(1.75f, 0.46f, 0);
        }
        else if(transform.position.x > 1.75f)
        {
            transform.position = new Vector3(-1.75f, 0.46f, 0);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("isMove", true);
            transform.Translate(speed * Time.fixedDeltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("isMove", true);
            transform.Translate(speed * Time.fixedDeltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else animator.SetBool("isMove", false);
    }


    private const float Damage = 2.5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Hit == 1) return;
        if(collision.CompareTag("Meteor"))
        {
            Hit = 1;
            animator.Play("Hit");

            StartCoroutine(UpdateRecoverTime());

            Vector3 dir = (transform.position - collision.transform.position).normalized;
            rigid.AddForce(dir * 2.5f, ForceMode2D.Impulse);
        }
    }

    private const float RecoverTime = 2f;

    private const float UpdateHpTime = .33f;
    private IEnumerator UpdateCurrentHp(float damage)
    {
        float preveCurrentHp = currentHp;
        float prevPer = currentHp / maxHp;
        float per = (currentHp - damage) / maxHp;

        float fixedTime = Time.time;
        while(Time.time <= fixedTime + UpdateHpTime)
        {
            currentHp = Mathf.Lerp(
                prevPer,
                per,
                Time.time - fixedTime / UpdateHpTime);

            hpBar.fillAmount = currentHp;
            hpBar.color = new Color(hpBar.color.r, currentHp, hpBar.color.b);

            yield return null;
        }

        currentHp = preveCurrentHp = damage;
        yield break;
    }
    private IEnumerator UpdateRecoverTime()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        Color color = GetComponent<SpriteRenderer>().color;
        color.a = 1f;

        bool isReverse = false;
        float fixedTime = Time.time;
        while(Time.time <= fixedTime + RecoverTime)
        {
            renderer.color =
                new Color(color.r, color.g, color.b, isReverse ? 0.8f : 0.2f);

            isReverse = !isReverse;
            yield return null;
        }
        renderer.color = color;
        Hit = 0;
        yield break;
    }
}

