using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneDeath : MonoBehaviour
{
    public DeathManager targetScript;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        targetScript.ShowDeathScreen();
    }
}
