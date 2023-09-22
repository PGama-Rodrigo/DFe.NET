using System;
using System.Xml.Serialization;
using DFe.Utils;

namespace NFe.Classes.Informacoes.Detalhe
{
    public class med
    {
		private string _cProdANVISA;
		private string _xMotivoIsencao;
		private decimal _vPMC;

        /// <summary>
        /// K01a - C�digo de Produto da ANVISA
        /// Vers�o 7.0
        /// </summary>
        public string cProdANVISA
        {
			get { return _cProdANVISA; }
			set { _cProdANVISA = value; }
		}

        /// <summary>
        /// K01b - Motivo da isen��o da ANVISA
        /// Vers�o 7.0
        /// </summary>
        public string xMotivoIsencao
        {
            get { return _xMotivoIsencao; }
            set { _xMotivoIsencao = value; }
        }

        /// <summary>
        /// K06 - Pre�o m�ximo consumidor
        /// Vers�o 7.0
        /// </summary>
        public decimal vPMC
        {
            get { return _vPMC; }
            set { _vPMC = value.Arredondar(2); }
        }
    }
}