using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouton : MonoBehaviour
{
    [SerializeField] private GameObject _zoneDanger;
    [SerializeField] private GameObject _parachute;

    private Rigidbody _rbMouton;

    // Start is called before the first frame update
    void Start()
    {
        _rbMouton = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//---------------------------------------------------------------------

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.gameObject.tag);

        if(other.gameObject.tag == _zoneDanger.gameObject.tag) {
            // Debug.Log(other.gameObject.tag);
            _parachute.SetActive(true);
            // _rbMouton.useGravity = false;
            _rbMouton.drag += 1;
        }
    }

//---------------------------------------------------------------------
}
