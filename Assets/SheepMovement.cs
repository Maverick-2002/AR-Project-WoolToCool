using UnityEngine;

public class SheepMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float changeDirectionTime = 2.0f;

    private Vector3 direction;
    private float timer;

    void Start()
    {
        ChangeDirection();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > changeDirectionTime)
        {
            ChangeDirection();
            timer = 0;
        }

        transform.Translate(direction * speed * Time.deltaTime);
    }

    void ChangeDirection()
    {
        direction = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
    }
}
