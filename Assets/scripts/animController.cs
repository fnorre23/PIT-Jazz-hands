using UnityEngine;
using UnityEngine.InputSystem;

public class animController : MonoBehaviour
{
    public InputActionProperty LTriggerAction;
    public InputActionProperty RGrabAction;
    
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (RGrabAction != null){
            float grabValue = RGrabAction.action.ReadValue<float>();
            animator.SetFloat("grab", grabValue);  
        }

        if (LTriggerAction != null){
            float triggerValue = LTriggerAction.action.ReadValue<float>();
            animator.SetFloat("trigger", triggerValue);
        }
        
    }
}
