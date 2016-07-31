using System;
using System.Linq;
using System.Web.Mvc;
using Rick;

namespace RickWeb.Models
{
    public class ResistorViewModel
    {
        public ResistorViewModel()
        {
            BandAColor = BandColor.Black.ToString();
            BandBColor = BandColor.Black.ToString();
            BandCColor = BandColor.Black.ToString();
            BandDColor = BandColor.Black.ToString();
        }

        public string BandAColor { get; set; }
        public string BandBColor { get; set; }
        public string BandCColor { get; set; }
        public string BandDColor { get; set; }

        public SelectList BandAColors
        {
            get
            {
                return
                    new SelectList(
                        Enum.GetValues(typeof(BandColor))
                            .Cast<BandColor>()
                            .Where(bc => bc != BandColor.Gold)
                            .Where(bc => bc != BandColor.Silver)
                            .Where(bc => bc != BandColor.None));
            }
        }

        public SelectList BandBColors
        {
            get
            {
                return
                    new SelectList(
                        Enum.GetValues(typeof(BandColor))
                            .Cast<BandColor>()
                            .Where(bc => bc != BandColor.Gold)
                            .Where(bc => bc != BandColor.Silver)
                            .Where(bc => bc != BandColor.None));
            }
        }

        public SelectList BandCColors
        {
            get
            {
                return
                    new SelectList(
                        Enum.GetValues(typeof(BandColor))
                            .Cast<BandColor>()
                            // I filter out Gray, White, Gold and Silver because these multipliers may generate
                            // resistance values that are non-integral. Gray and White may generate values that require 
                            // a long to be represented correctly. Additionally, Gold and Silver may generate floating
                            // point values. The implementation of `IOhmValueCalculator`, `OhmValueCalculator`, 
                            // "handles" these situations by raising exceptions. Filtering these values out from the
                            // UI prevents the user from encountering them.
                            .Where(bc => bc != BandColor.Gray)
                            .Where(bc => bc != BandColor.White)
                            .Where(bc => bc != BandColor.Gold)
                            .Where(bc => bc != BandColor.Silver)
                            .Where(bc => bc != BandColor.None));
            }
        }

        public SelectList BandDColors
        {
            get { return new SelectList(Enum.GetValues(typeof(BandColor))); }
        }

        public int Resistance
        {
            get
            {
                var calculator = new OhmValueCalculator();
                return calculator.CalculateOhmValue(BandAColor, BandBColor, BandCColor, BandDColor);
            }
        }

        public string ResistanceText
        {
            get { return string.Format("{0} {1}", Resistance, (Resistance != 1 ? "ohms" : "ohm")); }
        }
    }
}