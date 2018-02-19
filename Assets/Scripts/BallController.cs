using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] //поле приватное, но настраивамое через редактор
    Rigidbody rigidBody;
    [SerializeField]
    float multiplicator = 10; //умножитель силы

    void Update ()
    {
        float vertical;
        float horizontal;

        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        Vector3 addForce = Vector3.zero;
        addForce.z = vertical;
        addForce.x = horizontal;
        addForce *= multiplicator;

        rigidBody.AddForce(addForce);
    }

    public void DisableControl()
    {
        rigidBody.isKinematic = true;
    }
}
