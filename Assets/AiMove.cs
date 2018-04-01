using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AiMove : MonoBehaviour {

	private NavMeshAgent theAgent;
	public Transform target;
	public Transform spwan;
	public int curMovePoints;
	private Vector3 playerGroundPosition;
	private int playerDistance;
	private GameController gc;
	private int moveCost;
	public int MaxPoints;
	public bool startMove;
	private bool stopMove;
	public bool move;
	public int shotDistance;
	public float shotRate;
	public float nextFire; 
	public float hp;


	// Use this for initialization
	void Start () {
		
		hp = 100;
		move = true;
		shotDistance = 12;
	}
	
	// Update is called once per frame
	void Update ()
	{
		theAgent = GetComponent<NavMeshAgent>();
		gc = GetComponent<GameController> ();
		if (gc.enemyt == true) {
			
			playerGroundPosition = new Vector3 (transform.position.x, transform.position.y - (theAgent.height * 2 / 3), transform.position.z);
			int moveCost = (int)(Vector3.Distance (target.position, playerGroundPosition));
			int playerDistance = (int)(Vector3.Distance (target.position, playerGroundPosition));

			if (curMovePoints > moveCost && moveCost > 1) {
				if (move) { 
					
					curMovePoints = MaxPoints - moveCost + shotDistance;
					theAgent.destination = target.position;
					theAgent.Resume ();
					move = false;
			
				}
			}

		

			if (playerDistance <= shotDistance) {
				theAgent.Stop ();
				if (Time.time > nextFire) {
					nextFire = Time.time + shotRate;

				}
			}
		}
			if (gc.enemyt == false) {
				curMovePoints = MaxPoints;
				move = true;
			}
		
	}
	private void shot ()
	{
	}
}
