using UnityEngine;

public class SeekingShip : MonoBehaviour
{
    private GameObject player;
    public GameObject Explosion;
    public float speed = 2f;
    public float maxDegrees = 10f;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        transform.up = -(player.transform.position - transform.position);
        transform.rotation = Quaternion.Euler(Mathf.Rad2Deg * transform.rotation.x,
                                              Mathf.Rad2Deg * transform.rotation.y,
                                              Mathf.Clamp(Mathf.Rad2Deg * transform.rotation.z, -maxDegrees, maxDegrees));
        transform.Translate(-transform.up * speed * Time.deltaTime);

        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerBlast") || collision.CompareTag("GalagaPlayer"))
        {
            if (collision.CompareTag("PlayerBlast"))
                Destroy(collision.gameObject);
      
            GameObject temp = Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(temp, 1.0f);
            Destroy(gameObject);
        }
    }
}
