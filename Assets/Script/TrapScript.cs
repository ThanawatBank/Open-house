using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    public float timeTrapActivate = 2f;
    public float countdown = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countdown += Time.deltaTime;
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            countdown = 0;
        }
    }



    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.tag == "Player" && countdown >= timeTrapActivate)
        {
            PlayerHP playerHP = other.gameObject.GetComponent<PlayerHP>();
            playerHP.PlayerDecreaseHP();
            countdown = 0;
        }

    }
}
