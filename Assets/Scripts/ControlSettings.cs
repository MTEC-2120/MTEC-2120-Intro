using UnityEngine;
using UnityEngine.InputSystem;

public class ControlSettings : MonoBehaviour
{
    public InputActionReference moveAction;

    private void Start()
    {
        moveAction.action.ApplyBindingOverride(new InputBinding { overrideProcessors = "scale(factor=10)" });

        //          moveAction.action.ApplyBindingOverride(new InputBinding {overrideProcessors = "invertVector2(invertX=true,invertY=true)" });

    }
}