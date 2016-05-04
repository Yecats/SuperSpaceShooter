using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

    [Header("General Properties")]
    public int HitPoints = 3;
    public float FireDelay;
    [Range(3,15)]
    public float Speed;


    [Header("Laser Properties")]
    public GameObject LaserPrefab;
    public float LaserDistanceForward;
    public float LaserDistanceRight;
    public Vector3 LaserRotation;

    [Header("Other")]
    public GameManager GameMngr;
    protected bool CanShoot = true;
    protected EnvrionmentManager EnvironmentMngr;


    // Use this for initialization
    void Start()
    {
        EnvironmentMngr = GameObject.FindObjectOfType<EnvrionmentManager>();
    }

    /// <summary>
    /// Creates an instance of the laser game object and disables firing based on the FireDelay
    /// </summary>
    protected void ShootLaser()
    {
        GameObject.Instantiate(LaserPrefab, transform.position + Vector3.forward * LaserDistanceForward + Vector3.right * LaserDistanceRight, Quaternion.Euler(LaserRotation));

        Invoke("EnableShooting", FireDelay);
    }


    /// <summary>
    /// Enables the ability to shoot
    /// </summary>
    protected void EnableShooting()
    {
        CanShoot = true;
    }

    /// <summary>
    /// Applies the damage of the bullet/laser to the health and applies death
    /// </summary>
    /// <param name="amount">Amount of damage to apply</param>
    public virtual void CalculateHit(int amount)
    {
        HitPoints -= amount;
    }
}
