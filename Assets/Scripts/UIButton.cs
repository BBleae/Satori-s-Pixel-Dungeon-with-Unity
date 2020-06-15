using System;
using UnityEngine;

public class UIButton : MonoBehaviour {
    public string target;
    public SpriteRenderer sprite;
    public Material hightLightMaterial;

    Material originMaterial;
    Uri targetUri;

    void Awake() {
        originMaterial = sprite.material;
        targetUri = new Uri(target);
    }

    void OnMouseDrag() => sprite.material = hightLightMaterial;

    void OnMouseUp() => sprite.material = originMaterial;

    void OnMouseUpAsButton() {
        sprite.material = originMaterial;
        Action();
    }

    void Action() {

    }
}
