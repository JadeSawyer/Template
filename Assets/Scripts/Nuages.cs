using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuages : MonoBehaviour
{
    private float _positionX;
    private float _positionY;
    private float _positionZ;

    [SerializeField] private float _vitesse = 4;

    // Start is called before the first frame update
    void Start()
    {
        _positionX = transform.position.x;
        _positionY = transform.position.y;
        _positionZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        BougeNuage();
    }

    void BougeNuage(){
    // float _nouvellePositionX = _nouvellePositionX + 1;

    //------------------------------------------------------- Ça sert à...

    // _positionX = _positionX + (_vitesse * Time.deltaTime);

    // transform.position = new Vector3(_positionX, _positionY, _positionZ);

    //------------------------------------------------------- Ça sert à...

    transform.Translate(Vector3.right * _vitesse * Time.deltaTime); // Vector3(1, 0, 0);
    transform.Translate(Vector3.up * _vitesse * Time.deltaTime); // Vector3(1, 0, 0);
    }
}
