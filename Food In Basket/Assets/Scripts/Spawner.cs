using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnObjectPrefab;
    private Vector3[] spawnPoints = {
        new Vector3(-25, 8, -6),
        new Vector3(-20, 8, -6),
        new Vector3(-15, 8, -6)
    };
    private KeyCode[] dropKeys = { KeyCode.A, KeyCode.S, KeyCode.D };
    public float fallSpeed = 5f;

    void Update()
    {
        // Belirli tuþlara basýldýðýnda objeyi belirli bir noktadan düþürme
        for (int i = 0; i < dropKeys.Length; i++)
        {
            if (Input.GetKeyDown(dropKeys[i]))
            {
                DropObject(i);
            }
        }
    }

    void DropObject(int index)
    {
        // Prefabý instantiate et ve belirli bir hýzla belirli bir düþme noktasýna yerleþtirme
        GameObject newObject = Instantiate(spawnObjectPrefab, spawnPoints[index], Quaternion.identity);

        Destroy(newObject, 1.2f); // Ýstediðiniz süre sonra objeyi yok etmek için
    }
}
