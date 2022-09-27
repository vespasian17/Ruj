using UnityEngine;

[CreateAssetMenu(fileName = "PersonConfig", menuName = "ScriptableObjects/PersonConfig", order = 1)]
public class PersonConfig : ScriptableObject
{
    [field: SerializeField] public Sprite DefaultPersonImage { get; private set; }
    [field: SerializeField] public Sprite AngryPersonImage  { get; private set; }
    [field: SerializeField] public Sprite HornyPersonImage  { get; private set; }
    [field: SerializeField] public Sprite HappyPersonImage  { get; private set; }
    [field: SerializeField] public Sprite SadPersonImage  { get; private set; }
    [field: SerializeField] public Sprite FearPersonImage  { get; private set; }
    [field: SerializeField] public string PersonName  { get; private set; }
    [field: SerializeField] public string PersonDescription  { get; private set; }
    [field: SerializeField] public Color PersonNameColor  { get; private set; }
}
