using UnityEngine;

public class EnemyTracker : MonoBehaviour

{
    public float speed = 2f;
    public Transform[] points;

    private int i;
    void Start()
    {
        
    }

    void Update()
    {

        transform.position = points[0].position;


        transform.position = Vector2.MoveTowards(
        transform.position,
        points[i].position,
        speed * Time.deltaTime
    );
        if (Vector2.Distance(transform.position, points[i].position) < 0.01f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }

        }
    }


}
