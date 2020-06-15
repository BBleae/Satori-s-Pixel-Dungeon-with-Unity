using UnityEngine;

public class AlignCamera : ScreenBehaviour
{

    public enum HorizontalAlign { None, Left, Right };
    public enum VerticalAlign { None, Top, Buttom };
    public HorizontalAlign horizontalAlign = HorizontalAlign.None;
    public VerticalAlign verticalAlign = VerticalAlign.None;
    public float horizontalIndent;
    public float verticalIndent;
    
    override public void OnScreenResize()
    {
        Vector3 position = transform.position;

        if (horizontalAlign == HorizontalAlign.Left)
            position.x = horizontalIndent - cam.orthographicSize * ((float)screenSize.width / screenSize.height);

        if (horizontalAlign == HorizontalAlign.Right)
            position.x = cam.orthographicSize * ((float)screenSize.width / screenSize.height) - horizontalIndent;

        if (verticalAlign == VerticalAlign.Top)
            position.y = cam.orthographicSize - verticalIndent;

        if (verticalAlign == VerticalAlign.Buttom)
            position.y = verticalIndent - cam.orthographicSize;

        transform.position = position;
    }
}
