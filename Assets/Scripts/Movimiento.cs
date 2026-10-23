
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f;

    private Renderer objetoRenderer;

    void Start()
    {
        objetoRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
            objetoRenderer.material.color = Color.green;
        }

      
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            objetoRenderer.material.color = Color.yellow;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            objetoRenderer.material.color = Color.red;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            objetoRenderer.material.color = Color.blue;
        }
    }
}
