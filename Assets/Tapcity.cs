using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tapcity : MonoBehaviour
{
    public int money,chinaPoints,polFavors,smMultiplier;
    public SpriteRenderer trump1,trump2, trump3, trump4, trump5, trump6;
    public  Text dollarcount;
    private int rand;   
    private int oldrand;
    void Start ()
    {
        money = 1;
        chinaPoints = 0;
        polFavors = 0;
        smMultiplier = 1;
        rand = 1;
	}

    void OnMouseDown()
    {
        money += 1 * smMultiplier;
        dollarcount.text = "$" + money;
        oldrand = rand;
        while(oldrand == rand)
        {
           rand = Random.Range(1, 7);
        }
        trump1.gameObject.SetActive(false);
        trump2.gameObject.SetActive(false);
        trump3.gameObject.SetActive(false);
        trump4.gameObject.SetActive(false);
        trump5.gameObject.SetActive(false);
        trump6.gameObject.SetActive(false);
        if(rand == 1)
            trump1.gameObject.SetActive(true);
        if (rand == 2)
            trump2.gameObject.SetActive(true);
        if (rand == 3)
            trump3.gameObject.SetActive(true);
        if (rand == 4)
            trump4.gameObject.SetActive(true);
        if (rand == 5)
            trump5.gameObject.SetActive(true);
        if (rand == 6)
            trump6.gameObject.SetActive(true);
    }   
}
