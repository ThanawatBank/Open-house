using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rg2d;
    [SerializeField] private float speedMove;
    [SerializeField] private float defaultSpeed;

    private float Countdowndash = 0f;
    private float cooldown = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        speedMove = 5;
        defaultSpeed = speedMove;
        rg2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Countdowndash += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speedMove = 15;
            Countdowndash = 0f;

        }
        if (Countdowndash > cooldown)
        {
            speedMove = defaultSpeed;
        }

        rg2d.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), (Input.GetAxisRaw("Vertical"))) * speedMove;
        
    }
}
