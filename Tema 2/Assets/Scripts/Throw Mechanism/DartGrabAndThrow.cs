using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class DartGrabAndThrow: MonoBehaviour
{
    private XRGrabInteractable interactable;
    public float maxThrowForce = 50f;
    private float currentThrowForce = 0f;
    void Start()
    {
        interactable = GetComponent<XRGrabInteractable>();
        interactable.selectEntered.AddListener(OnGrab);
        interactable.selectExited.AddListener(OnRelease);
    }
    void OnGrab(SelectEnterEventArgs args)
    {
        currentThrowForce = 0f;
    }
    void OnRelease(SelectExitEventArgs args)
    {
        Dart dart = GetComponent<Dart>();
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            dart.SetThrowPosition(args.interactorObject.transform.position);
            currentThrowForce = Mathf.Min(currentThrowForce + Time.deltaTime * maxThrowForce * 30, maxThrowForce);
            Vector3 throwDirection = args.interactorObject.transform.forward;
            rb.AddForce(throwDirection * currentThrowForce, ForceMode.Impulse);
        }
    }
}