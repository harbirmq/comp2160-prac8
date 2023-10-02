using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        ScoreKeeper.Instance.IncreaseScore();
        Destroy(gameObject);
    //     if(collider.gameObject.CompareTag("Player"))
    //     {
    //         ScoreKeeper.Instance.IncreaseScore();
    //         Destroy(gameObject);
    //     }

    //     if(collider.gameObject.CompareTag("Player2"))
    //     {
    //         ScoreKeeper.Instance.IncreaseScore();
    //         Destroy(gameObject);
    //     }
    }
}
