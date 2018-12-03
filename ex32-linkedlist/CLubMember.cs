using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex32_linkedlist
{
	class ClubMember
	{
		private int nr;
		private string fnavn;
		private string lnavn;
		private int alder;

		public int Nr { get; set; }
		public string FNavn { get; set;}
		public string LNavn { get; set; }
		public int Alder { get; set; }


		public ClubMember(int Nr, string FNavn, string LNavn, int Alder)
		{
			nr = Nr;
			fnavn = FNavn;
			lnavn = LNavn;
			alder = Alder;
		}


		public override string ToString()
		{
			return "Nr: " + nr + "FNavn: " + fnavn + "LNavn: " + lnavn + "Alder: " + alder;
		}
	}
}
