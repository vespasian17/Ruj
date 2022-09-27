using System;
using System.Linq;
using UnityEngine;

namespace Configs
{
    [CreateAssetMenu(fileName = "DialogConfig", menuName = "Configs/DialogConfig")]
    public class DialogConfig : ScriptableObject
    {
        [field:SerializeField] public MessageInfo[] MessageInfos { get; private set; }

        public void GetMessageInfo(int indexMessage, out string personNameKey, out string personDescriptionKey, out Color personNameColor, out Sprite personSprite, out string messageKey)
        {
            personNameKey = null;
            personDescriptionKey = null;
            personNameColor = Color.white;
            personSprite = null;
            messageKey = null;
            
            var message = MessageInfos[indexMessage];
            var person = message.PersonConfig;

            if (message.PersonConfig != null)
            {
                personNameKey = message.PersonConfig.PersonNameKey;
                personDescriptionKey = message.PersonConfig.PersonDescriptionKey;
                personNameColor = message.PersonConfig.PersonNameColor;
                personSprite = person.SpriteInfos.First(x => x.Type == message.PersonSpriteType).Sprite;
                messageKey = message.Key;
            }
        }

        [Serializable]
        public class MessageInfo
        {
            [field:SerializeField] public PersonConfig PersonConfig { get; private set; }
            [field:SerializeField] public PersonSpriteType PersonSpriteType { get; private set; }
            [field: SerializeField] public string Key { get; private set; }
        }
    }
}