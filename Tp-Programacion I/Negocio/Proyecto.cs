using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Programacion_I.Negocio
{
    public class Proyecto
    {
        private int codigo;
        private Pais localizacion;
        private TipoProyectos tipoProyectos;
        private int nroCatastral;
        private double supTerr;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private DateTime fechaEstimada;
        private UnidadMedida unidadMedida;
        private double supProy;
        private double precioM2;
        private Cliente cliente;
        private Estado estado;
        private Etapa etapa;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Pais Localizacion
        {
            get { return localizacion; }
            set { localizacion = value; }
        }
        public TipoProyectos TipoProyectos
        {
            get { return tipoProyectos; }
            set { tipoProyectos = value; }
        }
        public int NroCatastral
        {
            get { return nroCatastral; }
            set { nroCatastral = value; }
        }
        public double SupTerr
        {
            get { return supTerr; }
            set { supTerr = value; }
        }
        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        public DateTime FechaFinal
        {
            get { return fechaFinal; }
            set { fechaFinal = value; }
        }
        public DateTime FechaEstimada
        {
            get { return fechaEstimada; }
            set { fechaEstimada = value; }
        }
        public UnidadMedida UnidadMedida
        {
            get { return unidadMedida; }
            set { unidadMedida = value; }
        }
        public double SupProy
        {
            get { return supProy; }
            set { supProy = value; }
        }
        public double PrecioM2
        {
            get { return precioM2; }
            set { precioM2 = value; }
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public Etapa Etapa
        {
            get { return etapa; }
            set { etapa = value; }
        }
        override public string ToString()
        {
            return codigo + " - " + nroCatastral;
        }
    }
}
