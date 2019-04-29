using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTile : MonoBehaviour {

    public GameObject player;

	public void Teleport_Player()
    {
        player.transform.position = new Vector3(transform.position.x, 2.6f, transform.position.z);
    }
}
