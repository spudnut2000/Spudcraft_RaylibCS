using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;

namespace Spudcraft_RaylibCS.Engine
{
    public unsafe class Block : Node
    {
        public Texture2D Texture;
        public Texture2D TextureTop;
        public Texture2D TextureBottom;
        public Texture2D TextureLeft;
        public Texture2D TextureRight;
        public Texture2D TextureFront;
        public Texture2D TextureBack;

        public static readonly Vector3[] CubeVertices = new Vector3[]
        {
            new(0,0,0),
            new(1,0,0),
            new(0,1,0),
            new(1,1,0),
            new(0,0,1),
            new(1,0,1),
            new(0,1,1),
            new(1,1,1)
        };

        public static readonly int[] CubeTopFace = { 6, 7, 3, 2 };       // Correct order: 6, 7, 3, 2
        public static readonly int[] CubeBottomFace = { 0, 1, 5, 4 };    // Correct order: 0, 1, 5, 4
        public static readonly int[] CubeLeftFace = { 6, 2, 0, 4 };      // Correct order: 6, 2, 0, 4
        public static readonly int[] CubeRightFace = { 7, 5, 1, 3 };     // Correct order: 7, 5, 1, 3
        public static readonly int[] CubeBackFace = { 6, 4, 5, 7 };      // Correct order: 6, 4, 5, 7
        public static readonly int[] CubeFrontFace = { 2, 3, 1, 0 };     // Correct order: 2, 3, 1, 0
        

        public override void Draw()
        {
            //Raylib.DrawModel(_model, new Vector3(0, 0, 0), 1.0f, Color.White);
        }
    }
}
