using MutualMyPJHPCommon.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace MutualMyPJHPAPI.Controllers
{
    [RoutePrefix("api/Jubilacions")]
    public class JubilacionsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/Jubilacions
        [Route("GetJubilacions/{ID}")]
        public async Task<IHttpActionResult> GetJubilacions(int ID)
        {
            var qry = await (from p in db.Jubilacions
                             where p.ID == ID
                             select new { p }).ToListAsync();

            var results = new List<Jubilacion>();

            foreach (var item in qry)
            {
                var result = new Jubilacion
                {
                    Art35 = item.p.Art35,
                    AyudaCapital = item.p.AyudaCapital,
                    AyudaInterés = item.p.AyudaInterés,
                    Año = item.p.Año,
                    Benef1 = item.p.Benef1,
                    Beneficiario = item.p.Beneficiario,
                    BienesPerson = item.p.BienesPerson,
                    CajaMédicos = item.p.CajaMédicos,
                    CoberturaOdontol = item.p.CoberturaOdontol,
                    CoberturaSalud = item.p.CoberturaSalud,
                    Cochera = item.p.Cochera,
                    Cuenta = item.p.Cuenta,
                    CuotaNro = item.p.CuotaNro,
                    CuotaSocial = item.p.CuotaSocial,
                    DescuentosAMMPJHPC = item.p.DescuentosAMMPJHPC,
                    DescuentosHP = item.p.DescuentosHP,
                    DNI = item.p.DNI,
                    Donación = item.p.Donación,
                    EntregadoPorMail = item.p.EntregadoPorMail,
                    Farmacia = item.p.Farmacia,
                    FechaEntregado = item.p.FechaEntregado,
                    FechaPago = item.p.FechaPago,
                    FechaPago1 = item.p.FechaPago1,
                    FechaPago2 = item.p.FechaPago2,
                    FotocopBibliot = item.p.FotocopBibliot,
                    GastosVarios = item.p.GastosVarios,
                    ID = item.p.ID,
                    IdJub = item.p.IdJub,
                    IndiceJub = item.p.IndiceJub,
                    LiquidoACobrar = item.p.LiquidoACobrar,
                    Mes = item.p.Mes,
                    Minoli = item.p.Minoli,
                    MontoBeneficio = item.p.MontoBeneficio,
                    MutualEHP = item.p.MutualEHP,
                    Pagada = item.p.Pagada,
                    Pago1 = item.p.Pago1,
                    Pago2 = item.p.Pago2,
                    Recibo = item.p.Recibo,
                    ReciboEntregado = item.p.ReciboEntregado,
                    RescateAcciones = item.p.RescateAcciones,
                    RetenciónImpGanancias = item.p.RetenciónImpGanancias,
                    RevistaHP = item.p.RevistaHP,
                    SAcc = item.p.SAcc,
                    SaldoNegativo = item.p.SaldoNegativo,
                    SeguroCNAYS = item.p.SeguroCNAYS,
                    SeguroConyuge = item.p.SeguroConyuge,
                    SeguroPrivado = item.p.SeguroPrivado,
                    SEnf = item.p.SEnf,
                    SubsidioFallecimiento = item.p.SubsidioFallecimiento,
                    TipoBeneficio = item.p.TipoBeneficio,
                    VariosHP = item.p.VariosHP,
                };
                results.Add(result);
            }
            return Ok(results);

        }




    }
}