using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class Player2Controller : MonoBehaviour
{
    public float speed = 1.0f;

    public Camera cam;
    public Transform target;
    public NavMeshAgent agent;

    public ThirdPersonCharacter character;

    void Start()
    {
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
       // float step = speed * Time.deltaTime; // calculate distance to move
       // transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        agent.SetDestination(target.position);

        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }
    }
}