using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkAndDestroy : MonoBehaviour
{

    private float timer = 0.0f;
    private float force;
    private float angle;
    public float angleStart = 0f;
    public float angleRange = 0f;
    public float forceStart = 1f;
    public float forceRange = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
        if (forceRange == 0)
            force = Random.Range(0.1f, 1.0f);
        else force = Random.Range(forceStart, forceStart + forceRange);
        angle = Random.Range(angleStart - angleRange, angleStart + angleRange);
    }

    Vector2 VectorFromAngle(float theta)
    {
        return new Vector2(Mathf.Cos(theta), Mathf.Sin(theta)); // Trig is fun
    }

    // Update is called once per frame
    void Update()
    {
        force /= 1.25f;
        transform.Translate(VectorFromAngle(angle)*force);
        timer++;
        if (timer > 10.0f)
        {
            transform.Rotate(0, 0, (timer - 10) / 2f);
            transform.localScale = (transform.localScale + new Vector3(-0.01f * ((timer - 10) / 4f), -0.01f * ((timer - 10) / 4f), -0.01f * ((timer - 10) / 4f)));
            if (transform.localScale.z < 0) Destroy(gameObject);
        }
    }
}
