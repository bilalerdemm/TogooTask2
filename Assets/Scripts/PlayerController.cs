using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public GameObject collectPoint, blueTable;
    public int maxChildCount;
    public SkinnedMeshRenderer playerMesh;
    public int score = 0;
    public Text scoreText;
    public GameObject winPanel, lostPanel;
    bool isFinish = false;
    private void Start()
    {

    }
    private void Update()
    {
        scoreText.text = score.ToString();
        if (score < 0)
        {
            lostPanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (isFinish)
        {
            if (transform.childCount == 3)
            {
                winPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueTable"))
        {
            int childCount = Random.Range(1, maxChildCount);
            maxChildCount -= maxChildCount;
            if (this.transform.childCount < 4)
            {
                playerMesh.material.color = other.gameObject.transform.GetChild(childCount).GetComponent<MeshRenderer>().material.color;
                other.gameObject.transform.GetChild(childCount).transform.parent = transform;
                this.transform.GetChild(3).transform.position = collectPoint.transform.position;
                if (other.gameObject.transform.childCount == 1)
                {
                    isFinish = true;
                }
            }
        }
        if (transform.childCount == 4)
        {
            if (other.gameObject.CompareTag("GreenTable"))
            {
                transform.GetChild(3).transform.parent = other.gameObject.transform;
                if (other.gameObject.transform.GetChild(other.gameObject.transform.childCount - 1).tag == ("GreenBall"))
                {
                    score = score + 10;
                }
                else
                {
                    score = score - 5;
                }
            }

            if (other.gameObject.CompareTag("RedTable"))
            {
                transform.GetChild(3).transform.parent = other.gameObject.transform;
                if (other.gameObject.transform.GetChild(other.gameObject.transform.childCount - 1).tag == ("RedBall"))
                {
                    score = score + 10;
                }
                else
                {
                    score = score - 5;
                }
            }
        }
    }
}
