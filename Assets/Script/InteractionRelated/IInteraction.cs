using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IInteraction
{
    public bool interactable { get; }
    public Text dialogue { get; }
    public float displayTime { get; }
    public float interaction(playerCam player);
    public void setDialogueInActive();
}
