using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextHi : MonoBehaviour
{
    private TextMeshProUGUI hiText;

    private void Awake()
    {
        hiText = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        hiText.text = $"¡Hola, {DataPersistance.sharedInstance.userName}";
    }

}
