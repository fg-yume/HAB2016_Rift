using UnityEngine;
using System.Collections.Generic;

public class FieldMap : MonoBehaviour {
    [SerializeField]
    private TrailTile tile;

    [SerializeField]
    private int m_mapRows;

    [SerializeField]
    private int m_mapColumns;

    [SerializeField]
    private int m_tileWidth;

    [SerializeField]
    private int m_tileLength;

    private TrailTile[,] map;

	// Use this for initialization
	void Start () {
        map = new TrailTile[m_mapRows, m_mapColumns];

        // pop map
        for( int i=m_mapColumns-1; i >= 0; --i )
        {
            for( int j=m_mapRows-1; j >= 0; --j )
            {
                map[i, j] = (TrailTile)Instantiate(tile, new Vector3(i * m_tileLength, 0, j * m_tileWidth), Quaternion.identity);
                map[i,j].InitType(0);

                map[i, j].transform.position = new Vector3(i * m_tileLength, 0, j * m_tileWidth);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
