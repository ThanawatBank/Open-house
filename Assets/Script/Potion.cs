using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {

            PlayerHP hp = col.gameObject.GetComponent<PlayerHP>();

            hp.increaseHP();

            Destroy(gameObject);

        }
    }
}
