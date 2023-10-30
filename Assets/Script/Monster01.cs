using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster01 : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rg2d;
    [SerializeField] private GameObject player;
    [SerializeField] private float distance = 5f;
    [SerializeField] private float speedmonster = 3f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rg2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < distance)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, (player.transform.position - transform.position).normalized, distance);
            if (hit.collider != null && hit.collider.CompareTag("Wall"))
            {
                // ถ้ามีการชนกับ Wall, หยุดการเคลื่อนที่
                rg2d.velocity = Vector3.zero;
            }
            else
            {
                // ไม่มีการชนกับ Wall, เคลื่อนที่ไปหา Player
                transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speedmonster * Time.deltaTime);
            }
        }
 

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            PlayerHP playerHP = collision.gameObject.GetComponent<PlayerHP>();
            playerHP.PlayerDecreaseHP();

        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            // ถ้า CodeMonster ชนกับ Wall, หยุดเคลื่อนที่
            rg2d.velocity = Vector2.zero;
        }

    }
}
