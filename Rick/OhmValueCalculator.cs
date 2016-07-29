namespace Rick
{
    /// <summary>
    /// Satisfies the needs of the web application UI by implementing <see cref="IOhmValueCalculator"/>.
    /// </summary>
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
            return resistor.Resistance();
        }
    }
}