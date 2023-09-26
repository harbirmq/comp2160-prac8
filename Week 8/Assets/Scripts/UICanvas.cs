using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UICanvas : MonoBehaviour
{
    private TextMeshProUGUI p1Score;
    private TextMeshProUGUI p2Score;

    // Start is called before the first frame update
    void Start()
    {
        p1Score = transform.Find("Canvas/PlayerOneScore").GetComponent<TextMeshProUGUI>();
        p2Score = transform.Find("Canvas/PlayerTwoScore").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        p1Score.text = string.Format("P1 Score: {0}", ScoreKeeper.Instance.PlayerOnePoints);
        p2Score.text = string.Format("P2 Score: {0}", ScoreKeeper.Instance.PlayerTwoPoints);
    }
}
