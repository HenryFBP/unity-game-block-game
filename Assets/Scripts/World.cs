using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class World : MonoBehaviour
{

    public Material material;
    public BlockType[] blocktypes;

    public void Start()
    {
        print("itz da world bro");

        Chunk chunk = new Chunk(this);
    }

    public BlockType getBlockTypeByName(string name)
    {
        return (
            from bt in this.blocktypes
            where bt.blockName.ToUpper().Equals(name.ToUpper())
            select bt
        ).FirstOrDefault();
    }
}

[System.Serializable]
public class BlockType
{

    [SerializeField] public string blockName;
    [SerializeField] public bool isSolid;
    [SerializeField] public byte blockId;

    [Header("Texture Values")]
    public int backFaceTexture;
    public int frontFaceTexture;
    public int topFaceTexture;
    public int bottomFaceTexture;
    public int leftFaceTexture;
    public int rightFaceTexture;

    // Back, Front, Top, Bottom, Left, Right

    public int GetTextureID(int faceIndex)
    {

        switch (faceIndex)
        {

            case 0:
                return backFaceTexture;
            case 1:
                return frontFaceTexture;
            case 2:
                return topFaceTexture;
            case 3:
                return bottomFaceTexture;
            case 4:
                return leftFaceTexture;
            case 5:
                return rightFaceTexture;
            default:
                Debug.Log("Error in GetTextureID; invalid face index");
                return 0;


        }

    }

}