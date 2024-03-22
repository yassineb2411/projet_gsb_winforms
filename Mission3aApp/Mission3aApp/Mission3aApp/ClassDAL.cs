using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3aApp
{
    public static class ClassDAL
    {
        public static IList<MedecinClass> GetAll()
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<MedecinClass>("Medecin_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static IList<MedecinClass> GetAllNoms()
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<MedecinClass>("Medecin_GetAllNoms", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static IList<MedecinClass> GetAllDepartements()
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<MedecinClass>("Medecin_GetAllDepartements", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static IList<MedecinClass> GetAllMedecinsByNomDep(string nom, string departement)
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@p_nom", nom);
                parameters.Add("@p_departement", departement);
                return db.Query<MedecinClass>("Medecin_GetAllByNomDep", parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static void UpdateMedecin(int id, string nom, string prenom, string adresse, int tel, string specialiteComplementaire, int departement)
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@p_id", id);
                parameters.Add("@p_nom", nom);
                parameters.Add("@p_prenom", prenom);
                parameters.Add("@p_adresse", adresse);
                parameters.Add("@p_tel", tel);
                parameters.Add("@p_specialiteComplementaire", specialiteComplementaire);
                parameters.Add("@p_departement", departement);
                db.Execute("Medecin_Update", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public static void AddMedecin(int id, string nom, string prenom, string adresse, int tel, string specialiteComplementaire, int departement)
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@p_id", id);
                parameters.Add("@p_nom", nom);
                parameters.Add("@p_prenom", prenom);
                parameters.Add("@p_adresse", adresse);
                parameters.Add("@p_tel", tel);
                parameters.Add("@p_specialiteComplementaire", specialiteComplementaire);
                parameters.Add("@p_departement", departement);
                db.Execute("Medecin_Add", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public static int GetMaxMedecinId()
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.QueryFirstOrDefault<int>("GetMaxMedecinId", commandType: CommandType.StoredProcedure);
            }
        }

        public static void DeleteMedecin(int id)
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@p_id", id);
                db.Execute("Medecin_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public static int GetMedecinByRapport(int id)
        {
            int reportCount = 0;

            using (IDbConnection connection = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@p_medecin_id", id);
                parameters.Add("@reportCount", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("Medecin_GetByRapport", parameters, commandType: CommandType.StoredProcedure);

                reportCount = parameters.Get<int>("@reportCount");
            }

            return reportCount;
        }
    }
}
