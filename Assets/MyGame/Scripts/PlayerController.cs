using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
     Rigidbody2D ridbod;

    [SerializeField]
    GameManager gameman;

    [SerializeField]
    float speed;


    void Start()
    {
        ridbod = GetComponent<Rigidbody2D>();
    }
  

    void FixedUpdate()
    {
        //Rotation durch Horizontale Input Achse
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal")*(speed/4));

        //Richtung durch Vertikale Input Achse
        ridbod.velocity = transform.rotation * new Vector2(0, Input.GetAxis("Vertical")) * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Bei Collision mit Item wird altes Item zerstört und neues gespawnt
        if (collision.CompareTag("Item"))
        {
            gameman.SpawnItem();
            Destroy(collision.gameObject);

        }
    }
}
