﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NearestColorUWPApp1.Helper
{
    public class ColorHelper
    {
        public static Vector3 GetSystemDrawingColorFromHexString(string hexString)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(hexString, @"[#]([0-9]|[a-f]|[A-F]){6}\b"))
                throw new ArgumentException();
            int red = int.Parse(hexString.Substring(1, 2), NumberStyles.HexNumber);
            int green = int.Parse(hexString.Substring(3, 2), NumberStyles.HexNumber);
            int blue = int.Parse(hexString.Substring(5, 2), NumberStyles.HexNumber);
            return new Vector3(red, green, blue);
        }

        public static string GetNearestColorName(Vector3 vect)
        {
            var cr = GetClosestColor(GetColorReferences(), vect);
            if( cr != null )
            {
                return cr.Name;
            }
            else
                return string.Empty;
        }

        private static ColorReference GetClosestColor(ColorReference[] colorReferences, Vector3 currentColor)
        {
            ColorReference tMin = null;
            float minDist = float.PositiveInfinity;

            foreach (ColorReference t in colorReferences)
            {
                float dist = Vector3.Distance(t.Argb, currentColor);
                if (dist < minDist)
                {
                    tMin = t;
                    minDist = dist;
                }
            }
            return tMin;
        }

        private static ColorReference[] GetColorReferences()
        {
            return new ColorReference[] {
                new ColorReference() { Name="AliceBlue", Argb=new Vector3 (
new ColorReference() { Name="LightSalmon", Argb=new Vector3 (
new ColorReference() { Name="AntiqueWhite", Argb=new Vector3 (
new ColorReference() { Name="LightSeaGreen", Argb=new Vector3 (
new ColorReference() { Name="Aqua", Argb=new Vector3 (
new ColorReference() { Name="LightSkyBlue", Argb=new Vector3 (
new ColorReference() { Name="Aquamarine", Argb=new Vector3 (
new ColorReference() { Name="LightSlateGray", Argb=new Vector3 (
new ColorReference() { Name="Azure", Argb=new Vector3 (
new ColorReference() { Name="LightSteelBlue", Argb=new Vector3 (
new ColorReference() { Name="Beige", Argb=new Vector3 (
new ColorReference() { Name="LightYellow", Argb=new Vector3 (
new ColorReference() { Name="Bisque", Argb=new Vector3 (
new ColorReference() { Name="Lime", Argb=new Vector3 (
new ColorReference() { Name="Black", Argb=new Vector3 (
new ColorReference() { Name="LimeGreen", Argb=new Vector3 (
new ColorReference() { Name="BlanchedAlmond", Argb=new Vector3 (
new ColorReference() { Name="Linen", Argb=new Vector3 (
new ColorReference() { Name="Blue", Argb=new Vector3 (
new ColorReference() { Name="Magenta", Argb=new Vector3 (
new ColorReference() { Name="BlueViolet", Argb=new Vector3 (
new ColorReference() { Name="Maroon", Argb=new Vector3 (
new ColorReference() { Name="Brown", Argb=new Vector3 (
new ColorReference() { Name="MediumAquamarine", Argb=new Vector3 (
new ColorReference() { Name="BurlyWood", Argb=new Vector3 (
new ColorReference() { Name="MediumBlue", Argb=new Vector3 (
new ColorReference() { Name="CadetBlue", Argb=new Vector3 (
new ColorReference() { Name="MediumOrchid", Argb=new Vector3 (
new ColorReference() { Name="Chartreuse", Argb=new Vector3 (
new ColorReference() { Name="MediumPurple", Argb=new Vector3 (
new ColorReference() { Name="Chocolate", Argb=new Vector3 (
new ColorReference() { Name="MediumSeaGreen", Argb=new Vector3 (
new ColorReference() { Name="Coral", Argb=new Vector3 (
new ColorReference() { Name="MediumSlateBlue", Argb=new Vector3 (
new ColorReference() { Name="CornflowerBlue", Argb=new Vector3 (
new ColorReference() { Name="MediumSpringGreen", Argb=new Vector3 (
new ColorReference() { Name="Cornsilk", Argb=new Vector3 (
new ColorReference() { Name="MediumTurquoise", Argb=new Vector3 (
new ColorReference() { Name="Crimson", Argb=new Vector3 (
new ColorReference() { Name="MediumVioletRed", Argb=new Vector3 (
new ColorReference() { Name="Cyan", Argb=new Vector3 (
new ColorReference() { Name="MidnightBlue", Argb=new Vector3 (
new ColorReference() { Name="DarkBlue", Argb=new Vector3 (
new ColorReference() { Name="MintCream", Argb=new Vector3 (
new ColorReference() { Name="DarkCyan", Argb=new Vector3 (
new ColorReference() { Name="MistyRose", Argb=new Vector3 (
new ColorReference() { Name="DarkGoldenrod", Argb=new Vector3 (
new ColorReference() { Name="Moccasin", Argb=new Vector3 (
new ColorReference() { Name="DarkGray", Argb=new Vector3 (
new ColorReference() { Name="NavajoWhite", Argb=new Vector3 (
new ColorReference() { Name="DarkGreen", Argb=new Vector3 (
new ColorReference() { Name="Navy", Argb=new Vector3 (
new ColorReference() { Name="DarkKhaki", Argb=new Vector3 (
new ColorReference() { Name="OldLace", Argb=new Vector3 (
new ColorReference() { Name="DarkMagena", Argb=new Vector3 (
new ColorReference() { Name="Olive", Argb=new Vector3 (
new ColorReference() { Name="DarkOliveGreen", Argb=new Vector3 (
new ColorReference() { Name="OliveDrab", Argb=new Vector3 (
new ColorReference() { Name="DarkOrange", Argb=new Vector3 (
new ColorReference() { Name="Orange", Argb=new Vector3 (
new ColorReference() { Name="DarkOrchid", Argb=new Vector3 (
new ColorReference() { Name="OrangeRed", Argb=new Vector3 (
new ColorReference() { Name="DarkRed", Argb=new Vector3 (
new ColorReference() { Name="Orchid", Argb=new Vector3 (
new ColorReference() { Name="DarkSalmon", Argb=new Vector3 (
new ColorReference() { Name="PaleGoldenrod", Argb=new Vector3 (
new ColorReference() { Name="DarkSeaGreen", Argb=new Vector3 (
new ColorReference() { Name="PaleGreen", Argb=new Vector3 (
new ColorReference() { Name="DarkSlateBlue", Argb=new Vector3 (
new ColorReference() { Name="PaleTurquoise", Argb=new Vector3 (
new ColorReference() { Name="DarkSlateGray", Argb=new Vector3 (
new ColorReference() { Name="PaleVioletRed", Argb=new Vector3 (
new ColorReference() { Name="DarkTurquoise", Argb=new Vector3 (
new ColorReference() { Name="PapayaWhip", Argb=new Vector3 (
new ColorReference() { Name="DarkViolet", Argb=new Vector3 (
new ColorReference() { Name="PeachPuff", Argb=new Vector3 (
new ColorReference() { Name="DeepPink", Argb=new Vector3 (
new ColorReference() { Name="Peru", Argb=new Vector3 (
new ColorReference() { Name="DeepSkyBlue", Argb=new Vector3 (
new ColorReference() { Name="Pink", Argb=new Vector3 (
new ColorReference() { Name="DimGray", Argb=new Vector3 (
new ColorReference() { Name="Plum", Argb=new Vector3 (
new ColorReference() { Name="DodgerBlue", Argb=new Vector3 (
new ColorReference() { Name="PowderBlue", Argb=new Vector3 (
new ColorReference() { Name="Firebrick", Argb=new Vector3 (
new ColorReference() { Name="Purple", Argb=new Vector3 (
new ColorReference() { Name="FloralWhite", Argb=new Vector3 (
new ColorReference() { Name="Red", Argb=new Vector3 (
new ColorReference() { Name="ForestGreen", Argb=new Vector3 (
new ColorReference() { Name="RosyBrown", Argb=new Vector3 (
new ColorReference() { Name="Fuschia", Argb=new Vector3 (
new ColorReference() { Name="RoyalBlue", Argb=new Vector3 (
new ColorReference() { Name="Gainsboro", Argb=new Vector3 (
new ColorReference() { Name="SaddleBrown", Argb=new Vector3 (
new ColorReference() { Name="GhostWhite", Argb=new Vector3 (
new ColorReference() { Name="Salmon", Argb=new Vector3 (
new ColorReference() { Name="Gold", Argb=new Vector3 (
new ColorReference() { Name="SandyBrown", Argb=new Vector3 (
new ColorReference() { Name="Goldenrod", Argb=new Vector3 (
new ColorReference() { Name="SeaGreen", Argb=new Vector3 (
new ColorReference() { Name="Gray", Argb=new Vector3 (
new ColorReference() { Name="Seashell", Argb=new Vector3 (
new ColorReference() { Name="Green", Argb=new Vector3 (
new ColorReference() { Name="Sienna", Argb=new Vector3 (
new ColorReference() { Name="GreenYellow", Argb=new Vector3 (
new ColorReference() { Name="Silver", Argb=new Vector3 (
new ColorReference() { Name="Honeydew", Argb=new Vector3 (
new ColorReference() { Name="SkyBlue", Argb=new Vector3 (
new ColorReference() { Name="HotPink", Argb=new Vector3 (
new ColorReference() { Name="SlateBlue", Argb=new Vector3 (
new ColorReference() { Name="IndianRed", Argb=new Vector3 (
new ColorReference() { Name="SlateGray", Argb=new Vector3 (
new ColorReference() { Name="Indigo", Argb=new Vector3 (
new ColorReference() { Name="Snow", Argb=new Vector3 (
new ColorReference() { Name="Ivory", Argb=new Vector3 (
new ColorReference() { Name="SpringGreen", Argb=new Vector3 (
new ColorReference() { Name="Khaki", Argb=new Vector3 (
new ColorReference() { Name="SteelBlue", Argb=new Vector3 (
new ColorReference() { Name="Lavender", Argb=new Vector3 (
new ColorReference() { Name="Tan", Argb=new Vector3 (
new ColorReference() { Name="LavenderBlush", Argb=new Vector3 (
new ColorReference() { Name="Teal", Argb=new Vector3 (
new ColorReference() { Name="LawnGreen", Argb=new Vector3 (
new ColorReference() { Name="Thistle", Argb=new Vector3 (
new ColorReference() { Name="LemonChiffon", Argb=new Vector3 (
new ColorReference() { Name="Tomato", Argb=new Vector3 (
new ColorReference() { Name="LightBlue", Argb=new Vector3 (
new ColorReference() { Name="Turquoise", Argb=new Vector3 (
new ColorReference() { Name="LightCoral", Argb=new Vector3 (
new ColorReference() { Name="Violet", Argb=new Vector3 (
new ColorReference() { Name="LightCyan", Argb=new Vector3 (
new ColorReference() { Name="Wheat", Argb=new Vector3 (
new ColorReference() { Name="LightGoldenrodYellow", Argb=new Vector3 (
new ColorReference() { Name="White", Argb=new Vector3 (
new ColorReference() { Name="LightGreen", Argb=new Vector3 (
new ColorReference() { Name="WhiteSmoke", Argb=new Vector3 (
new ColorReference() { Name="LightGray", Argb=new Vector3 (
new ColorReference() { Name="Yellow", Argb=new Vector3 (
new ColorReference() { Name="LightPink", Argb=new Vector3 (
new ColorReference() { Name="YellowGreen", Argb=new Vector3 (
            };
        }
    }
    
    public class ColorReference
    {
        public string Name { get; set; }
        public Vector3 Argb { get; set; }
    }
}