using UnityEngine;

public class Blast : MonoBehaviour
{
    public float speed = 5;
    void Update()
    {
       transform.Translate(transform.up * speed * Time.deltaTime);
        if (transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
