using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUniversal : MonoBehaviour
{
    public LayerMask collisionLayer;
    public float radius = 0.05f;
    public float damage = 2f;
    public bool is_Player, is_Enemy;
    public GameObject hit_FX_prefab;

    // Update is called once per frame
    void Update()
    {
        DetectCollision();
    }
    void DetectCollision()
    {
        Collider[] hit = Physics.OverlapSphere(transform.position, radius, collisionLayer);
        if (hit.Length > 0)
        {
            if (is_Player)
            {
                Vector3 hitFX_pos = hit[0].transform.position;
                hitFX_pos.y += 0.065f;
                if (hit[0].transform.forward.x > 0)
                {
                    hitFX_pos.x += 0.015f;
                }else if (hit[0].transform.forward.x < 0)
                {
                    hitFX_pos.x -= 0.015f;
                }
                Instantiate(hit_FX_prefab, hitFX_pos, Quaternion.identity);
                if(gameObject.CompareTag(Tags.LEFT_ARM_TAG)||
                    gameObject.CompareTag(Tags.LEFT_LEG_TAG))
                {
                    hit[0].GetComponent<HealthScript>().ApplyDamage(damage, true);
                }
                else
                {
                    hit[0].GetComponent<HealthScript>().ApplyDamage(damage, false);
                }
                
            }
            if (is_Enemy)
            {
                hit[0].GetComponent<HealthScript>().ApplyDamage(damage, false);
            }
            gameObject.SetActive(false);
        }
    }
}
