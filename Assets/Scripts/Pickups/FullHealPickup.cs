using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealPickup : Pickup
{
    public override void DoOnPickup(Collider2D collision)
    {
        Health playerHealth = collision.gameObject.GetComponent<Health>();
        if (collision.tag == "Player" && playerHealth != null)
        {
            if (playerHealth.currentHealth < playerHealth.maximumHealth)
            {
                playerHealth.ReceiveHealing(playerHealth.maximumHealth);
                base.DoOnPickup(collision);
            }
        }
    }
}
