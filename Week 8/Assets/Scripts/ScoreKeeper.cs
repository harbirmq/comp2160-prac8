using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] float pointsPerPickup;

    private float points;

    static private ScoreKeeper instance;
    static public ScoreKeeper Instance
    {
        get
        {
            return instance;
        }
    }

    public float Points
    {
        get
        {
            return points;
        }
    }

    void Awake()
    {
        instance = this;
    }

    public void IncreaseScore()
    {
        points += pointsPerPickup;
    }
}
