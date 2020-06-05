//Udisteanu Iulian-Elisei grupa 3123
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelModele;
using System.IO;
using System.Collections;

namespace NivelAccesDate
{
    public class AdministrarePersoaneFisier_Text : IStocareData
    {
        private const int ID_PRIMA_PERSOANA = 1;
        private const int INCREMENT = 1;
        private const int PAS_ALOCARE = 10;
        string NumeFisier { get; set; }

        public AdministrarePersoaneFisier_Text(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            using (Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }
        public void AddPersoana(Persoana pers)
        {
            pers.IdPersoana = GetId();
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

        public List<Persoana> GetPersoane()
        {
            List<Persoana> persoane = new List<Persoana>();

            try
            {
                
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Persoana p = new Persoana(line);
                        persoane.Add(p);
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

        public bool UpdatePersoana(Persoana persoanaActualizata)
        {

            List<Persoana> persoane = GetPersoane();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Persoana persoana in persoane)
                    {
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (persoana.IdPersoana != persoanaActualizata.IdPersoana)
                        {
                            swFisierText.WriteLine(persoana.ConversieLaSir_PentruFisier());
                        }
                        else
                        {
                            swFisierText.WriteLine(persoanaActualizata.ConversieLaSir_PentruFisier());
                        }
                    }
                    actualizareCuSucces = true;
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

            return actualizareCuSucces;

        }


        public Persoana GetPersoana(string nume, string prenume)
        {
            throw new NotImplementedException();
        }

        public List<Persoana> GetPersoane(string cautare)
        {
            List<Persoana> persoane = GetPersoane();
            List<Persoana> persoaneCautate = new List<Persoana>();
            foreach(var pers in persoane)
            {
                if(pers.Nume.Contains(cautare) || pers.Prenume.Contains(cautare))
                {
                    persoaneCautate.Add(pers);
                }
            }
            return persoaneCautate;
        }

        private int GetId()
        {
            int IdPersoana = ID_PRIMA_PERSOANA;
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Persoana s = new Persoana(line);
                        IdPersoana = s.IdPersoana + INCREMENT;
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
            return IdPersoana;
        }

        public bool StergePersoana(int id)
        {
            List<Persoana> persoane = GetPersoane();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Persoana persoana in persoane)
                    {
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (persoana.IdPersoana != id)
                        {
                            swFisierText.WriteLine(persoana.ConversieLaSir_PentruFisier());
                        }
                    }
                    actualizareCuSucces = true;
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

            return actualizareCuSucces;
        }


        public List<Persoana> CautareDupaDataCurenta()
        {
            List<Persoana> contacte = GetPersoane();
            List<Persoana> sarbatoriti = new List<Persoana>();
            foreach(var contact in contacte)
            {
                if(contact.DataNasterii.Day == DateTime.Now.Day && contact.DataNasterii.Month == DateTime.Now.Month)
                {
                    sarbatoriti.Add(contact);
                }
            }

            return sarbatoriti;
        }

        public List<Persoana> FiltrareDupaDataActualizarii(DateTime data1, DateTime data2)
        {
            List<Persoana> contacte = GetPersoane();
            List<Persoana> filtrare = new List<Persoana>();
            foreach(var contact in contacte)
            {
                if(contact.DataActualizare.CompareTo(data1)>=0 && contact.DataActualizare.CompareTo(data2)<=0)
                {
                    filtrare.Add(contact);
                }
            }

            return filtrare;

        }
    }
}
