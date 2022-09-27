using System;
using UnityEngine;

[CreateAssetMenu(fileName = "PersonConfig", menuName = "Configs/PersonConfig")]
public class PersonConfig : ScriptableObject
{
    [field: SerializeField] public SpriteInfo[] SpriteInfos { get; private set; }
    [field: SerializeField] public string PersonNameKey  { get; private set; }
    [field: SerializeField] public string PersonDescriptionKey  { get; private set; }
    [field: SerializeField] public Color PersonNameColor  { get; private set; }

    [Serializable]
    public class SpriteInfo
    {
        [field: SerializeField] public PersonSpriteType Type { get; private set; }
        [field: SerializeField] public Sprite Sprite { get; private set; }
    }
}
