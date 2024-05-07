using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    public int numberOfTargets = 5;
    public float minX = -4.0f;
    public float maxX = 4.0f;
    public float minY = -4.0f;
    public float maxY = 4.0f;
    public float spawnHeight = 1.0f; // Adjust this to control the height above ground
    public int gridRows = 5;
    public int gridCols = 5;

    void Start()
    {
        SpawnTargets();
    }

    void SpawnTargets()
    {
        int targetsSpawned = 0;

        // Calculate the size of each grid cell
        float cellWidth = (maxX - minX) / gridCols;
        float cellHeight = (maxY - minY) / gridRows;

        for (int row = 0; row < gridRows; row++)
        {
            for (int col = 0; col < gridCols; col++)
            {
                // Calculate the position of the center of the current grid cell
                float centerX = minX + col * cellWidth + cellWidth / 2f;
                float centerY = minY + row * cellHeight + cellHeight / 2f;

                // Spawn a target at a random position within the current grid cell
                Vector3 spawnPosition = new Vector3(Random.Range(centerX - cellWidth / 2f, centerX + cellWidth / 2f),
                                                    spawnHeight,
                                                    Random.Range(centerY - cellHeight / 2f, centerY + cellHeight / 2f));

                // Instantiate the target prefab at the random position
                Instantiate(targetPrefab, spawnPosition, Quaternion.identity);

                targetsSpawned++;

                // Check if the desired number of targets have been spawned
                if (targetsSpawned >= numberOfTargets)
                {
                    return;
                }
            }
        }
    }
}
