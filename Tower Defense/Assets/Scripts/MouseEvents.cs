using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    [field: SerializeField]
    public UnityEvent OnEnter { get; private set; }

    [field: SerializeField]
    public UnityEvent OnExit { get; private set; }

    [field: SerializeField]
    public UnityEvent OnClick { get; private set; }

    void OnMouseEnter()
    {
        transform.parent.gameObject.name = "MouseEntered";
        OnEnter.Invoke();
    }

    void OnMouseExit()
    {
        transform.parent.gameObject.name = "MouseExited";
        OnExit.Invoke();
    }

    void OnMouseUpAsButton()
    {
        OnClick.Invoke();
    }
}
