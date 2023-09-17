using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
/// <summary>
/// This class makes up the on screen people (or items)
/// </summary>
public class DialogFrame  {
    
    public DialogSprite dialogSprite;
    /// <summary>
    /// Hold on screen position
    /// </summary>
    public RectTransform transform;
    /// <summary>In case we need to resolve z pos</summary>
    public int order;

}

