using UnityEngine;

public class ratmove : MonoBehaviour
{
    public float speed = 6f;
    public int points = 100;

    void Update()
    {
        transform.Translate(-transform.right * speed * Time.deltaTime);

        if (transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }
}
