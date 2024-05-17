using System;
using UnityEngine;
using GameData.Crosshair;

namespace Gameplay.Crosshair
{
    public class CrosshairSettings
    {
        private CrosshairData _crosshairData;

        private GameObject _horizontalLine;
        private GameObject _verticalLine;

        private SpriteRenderer _horizontalRenderer;
        private SpriteRenderer _verticalRenderer;

        public CrosshairSettings(GameObject horizontalLine, GameObject verticalLine)
        {
            _crosshairData = new CrosshairData();

            _horizontalLine = horizontalLine;
            _verticalLine = verticalLine;

            CrosshairSetSize();
            CrosshairSetColor();

            CrosshairData.OnSettingsChanged += ChangeCrosshair;

            _crosshairData.SaveSize(0.5f, 0.1f);
        }

        ~CrosshairSettings()
        {
            CrosshairData.OnSettingsChanged -= ChangeCrosshair;
        }
        
        private void CrosshairSetSize()
        {
            _horizontalLine.transform.localScale = new Vector3(_crosshairData.SizeLength, _crosshairData.SizeWidth);
            _verticalLine.transform.localScale = new Vector3(_crosshairData.SizeWidth, _crosshairData.SizeLength);
        }


        private void CrosshairSetColor()
        {
            _horizontalRenderer = _horizontalLine.GetComponent<SpriteRenderer>();
            _verticalRenderer = _verticalLine.GetComponent<SpriteRenderer>();

            _horizontalRenderer.color = new Color(_crosshairData.ColorRed, _crosshairData.ColorGreen, _crosshairData.ColorBlue);
            _verticalRenderer.color = new Color(_crosshairData.ColorRed, _crosshairData.ColorGreen, _crosshairData.ColorBlue);
        }

        private void ChangeCrosshair(object sender, EventArgs e)
        {
            CrosshairSetSize();
            CrosshairSetColor();
        }
    }
}
