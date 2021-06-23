using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") collision.GetComponent<Player>().LethalHit();
    }
}
