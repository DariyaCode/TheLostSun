using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "New/ New Dialog Sprite")]
/// <summary>
/// This is used to hold the sprite along with scale information
/// This can be used over and over again inside the performer class
/// </summary>
public class DialogSprite : ScriptableObject {

    public Sprite sprite;
}
