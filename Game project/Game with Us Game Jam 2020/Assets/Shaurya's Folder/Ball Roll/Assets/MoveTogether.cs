using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTogether : MonoBehaviour
{
    public GameObject OtherObject;
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OtherObject.transform.position = transform.TransformPoint(pos);
    }
}
