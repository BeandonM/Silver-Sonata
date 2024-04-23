using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerManager))]
[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour, IMove
{
    [SerializeField] private PlayerManager playerManager;
    private EntityData playerData;
    [SerializeField] private PlayerInput input;
    [SerializeField] private Rigidbody2D rb;
    private void Awake()
    {
        playerManager = GetComponent<PlayerManager>();
        input = GetComponent<PlayerInput>();
        playerData = playerManager.getData();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        move();
    }
    public void move()
    {
        Vector2 moveforce = input.getMove() * playerData.getMovespeed();
        rb.velocity = moveforce;
        /*
        Vector2 moveForce = playerInput * moveSpeed;
        moveForce += forceToApply;
        forceToApply /= forceDamping;
        if (Mathf.Abs(forceToApply.x) <= 0.01f && Mathf.Abs(forceToApply.y) <= 0.01f)
        {
            forceToApply = Vector2.zero;
        }
        rb.velocity = moveForce;
        */
    }
    /*
        // Start is called before the first frame update
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private Rigidbody2D rb;
        private Vector2 forceToApply;
        [SerializeField] private float forceDamping = 1.2f;
        private Vector2 playerInput;
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            playerInput = Vector2.zero;
        }

        // Update is called once per frame
        private void Update()
        {
            grabInputs();
            Move();
        }

        private void grabInputs()
        {
            playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        }

        private void Move()
        {
            Vector2 moveForce = playerInput * moveSpeed;
            moveForce += forceToApply;
            forceToApply /= forceDamping;
            if(Mathf.Abs(forceToApply.x) <= 0.01f && Mathf.Abs(forceToApply.y) <= 0.01f)
            {
                forceToApply = Vector2.zero;
            }
            rb.velocity = moveForce;
        }
    */
}
