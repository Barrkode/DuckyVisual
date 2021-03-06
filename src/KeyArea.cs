﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckyVisual
{
    class KeyArea
    {
        private Dictionary<string, Color> KeyMap = new Dictionary<string, Color>();
        private readonly string HexProp;

        public KeyArea(Dictionary<string, Color> keyMap, string hexProp)
        {
            KeyMap = keyMap;
            HexProp = hexProp;
        }

        public void ColorKey(string key, Color color)
        {
            if (KeyMap.ContainsKey(key))
                KeyMap[key] = color;
        }

        public void ColorAllKeys(Color color)
        {
            foreach (var key in KeyMap.Keys.ToList())
            {
                KeyMap[key] = color;
            }
        }

        public String GetHexDataProp()
        {
            string data = HexProp;
            foreach (KeyValuePair<string, Color> entry in KeyMap)
            {
                data = data.Replace(entry.Key, entry.Value.GetHexString());
            }
            data = data.Replace(" ", "");
            return data;
        }
    }
}
