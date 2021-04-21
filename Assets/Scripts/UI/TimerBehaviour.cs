using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBehaviour : MonoBehaviour
{
    [SerializeField]
    Text _displayTimer;

    // Start is called before the first frame update
    void Start()
    {
        _displayTimer.text = "" + 0;
    }

    // Update is called once per frame
    void Update()
    {
        _displayTimer.text = "" + Mathf.Round(Time.time);
    }
}
