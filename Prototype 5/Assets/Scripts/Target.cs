using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRB;
    private GameManager gameManager;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -2;

    public ParticleSystem explosionParticle;
    public int pointValue;

    // Start is called before the first frame update
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        targetRB.AddForce(RandomForce(), ForceMode.Impulse);
        targetRB.AddTorque(RadmonTorque(), RadmonTorque(), RadmonTorque(), ForceMode.Impulse);

        transform.position = RadmonSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            gameManager.UpdateScore(pointValue);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }        
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RadmonTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RadmonSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), -ySpawnPos);
    }
}
