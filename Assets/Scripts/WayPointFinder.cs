using UnityEngine;
using UnityEngine.SceneManagement;

public class WayPointFinder : MonoBehaviour
{
    public float speed = 2f;
    public Transform[] points;

    private int i;
    void Start()
    {
        transform.position = points[0].position;
    }

    void Update()
    {
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("DeathScene");
    }
}
