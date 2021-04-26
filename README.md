## UnityTextI18n

Simply localize text based on the `Resources/i18n/` folder in your Unity project.

### How To Use:

1. Create a `Resources/i18n` directory in your assets dir.

2. Create a file based on the language that you are going to use, this is an `en.txt` file.

```text
# Comments start with #
#
# Empty lines are ignored.
# key = text can go here along the entire line

sample.text = This is a sample text that will appear in the text area. 
```

3. Create a `I18NText.cs` script that can be used within Unity to use this, probably will be removed later.

```c#
using UnityEngine;
using UnityEngine.UI;
using UnityTextI18n;

public class I18NText : MonoBehaviour
{
    [SerializeField] private string textId = default;

    private void Start()
    {
        var text = GetComponent<Text>();
        if (text == null) return;

        text.text = textId == "ISOCode" ? I18N.GetLanguageCode() : I18N.Language[textId];
    }
}
```

### Future of this package:
One of the ideas is to have a `.dll` for each version after version `2019.4.8f1` (LTS only).