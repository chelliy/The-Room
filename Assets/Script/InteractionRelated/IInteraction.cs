using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteraction
{
    public bool interactable { get; }
    public float interaction(playerCam player);
}
