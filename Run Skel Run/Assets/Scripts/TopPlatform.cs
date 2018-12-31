using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.rotation.eulerAngles.z == 180)
        {
            gameObject.GetComponent<CircleCollider2D>().offset = new Vector2(-0.5f, -0.13f);
        }
    }
}
