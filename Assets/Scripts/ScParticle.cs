using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScParticle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 2f);
    }
}
