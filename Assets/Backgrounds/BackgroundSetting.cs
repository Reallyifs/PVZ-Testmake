using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSetting : MonoBehaviour
{
    internal static Texture2D currentTex;

    public Texture2D loading_Tex;
    public Texture2D normol_BgTex;
    public Texture2D world_1_BgTex;

    public SpriteRenderer spriteRenderer;

    public int bgSelect = 0;

    // Start is called before the first frame update
    private void Start()
    {
        currentTex = normol_BgTex;
        BgSetter.bgSR = spriteRenderer;
    }

    private void Update()
    {
        BgSetter.SetNewBackground();
    }

    private static class BgSetter
    {
        public static SpriteRenderer bgSR;

        public static Sprite SetNewBackground(Texture2D texture)
        {
            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2());
            bgSR.sprite = sprite;
            return sprite;
        }

        public static Sprite SetNewBackground()
        {
            return SetNewBackground(currentTex);
        }
    }

    private class BgID
    {
        public const int NormolBg = 0;
        public const int LoadingBg = -1;

        public const int World1Bg = 3;
    }
}