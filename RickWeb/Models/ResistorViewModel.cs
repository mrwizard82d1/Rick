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
                            .Where(bc => bc != BandColor.None));
            }
        }

        public SelectList BandDColors
        {
            get { return new SelectList(Enum.GetValues(typeof(BandColor))); }
        }

        public string ResistanceText
        {
            get { return "0 ohms"; }
        }
    }
}