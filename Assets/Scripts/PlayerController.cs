using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 10;
    public Text ScoreText;

    private int score;

    public SimpleInput fixedJoystick;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        score = 0;
    }

    private void FixedUpdate()
    {
                movementX = SimpleInput.GetAxis( "Horizontal" );
        movementY = SimpleInput.GetAxis( "Vertical" );

        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement  * speed);



    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp")) 
        {
            other.gameObject.SetActive(false);
            score = score + 1;

            Debug.Log("Score: " + score);

        // Show UI 
        ScoreText.text = "Score: " + score.ToString();
		if (score >= 10) 
		{
            SceneManager.LoadScene(2);
		}
        }
    }

}
