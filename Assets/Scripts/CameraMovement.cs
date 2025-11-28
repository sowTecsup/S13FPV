using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject Target;
    public float cameraSpeed;
    public float cameraRange;
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        CamerMovementMechanic();
    }
    public void CamerMovementMechanic()
    {
        float distance = Vector2.Distance(Target.transform.position, transform.position);

        if(distance >= cameraRange)
        {

            Vector3 target = Target.transform.position;
            target.z = -10;

            Vector3 dir = (target - transform.position).normalized;

            transform.position += dir * cameraSpeed * Time.deltaTime;
        }

    }
}
