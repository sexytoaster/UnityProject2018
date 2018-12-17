using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public GameObject[] coins;

    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLength = 18.0f;
    private int amnTilesOnScreen = 5;
    private float safeZone = 15.0f;
    private int lastPrefabIndex = 0;
    public bool firstLap = false;
    bool originMoved = false;
    private List<GameObject> activeTiles;
    // Use this for initialization
    void Start()
    {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        //so first tile is always the flat prefab without obsticles, we add this here
        //might revise to see if there is a better way of doing it


        GameObject go;
        go = Instantiate(tilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add(go);

        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnZ > (50f + (amnTilesOnScreen * tileLength)))
        {
            originMoved = true;
        }

        float z = GameObject.FindGameObjectWithTag("Player").transform.position.z;
        if (z < 48 && firstLap == true && originMoved == true)
        {

            originMoved = false;
            spawnZ = spawnZ - 100.5f;
        }
        if (playerTransform.position.z - safeZone > (spawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTile();
            DeleteTile();
        }

    }

    private void SpawnTile(int prefabIndex = -1)
    {
        int i, side; // side is either 0,1,2 left, middle, right
        Vector3 v = new Vector3(2f, 0, 0);
        Vector3 up = new Vector3(0, .5f, 0);
        GameObject go;
        go = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
        side =Random.Range(0, 5);
        float coinSpace = tileLength / 8;
        float currentSpace = (tileLength / 2) * -1;
        Debug.Log(currentSpace);
        for (i = 0; i< 8; i++)
        {
            Vector3 temp = new Vector3(0, 0, currentSpace);
            Vector3 space = new Vector3(0, 0, coinSpace);

            GameObject coin;
            coin = Instantiate(coins[0]) as GameObject;
            coin.transform.SetParent(transform);
            if (side == 2)
            {
                coin.transform.position = (Vector3.forward * spawnZ + temp) + v + up;
            }
            else if(side == 1)
            {
                coin.transform.position = (Vector3.forward * spawnZ + temp) + up;
            }
            else if (side == 0)
            {
                coin.transform.position = Vector3.forward * spawnZ + temp - v + up;
            }
            else if (side >= 3)
            {

            }
            currentSpace = currentSpace + coinSpace;
        }
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        activeTiles.Add(go);
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
        firstLap = true;
    }

    private int RandomPrefabIndex()
    {
        if (tilePrefabs.Length <= 1)
        {
            return 0;

        }

        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }
        lastPrefabIndex = randomIndex;
        return randomIndex;
    }

}
