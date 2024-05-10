using UnityEngine;

namespace GameData
{
    public class CrosshairData
    {
        /*
                        Size variables
        */

        public float SizeLength {get; private set;}
        public float SizeWidth {get; private set;}

        private const float _defaultSizeLength = 3f;
        private const float _defaultSizeWidth = 0.5f;

        /*
                        Color variables
        */

        public float ColorRed {get; private set;}
        public float ColorGreen {get; private set;}
        public float ColorBlue {get; private set;}

        private const float _defaultColorRed = 0;
        private const float _defaultColorGreen = 0;
        private const float _defaultColorBlue = 0;


        public CrosshairData()
        {
            if(PlayerPrefs.HasKey("CrosshairSizeLength") && PlayerPrefs.HasKey("CrosshairSizeWidth"))
            {
                SizeLength = PlayerPrefs.GetFloat("CrosshairSizeLength");
                SizeWidth = PlayerPrefs.GetFloat("CrosshairSizeWidth");
            }
            else
            {
                SizeLength = _defaultSizeLength;
                SizeWidth = _defaultSizeWidth;

                SaveSizeSettings();
            }
            if(PlayerPrefs.HasKey("CrosshairColorRed") && PlayerPrefs.HasKey("CrosshairColorRed") && PlayerPrefs.HasKey("CrosshairColorRed"))
            {
                ColorRed = PlayerPrefs.GetFloat("CrosshairColorRed");
                ColorGreen = PlayerPrefs.GetFloat("CrosshairColorGreen");
                ColorBlue = PlayerPrefs.GetFloat("CrosshairColorBlue");
            }
            else
            {
                ColorRed = _defaultColorRed;
                ColorGreen = _defaultColorGreen;
                ColorBlue = _defaultColorBlue;

                SaveColorSettings();
            }
        }

        /*
                        Size methods
        */

        private void SaveSizeSettings()
        {
            PlayerPrefs.SetFloat("CrosshairSizeLength", SizeLength);
            PlayerPrefs.SetFloat("CrosshairSizeWidth", SizeWidth);
        }

        public void SaveSize(float length, float width)
        {
            SizeLength = length;
            SizeWidth = width;

            SaveSizeSettings();
        }

        /*
                        Color methods
        */

        private void SaveColorSettings()
        {
            PlayerPrefs.SetFloat("CrosshairColorRed", ColorRed);
            PlayerPrefs.SetFloat("CrosshairColorGreen", ColorGreen);
            PlayerPrefs.SetFloat("CrosshairColorBlue", ColorBlue);
        }

        public void SaveColor(float red, float green, float blue)
        {
            ColorRed = red;
            ColorGreen = green;
            ColorBlue = blue;

            SaveColorSettings();
        }
    }
}