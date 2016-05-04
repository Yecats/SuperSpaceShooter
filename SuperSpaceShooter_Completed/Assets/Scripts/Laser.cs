using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour
{

    public int Damage = 10;
    public bool EnemyWeapon;

    // Update is called once per frame
    void Update()
    {
        if (EnemyWeapon)
        {
            transform.position = Vector3.Lerp(transform.position, transform.position -= Vector3.forward, 5f * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, transform.position += Vector3.forward, 8f * Time.deltaTime);
        }
    }



    public void OnCollisionEnter(Collision collision)
    {
        if (!EnemyWeapon && collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().CalculateHit(Damage);
        }

        else if (EnemyWeapon && collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().CalculateHit(Damage);
        }

        Destroy(this.gameObject);
    }
}
