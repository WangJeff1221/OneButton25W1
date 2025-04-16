using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isOnBottomTrack = true;
    public float trackHeight = 4.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isOnBottomTrack = !isOnBottomTrack;
            float targetY = isOnBottomTrack ? -trackHeight / 2 : trackHeight / 2;
            transform.position = new Vector3(transform.position.x, targetY, transform.position.z);
        }
    }
}
