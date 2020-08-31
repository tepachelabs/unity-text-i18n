## UnityTextI18n

Simply localize text based on the `Resources/i18n/` folder in your Unity project.

One of the ideas is to have a `.dll` for each version after version `2019.4.8f1` (LTS only).

I include a default `I18NText.cs` script that can be used within Unity to use this, probably will be removed later.

```c#
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
```