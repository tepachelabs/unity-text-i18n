using UnityEngine;
using UnityEngine.UI;

namespace UnityTextI18n
{
    public class I18NText : MonoBehaviour
    {
        [SerializeField] private string textId = default;

        private void Start()
        {
            var text = GetComponent<Text>();
            if (text == null) return;

            if (textId == "ISOCode")
            {
                text.text = I18N.GetLanguageCode();
            }
            else
            {
                text.text = I18N.Language[textId];
            }
        }
    }
}