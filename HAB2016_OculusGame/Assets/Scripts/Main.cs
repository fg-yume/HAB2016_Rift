using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{

    private int TARGET_FRAME_RATE = 90;
    private int m_width = 1000;

    public static bool[,] m_grid;

    void Awake()
    {
        Debug.Log(" hello! ");
        Application.targetFrameRate = TARGET_FRAME_RATE;
    }

    // Use this for initialization
    void Start()
    {
        Debug.Log("test");

        m_grid = new bool[m_width, m_width];
        for (int i = m_width - 1; i >= 0; --i)
        {
            for (int j = m_width - 1; j >= 0; --j)
            {
                m_grid[i, j] = false;
            }
        }
        for (int i = m_width - 1; i >= 0; --i)
        {
            m_grid[i, 0] = true;
            m_grid[0, i] = true;
            m_grid[i, m_width - 1] = true;
            m_grid[m_width - 1, i] = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

