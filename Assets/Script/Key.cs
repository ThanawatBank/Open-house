using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField]private GameObject door1;
    // Start is called before the first frame update
    void Start()
    {
        //  door1 = GetComponentInParent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Door door = door1.GetComponent<Door>();
            door.havekey = true;

            Destroy(gameObject);

        }
    }
}
