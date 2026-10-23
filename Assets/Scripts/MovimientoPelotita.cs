using UnityEngine;

public class MovimientoPelotita : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 7f;

    private Rigidbody2D rb;
    private bool enSuelo;

    void Start()
    {
        // Obtenemos el Rigidbody2D de la pelota
        rb = GetComponent<Rigidbody2D>();

        // Posición y rotación inicial
        transform.position = new Vector3(0f, -1f, 0f);
        transform.rotation = Quaternion.identity;
    }

    void Update()
    {
        // Movimiento horizontal (flechas izquierda/derecha o A/D)
        float movimiento = Input.GetAxisRaw("Horizontal");

        // Controlamos la velocidad horizontal
        rb.linearVelocity = new Vector2(
            movimiento * velocidad,
            rb.linearVelocity.y
        );

        // Saltar con la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(
                Vector2.up * fuerzaSalto,
                ForceMode2D.Impulse
            );

            enSuelo = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprobamos si la pelota toca el suelo o una plataforma para poder saltar
        if (collision.gameObject.CompareTag("Suelo") ||
            collision.gameObject.CompareTag("Plataforma"))
        {
            enSuelo = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo") ||
            collision.gameObject.CompareTag("Plataforma"))
        {
            enSuelo = false;
        }
    }
}