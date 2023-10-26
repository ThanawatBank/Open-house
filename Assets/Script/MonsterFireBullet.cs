using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFireBullet : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float distance = 7f;
    [SerializeField] private float speedmonster = 1f;
    [SerializeField] private float fireDistance ;


    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject aim;
    [SerializeField] private GameObject firebullet;

    [SerializeField] private float fireRate = 1;
    [SerializeField] private float countDown = 0;
    // Start is called before the first frame update
    void Start()
    {
        fireRate = 1;
        countDown = 0;
        fireDistance = 10;
       
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < distance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speedmonster * Time.deltaTime);
        }


        float angle = Mathf.Atan2((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg;
        aim.transform.rotation = Quaternion.Euler(0, 0, angle);


        countDown += Time.deltaTime;

        if (countDown >= fireRate  && Vector3.Distance(player.transform.position, transform.position) < fireDistance)
        {
            Instantiate(bullet, firebullet.transform.position, aim.transform.rotation);
            countDown = 0;
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            PlayerHP playerHP = collision.gameObject.GetComponent<PlayerHP>();
            playerHP.PlayerDecreaseHP();
        }
    }
}
