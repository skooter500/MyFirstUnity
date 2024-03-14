using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject brickPrefab;

    public int width = 10;
    public int height = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int col = 0 ; col < width ; col ++)
        {
            GameObject brick = Instantiate<GameObject>(brickPrefab);

            Vector3 pos = new Vector3(col, 0, 0);
            brick.transform.position = pos;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
