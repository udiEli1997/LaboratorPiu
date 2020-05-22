using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelModele;
using System.Collections;

namespace NivelAccesDate
{
    public interface IStocareData
    {
        void AddPersoana(Persoana s);
        List<Persoana> GetPersoane();

        List<Persoana> GetPersoane(string cautare);

        Persoana GetPersoana(string nume, string prenume);

        bool UpdatePersoana(Persoana persoanaActualizata);

        bool StergePersoana(int id);

        List<Persoana> CautareDupaDataCurenta();

        List<Persoana> FiltrareDupaDataActualizarii(DateTime data1, DateTime data2);
    }
}
