using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public float speed = 10f;
    public float distance = 50f; // La distance que l'ennemi parcourra avant de faire demi-tour

    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Faites osciller l'ennemi entre la position de départ et la distance spécifiée
        transform.position = startPos + new Vector3(Mathf.PingPong(Time.time * 10, distance), 0, 5);
    }
}
