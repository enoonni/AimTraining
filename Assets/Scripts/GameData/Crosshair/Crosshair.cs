using Unity.VisualScripting;
using UnityEngine;

namespace GameData
{
    public class Crosshair
    {
        public float SizeLength {get; private set;}
        public float SizeWidth {get; private set;}

        private float _defaultSizeLength = 3f;
        private float _defaultSizeWidth = 0.5f;

        public Crosshair()
        {
            if(PlayerPrefs.HasKey("CrosshairSizeLength"))
            {
                SizeLength = PlayerPrefs.GetFloat("CrosshairSizeLength");
                SizeWidth = PlayerPrefs.GetFloat("CrosshairSizeWidth");
            }
            else
            {
                SizeLength = _defaultSizeLength;
                SizeWidth = _defaultSizeWidth;

                SaveSettings();
            }
        }

        private void SaveSettings()
        {
            PlayerPrefs.SetFloat("CrosshairSizeLength", SizeLength);
            PlayerPrefs.SetFloat("CrosshairSizeWidth", SizeWidth);
        }

        public void SaveSize(float length, float width)
        {
            SizeLength = length;
            SizeWidth = width;

            SaveSettings();
        }
    }
}