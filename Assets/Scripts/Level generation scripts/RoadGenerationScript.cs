using System.Collections.Generic;
using UnityEngine;

public class RoadGenerationScript : TileGenerationScript
{
    public override GameObject Generate(int column, int row)
    {
        //set as road
        //assuming road points west

        //TODO::add logic to check if road ia long edge and add outer wall?
        if (column % (Size - 1) == 0)
        {
            return Instantiate(tiles[Random.Range(0, tiles.Count)], new Vector3(column * Width, 0, row * Width),
                Quaternion.Euler(0, Random.Range(0, 2) * 180 + 90, 0));
        }

        return Instantiate(tiles[Random.Range(0, tiles.Count)], new Vector3(column * Width, 0, row * Width),
            Quaternion.Euler(0, Random.Range(0, 2) * 180, 0));
    }
}