using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    [SerializeField] private float speedBullet = 15f;
    [SerializeField] private Rigidbody2D rg2d;
    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rg2d.velocity =  transform.right * speedBullet;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            MonsterHP hp = collision.gameObject.GetComponent<MonsterHP>();
            hp.DecreaseHP();
            Destroy(gameObject);
        }
        if (collision.collider.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (collision.collider.tag == "BulletMonster")
        {
            Destroy(gameObject);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
