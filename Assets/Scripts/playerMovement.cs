using UnityEngine;

public class playerMovement : MonoBehaviour {


    //This is a reference to the Rigidbody component in the Player GameObject
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

	// Use this for initialization
	// Update is called once per frame
	void FixedUpdate () {                           //fixed update likes for physics unity

        //add a forward force 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   //evens out different framerates

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
