
using UnityEngine;

public class CameraControler : MonoBehaviour
{

    [SerializeField] private float speed;
    private float currentposX;
    private Vector3 velocity = Vector3.zero;

    //play follow camera movement
    [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;
    private float lookAhead;


    private void Update()
    {
        //Room to room Camera movement
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentposX, transform.position.y, transform.position.z), ref velocity, speed);

        //play follow camera movement
        transform.position = new Vector3(player.position.x + lookAhead, transform.position.y, transform.position.z);
        lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentposX = _newRoom.position.x;

    }

}

