using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{

    [SerializeField] public MeshRenderer meshRenderer;
    [SerializeField] public MeshFilter meshFilter;

    void Start()
    {
        int vertexIdx = 0;
        List<Vector3> vertices = new List<Vector3>();
        List<int> triangles = new List<int>();
        List<Vector2> uvs = new List<Vector2>();

        //TODO I have no idea what exactly this does, but I think it creates a bunch of triangles to get ready to map textures to, on the faces of a cube.
        //TODO see https://youtu.be/h66IN1Pndd0?list=PLVsTSlfj0qsWEJ-5eMtXsYp03Y9yF1dEn&t=1219

        for (int p = 0; p < 6; p++)
        {
            for (int i = 0; i < 6; i++)
            {
                int triangleIdx = VoxelData.voxelTriangles[p, i];
                Vector3 triangleCoords = VoxelData.voxelVertices[triangleIdx];

                vertices.Add(triangleCoords);
                triangles.Add(vertexIdx);

                uvs.Add(VoxelData.voxelUvs[i]);

                vertexIdx += 1;
            }
        }
        Mesh mesh = new Mesh();
        mesh.vertices = vertices.ToArray();
        mesh.triangles = triangles.ToArray();
        mesh.uv = uvs.ToArray();
        mesh.RecalculateNormals();
        meshFilter.mesh = mesh;

    }
}
