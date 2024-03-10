using System.Runtime.CompilerServices;
using UnityEngine;

namespace ColorObject
{
    /// <summary>
    /// treat a struct 'UnityEngine.Color' as if it were a 'UnityEngine.Object'.
    /// </summary>
    public sealed class ColorObject : ScriptableObject
    {
        public Color Color = default;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Color(ColorObject clo)
        {
            return clo.Color;
        }
    }
}
