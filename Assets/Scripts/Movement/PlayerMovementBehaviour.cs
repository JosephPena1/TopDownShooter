using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [Tooltip("How fast the player will move.")]
    [SerializeField]
    private float _moveSpeed;
    [Tooltip("The current active camera. Used to get mouse position for rotation.")]
    [SerializeField]
    private Camera _camera;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //Store reference to the attached rigidbody
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //Create a ray that starts at a screen point
        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        //Checks to see if the ray hits any object in the world
        if (Physics.Raycast(ray, out hit))
        {
            //Finds the direction the player should look towards
            Vector3 lookDir = new Vector3(hit.point.x, transform.position.y, hit.point.z) - transform.position;
            //Create a rotation from the player's forward to the look direction
            Quaternion rotation = Quaternion.LookRotation(lookDir);
            //Set the rotation to be the new rotation found
            _rigidbody.MoveRotation(rotation);

            //Checks if Left mouse button is pressed or held
            if (Input.GetMouseButton(1))
            {
                //Finds the position of the mouse ray
                Vector3 movePos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                //Finds the position the player should go towards
                Vector3 toTarget = (movePos - transform.position).normalized;
                //Sets the position to be the current position plus the distance to target
                _rigidbody.MovePosition(transform.position + toTarget * _moveSpeed);
            }
        }
    }
}
