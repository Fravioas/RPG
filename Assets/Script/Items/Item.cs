using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fravio
{
   public class Item : ScriptableObject
    {
        [Header("Informação do item")]
        public Sprite itemIcon;
        public string itemName;
    }
}
