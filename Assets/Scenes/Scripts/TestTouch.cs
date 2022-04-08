using UnityEngine;

public class TestTouch : MonoBehaviour
{   
    private InputManager inputManager;
    private Camera cameraMain;

    ////Awake is called when the script instance is being loaded. Awake is called before any Start functions
    private void Awake() {
        inputManager = InputManager.Instance;
        cameraMain = Camera.main;

    }

    //Subscribing to the event
    private void OnEnable(){
        inputManager.OnStartTouch += Move;

    }

    //Unsubscrubing to the event
    private void OnDisable(){
        inputManager.OnEndTouch -= Move;
    }

    //Coordinates for where you touch on the screen.
    public void Move(Vector2 screenPosition, float time){
        Vector3 screenCoordinates = new Vector3(screenPosition.x, screenPosition.y, cameraMain.nearClipPlane);
        Vector3 worldCoordinates = cameraMain.ScreenToWorldPoint(screenCoordinates);
        worldCoordinates.z = 0;
        transform.position = worldCoordinates;
    }

}
