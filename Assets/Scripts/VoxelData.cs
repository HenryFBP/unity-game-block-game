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
}
