using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject player;

    public GameObject platformPrefab;
    public GameObject coinPrefab;

    public List<GameObject> specialPlatforms;

    List<GameObject> platforms = new List<GameObject>();

    float platformLength = 8;
    float nextPlatformZ = 0;
    float nextPlatformY = 0;

    bool spawnCoins = false;

    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            AddNewPlatform();
        }
    }

    void AddNewPlatform()
    {
        //Spawn platform
        GameObject newPlatform;
        if(Random.Range(0,3) == 0)
        {
             newPlatform = Instantiate(specialPlatforms[Random.RandomRange(0, specialPlatforms.Count)]);
            
        }
        else
        {
             newPlatform = Instantiate(platformPrefab);
            
        }
        newPlatform.transform.position = new Vector3(0, nextPlatformY, nextPlatformZ);
        platforms.Add(newPlatform);

        //Spawn Coin
        if (spawnCoins)
        {
            GameObject newCoin = Instantiate(coinPrefab);
            newCoin.transform.position = new Vector3(0, nextPlatformY + 1.56f, nextPlatformZ);
            newCoin.transform.parent = newPlatform.transform;
        }
 
        nextPlatformZ += platformLength;

        //Random abstand Platform
        if (nextPlatformZ > 20)
        { 
            if(Random.Range(0,3) == 0)
            {
                //Boolean wechsel
                spawnCoins = !spawnCoins;
                nextPlatformY += Random.Range(-2, 2);
                nextPlatformZ += Random.Range(4,8);
               
                
            }
        }
    }

    void Update()
    {
        if(platforms.Count > 0)
        {
            GameObject oldestPlatform = platforms[0];
            float distanceToOldestPlatform = player.transform.position.z - oldestPlatform.transform.position.z;

            //Zerstöre Platform hinter Spieler
            if(distanceToOldestPlatform > 10)
            {
                Destroy(oldestPlatform);
                platforms.Remove(oldestPlatform);
            }

            GameObject newestPltform = platforms[platforms.Count - 1];
            float distanceToNewestPlatform = newestPltform.transform.position.z - player.transform.position.z;
            
            //Spawnt neue Platform
            if(distanceToNewestPlatform < 100)
            {
                AddNewPlatform();
            }
        }
    }

    public float GetPlatformY()
    {
        return nextPlatformY;
    }
}
