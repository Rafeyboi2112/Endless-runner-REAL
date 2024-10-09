using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public float fallThreshold = -10f;
    private DeathManager deathManager;
    void Start()
    {
        deathManager = FindObjectOfType<DeathManager>();
    }

    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            deathManager.ShowDeathScreen();
        }
    }
}
