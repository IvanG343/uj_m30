using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private ParticleSystem diePS;
    private Renderer playerRend;
    private PlayerMovement playerMovement;
    private Rigidbody playerRB;

    private void Start()
    {
        diePS = GetComponentInChildren<ParticleSystem>();
        playerRend = GetComponent<Renderer>();
        playerMovement = GetComponent<PlayerMovement>();
        playerRB = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 20)
        {
            diePS.Play();
            Die();
        }
    }

    private void Die()
    {
        playerRend.enabled = false;
        playerMovement.enabled = false;
        playerRB.isKinematic = true;
        GameManager.instance.Loose();
    }
}
