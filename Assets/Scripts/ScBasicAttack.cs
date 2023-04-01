using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScBasicAttack : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force;
    public float lifetime = 2f;
    // Start is called before the first frame update
    void Start()
    {
      
      mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
      rb = GetComponent<Rigidbody2D>();
      mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
      Vector3 direction =  mousePos - transform.position;
      Vector3 rotation = transform.position - mousePos;
      rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
      float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
      transform.rotation = Quaternion.Euler(0, 0, rot + 90);
      Destroy(this.gameObject,lifetime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }
}
