using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class ZombieScript : MonoBehaviour
{
    private NavMeshAgent Mob;
    public GameObject Player;
    public float MobDistanceRun = 4.0f;

    //speed variables
    public float timeRemaining = 300;
    public bool timerIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        Mob = GetComponent<NavMeshAgent>();

        //timer starts
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        //run toward player
        float speed = 2f;

        if (distance < MobDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position - dirToPlayer;

            Mob.SetDestination(newPos);

        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                Mob.speed = speed+3;
                Debug.Log("Speeed Update");
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }


    }
     private void OnTriggerEnter(Collider other)
    {

    if (other.gameObject.name == "Player")
        {
            {
                ScoringSystem.theScore = 0;
                SceneManager.LoadScene("GameOverMenu");
                
            }
        }
    }
}
