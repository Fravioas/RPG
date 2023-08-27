using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Fravio
{
    public class MagikaBar : MonoBehaviour
    {
        public Slider slider;

        private void Start() 
        {
            slider = GetComponent<Slider>();
        }

        public void SetMaxMagika(int maxMagika)
        {
            slider.maxValue = maxMagika;
            slider.value = maxMagika;
        }

        public void SetCurrentMagika(int currentMagika)
        {
            slider.value = currentMagika;
        }
    }
}
