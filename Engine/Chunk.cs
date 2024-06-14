using System.Data;
using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace Spudcraft_RaylibCS.Engine;

public unsafe class Chunk
{
    public static int ChunkWidth = 16;
    public static int ChunkHeight = 32;

    private Node[,,] Nodes = new Node[ChunkWidth, ChunkHeight, ChunkWidth];
    
    private Mesh _mesh = new();
    private Model _model = new();

    public Chunk()
    {
        Generate();
    }
    
    public void Generate()
    {
        for (int x = 0; x < ChunkWidth; x++)
        {
            for (int y = 0; y < ChunkHeight; y++)
            {
                for (int z = 0; z < ChunkWidth; z++)
                {
                    Nodes[x, y, z] = new Block();
                }
            }
        }
    }
    
    public void Draw()
    {
        DrawModel(_model, new Vector3(0, 0, 0), 1.0f, Color.White);
    }

    public Node GetNode(int x, int y, int z)
    {
        return Nodes[x, y, z];
    }
    
    public void UpdateMesh()
    {
        for (int x = 0; x < ChunkWidth; x++)
        {
            for (int y = 0; y < ChunkHeight; y++)
            {
                for (int z = 0; z < ChunkWidth; z++)
                {
                    CreateBlock(x, y, z);
                }
            }
        }
    }
    
    private void CreateBlock(int x, int y, int z)
    {
        var block = Nodes[x, y, z] as Block;
        Vector3 blockPosition = new Vector3(x, y, z);

        if (CheckTransparency(blockPosition + Vector3.UnitY))
        {
            // TODO: CreateBlockFace(Block.TopFace, blockPosition, block.TextureTop);
        }
        if (CheckTransparency(blockPosition - Vector3.UnitY))
        {
            // TODO: CreateBlockFace(Block.BottomFace, blockPosition, block.TextureBottom);
        }
        if (CheckTransparency(blockPosition + Vector3.UnitX))
        {
            // TODO: CreateBlockFace(Block.RightFace, blockPosition, block.TextureRight);
        }
        if (CheckTransparency(blockPosition - Vector3.UnitX))
        {
            // TODO: CreateBlockFace(Block.LeftFace, blockPosition, block.TextureLeft);
        }
        if (CheckTransparency(blockPosition + Vector3.UnitZ))
        {
            // TODO: CreateBlockFace(Block.FrontFace, blockPosition, block.TextureFront);
        }
        if (CheckTransparency(blockPosition - Vector3.UnitZ))
        {
            // TODO: CreateBlockFace(Block.BackFace, blockPosition, block.TextureBack);
        }
    }

    private void CreateBlockFace(BlockFace face, Vector3 blockPosition, Texture2D texture)
    {
        // TODO: Implement CreateBlockFace
        if (face is BlockFace.Top)
        {
            // TODO: Implement CreateBlockFace Top
        }

        if (face is BlockFace.Bottom)
        {
            // TODO: Implement CreateBlockFace Bottom
        }

        if (face is BlockFace.Left)
        {
            // TODO: Implement CreateBlockFace Left
        }

        if (face is BlockFace.Right)
        {
            // TODO: Implement CreateBlockFace Right
        }

        if (face is BlockFace.Front)
        {
            // TODO: Implement CreateBlockFace Front
        }

        if (face is BlockFace.Back)
        {
            // TODO: Implement CreateBlockFace Back
        }
    }


    
    
    private bool CheckTransparency(int x, int y, int z)
    {
        if (x < 0 || x >= ChunkWidth || y < 0 || y >= ChunkHeight || z < 0 || z >= ChunkWidth)
        {
            return true;
        }
        
        return Nodes[x,y,z].IsTransparent;
    }
    
    private bool CheckTransparency(Vector3 position)
    {
        return CheckTransparency((int)position.X, (int)position.Y, (int)position.Z);
    }
}

public enum BlockFace
{
    Front,
    Back,
    Top,
    Bottom,
    Left,
    Right
}