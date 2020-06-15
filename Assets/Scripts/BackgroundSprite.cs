using UnityEngine;

public class BackgroundSprite : ScreenBehaviour {
    public new SpriteRenderer renderer;
    public float speed = 2f;
    public float cycle = 32f;
    public enum Direction { Up, Down, Left, Right }
    public Direction direction = Direction.Up;

    public override void OnScreenResize() =>
        renderer.size = new Vector2((cam.orthographicSize * ((float)screenSize.width / screenSize.height) / transform.localScale.x + cycle) * 2,
            (cam.orthographicSize / transform.localScale.y + cycle) * 2);

    void Update() {
        Vector3 position = transform.position;
        if (position.y > cycle) {
            position.y -= cycle;
        }
        position.y += speed * Time.deltaTime;
        transform.position = position;
    }
}
