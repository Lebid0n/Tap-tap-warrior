using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CliclEvent : MonoBehaviour
{
    [SerializeField] int money;

    public void ClickEvent()
    {
        money++;
    }
}
