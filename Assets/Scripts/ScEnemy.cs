using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScEnemy : MonoBehaviour
{
    [SerializeField] private int mobDamage;
    [SerializeField] private ScHealthController _schealthController;
    [SerializeField] private int mobHealth;
    public GameObject blood;
    public GameObject[] itemDrops;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
        }
        if (collision.CompareTag("bullet"))
        {
            MobGetsDamage();

        }
    }
   void Damage() 
   {
    _schealthController.playerHealth = _schealthController.playerHealth - mobDamage;
    _schealthController.UpdateHealth();
    gameObject.SetActive(false);
   }

   void MobGetsDamage()
   {
    mobHealth = mobHealth - 1;
    
    if (mobHealth <= 0) 
    {
        Instantiate(blood, transform.position, Quaternion.identity);
        ItemDrop();
        ScScore.scoreValue += 1;
        Destroy(this.gameObject);
    }
   }
   private void ItemDrop()
   {
    for (int i = 0; i < itemDrops.Length; i++)
    {
        Instantiate(itemDrops[i], transform.position, Quaternion.identity);
    }
   }
}
