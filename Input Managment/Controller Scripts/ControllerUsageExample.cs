using UnityEngine;

public class ControllerUsageExample : MonoBehaviour {
    
    //Default input device is set to Xbox controller, it can be changed in inspector
    public ControllerEnum inputDevice = ControllerEnum.XBOX_CONTROLLER;
    private IController controller;

	void Start () {
        //Adds chosen type of controller to gameobject
		switch(inputDevice)
        {
            case ControllerEnum.XBOX_CONTROLLER:
                controller = gameObject.AddComponent(typeof(ControllerXbox)) as ControllerXbox;
                break;
            case ControllerEnum.MOUSE_KEYBOARD_CONTROLLER:
                controller = gameObject.AddComponent(typeof(ControllerMouseAndKeyboard)) as ControllerMouseAndKeyboard;
                break;
        }
	}
}
