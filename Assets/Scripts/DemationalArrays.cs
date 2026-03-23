using UnityEngine;
using System;

public class DementionalArrays : MonoBehaviour
{
    public GameObject Tile;
    public int[,] Map =
        {
            { 1, 0, 1, 0 },
            { 0, 1, 0, 0 },
            { 1, 0, 0, 0 },
            { 0, 0, 1, 0 }

        };

    void Start()
    {
        Vector2 tileSize = Tile.GetComponent<SpriteRenderer>().bounds.size;
        for (int i = 0; i < Map.GetLength(0); i++)
        {
            for (int I = 0; I < Map.GetLength(1); I++)
            {
                switch (Map[i, I])
                {
                    case 0:
                        GameObject emptyTile = Instantiate(Tile, new Vector3(I * tileSize.y, i * tileSize.x, 0), Quaternion.identity);
                        emptyTile.GetComponent<SpriteRenderer>().color = Color.gray;
                        break;
                    case 1:
                        GameObject path = Instantiate(Tile, new Vector3(I * tileSize.y, i * tileSize.x, 0), Quaternion.identity);
                        path.GetComponent<SpriteRenderer>().color = Color.green;
                        break;
                        
                }
            }
        }
    }



}