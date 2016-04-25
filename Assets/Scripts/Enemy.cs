using UnityEngine;
using System.Collections;

/// <summary>
/// Handles enemy AI specific behaviors such as moving, shooting and taking damage
/// </summary>
public class Enemy : Ship {

	private NavMeshAgent _navMeshAgent;
    private GameObject _player;
    private float _distanceToPlayer = 4f;

	// Use this for initialization
	void Start () {

        //Get references to components
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _player = GameObject.FindObjectOfType<Player>().gameObject;
        GameMngr = GameObject.FindObjectOfType<GameManager>();

        // Set destination for navigation
        _navMeshAgent.SetDestination(_player.transform.position + Vector3.forward * _distanceToPlayer);
        _navMeshAgent.speed = Speed;

        //Start navigating
        _navMeshAgent.Resume();

        GetNextPosition();

    }

    // Update is called once per frame
    void Update () {

        //Continue to update destination based on player position
        transform.rotation = Quaternion.identity;

        if (CanShoot)
        {
            CanShoot = false;

            ShootLaser();
        }
    }

    /// <summary>
    /// Gets the a random position within a set range of the player every half a second
    /// </summary>
    private void GetNextPosition()
    {
        Vector3 destination = _player.transform.position + Vector3.forward * _distanceToPlayer + Random.insideUnitSphere * 1;
        destination.y = transform.position.y;

        _navMeshAgent.SetDestination(destination);

        Invoke("GetNextPosition", .5f);
    }

    public override void CalculateHit(int amount)
    {
        base.CalculateHit(amount);

        if (HitPoints <= 0)
        {
            GameMngr.IncrementScore();
            Destroy(this.gameObject);
        }
    }
}
