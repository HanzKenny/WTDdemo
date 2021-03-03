using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTest : MonoBehaviour
{
    [SerializeField]
    private float m_duration;

    private float m_durationTimer; //You are going to need a float variable to indicate the Timer for something, in this case its the duration.

    private void DoSomething()
    {
        Debug.Log("Am I Suppose to do something");
    }

    //This is just to show how you did it in your code, this actually isnt needed.
    private IEnumerator DoTimerRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(m_duration);
            DoSomething();
        }
    }

    //How to Convert
    private void Start()
    {
        //Initialize the Timer to its coressponding value
        m_durationTimer = m_duration;
    }

    private void Update()
    {
        //There are many ways to code the timers behaviour as it goes down, but this should show you the core principles for how its coded.

        m_durationTimer -= Time.deltaTime; //Decrease Timer value using Time.deltaTime so that if the value is 3 for 3 seconds, it will take 3 seconds for the value to be <= 0. This is also how you make sure that calculations are independent on CPU speed. 
        if(m_duration <= 0) //Not all the time the value will be precisely at 0
        {
            // Here we assume that the amount of time, we want for the duration has passed.
            DoSomething();
            m_durationTimer = m_duration; //This Technically Resets the Timer
        }

        /*To Summarize: you need the following
         * 
         * -Initialize the Timer value
         * -Decrease Timer Value with Time.deltaTime
         * -Check if Timer Value is <= 0, then Do what you want it to do
         * -Reinitialize the Timer Value If wanted
         */
    }
}
