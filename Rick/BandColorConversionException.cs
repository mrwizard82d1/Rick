using System;

namespace Rick
{
    /// <summary>
    /// Exceptions raised in converting <see cref="String"/>s to <see cref="BandColor"/>s.
    /// </summary>
    /// <remarks>
    /// Instead of using system exceptions, I prefer to return more specific classes.
    /// </remarks>
    public class BandColorConversionException : Exception
    {
        public BandColorConversionException(string message) : base(message) { }
    }
}