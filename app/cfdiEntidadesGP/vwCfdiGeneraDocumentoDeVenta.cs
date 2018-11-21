//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cfdiEntidadesGP
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwCfdiGeneraDocumentoDeVenta
    {
        public string correlativo { get; set; }
        public short soptype { get; set; }
        public string sopnumbe { get; set; }
        public string serie { get; set; }
        public string numero { get; set; }
        public string tipoDocumento { get; set; }
        public string emisorTipoDoc { get; set; }
        public string emisorNroDoc { get; set; }
        public string emisorNombre { get; set; }
        public string emisorUbigeo { get; set; }
        public string emisorDireccion { get; set; }
        public string emisorUrbanizacion { get; set; }
        public string emisorDepartamento { get; set; }
        public string emisorProvincia { get; set; }
        public string emisorDistrito { get; set; }
        public string emisorCodPais { get; set; }
        public string receptorTipoDoc { get; set; }
        public string receptorNroDoc { get; set; }
        public string receptorNombre { get; set; }
        public string emailTo { get; set; }
        public Nullable<int> send_email_statements { get; set; }
        public string idDocumento { get; set; }
        public System.DateTime fechaEmision { get; set; }
        public string horaEmision { get; set; }
        public System.DateTime fechaVencimiento { get; set; }
        public string moneda { get; set; }
        public string tipoOperacion { get; set; }
        public decimal xchgrate { get; set; }
        public decimal descuentoGlobalMonto { get; set; }
        public decimal descuentoGlobalImponible { get; set; }
        public Nullable<decimal> descuentoGlobalPorcentaje { get; set; }
        public string codigoDetraccion { get; set; }
        public Nullable<decimal> porcentajeDetraccion { get; set; }
        public Nullable<decimal> montoDetraccion { get; set; }
        public string codleyendaDetraccion { get; set; }
        public string numCuentaBancoNacion { get; set; }
        public string medioPagoDetraccion { get; set; }
        public decimal montoTotalVenta { get; set; }
        public decimal montoTotalImpuestos { get; set; }
        public Nullable<decimal> montoSubtotalValorVenta { get; set; }
        public Nullable<decimal> montoTotalDescuentosPorItem { get; set; }
        public decimal montoTotalImpuOperGratuitas { get; set; }
        public decimal montoTotalIgv { get; set; }
        public decimal montoSubtotalIvaImponible { get; set; }
        public decimal montoSubtotalExonerado { get; set; }
        public decimal montoSubtotalExportacion { get; set; }
        public decimal montoSubtotalGratuito { get; set; }
        public decimal montoSubtotalInafecto { get; set; }
        public decimal montoSubtotalIvaImponiblePen { get; set; }
        public decimal montoSubtotalExoneradoPen { get; set; }
        public decimal montoSubtotalExportacionPen { get; set; }
        public decimal montoSubtotalGratuitoPen { get; set; }
        public decimal montoSubtotalInafectoPen { get; set; }
        public string cRelacionadoNumDocAfectado { get; set; }
        public string cRelacionadoTipoDocAfectado { get; set; }
        public string infoRelNotasCodigoTipoNota { get; set; }
        public string infoRelNotasObservaciones { get; set; }
        public string codleyendaTransfGratuita { get; set; }
        public string montoEnLetras { get; set; }
        public string estadoContabilizado { get; set; }
        public System.DateTime docdate { get; set; }
    }
}
