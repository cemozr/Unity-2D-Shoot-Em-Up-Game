using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScMagic : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject Player1;
    public GameObject Magic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.RotateAround(Player1.transform.position, new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime * 100); 
       transform.RotateAround(Magic.transform.position, new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime * 100); 
    }
}
