using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
     public bool havekey = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (havekey == true && col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}