using ClassLibrary;
using Models;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AnneeScolaireDAO
    {
        /// <summary>
        /// Private Connection
        /// </summary>
        private SqlConnection connection;

        /// <summary>
        /// Default Contructor
        /// </summary>
        public AnneeScolaireDAO()
        {
            connection = Singleton.GetInstance().GetConnection();
        }

        /// <summary>
        /// Get AnneeScolaire With All Associations
        /// </summary>
        /// <param name="idAnneeScolaire"></param>
        /// <returns></returns>
        public AnneeScolaire GetAnneeScolaire(int idAnneeScolaire)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var anneeScolaire = db.Query("AnneeScolaire").Where("IdAnneeScolaire", idAnneeScolaire).Select("IdAnneeScolaire", "Annee").FirstOrDefault<AnneeScolaire>();
                var idClasse = db.Query("AnneeScolaire").Where("IdAnneeScolaire", idAnneeScolaire).Select("IdClasse").FirstOrDefault<Int32>();
                var classe = new ClasseDAO().GetClasse(idClasse);
                var idEtudiant = db.Query("AnneeScolaire").Where("IdAnneeScolaire", idAnneeScolaire).Select("IdEtudiant").FirstOrDefault<Int32>();
                var etudiant = new EtudiantDAO().GetEtudiant(idEtudiant);
                anneeScolaire.Classe = classe;
                anneeScolaire.Etudiant = etudiant;
                return anneeScolaire;
            }
            catch (Exception ex)
            {
                Console.WriteLine("AnneeScolaire DAO Get AnneeScolaire : " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Get All AnneeScolaires
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AnneeScolaire> GetAnneeScolaires()
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var anneeScolaires = db.Query("AnneeScolaire").Select("IdAnneeScolaire", "Annee").Get<AnneeScolaire>();
                //If The List is empty then return null
                if (anneeScolaires.Count() == 0)
                    return null;
                for (int i = 0; i < anneeScolaires.Count(); i++)
                {
                    var idClasse = db.Query("AnneeScolaire").Where("IdAnneeScolaire", anneeScolaires.ElementAt<AnneeScolaire>(i).IdAnneeScolaire).Select("IdClasse").FirstOrDefault<Int32>();
                    anneeScolaires.ElementAt<AnneeScolaire>(i).Classe = new ClasseDAO().GetClasse(idClasse);
                    var idEtudiant = db.Query("AnneeScolaire").Where("IdAnneeScolaire", anneeScolaires.ElementAt<AnneeScolaire>(i).IdAnneeScolaire).Select("IdEtudiant").FirstOrDefault<Int32>();
                    anneeScolaires.ElementAt<AnneeScolaire>(i).Etudiant = new EtudiantDAO().GetEtudiant(idEtudiant);
                }
                return anneeScolaires;
            }
            catch (Exception ex)
            {
                Console.WriteLine("AnneeScolaire DAO Get AnneeScolaires : " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Update AnneeScolaire
        /// </summary>
        /// <param name="anneeScolaire"></param>
        /// <returns></returns>
        public int UpdateAnneeScolaire(AnneeScolaire anneeScolaire)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("AnneeScolaire").Where("IdAnneeScolaire", anneeScolaire.IdAnneeScolaire).Update(new
                {
                    anneeScolaire.Annee,
                    anneeScolaire.Classe.IdClasse,
                    anneeScolaire.Etudiant.IdEtudiant
                });
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("AnneeScolaire DAO Update : " + ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// delete record from the database
        /// </summary>
        /// <param name="idAnneeScolaire"></param>
        /// <returns></returns>
        public int DeleteAnneeScolaire(int idAnneeScolaire)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("AnneeScolaire").Where("IdAnneeScolaire", idAnneeScolaire).Delete();
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("AnneeScolaire DAO Delete : " + ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// Add record to the database
        /// </summary>
        /// <param name="anneeScolaire"></param>
        /// <returns></returns>
        public int InsertAnneeScolaire(AnneeScolaire anneeScolaire)
        {
            try
            {
                SqlServerCompiler compiler = new SqlServerCompiler();
                var db = new QueryFactory(connection, compiler);
                var rs = db.Query("AnneeScolaire").Insert(new
                {
                    anneeScolaire.Annee,
                    anneeScolaire.Classe.IdClasse,
                    anneeScolaire.Etudiant.IdEtudiant
                });
                return rs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("AnneeScolaire DAO Insert : " + ex.Message);
                return 0;
            }
        }
    }
}
