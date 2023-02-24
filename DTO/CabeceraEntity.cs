using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDE.Objetos
{
    public class CabeceraEntity
    {
        public string Id { get; set; }
        public string Tipo { get; set; }
        public string ITipEmi { get; set; }
        public string ITiDE { get; set; }
        public string DNumTim { get; set; }
        public string DEst { get; set; }
        public string DPuntExp { get; set; }
        public string DNumDoc { get; set; }
        public string DFeEmiDE { get; set; }
        public string ITipTra { get; set; }
        public string ITImp { get; set; }
        public string CMoneOpe { get; set; }
        public string DRucEm { get; set; }
        public string DDVEmi { get; set; }
        public string INatRec { get; set; }
        public string ITiOpe { get; set; }
        public string DRucRec { get; set; }
        public string DDVRec { get; set; }
        public string DNomRec { get; set; }
        public string DDirRec { get; set; }
        public string DTelRec { get; set; }
        public string CPaisRec { get; set; }
        public string DDesPaisRe { get; set; }
        public string ICondOpe { get; set; }
        public string ICondCred { get; set; }
        public string DPlazoCre { get; set; }
        public string IIndPres { get; set; }
        public string DSubExe { get; set; }
        public string DSubExo { get; set; }
        public string DSub5 { get; set; }
        public string DSub10 { get; set; }
        public string DTotOpe { get; set; }
        public string DTotDesc { get; set; }
        public string DTotDescGlotem { get; set; }
        public string DocAsociadoNumero { get; set; }
        public string DocAsociadoTipo { get; set; }
        public string IMotEmi { get; set; }
        public string DDesMotEmi { get; set; }
        public string ITipDocAso { get; set; }
        public string DCdCDERef { get; set; }
        public DateTime DFeIniT { get; set; }
        public string DCondTiCam { get; set; }
        public string DTiCam { get; set; }
        public string DEmailRec { get; set; }
        public string DNumCasRec { get; set; }
        public string ITiContRec { get; set; }
        public string DDCondCred { get; set; }
        public string INAtVen { get; set; }
        public string ITipIDVen { get; set; }
        public string DNumIDVen { get; set; }
        public string DNomVen { get; set; }
        public string DDirVen { get; set; }
        public string DNumCasVen { get; set; }
        public string CDepVen { get; set; }
        public string CDisVen { get; set; }
        public string CCiuVen { get; set; }
        public string DDirProv { get; set; }
        public string CDepProv { get; set; }
        public string CDisProv { get; set; }
        public string CCiuProv { get; set; }
        public string ITipCons { get; set; }
        public string DNumCons { get; set; }
        public string DNumControl { get; set; }
        public string ITipIDRec { get; set; }
    }
    public class DetalleEntity
    {
        public string DCodInt { get; set; }
        public string DDesProSer { get; set; }
        public string DCantProSer { get; set; }
        public string DPUniProSer { get; set; }
        public string DTasaIVA { get; set; }
    }
}
