using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class NPCController : MonoBehaviour
{
    [Header("Movimiento")]
    public float speed = 2f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // El NPC avanza siempre hacia adelante
        Vector3 movement = transform.forward * speed;

        controller.Move(movement * Time.deltaTime);
    }
}