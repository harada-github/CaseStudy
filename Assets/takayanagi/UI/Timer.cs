using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text text;

    float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;

        text.text = time.ToString("f2");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        text.text = time.ToString("f2");
    }
}
