using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Target;
    public int Life = 3;
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("trigger entro: " + collision.tag);
        
        if (collision.tag == "Bullet")
        {
            Life--;
            if(Life  <= 0)
                Destroy(gameObject);
        }
    }
   /* private void OnTriggerExit2D(Collider2D collision)
    {
        print("trigger salio");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        print("trigger mantuvo");
    }*/
}
