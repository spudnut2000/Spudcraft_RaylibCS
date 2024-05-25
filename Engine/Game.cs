using System.Numerics;
using Raylib_cs;

namespace Spudcraft_RaylibCS.Engine;

using static Raylib;

public unsafe class Game
{
    private Camera3D _camera = new();
    
    private Vector3 _cubePos = Vector3.Zero;
    
    Chunk _chunk = new Chunk();
    
    public Game() { }

    public void Start()
    {
        InitWindow(1280, 720, "Spudcraft RaylibCS");
        
        SetTargetFPS(60);

        _camera.Position = new Vector3(10.0f, 10.0f, 10.0f);
        _camera.Target = new Vector3(0.0f, 0.0f, 0.0f);
        _camera.Up = new Vector3(0.0f, 1.0f, 0.0f);
        _camera.FovY = 45.0f;
        _camera.Projection = CameraProjection.Perspective;
        
        DisableCursor();    
        
        while (!WindowShouldClose())
        {
            Update();
            
            BeginDrawing();
            ClearBackground(Color.White);
            Draw();
            BeginMode3D(_camera);
            Draw3D();
            EndMode3D();
            EndDrawing();
        }
        
        Unload();
        
        CloseWindow();
    }
    
    public void Update()
    {
        if (IsKeyDown(KeyboardKey.Up))
        {
            _cubePos.Y += 1f * GetFrameTime();
        }
        if (IsKeyDown(KeyboardKey.Down))
        {
            _cubePos.Y -= 1f * GetFrameTime();
        }

        fixed (Camera3D* camera = &_camera)
        {
            UpdateCamera(camera, CameraMode.Free);
        }
    }
    
    public void Draw()
    {
        
    }
    
    
    
    public void Draw3D()
    {
        DrawGrid(10, 1.0f);
        // DrawCube(_cubePos, 1.0f, 1.0f, 1.0f, Color.Blue);
        _chunk.Draw();
    }
    
    public void Unload()
    {
        
    }
}