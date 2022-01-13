using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    [Header("Settings:")]
    private float mMovementSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        var horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontal, 0, 1) * (mMovementSpeed * Time.deltaTime));
    }
}
