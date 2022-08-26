using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer background;
    [SerializeField] private Camera camera;
    //Çözünürlük düzelten metot
    void ResolutionCorrection()
    {
        float screenRatio = FindScreenRatio(Screen.width, Screen.height);
        float frameRatio = FindScreenRatio(background.bounds.size.x, background.bounds.size.y);
        if (screenRatio >= frameRatio)
        {
            camera.orthographicSize = (background.bounds.size.y / 2);
        }
        else
        {
            camera.orthographicSize = (background.bounds.size.y / 2) * frameRatio / screenRatio;
           
        }
    }

    float FindScreenRatio(float width, float height)
    {
        return (width / height);
    }
    
    private void LateUpdate() {
        ResolutionCorrection();
    }

}
