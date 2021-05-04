using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityTextI18n
{
    [RequireComponent(typeof(Text))]
    [AddComponentMenu("UI/I18NText", 10)]
    public class I18NText : MonoBehaviour
    {
        private const string TranslationIdNotFoundInTheI18NOptions = "translationId not found in the i18n resource file";
        
        [SerializeField] protected string translationId = string.Empty;
        private void Start()
        {
            var text = GetComponent<Text>();
            if (text == null) return;
            
            if (!I18N.Language.ContainsKey(translationId))
            {
                throw new NotSupportedException(TranslationIdNotFoundInTheI18NOptions);
            }
            
            Translate(text);
        }

        private void Translate(Text textComponent)
        {
            textComponent.text = translationId == string.Empty ? 
                I18N.GetLanguageCode() : I18N.Language[translationId];
        }
    }
}