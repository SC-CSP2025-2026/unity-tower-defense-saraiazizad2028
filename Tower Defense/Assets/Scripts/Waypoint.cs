using UnityEditor;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    [field: SerializeField]

    public Waypoint Next { get; private set; }

    void OnDrawGizmos()
    {
        if (Next == null) { return; }
        Handles.color = Color.red;
        Handles.DrawLine(transform.position, Next.transform.position, 3f);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
