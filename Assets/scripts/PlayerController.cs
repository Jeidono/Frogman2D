using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private float direction = 0f;
    public float jumpSpeed =8f;
    private Rigidbody2D player;
    
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");

        if(direction > 0f) {
            player.linearVelocity = new Vector2(direction * speed, player.linearVelocity.y);
        }
        else if (direction < 0f) {
            player.linearVelocity = new Vector2(direction * speed, player.linearVelocity.y);
        }
        else {
             player.linearVelocity = new Vector2(0, player.linearVelocity.y);
        }

        if(Input.GetKeyDown("space")){
            player.linearVelocity = new Vector2(player.linearVelocity.x, jumpSpeed);
        }
    }
}
