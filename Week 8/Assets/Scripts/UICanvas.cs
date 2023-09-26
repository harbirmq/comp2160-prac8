using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UICanvas : MonoBehaviour
{
    private TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        score = transform.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = string.Format("Score: {0}", ScoreKeeper.Instance.Points);
    }
}
