using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
struct CrosshairImage
{
    public Vector2 position { get; set; }
    public Sprite image { get; set; }
}

public class CrosshairManager : MonoBehaviour {

    [SerializeField]
    private List<CrosshairImage> crosshairImages;

    private void Start()
    {
        crosshairImages = new List<CrosshairImage>();

    }
}
