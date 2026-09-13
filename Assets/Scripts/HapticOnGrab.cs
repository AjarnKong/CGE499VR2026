using UnityEngine;
using System.Collections;

public class HapticOnGrab : MonoBehaviour
{
    [SerializeField]
    private OVRInput.Controller controller
        = OVRInput.Controller.RTouch;
    [SerializeField] private float frequency = 0.4f;
    [SerializeField] private float amplitude = 0.6f;
    [SerializeField] private float duration = 0.15f;

    public void Pulse()
    {
        StopAllCoroutines();
        StartCoroutine(PulseRoutine());
    }

    private IEnumerator PulseRoutine()
    {
        OVRInput.SetControllerVibration(
            frequency, amplitude, controller);
        yield return new WaitForSeconds(duration);
        OVRInput.SetControllerVibration(0f, 0f, controller);
    }
}



