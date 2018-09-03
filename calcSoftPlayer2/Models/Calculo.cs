using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace calcSoftPlayer2.Models
{
  public class Calculo
  {
    public int valor { get; set; }
    public int tempo { get; set; }

    public decimal calculaJuros(decimal? valorInicial, int tempo, decimal? casasDecimais)
    {
      tempo = tempo > 0 ? tempo : 1;
      if (tempo == 0)
      if (casasDecimais != null || valorInicial != null)
        return (decimal)((double)valorInicial * Math.Pow(1 + (double)casasDecimais, tempo));
      else
        throw new Exception("");

      throw new Exception("");
    }
  }
}