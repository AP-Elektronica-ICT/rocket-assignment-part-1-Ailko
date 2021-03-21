using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.position = target.transform.position + new Vector3(0, -target.transform.position.y + 10, -25);
            transform.LookAt(target);
        }
    }
}
