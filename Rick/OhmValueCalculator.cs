namespace Rick
{
    /// <summary>
    /// Satisfies the needs of the web application UI by implementing <see cref="IOhmValueCalculator"/>.
    /// </summary>
    /// <raises>
    /// <see cref="ResistorException"/> when values are too large to be represented by <see cref="System.Int32"/>.
    /// </raises>
    /// <remarks>
    /// <para>
    /// This class plays the role of Facade in the Facade design pattern. It simplifies the domain interface so
    /// that the web application only needs call a single method in order to calculate the resistance of a resistor.
    /// </para>
    /// </remarks>
    public class OhmValueCalculator : IOhmValueCalculator
    {
        public int CalculateOhmValue(string bandAColorText, string bandBColorText, string bandCColorText,
            string bandDColorText)
        {
            var bandAColor = BandColorFactory.FromText(bandAColorText);
            var bandBColor = BandColorFactory.FromText(bandBColorText);
            var bandCColor = BandColorFactory.FromText(bandCColorText);
            var bandDColor = BandColorFactory.FromText(bandDColorText);

            var resistor = new Resistor(bandAColor, bandBColor, bandCColor, bandDColor);
            var resistance = resistor.Resistance();
            if (ValueTooBigForAnInteger(resistance))
            {
                throw new ResistorException(string.Format("Resistance '{0}' too large.", resistance));
            }

            return (int) resistance;
        }

        private static bool ValueTooBigForAnInteger(long value)
        {
            return value > int.MaxValue;
        }

    }
}