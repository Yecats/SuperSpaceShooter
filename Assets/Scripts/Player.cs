using UnityEngine;
using System.Collections;

/// <summary>
/// Handles player specific behaviors such as moving, shooting and taking damage
/// </summary>
public class Player : Ship {


    public float BackgroundMultiplyer = 0.008f;
    public UserInterfaceManager UserInterface;

    // Update is called once per frame
    void Update () {
	
        if (Input.GetAxis("Horizontal") < 0) //Move left
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.left, Speed * Time.deltaTime);
            EnvironmentMngr.SetMovingHorizontalMultiplyer(-BackgroundMultiplyer);
        }
        else if (Input.GetAxis("Horizontal") > 0) //Move Right
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - Vector3.left, Speed * Time.deltaTime);
            EnvironmentMngr.SetMovingHorizontalMultiplyer(BackgroundMultiplyer);
        }

        else
        {
            EnvironmentMngr.SetMovingHorizontalMultiplyer(0);
        }

        if (Input.GetAxis("Vertical") > 0) //Move up
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.forward, Speed * Time.deltaTime);
            EnvironmentMngr.SetMovingVerticallyMultiplyer(BackgroundMultiplyer);

        }
        else if (Input.GetAxis("Vertical") < 0) //Move down
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - Vector3.forward, Speed * Time.deltaTime);
            EnvironmentMngr.SetMovingVerticallyMultiplyer(-BackgroundMultiplyer);
        }

        else
        {
            EnvironmentMngr.SetMovingVerticallyMultiplyer(0);
        }

        if (Input.GetAxis("Shoot") > 0 && CanShoot)
        {
            CanShoot = false;

            ShootLaser();
        }
    }


    public override void CalculateHit(int amount)
    {
        //Remove heart from UI
        UserInterface.DecreasePlayerHealth();
        base.CalculateHit(amount);

        if (HitPoints <= 0)
        {
            GameMngr.EndGame(); 
        }
    }

}
