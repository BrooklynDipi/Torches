using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static float timeLeft;
    public static float oilTimeLeft;
    public Text timerText, oilTimer;

    public static bool oilTimerStart;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 90;
        oilTimeLeft = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time Remaining: " + ScoreManager.timeLeft.ToString();
        }

        if (oilTimerStart)
        {
            oilTimeLeft -= Time.deltaTime;
            oilTimer.text = "Oil Burn Remaining: " + ScoreManager.oilTimeLeft.ToString();
        }

        if (oilTimeLeft <= 0)
        {
            oilTimeLeft = 0;
            oilTimerStart = false;
        }

    }
}
