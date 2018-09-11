using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public playerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
