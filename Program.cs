using Raylib_cs;
using System.Numerics;
using Spudcraft_RaylibCS.Engine;

Game game = new();
game.Start();




// Raylib.InitWindow(1280, 960, "Hello World!");
// Raylib.SetTargetFPS(60);
//
// Camera3D camera = new(Vector3.One * 1.5f, Vector3.Zero, Vector3.UnitY, 60f, CameraProjection.Perspective);
// Mesh cube = new(8, 12);
// cube.AllocVertices();
// cube.AllocTexCoords();
// cube.AllocIndices();
// Span<Vector3> vertices = cube.VerticesAs<Vector3>();
// Span<Vector2> texcoords = cube.TexCoordsAs<Vector2>();
// Span<ushort> indices = cube.IndicesAs<ushort>();
//
// vertices[0] = new Vector3(-1.0f, 1.0f, -1.0f);  // 0
// vertices[1] = new Vector3(-1.0f, -1.0f, -1.0f); // 1
// vertices[2] = new Vector3(1.0f, -1.0f, -1.0f);  // 2
// vertices[3] = new Vector3(1.0f, 1.0f, -1.0f);   // 3
// vertices[4] = new Vector3(-1.0f, 1.0f, 1.0f);   // 4
// vertices[5] = new Vector3(-1.0f, -1.0f, 1.0f);  // 5
// vertices[6] = new Vector3(1.0f, -1.0f, 1.0f);   // 6
// vertices[7] = new Vector3(1.0f, 1.0f, 1.0f);    // 7
//
// texcoords[0] = new Vector2(0.0f, 0.0f);
// texcoords[1] = new Vector2(0.0f, 1.0f);
// texcoords[2] = new Vector2(1.0f, 1.0f);
// texcoords[3] = new Vector2(1.0f, 0.0f);
// texcoords[4] = new Vector2(0.0f, 0.0f);
// texcoords[5] = new Vector2(0.0f, 1.0f);
// texcoords[6] = new Vector2(1.0f, 1.0f);
// texcoords[7] = new Vector2(1.0f, 0.0f);
//
// indices[0] = 1; indices[1] = 0; indices[2] = 2;  // Front face
// indices[3] = 3; indices[4] = 2; indices[5] = 0;
//
// indices[6] = 4; indices[7] = 5; indices[8] = 6;  // Back face
// indices[9] = 6; indices[10] = 7; indices[11] = 4;
//
// indices[12] = 0; indices[13] = 4; indices[14] = 7;  // Top face
// indices[15] = 7; indices[16] = 3; indices[17] = 0;
//
// indices[18] = 5; indices[19] = 1; indices[20] = 6;  // Bottom face
// indices[21] = 2; indices[22] = 6; indices[23] = 1;
//
// indices[24] = 0; indices[25] = 1; indices[26] = 5;  // Left face
// indices[27] = 5; indices[28] = 4; indices[29] = 0;
//
// indices[30] = 2; indices[31] = 3; indices[32] = 6;  // Right face
// indices[33] = 7; indices[34] = 6; indices[35] = 3;
//
// Raylib.UploadMesh(ref cube, false);
// Model model = Raylib.LoadModelFromMesh(cube);
//
// Texture2D texture = Raylib.LoadTexture("resources/grass.png");
// Console.WriteLine(Directory.GetCurrentDirectory());
//
// Raylib.SetMaterialTexture(ref model, 0, MaterialMapIndex.Diffuse, ref texture);
//
// Raylib.DisableCursor();
//
// while (!Raylib.WindowShouldClose())
// {
//     Raylib.UpdateCamera(ref camera, CameraMode.Free);
//
//     Raylib.BeginDrawing();
//     Raylib.ClearBackground(Color.Black);
//     Raylib.BeginMode3D(camera);
//     Raylib.DrawModel(model, Vector3.Zero, 1f, Color.White);
//     Raylib.EndMode3D();
//     Raylib.EndDrawing();
// }
// Raylib.UnloadModel(model);
// Raylib.UnloadTexture(texture);
// Raylib.CloseWindow();