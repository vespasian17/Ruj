using Assets.SimpleLocalization;
using Configs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Systems
{
    public class DialogSystem : MonoBehaviour
    {
        [SerializeField] private DialogConfig debugDialog;

        private DialogUIComponent dialogComponent;
        private int currentMessageIndex;
        private DialogConfig currentDialog;

        private void Start()
        {
            dialogComponent = FindObjectOfType<DialogUIComponent>();
            
            SetDialog();
            dialogComponent.NextMessageButton.onClick.AddListener(SetCurrentMessage);
        }

        private void SetDialog()
        {
            currentDialog = debugDialog;
        }

        private void SetCurrentMessage()
        {
            currentMessageIndex++;
            currentDialog.GetMessageInfo(currentMessageIndex, out string nameKey, out string descriptionKey, out Color nameColor, out Sprite sprite, out string messageKey);
            
            dialogComponent.NameLocalizeText.LocalizeText(nameKey);
            dialogComponent.DescriptionLocalizeText.LocalizeText(descriptionKey);
            dialogComponent.MessageLocalizeText.LocalizeText(messageKey);
            
            dialogComponent.NameText.color = nameColor;
            dialogComponent.PersonImage.sprite = sprite;
        }
    }
}