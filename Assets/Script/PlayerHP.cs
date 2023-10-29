using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    private SpriteRenderer colorChange;

    [SerializeField] private int playerHP = 10;
    [SerializeField] private int maxHP = 10;

    public Vector3 respawnPiont;
    private float countDownColorChange;

    // Start is called before the first frame update
    void Start()
    {
        respawnPiont = Vector3.zero;
        colorChange = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        countDownColorChange += Time.deltaTime;
        
        if (playerHP == 0)
        {
            transform.position = respawnPiont;
            playerHP = maxHP;
        }

        if (countDownColorChange > 1)
        {
            colorChange.color = Color.white;
        }
    }
    
    public void PlayerDecreaseHP()
    {
        //√—∫¥“‡¡®
        playerHP -= 1;
        colorChange.color = Color.red;
        countDownColorChange = 0;
    }

    public void ReSpawmPoint()
    {
        

    }
}
