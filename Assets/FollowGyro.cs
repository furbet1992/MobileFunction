
using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0, 0, 1, 0);

    private void Start()
    {
        GyroManager.Instance.EnabledGyro(); 
    }

    // Update is called once per frame
    private void Update()
    {
        transform.localRotation = GyroManager.Instance.GetGyroRotation() * baseRotation; 
    }
}
