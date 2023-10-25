using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster01 : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float distance = 5f;
    [SerializeField] private float speedmonster = 3f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < distance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speedmonster * Time.deltaTime);
        }
        
    }
}
