using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectTableController : MonoBehaviour
{
    //public List<GameObject> BallList = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int childCount = Random.Range(5, 12);
            transform.GetChild(childCount).transform.parent = other.gameObject.transform;
        }

        #region
        /*
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < BallList.Count; i++)
            {
                if (BallList[i].name.Contains("Ball"))
                {
                    BallList[i].gameObject.transform.Translate(TableController.instance.spawnPoint.transform.position.x, TableController.instance.spawnPoint.transform.position.y, TableController.instance.spawnPoint.transform.position.z);
                    BallList[i].gameObject.transform.parent = other.gameObject.transform;
                    BallList.RemoveAt(i);
                    Debug.Log("BallList Goruldu");
                    break;
                }
            }
        }
        */
        #endregion
    }

}
