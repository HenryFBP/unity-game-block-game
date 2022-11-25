using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VoxelData
{

    public static readonly Vector3[] voxelVertices =
    {
        new Vector3(0,0,0),
        new Vector3(1,0,0),
        new Vector3(1,1,0),
        new Vector3(0,1,0),
        new Vector3(0,0,1),
        new Vector3(1,0,1),
        new Vector3(1,1,1),
        new Vector3(0,1,1),
    };

    public static readonly int[,] voxelTriangles = new int[6, 6]
    {
        {0,3,1,1,3,2,},//back    face
        {5,6,4,4,6,7,},//front   face
        {3,7,2,2,7,6,},//top     face
        {1,5,0,0,5,4,},//bottom  face
        {4,7,0,0,7,3,},//top     face
        {1,2,5,5,2,6,},//top     face
    };

    // https://youtu.be/h66IN1Pndd0?list=PLVsTSlfj0qsWEJ-5eMtXsYp03Y9yF1dEn&t=1969
    public static readonly Vector2[] voxelUvs = new Vector2[6]
    {
        new Vector2(0,0),
        new Vector2(0,1),
        new Vector2(1,0),
        new Vector2(1,0),
        new Vector2(0,1),
        new Vector2(1,1),
    };
}
