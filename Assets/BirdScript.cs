using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
/*        else if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            myRigidbody.velocity = Vector2.right * 10;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            myRigidbody.velocity = Vector2.left * 10;
        }*/

    }
}
