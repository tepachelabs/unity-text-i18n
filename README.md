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

3. Add a `Text` component and add the component `I18NText` from the `UI` context menu.

![i18ntext component][component_image]

### Future of this package:
- One of the ideas is to have a `.dll` for each version after version `2019.4.8f1` (LTS only).
- Add an editor in unity for all the values

[component_image]: https://i.imgur.com/qieCZ4b.png