using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
  
    public float rotateSpeed;

    private void FixedUpdate() {

        transform.Rotate(new Vector3(0, 0, rotateSpeed));
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if(collision.gameObject.name == "Player") {
            Destroy(collision.gameObject);
            GameManager.instance.endGame();

        }else if(collision.gameObject.tag == "Ground") {

            GameManager.instance.incrementScore();
            gameObject.SetActive(false);
            Destroy(gameObject, 3f);
        }
    }
}
