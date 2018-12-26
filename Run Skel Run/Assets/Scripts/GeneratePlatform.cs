using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
    public GameObject platform, backGround, topPlank;
    public Transform genPoint;
    public float distanceBetween;

    private float platformWidth;

    // Start is called before the first frame update
    void Start()
    {
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.x < genPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
            Vector3 pos = new Vector3(transform.position.x + platformWidth, 0.6108786f, 0.03320313f);
            Vector3 position = new Vector3(Random.Range(-9.0f, 5.0f) + transform.position.x + platformWidth + distanceBetween, Random.Range(0, 2) == 0 ? -0.4f : 0.78f, -1.5f);

            Instantiate(platform, transform.position, transform.rotation);
            Instantiate(topPlank, position, Quaternion.Euler(0, 0, Random.Range(0, 2) == 0 ? 0 : 180));
            Instantiate(backGround, pos, transform.rotation);

        }


    }
}
