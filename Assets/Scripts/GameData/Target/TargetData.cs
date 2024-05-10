using UnityEngine;

namespace GameData
{

    public class TargetData
    {
        /*
                        Size variables
        */

        public float SizeTarget{get; private set;}
        public float SizeFrame{get; private set;}

        private const float _defaultSizeTarget = 0.8f;
        private const float _defaultSizeFrame = 0.2f;

        /*
                        Color variables
        */
        
        public float ColorRedTarget{get; private set;}
        public float ColorGreenTarget{get; private set;}
        public float ColorBlueTarget{get; private set;}

        public float ColorRedFrame{get; private set;}
        public float ColorGreenFrame{get; private set;}
        public float ColorBlueFrame{get; private set;}

        private const float _defaultColorRedTarget = 1;
        private const float _defaultColorGreenTarget = 1;
        private const float _defaultColorBlueTarget = 1;

        private const float _defaultColorRedFrame = 0;
        private const float _defaultColorGreenFrame = 0;
        private const float _defaultColorBlueFrame = 1;

        public TargetData()
        {
            if(PlayerPrefs.HasKey("TargetSizeTarget") && PlayerPrefs.HasKey("TargetSizeFrame"))
            {
                SizeTarget = PlayerPrefs.GetFloat("TargetSizeTarget");
                SizeFrame = PlayerPrefs.GetFloat("TargetSizeFrame");
            }
            else
            {
                SizeTarget = _defaultSizeTarget;
                SizeFrame = _defaultSizeFrame;

                SaveSizeSettings();
            }
        }

        /*
                        Size methods
        */

        private void SaveSizeSettings()
        {
            PlayerPrefs.SetFloat("TargetSizeTarget", SizeTarget);
            PlayerPrefs.SetFloat("TargetSizeFrame", SizeFrame);
        }

        public void SaveSize(float sizeTarget, float sizeFrame)
        {
            SizeTarget = sizeTarget;
            SizeFrame = sizeFrame;

            SaveSizeSettings();
        }

        /*
                        Color methods
        */

        private void SaveColorTargetSettings()
        {
            PlayerPrefs.SetFloat("ColorRedTarget", ColorRedTarget);
            PlayerPrefs.SetFloat("ColorGreenTarget", ColorGreenTarget);
            PlayerPrefs.SetFloat("ColorBlueTarget", ColorBlueTarget);

            SaveColorTargetSettings();
        }

        public void SaveColorTarget(float red, float green, float blue)
        {
            ColorRedTarget = red;
            ColorGreenTarget = green;
            ColorBlueTarget = blue;
        }

        private void SaveColorFrameSettings()
        {
            PlayerPrefs.SetFloat("ColorRedFrame", ColorRedFrame);
            PlayerPrefs.SetFloat("ColorGreenFrame", ColorGreenFrame);
            PlayerPrefs.SetFloat("ColorBlueFrame", ColorBlueFrame);
        }

        public void SaveColorFrame(float red, float green, float blue)
        {
            ColorRedFrame = red;
            ColorGreenFrame = green;
            ColorBlueFrame = blue;

            SaveColorFrameSettings();
        }
    }
}
