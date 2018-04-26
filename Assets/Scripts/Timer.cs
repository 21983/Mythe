using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public bool IsDone { get; private set; }
    public bool Running { get; set; }
    public bool Repeat { get; private set; }

    private float baseTime;
    [SerializeField]
    private float time;
    private Action callback;

    public static Timer StartNew(GameObject g, float t, Action callback = null)
    {
        var timer = g.AddComponent<Timer>();
        timer.SetTime(t);
        timer.SetCallback(callback);
        timer.Running = true;
        return timer;
    }

    public static Timer StartNewRepeat(GameObject g, float t, Action callback = null)
    {
        var timer = StartNew(g, t, callback);
        timer.Repeat = true;
        return timer;
    }

    protected void SetTime(float t)
    {
        baseTime = t;
        time = t;
    }

    protected void SetCallback(Action callback)
    {
        this.callback = callback;
    }
    public void Toggle()
    {
        Running = !Running;
    }
    public void Resume()
    {
        Debug.Log("resumed");
        Running = true;
    }


    void Update()
    {
        if (Running && time > 0)
        {
            time -= Time.deltaTime;
            Debug.Log(time);
            if (time < 0)
            {
                
                if (!Repeat) Running = false;
                IsDone = true;
                time = baseTime;
                if (callback != null)
                    callback.Invoke();
            }
        }
    }
}


