using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public float speed = 4;
    public GameObject Blast;
    public GameObject Explosion;

    public float blasttimer = 0, blastwait = 3;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);

        blasttimer += Time.deltaTime;
        if (blasttimer >= blastwait)
        {
            Instantiate(Blast, transform.position - new Vector3(0, 0.5f, 0), Quaternion.identity);
            blasttimer = 0;
        }

        if (transform.position.y < -6)
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
