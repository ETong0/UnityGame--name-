
using UnityEngine;

public class CameraControler : MonoBehaviour
{

    [SerializeField] private float speed;
    private float currentposX;
    private Vector3 velocity = Vector3.zero;

    //play follow camera movement
    [SerializeField] private Transform player;


    private void Update()
    {
        //Room to room Camera movement
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentposX, transform.position.y, transform.position.z), ref velocity, speed);

        //play follow camera movement
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentposX = _newRoom.position.x;

    }

}

