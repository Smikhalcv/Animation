using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlobalEvents : MonoBehaviour
{
    public static UnityEvent OffPause = new UnityEvent();
    public static UnityEvent HitToPlayer = new UnityEvent();
    public static UnityEvent StopAnimation = new UnityEvent();
}
