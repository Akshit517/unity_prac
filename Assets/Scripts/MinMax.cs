using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMax {

    public float Min { get; private set; }
    public float Max { get; private set; }

    public MinMax()
    {
        Max = float.MinValue;
        Min = float.MaxValue;
    }

    public void AddValue(float v)
    {
        if (v > Max)
        {
            this.Max = v;
        }
        if (v < Min)
        {
            this.Min = v;
        }
    }
}