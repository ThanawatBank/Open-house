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
            Destroy( collision.gameObject);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
