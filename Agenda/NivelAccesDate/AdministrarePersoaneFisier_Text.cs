using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelModele;
using System.IO;

namespace NivelAccesDate
{
    public class AdministrarePersoaneFisier_Text : IStocareData
    {
        private const int PAS_ALOCARE = 10;
        string NumeFisier { get; set; }

        public AdministrarePersoaneFisier_Text(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }
        public void AddPersoana(Persoana pers)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(pers.ConversieLaSir_PentruFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public Persoana[] GetPersoane(out int nrPersoane)
        {
            Persoana[] persoane = new Persoana[PAS_ALOCARE];

            try
            {
                
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    nrPersoane = 0;

                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        persoane[nrPersoane++] = new Persoana(line);
                        if (nrPersoane == PAS_ALOCARE)
                        {
                            Array.Resize(ref persoane, nrPersoane + PAS_ALOCARE);
                        }
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return persoane;
        }

        public bool UpdatePersoana(Persoana[] persoane, int nrPersoane)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier))
                {
                    for (int i = 0; i < nrPersoane; i++)
                    {
                        swFisierText.WriteLine(persoane[i].ConversieLaSir_PentruFisier());
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return false;
        }
    }
}
