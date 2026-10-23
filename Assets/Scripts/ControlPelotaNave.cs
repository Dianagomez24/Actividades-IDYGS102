
using UnityEngine;

public class ControlPelotaNave : MonoBehaviour
{
    public Transform nave;

    private Vector3 distanciaInicial;

    void Start()
    {
        if (nave != null)
        {
            distanciaInicial = transform.position - nave.position;
        }
    }

    void LateUpdate()
    {
        if (nave != null)
        {
            transform.position = nave.position + distanciaInicial;
        }
    }
}
