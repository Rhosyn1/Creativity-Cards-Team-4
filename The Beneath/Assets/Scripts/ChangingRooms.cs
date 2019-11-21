using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingRooms : MonoBehaviour
{
    //if player touches door then player is transported to next room
    public Collider playerObject;
    public Collider colourCollider;

    public GameObject player;
    private MeshRenderer render;

    public Color myColour = new Color(75f, 28f, 82f, 255f);
    void OnCollisionEnter(Collision other)
    {
        if(render.material.color == myColour)
        {
            player.transform.position = new Vector3(-31.08f,3.151f,-3.63f);
            
        }
    }
}
