using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    private float DELAY_TIME = 0.3f;
    private Vector3 bikedir;

    private int[] m_lastPos;
    int direction;
    double turnDelay;
    private Vector3 moveDirection = Vector3.zero;
    // Use this for initialization

    void Start()
    {
        //transform.rotation = Quaternion.identity;
        gameObject.SetActive(true);
        //bikedir = new Vector3(0, 0, 1);
        direction = 90;
        turnDelay = -1;

        m_lastPos = new int[] { -1, -1 };
    }

    // Update is called once per frame
    void Update()
    {

        CharacterController controller = GetComponent<CharacterController>();
        turnButton2();
        //transform.Translate(bikedir * moveSpeed * Time.deltaTime);
        transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);

        //transform.position += Vector3.forward * Time.deltaTime;

        collisionCheck();
    }

    private void die()
    {
        Debug.Log("You died! :]");
    }

    public void collisionCheck()
    {
        // check if current square is taken
        int[] currPos = getRelativeMapLocation();

        // compare curr position vs last position
        if (m_lastPos[0] == -1)
        {

            m_lastPos[0] = currPos[0];
            m_lastPos[1] = currPos[1];

            return;
        }

        // check for collision here!
        if ( Main.m_grid[ currPos[0], currPos[1] ] == true )
        {
            // we done goofed
            die();
        }

        if ( m_lastPos[0] == currPos[0] &&
            m_lastPos[1] == currPos[1] )
        {
            // Don't update things, we haven't moved out of previous position yet
            return;
        }

        //Debug.Log("New position: [" + currPos[0] + "," + currPos[1] + "]");

        // update last position
        Main.m_grid[m_lastPos[0], m_lastPos[1]] = true; // ;-;

        m_lastPos[0] = currPos[0];
        m_lastPos[1] = currPos[1];

        //Debug.Log("test on Main: [" + m_last)
    }
    
    private int[] getRelativeMapLocation()
    {
        // 1000x1000 top-left: -200, 200, bottom-right: 200, -200
        // units of .2
        //int mapLocation[2];

        int gridPosZ = (int) (transform.position.z / .2);
        int gridPosX = (int)(transform.position.x / .2);

        //Debug.Log(gridPosX + "," + gridPosZ);

        return new int []{ gridPosX, gridPosZ };
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
        /*
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
        }*/
        float z = Input.GetAxisRaw("Horizontal");
        float x = Input.GetAxisRaw("Vertical");
        if (z > .2)
        {
            direction += 90;
            direction %= 360;

            bikedir = new Vector3((float)Math.Cos(direction * Math.PI / 180), 0, (float)Math.Sin(direction * Math.PI / 180));
            transform.Rotate(new Vector3(0, 0, 90));
        }
        if (z < -.2)
        {
            direction -= 90;
            direction %= 360;

            bikedir = new Vector3((float)Math.Cos(direction * Math.PI / 180), 0, (float)Math.Sin(direction * Math.PI / 180));
            transform.Rotate(new Vector3(0, 0, -90));
        }
        moveDirection = new Vector3(0, 0, z);
        Debug.Log("a x: " + x + " z: " + z);
        turnDelay = DELAY_TIME;

    }

    void turnButton()
    {
        turnDelay -= Time.deltaTime;
        if (turnDelay > 0)

        {
            return;
        }
       
        turnDelay = DELAY_TIME;
    }
}
