using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighRiskComparator.Models
{
    public class PatientData
    {
		public int Id { get; set; }
		//Admin
		public string Prenom { get; set; }
		public string Nom { get; set; }
		public DateTime DateDeNaissance { get; set; }
		public string Genre { get; set; }
		//Biometrie
		public int Poids { get; set; }
		public int Taille { get; set; }
		//Const_biologique
		public int HbA1c { get; set; }
		public int CholesterolTotal { get; set; }
		public int CholesterolHdl { get; set; }
		//Parametres
		public int Pss { get; set; }
		//Assuetudes
		public int ConsommationTabagique { get; set; }

	}
}
