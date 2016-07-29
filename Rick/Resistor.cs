namespace Rick
{
    /// <summary>
    /// Models a discrete resistor.
    /// </summary>
    /// <remarks>
    /// For simply calculating the resistance, this class is overkill. However, I envision that this application 
    /// eventually supports a QA technician being able to determine the nominal resistance and tolerance of a discrete
    /// resistor. If the QA tech performs tests on resistors, capacitors and other discrete components, having a
    /// <see cref="Resistor"/> class may make sense.
    /// </remarks> 
    public class Resistor
    {
        public Resistor(BandColor bandAColor, BandColor bandBColor, BandColor bandCColor, BandColor bandDColor)
        {
        }

        public int Resistance()
        {
            return 20;
        }
    }
}