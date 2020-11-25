using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

  private NavMeshAgent navMesh;
  public Transform Player;
  public Transform[] randomPoints;

  private float playerDist, randomPointDist;
  public int currentRandomPoint;
  private bool chasing, chaseTime, attacking;
  private float chaseStopwatch, attackingStopwatch;

  public float perceptionDistance = 30, chaseDistance = 20, attackDistance = 1, walkVelocity = 2, chaseVelocity = 6, attackTime = 1.5f, enemyDamage = 50;

  public bool seeingPlayer;

  void Start () {
  currentRandomPoint = Random.Range(0, randomPoints.Length);
  navMesh = this.GetComponent<NavMeshAgent>();
  }

  // Update is called once per frame
  void Update()
  {
    playerDist = Vector3.Distance(Player.transform.position, transform.position);
    randomPointDist = Vector3.Distance(randomPoints[currentRandomPoint].
    transform.position, transform.position);

    RaycastHit hit;

    Vector3 startRay = transform.position;
    Vector3 endRay = Player.transform.position;
    Vector3 direction = endRay - startRay;

    if (Physics.Raycast (transform.position, direction, out hit, 1000) &&
    playerDist < perceptionDistance )
    { if (hit.collider.gameObject.CompareTag("Player"))
      {
        seeingPlayer = true;
      }
      else
      {
        seeingPlayer = false;
      }
    }
    if ( playerDist > perceptionDistance)
    {
      walk();
    }

    if ( playerDist <= perceptionDistance && playerDist > chaseDistance) {
    if (seeingPlayer == true)
      look();
    else
      walk();
    }
    if ( playerDist <= chaseDistance && playerDist > attackDistance) {
      if (seeingPlayer == true) {
        chase();
        chasing = true;
      }else {
        walk();
      }
    }
    if (playerDist <= attackDistance && seeingPlayer == true)
      attack();
    if (randomPointDist <= 8) {
      currentRandomPoint = Random.Range(0, randomPoints.Length);
      walk();
    }
    if (chaseTime == true)
      chaseStopwatch += Time.deltaTime;
    if (chaseStopwatch >= 5 && seeingPlayer == false) {
      chaseTime = false;
      chaseStopwatch = 0;
      chasing = false;
    }
    if (attacking == true)
      attackingStopwatch += Time.deltaTime;
  }

  void walk () {
    if (chasing == false)
    {
      navMesh.acceleration = 1;
      navMesh.speed = walkVelocity;
      navMesh.destination = randomPoints[currentRandomPoint].position;
    }
    else if (chasing == true)
    {
      chaseTime = true;
    }
  }

  void look () {
    navMesh.speed = 0;
    transform.LookAt (Player);
  }

  void chase () {
    navMesh.acceleration = 5;
    navMesh.speed = chaseVelocity;
    navMesh.destination = Player.position;
  }

  void attack () {
    navMesh.acceleration = 0;
    navMesh.speed = 0;
    attacking = true;
  }


}
