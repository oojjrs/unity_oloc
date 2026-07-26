using UnityEngine;

namespace oojjrs.oloc
{
    [CreateAssetMenu(fileName = "CountryFlagCollection", menuName = "Oloc/Country Flag Collection")]
    public sealed class CountryFlagCollection : ScriptableObject
    {
        public Sprite[] Sprites;
    }
}
