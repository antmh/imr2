using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HoopColliderBehaviour : MonoBehaviour
{
    public TextMeshPro textMesh;
    private int score = 0;

    private void OnTriggerExit(Collider other)
    {
        ++score;
        textMesh.text = "Score: " + score;
    }
}
