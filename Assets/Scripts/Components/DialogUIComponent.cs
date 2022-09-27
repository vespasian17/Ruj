using System.Collections;
using System.Collections.Generic;
using Assets.SimpleLocalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogUIComponent : MonoBehaviour
{
    [field:SerializeField] public LocalizedText NameLocalizeText { get; private set; }
    [field:SerializeField] public TextMeshProUGUI NameText { get; private set; }
    [field:SerializeField] public LocalizedText MessageLocalizeText { get; private set; }
    [field:SerializeField] public LocalizedText DescriptionLocalizeText { get; private set; }
    [field:SerializeField] public Image PersonImage { get; private set; }
    [field:SerializeField] public Button NextMessageButton { get; private set; }
}
