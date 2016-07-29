using System;
using System.Numerics;

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
        private readonly BandColor _bandAColor;
        private readonly BandColor _bandBColor;
        private readonly BandColor _bandCColor;
        // ReSharper disable once NotAccessedField.Local
        private BandColor _bandDColor;

        public Resistor(BandColor bandAColor, BandColor bandBColor, BandColor bandCColor, BandColor bandDColor)
        {
            _bandAColor = bandAColor;
            _bandBColor = bandBColor;
            _bandCColor = bandCColor;
            _bandDColor = bandDColor;
        }

        public int Resistance()
        {
            // Handle a zero-ohm resistor specially.
            if (_bandAColor == BandColor.Black && _bandBColor == BandColor.None && _bandCColor == BandColor.None)
            {
                return 0;
            }

            var significantDigits = 10 * (int) _bandAColor + (int) _bandBColor;

            // Using the Math library (which uses double precision arithmetic) may not be the most efficient method
            // to calculate integral powers of 10, but is suffices for this problem.
            var value = significantDigits * (long) Math.Pow(10, (int) _bandCColor);
            if (value > int.MaxValue)
            {
                throw new ResistorException(string.Format("Resistance '{0}' too large.", value));
            }
            return (int) value;
        }
    }
}