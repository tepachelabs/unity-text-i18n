using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityTextI18n
{
    public class I18N
    {
        public static Dictionary<string, string> Language { get; private set; }

        static I18N()
        {
            LoadLanguage();
        }

        private static void LoadLanguage()
        {
            if (Language == null)
            {
                Language = new Dictionary<string, string>();
            }

            var languageCode = GetLanguageCode();
            var languageTextAsset = Resources.Load(@"i18n/" + languageCode);
            if (languageTextAsset == null)
            {
                Debug.LogError("File not found for I18n: Assets/Resources/i18n/" + languageCode +
                               ".txt, using english as default");
                languageTextAsset = Resources.Load(@"i18n/en"); // fallback to english
            }

            var textFileLines = ((TextAsset) languageTextAsset).text;
            var lines = textFileLines.Split(new[] {"\r\n", "\n"}, StringSplitOptions.None);
            foreach (var line in lines)
            {
                if (line.IndexOf("=", StringComparison.Ordinal) < 0 || line.StartsWith("#")) continue;

                var key = line.Substring(0, line.IndexOf("=", StringComparison.Ordinal));
                var value = line.Substring(line.IndexOf("=", StringComparison.Ordinal) + 1,
                    line.Length - line.IndexOf("=", StringComparison.Ordinal) - 1).Replace("\\n", Environment.NewLine);
                Language.Add(key.TrimEnd(), value);
            }
        }

        public static string GetLanguageCode()
        {
            return TwoLetterIsoCodeFromSystemLanguage().ToLower();
        }

        private static string TwoLetterIsoCodeFromSystemLanguage()
        {
            var lang = Application.systemLanguage;

            var res = string.Empty;

            switch (lang)
            {
                case SystemLanguage.Spanish:
                    res = "ES";
                    break;
                case SystemLanguage.Unknown:
                    res = "EN";
                    break;
                case SystemLanguage.Afrikaans:
                    break;
                case SystemLanguage.Arabic:
                    break;
                case SystemLanguage.Basque:
                    break;
                case SystemLanguage.Belarusian:
                    break;
                case SystemLanguage.Bulgarian:
                    break;
                case SystemLanguage.Catalan:
                    break;
                case SystemLanguage.Chinese:
                    break;
                case SystemLanguage.Czech:
                    break;
                case SystemLanguage.Danish:
                    break;
                case SystemLanguage.Dutch:
                    break;
                case SystemLanguage.English:
                    break;
                case SystemLanguage.Estonian:
                    break;
                case SystemLanguage.Faroese:
                    break;
                case SystemLanguage.Finnish:
                    break;
                case SystemLanguage.French:
                    break;
                case SystemLanguage.German:
                    break;
                case SystemLanguage.Greek:
                    break;
                case SystemLanguage.Hebrew:
                    break;
                case SystemLanguage.Hungarian:
                    break;
                case SystemLanguage.Icelandic:
                    break;
                case SystemLanguage.Indonesian:
                    break;
                case SystemLanguage.Italian:
                    break;
                case SystemLanguage.Japanese:
                    break;
                case SystemLanguage.Korean:
                    break;
                case SystemLanguage.Latvian:
                    break;
                case SystemLanguage.Lithuanian:
                    break;
                case SystemLanguage.Norwegian:
                    break;
                case SystemLanguage.Polish:
                    break;
                case SystemLanguage.Portuguese:
                    break;
                case SystemLanguage.Romanian:
                    break;
                case SystemLanguage.Russian:
                    break;
                case SystemLanguage.SerboCroatian:
                    break;
                case SystemLanguage.Slovak:
                    break;
                case SystemLanguage.Slovenian:
                    break;
                case SystemLanguage.Swedish:
                    break;
                case SystemLanguage.Thai:
                    break;
                case SystemLanguage.Turkish:
                    break;
                case SystemLanguage.Ukrainian:
                    break;
                case SystemLanguage.Vietnamese:
                    break;
                case SystemLanguage.ChineseSimplified:
                    break;
                case SystemLanguage.ChineseTraditional:
                    break;
                default:
                    return null;
            }

            return res;
        }
    }
}