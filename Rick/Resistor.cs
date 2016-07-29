using System;

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

        public long Resistance()
        {
            // Handle a zero-ohm resistor specially.
            if (IsZeroOhmResistor)
            {
                return 0;
            }

            ValidateSignificantFigureBands();

            var significantFigures = 10 * FirstSignificantDigit + SecondSignificantDigit;

            if (_bandCColor == BandColor.Gold)
            {
                throw new ResistorException(
                    string.Format("Non-integral resistance with significant figures '{0}' and multiplier band '{1}'.",
                        significantFigures, _bandCColor));
            }

            var value = significantFigures * Multiplier;

            return value;
        }

        private void ValidateSignificantFigureBands()
        {
            MustHaveSiignificantFigureBandLabeled(_bandAColor, "A");
            MustHaveSiignificantFigureBandLabeled(_bandBColor, "B");

            if (_bandAColor == BandColor.Gold || _bandAColor == BandColor.Silver)
            {
                throw new ResistorException(
                    string.Format("Cannot convert a {0} A band to a significant figure.",
                        _bandAColor.ToString().ToLowerInvariant()));
            }
        }

        private static void MustHaveSiignificantFigureBandLabeled(BandColor bandColor, string invalidBand)
        {
            if (bandColor == BandColor.None)
            {
                throw new ResistorException(string.Format("Significant figure band {0} not present.", invalidBand));
            }
        }

        private long Multiplier
        {
            // Using the Math library (which uses double precision arithmetic) may not be the most efficient method
            // to calculate integral powers of 10, but it suffices for this problem.
            get
            {
                return (long) Math.Pow(10, (int) _bandCColor);
            }
        }

        private int SecondSignificantDigit
        {
            get { return (int) _bandBColor; }
        }

        private int FirstSignificantDigit
        {
            get { return (int) _bandAColor; }
        }

        private bool IsZeroOhmResistor
        {
            get { return _bandAColor == BandColor.Black && _bandBColor == BandColor.None && _bandCColor == BandColor.None; }
        }
    }
}