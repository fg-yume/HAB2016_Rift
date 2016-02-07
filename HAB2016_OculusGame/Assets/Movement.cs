using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    private float DELAY_TIME = 0.3f;
    private Vector3 bikedir;
    int direction;
    double turnDelay;
    // Use this for initialization

    void Start()
    {
        //transform.rotation = Quaternion.identity;
        gameObject.SetActive(true);
        //bikedir = new Vector3(0, 0, 1);
        direction = 90;
        turnDelay = -1;
    }

    // Update is called once per frame
    void Update()
    {

        turnButton2();
        //transform.Translate(bikedir * moveSpeed * Time.deltaTime);
        transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);

        //transform.position += Vector3.forward * Time.deltaTime;
    }

    void turnButton2()
    {
        turnDelay -= Time.deltaTime;

        if (turnDelay > 0)
        {
            return;
        }

        //Debug.Log("Ready to turn");

        //Quaternion target = Quaternion.identity;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, -90));
            //Debug.Log("rot left");
            turnDelay = DELAY_TIME;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, 90));
            //Debug.Log("rot right");
            turnDelay = DELAY_TIME;
        }

    }

    void turnButton()
    {
        turnDelay -= Time.deltaTime;

        if (turnDelay > 0)
        {
            return;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += 90;
            direction %= 360;
            bikedir = new Vector3((float)Math.Cos(direction * Math.PI / 180), 0, (float)Math.Sin(direction * Math.PI / 180));
            //transform.Rotate(new Vector3(0, 0, 90));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction -= 90;
            direction %= 360;
            bikedir = new Vector3((float)Math.Cos(direction * Math.PI / 180), 0, (float)Math.Sin(direction * Math.PI / 180));
            //transform.Rotate(new Vector3(0, 0, 90));
        }
        turnDelay = DELAY_TIME;
    }
}
