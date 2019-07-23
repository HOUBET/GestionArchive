using ClassLibrary;
using Models;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class ClasseDAO
    {
        private SqlConnection connection;

        public ClasseDAO()
        {
            connection = Singleton.GetInstance().GetConnection();
        }

        public Classe GetClasse(int idClasse)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var classe = db.Query("Classe").Where("IdClasse", idClasse).FirstOrDefault<Classe>();
                return classe;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Classe DAO Get Classe : " + ex.Message);
                return null;
            }
        }

        public IEnumerable<Classe> GetClasses()
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var classes = db.Query("Classe").Get<Classe>();
                if (classes.Count() == 0)
                    return null;
                return classes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Classe DAO Get Classes : " + ex.Message);
                return null;
            }
        }

        public IEnumerable<Classe> GetClassesByEtudiant(int IdEtudiant)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var classes = db.Query("AnneeScolaire").Join("Etudiant", "AnneeScolaire.IdEtudiant", "Etudiant.IdEtudiant")
                    .Join("Classe", "AnneeScolaire.IdClasse", "Classe.IdClasse")
                    .Where("Etudiant.IdEtudiant", IdEtudiant).Select("Classe.IdClasse", "Classe.NomClasse", "Classe.NiveauClasse").Get<Classe>();
                if (classes.Count() == 0)
                    return null;
                return classes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Classe DAO Get Classes : " + ex.Message);
                return null;
            }
        }

        public int UpdateClasse(Classe classe)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("Classe").Where("IdClasse", classe.IdClasse).Update(new {
                    classe.NomClasse,
                    classe.NiveauClasse,
                });
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Classe DAO Update : " + ex.Message);
                return 0;
            }
        }

        public int DeleteClasse(int idClasse)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("Classe").Where("IdClasse", idClasse).Delete();
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Classe DAO Delete : " + ex.Message);
                return 0;
            }
        }

        public int InsertClasse(Classe classe)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("Classe").Insert(new {
                    classe.NomClasse,
                    classe.NiveauClasse,
                });
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Classe DAO Insert : " + ex.Message);
                return 0;
            }
        }
    }
}
