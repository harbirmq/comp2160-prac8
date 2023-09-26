using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private float pointsPerPickup = 10;

    private float playerOnePoints = 0;
    private float playerTwoPoints = 0;

    static private ScoreKeeper instance;
    static public ScoreKeeper Instance
    {
        get
        {
            return instance;
        }
    }

    public float PlayerOnePoints
    {
        get
        {
            return playerOnePoints;
        }
    }

    public float PlayerTwoPoints
    {
        get
        {
            return playerTwoPoints;
        }
    }

    void Awake()
    {
        instance = this;
    }

    public void IncreaseScore1()
    {
        playerOnePoints += pointsPerPickup;
    }

    public void IncreaseScore2()
    {
        playerTwoPoints += pointsPerPickup;
    }
}
