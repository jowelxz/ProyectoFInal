using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;

    private Rigidbody2D rb;
    private float movimientoX;
    private bool enSuelo;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movimientoX = 0f;

        if (Input.GetKey(KeyCode.A))
            movimientoX = -1f;

        if (Input.GetKey(KeyCode.D))
            movimientoX = 1f;

        if (Input.GetKeyDown(KeyCode.W) && enSuelo)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                fuerzaSalto
            );

            enSuelo = false;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(
            movimientoX * velocidad,
            rb.linearVelocity.y
        );
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
            enSuelo = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
            enSuelo = false;
    }
}
