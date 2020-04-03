using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelModele;
namespace NivelAccesDate
{
    public interface IStocareData
    {
        void AddPersoana(Persoana s);
        Persoana[] GetPersoane(out int nrPersoane);

        bool UpdatePersoana(Persoana[] persoane, int nrPersoane);
    }
}
