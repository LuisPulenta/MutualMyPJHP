using System;
using System.ComponentModel.DataAnnotations;

namespace MutualMyPJHPCommon.Models
{
    public class Jubilacion
    {
        [Key]
        public int IdJub { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public int Recibo { get; set; }
        public int ID { get; set; }
        public int DNI { get; set; }
        public string Beneficiario { get; set; }
        public string TipoBeneficio { get; set; }
        public Decimal? IndiceJub { get; set; }
        public Decimal? MontoBeneficio { get; set; }
        public Decimal? LiquidoACobrar { get; set; }
        public string Cuenta { get; set; }
        public Decimal? Pago1 { get; set; }
        public Decimal? Pago2 { get; set; }
        public Decimal? CuotaSocial { get; set; }
        public Decimal? SubsidioFallecimiento { get; set; }
        public Decimal? RetenciónImpGanancias { get; set; }
        public Decimal? Art35 { get; set; }
        public Decimal? SEnf { get; set; }
        public Decimal? SAcc { get; set; }
        public Decimal? Minoli { get; set; }
        public Decimal? Cochera { get; set; }
        public Decimal? AyudaCapital { get; set; }
        public Decimal? AyudaInterés { get; set; }
        public string CuotaNro { get; set; }
        public Decimal? MutualEHP { get; set; }
        public Decimal? GastosVarios { get; set; }
        public Decimal? Donación { get; set; }
        public Decimal? SeguroConyuge { get; set; }
        public Decimal? DescuentosAMMPJHPC { get; set; }
        public Decimal? SeguroPrivado { get; set; }
        public Decimal? SeguroCNAYS { get; set; }
        public Decimal? RescateAcciones { get; set; }
        public Decimal? CoberturaSalud { get; set; }
        public Decimal? CajaMédicos { get; set; }
        public Decimal? Farmacia { get; set; }
        public Decimal? SaldoNegativo { get; set; }
        public Decimal? CoberturaOdontol { get; set; }
        public Decimal? RevistaHP { get; set; }
        public Decimal? BienesPerson { get; set; }
        public Decimal? VariosHP { get; set; }
        public Decimal? FotocopBibliot { get; set; }
        public Decimal? DescuentosHP { get; set; }
        public DateTime FechaPago1 { get; set; }
        public DateTime FechaPago2 { get; set; }
        public Decimal? Benef1 { get; set; }
        public Boolean? Pagada { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaEntregado { get; set; }
        public Boolean? ReciboEntregado { get; set; }
        public Boolean? EntregadoPorMail { get; set; }
    }
}
