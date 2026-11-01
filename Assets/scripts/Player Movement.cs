using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4.5f;
    public TextMeshProUGUI scorebox;
    private int scoreval = 0;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4f, 3.4f), transform.position.z);

    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            if (collision.gameObject.GetComponent<ratmove>() != null)
            {
                scoreval += collision.GetComponent<ratmove>().points;
                scorebox.text = $"Score: {scoreval}";
            }
            Destroy(collision.gameObject);
        }
    }
}
