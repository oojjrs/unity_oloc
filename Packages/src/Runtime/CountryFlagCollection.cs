using UnityEngine;
using UnityEngine.U2D;

namespace Oojjrs.Oloc
{
    [CreateAssetMenu(fileName = "CountryFlagCollection", menuName = "Oojjrs/Oloc/Country Flag Collection")]
    public sealed class CountryFlagCollection : ScriptableObject
    {
        [SerializeField]
        private SpriteAtlas atlas;

        [SerializeField]
        private Sprite[] sprites;

        public SpriteAtlas Atlas => atlas;

        public Sprite[] Sprites => sprites;
    }
}
