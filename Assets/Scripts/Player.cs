using UnityEngine;

public class Player : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position -= new Vector3(0, 1, 0);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position -= new Vector3(1, 0, 0);

        }
    }
}
