using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public GameObject particleObject;
    private float origYScale;
    public float minYScale = 0.5f;
    private float origX;
    private float origY;

    Vector3 startPoint;
    Vector3 endPoint;

    public TrajectoryLine tl;
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        origYScale = transform.localScale.y;
        origX = transform.position.x;
        origY = transform.position.y;
        tl = GetComponent<TrajectoryLine>();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0, -(transform.localScale.y - origYScale) / 5f, 0);
        if (Input.GetMouseButtonDown(0))
		{
            startPoint = transform.position;
            startPoint.z = 15;
		}
        if (Input.GetMouseButton(0))
		{
            faceMouse();
            if (transform.localScale.y > 1f)
                transform.localScale += new Vector3(0, -(transform.localScale.y - 1f) / 5f, 0);

            Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPoint.z = 15;
            tl.RenderLine(startPoint, currentPoint);
            //Debug.Log("pressed");
		}
        if (Input.GetMouseButtonUp(0))
		{
            transform.localScale = new Vector3(transform.localScale.x, origYScale*2, transform.localScale.z);
            //Debug.Log("not pressed");
            for (int i = 0; i < 10; i++)
            {
                Instantiate(particleObject, transform.position, transform.rotation * Quaternion.Euler(0, 0, -90f));
            }
            tl.EndLine();
        }


    }

    void faceMouse()
	{
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = direction;
	}
}
