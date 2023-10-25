using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimBullet : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject aim;
    [SerializeField] private GameObject firebullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenpoint = Camera.main.WorldToScreenPoint(transform.localPosition);
        float angle = Mathf.Atan2((mousePos.y -  screenpoint.y) ,(mousePos.x - screenpoint.x)) * Mathf.Rad2Deg;
        aim.transform.rotation = Quaternion.Euler( 0,0,angle);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, firebullet.transform.position, aim.transform.rotation);
        }
        
    }
}
