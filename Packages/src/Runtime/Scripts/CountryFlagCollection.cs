using System;
using UnityEngine;

namespace oojjrs.oloc
{
    [CreateAssetMenu(fileName = "CountryFlagCollection", menuName = "Oloc/Country Flag Collection")]
    public sealed class CountryFlagCollection : ScriptableObject
    {
        public Sprite[] Sprites;

        public Sprite GetFlagSprite(string countryOrLocaleCode)
        {
            if ((Sprites != null) && (string.IsNullOrWhiteSpace(countryOrLocaleCode) == false))
            {
                var countryCode = countryOrLocaleCode.Substring(Math.Max(countryOrLocaleCode.LastIndexOf('-'), countryOrLocaleCode.LastIndexOf('_')) + 1);
                foreach (var sprite in Sprites)
                {
                    if ((sprite != null) && string.Equals(sprite.name, countryCode, StringComparison.OrdinalIgnoreCase))
                        return sprite;
                }
            }

            return null;
        }
    }
}
