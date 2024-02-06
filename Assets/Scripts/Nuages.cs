using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuages : MonoBehaviour
{
    private float _positionX;
    private float _positionY;
    private float _positionZ;

    // Start is called before the first frame update
    void Start()
    {
        _positionX = transform.position.x;
        _positionY = transform.position.y;
        _positionZ = transform.position.z;

        BougeNuage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BougeNuage(){
        transform.position = new Vector3(50, 50, 100);
    }
}
