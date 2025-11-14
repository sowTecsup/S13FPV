using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Target;
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
