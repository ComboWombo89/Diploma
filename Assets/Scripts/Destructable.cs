using UnityEngine;

public class Destructable : MonoBehaviour
{
    public GameObject expolosion;
    private bool canBeDestroyed = false;
    public int scoreValue = 100;
    // Start is called before the first frame update
    void Start()
    {
        Level.instance.AddDestructable();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -2)
        {
            DestroyDestructable();
        }
        
        if (transform.position.x < 17f && !canBeDestroyed)
        {
            canBeDestroyed = true;
            Gun[] guns = transform.GetComponentsInChildren<Gun>();
            foreach (Gun gun in guns)
            {
                gun.isActive = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!canBeDestroyed)
        {
            return;
        }
        Bullet bullet = collision.GetComponent<Bullet>();
        if (bullet != null)
        { 
            if (!bullet.isEnemy)
            { 
                Level.instance.AddScore(scoreValue);
                DestroyDestructable();
                Destroy(bullet.gameObject);
            }
        }
    }

    void DestroyDestructable()
    {
        Instantiate(expolosion, transform.position, Quaternion.identity);
        Level.instance.RemoveDestructable();
        Destroy(gameObject);
    }
    
}
