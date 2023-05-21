using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;
    private SpriteRenderer sprite;
    private Animator anim;

    private float dirx = 0f;
    // [SerializeField] enable toggle by Unity UI
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 10f;

    private enum MoveState {idle, running, jumping, falling}

    [SerializeField] private AudioSource jumpSoundEffect;

    // Start is called before the first frame update
    private void Start()
    {
        // Edit>>Preference>>external tool>>check the first two boxed of VS
        // and then regenerate project to enable auto complete
        Debug.Log("Hello, world!");
        player = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Raw: only -1, 1:: No Raw : floating num
        dirx = Input.GetAxisRaw("Horizontal");
        player.velocity = new Vector2(dirx * moveSpeed, player.velocity.y);

        // Edit>>project setting>> input manager
        if (Input.GetButtonDown("Jump")) // Jump
        {
            player.velocity = new Vector2(player.velocity.x, jumpForce);
            jumpSoundEffect.Play();
        }

        UpdateAnimation();
    }

    // ctrl+R ctrl+R to change function name all at once
    private void UpdateAnimation()
    {
        MoveState state;
        if(dirx > 0f)
        {
            sprite.flipX = false;
            state = MoveState.running;
        }
        else if(dirx < 0f)
        {
            sprite.flipX = true;
            state = MoveState.running;
        }
        else
        {
            state = MoveState.idle;
        }

        if (player.velocity.y > .1f)
        {
            state = MoveState.jumping;
        }
        else if (player.velocity.y < -.1f)
        {
            state = MoveState.falling;
        }

        anim.SetInteger("state", (int)state);
    }
}
