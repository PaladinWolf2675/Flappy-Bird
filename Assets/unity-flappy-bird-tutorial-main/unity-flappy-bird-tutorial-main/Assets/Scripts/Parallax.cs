using UnityEngine;
// We’re telling Unity, “Hey, we want to use your game-making tools for this script.”

public class Parallax : MonoBehaviour
{
    // How fast the background will appear to move.
    // Imagine this like the speed dial on a treadmill for your background.
    public float animationSpeed = 1f;

    // This will hold the part of the object that actually shows the picture.
    // Kind of like holding a photo frame so you can slide the picture inside it.
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        // When the game starts, grab the object’s "photo frame" (the MeshRenderer)
        // so we can slide the picture around later.
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        // Imagine your background is a giant wallpaper on a roll.
        // Each moment the game runs, we nudge that wallpaper a tiny bit sideways.
        // animationSpeed decides how quickly we scroll the wallpaper.
        // Time.deltaTime makes sure the scroll speed feels the same
        // no matter how fast the computer runs.

        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
        // The "new Vector2(..., 0)" part just means: 
        // "Move sideways by this much, and don’t move up or down."
    }
}
