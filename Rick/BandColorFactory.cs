using System;
using System.Collections.Generic;

namespace Rick
{
    /// <summary>
    /// Factory for creating <see cref="BandColor"/> instances.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Again, for this exercise, this class is probably too much. However, in a broader application, it would be 
    /// more appropriate.
    /// </para>
    /// <para>
    /// I could have used the .NET method `Enum.Parse(BandColor, string)`; however, although this method might be more
    /// performant, it requires a reader to be familar with details like this method accepts not only the string name
    /// of the enumeration but it also accepts the string representation of the integer equivalent of the value. To
    /// avoid both me and others needing to remember these details, I opted to simply look up the lower case string
    /// names of the enumeration.
    /// more appropriate.
    /// </para>
    /// </remarks>
    public static class BandColorFactory
    {
        private static readonly Dictionary<string, BandColor> TextBandColorMap = new Dictionary<string, BandColor>
        {
            {"black", BandColor.Black},
            {"brown", BandColor.Brown},
            {"red", BandColor.Red},
            {"orange", BandColor.Orange},
            {"yellow", BandColor.Yellow},
            {"green", BandColor.Green},
            {"blue", BandColor.Blue},
            {"violet", BandColor.Violet},
            {"gray", BandColor.Gray},
            {"white", BandColor.White},
            {"gold", BandColor.Gold},
            {"silver", BandColor.Silver},
            {"none", BandColor.None}
        };

        /// <summary>
        /// Converts a <see cref="String"/> to a <see cref="BandColor"/>.
        /// </summary>
        /// <param name="colorText">
        /// The text to convert.
        /// </param>
        /// <returns>
        /// The <see cref="BandColor"/> corresponding to <paramref name="colorText"/>. Empty strings or strings 
        /// consisting only of whitespace return <see cref="BandColor.None"/>. However, I consider a null value to be 
        /// an error because it is too easy in .NET to create a <code>null</code> value.
        /// </returns>
        public static BandColor FromText(string colorText)
        {
            if (colorText == null)
            {
                throw new BandColorConversionException("Cannot convert `null` value to `BandColor`.");
            }

            if (string.IsNullOrWhiteSpace(colorText))
            {
                return BandColor.None;
            }

            return TextBandColorMap[colorText.ToLowerInvariant()];
        }
    }
}