using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHP : MonoBehaviour
{
    private SpriteRenderer colorChange;
    private float countDowncolorChange;
    [SerializeField] private int hp =  3;
   // [SerializeField] private int maxhp = 3;
    // Start is called before the first frame update
    void Start()
    {
        colorChange = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        countDowncolorChange += Time.deltaTime;
        if (countDowncolorChange > 1)
        {
            colorChange.color = Color.white;
        }

        if (hp == 0)
        {
            Destroy(gameObject);
        }
    }

    public void DecreaseHP()
    {
        hp -= 1;

        colorChange.color = Color.red;
        countDowncolorChange = 0;
    }
}
