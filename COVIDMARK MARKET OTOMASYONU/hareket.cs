//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COVIDMARK_MARKET_OTOMASYONU
{
    using System;
    using System.Collections.Generic;
    
    public partial class hareket
    {
        public int hareketID { get; set; }
        public string hareketBirim { get; set; }
        public string hareketTuru { get; set; }
        public byte gelenAdet { get; set; }
        public byte gidenAdet { get; set; }
        public short kalanAdet { get; set; }
        public System.DateTime hareketTarih { get; set; }
    }
}
