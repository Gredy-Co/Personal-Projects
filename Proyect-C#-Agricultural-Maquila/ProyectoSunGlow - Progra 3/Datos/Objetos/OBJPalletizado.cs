using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSunGlow___Progra_3.Datos
{
    internal class OBJPalletizado
    {
        private int idPalletizado;
        private int numeroPallet;
        private int cantidadCajasEnPallet;
        private DateTime fechaPalletizado;
        private TimeSpan horaPalletizado;
        private string destinoPallet;
        private string estado;

        public OBJPalletizado(int idPalletizado, int numeroPallet, int cantidadCajasEnPallet, DateTime fechaPalletizado, TimeSpan horaPalletizado, string destinoPallet, string estado)
        {
            this.idPalletizado = idPalletizado;
            this.numeroPallet = numeroPallet;
            this.cantidadCajasEnPallet = cantidadCajasEnPallet;
            this.fechaPalletizado = fechaPalletizado;
            this.horaPalletizado = horaPalletizado;
            this.destinoPallet = destinoPallet;
            this.estado = estado;
        }

        public OBJPalletizado()
        {
            this.idPalletizado = 0;
            this.numeroPallet = 0;
            this.cantidadCajasEnPallet = 0;
            this.fechaPalletizado = DateTime.MinValue;
            this.horaPalletizado = TimeSpan.Zero;
            this.destinoPallet = "";
            this.estado = "";
        }

        public int ID_Palletizado { get => idPalletizado; set => idPalletizado = value; }
        public int Numero_Pallet { get => numeroPallet; set => numeroPallet = value; }
        public int Cantidad_Cajas_En_Pallet { get => cantidadCajasEnPallet; set => cantidadCajasEnPallet = value; }
        public DateTime Fecha_Palletizado { get => fechaPalletizado; set => fechaPalletizado = value; }
        public TimeSpan Hora_Palletizado { get => horaPalletizado; set => horaPalletizado = value; }
        public string Destino_Pallet { get => destinoPallet; set => destinoPallet = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
