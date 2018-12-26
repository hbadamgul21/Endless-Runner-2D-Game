using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    public GameObject destroyPlatformPoint;

    // Start is called before the first frame update
    void Start()
    {
        destroyPlatformPoint = GameObject.Find("PlatformDestroyPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < destroyPlatformPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
