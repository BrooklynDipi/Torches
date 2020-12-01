using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject light;

    public int oilPowerUp;
    public int lfPowerUp;

    public Vector3 scaleTransform;
    public Vector3 standardScaleTransform;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ScoreManager.oilTimerStart == false)
        {
            light.transform.localScale = standardScaleTransform;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Oil")
        {
            ScoreManager.oilTimeLeft =+ oilPowerUp;
            ScoreManager.oilTimerStart = true;
            light.transform.localScale = scaleTransform;
        }

        if (col.gameObject.tag == "Lighter Fluid")
        {
            ScoreManager.timeLeft = ScoreManager.timeLeft + lfPowerUp;
        }
    }
}
