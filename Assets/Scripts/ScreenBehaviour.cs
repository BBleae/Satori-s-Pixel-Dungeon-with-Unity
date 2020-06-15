using UnityEngine;

public abstract class ScreenBehaviour : MonoBehaviour
{
    public Camera cam;

    protected struct ScreenSize
    {
        public int width;
        public int height;
    };
    protected ScreenSize screenSize;
    void Awake()
    {
        UpdateScreenSize();
        OnScreenResize();
    }

    void FixedUpdate()
    {
        if (screenSize.width != Screen.width || screenSize.height != Screen.height)
        {
            UpdateScreenSize();
            OnScreenResize();
        }
    }

    void UpdateScreenSize()
    {
        screenSize.width = Screen.width;
        screenSize.height = Screen.height;
    }
    abstract public void OnScreenResize();
}
