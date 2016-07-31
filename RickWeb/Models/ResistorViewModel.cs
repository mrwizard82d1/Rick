using System;
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
            get { return new SelectList(Enum.GetValues(typeof(BandColor))); }
        }

        public SelectList BandBColors
        {
            get { return new SelectList(Enum.GetValues(typeof(BandColor))); }
        }

        public SelectList BandCColors
        {
            get { return new SelectList(Enum.GetValues(typeof(BandColor))); }
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