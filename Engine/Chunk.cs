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
        CreateMesh();
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
    
    public unsafe void CreateMesh()
    {
        
    }

    public void Draw()
    {
        Raylib.DrawModel(_model, new Vector3(0, 0, 0), 1.0f, Color.White);
    }

    public Node GetNode(int x, int y, int z)
    {
        return Nodes[x, y, z];
        
        
    }
    
    private bool CheckTransparency(int x, int y, int z)
    {
        if (x < 0 || x >= ChunkWidth || y < 0 || y >= ChunkHeight || z < 0 || z >= ChunkWidth)
        {
            return true;
        }
        
        return Nodes[x,y,z].IsTransparent;
    }
}