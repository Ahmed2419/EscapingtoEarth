using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SlowMotion : MonoBehaviour
{
    // Start is called before the first frame update
    public float slowMotionScale;
    public float ReverseMotionScale;
    private float startTimeScale;
    private float startFixedDeltaTime;
    public Slider TimeSlow;
    [SerializeField]
    private float SlowMotionPower;
    void Start()
    {
        startTimeScale = Time.timeScale;
        startFixedDeltaTime = Time.fixedDeltaTime;
        SlowMotionPower = 0;
    }

    // Update is called once per frame
    void Update()
    { 
      SlowMotionPower += Time.deltaTime;
        
        TimeSlow.value = SlowMotionPower;
        if (SlowMotionPower >= 2)
        {

            if (Input.GetKey(KeyCode.Q))
            {
                StartSlow();
                Debug.Log("Hello");
               
            }

          

        } 
        if (Input.GetKey(KeyCode.E))
            {
                StopSlow();
            }
    }
    void StartSlow()
    {
        
        Time.timeScale = slowMotionScale;
        Time.fixedDeltaTime = startFixedDeltaTime * slowMotionScale;
    }
    void StopSlow()
    {
        Time.timeScale = startTimeScale;
        Time.fixedDeltaTime = startFixedDeltaTime;
    }
}
