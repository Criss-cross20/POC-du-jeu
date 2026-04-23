using UnityEngine;

public class CAmerafollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;
    

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.position + Offset;
    }
}
