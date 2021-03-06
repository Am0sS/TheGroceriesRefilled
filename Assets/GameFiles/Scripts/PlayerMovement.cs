using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // VARIABLES

    [Header("Basic Player Settings")]
    [Tooltip("Base value is 12")]   public float speed = 12f;
    [Tooltip("Base value is -20")]  public float gravity = -20f;
    [Tooltip("Base value is 0.4")]  public float groundCheckDistance = 0.4f;
    Vector3 velocity;
    bool isGrounded;

    [Header("Do Not Change")]
    public CharacterController controller;
    public Transform groundCheck;
    public LayerMask groundMask;
    public GameObject RefillUI;



    void Update()
    {

        // Grounded Check
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckDistance, groundMask);
        if (isGrounded == true && velocity.y < 0)
            velocity.y = -2f;

        // Axis
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        // Character Move
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        // Gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        // Running
        if (Input.GetKey(KeyCode.LeftShift))
            speed = 15f;
        else
            speed = 12f;
    }

        // Trash
        private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Trash"))
        {
        RefillUI.GetComponent<GrabBoxes>().hasBox = false;
        Destroy(GameObject.FindGameObjectWithTag("dairyBox"));
        Destroy(GameObject.FindGameObjectWithTag("houseHoldBox"));
        Destroy(GameObject.FindGameObjectWithTag("vegAndFruitBox"));
        Destroy(GameObject.FindGameObjectWithTag("petFoodBox"));
        Destroy(GameObject.FindGameObjectWithTag("drinkBox"));
        Destroy(GameObject.FindGameObjectWithTag("paperBox"));
        Destroy(GameObject.FindGameObjectWithTag("meatBox"));
        }


        if (other.gameObject.CompareTag("Door"))
        {
            Application.Quit();
        }
    }
}
