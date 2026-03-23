using UnityEngine;

public class MovementScript : MonoBehaviour
    {
    [SerializeField]
    private GameObject Waypoint;
    public float speed = 4f;
    public float duration;
        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }

            if ((Input.GetKeyDown(KeyCode.Space)))
            {
            duration = 6f;


            }

            if (duration > 0)
            {
                speed = 6f;
                duration-=Time.deltaTime;
            }

            else
            {
                speed = 4f;
            }
    }
}
/*
* project gay guy
GameObject wp = Instantiate(Waypoint);
wp.transform.position = transform.position;
gameObject.transform.position = wp.transform.position;
*/

