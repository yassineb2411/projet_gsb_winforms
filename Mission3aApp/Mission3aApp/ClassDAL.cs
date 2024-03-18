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
    }
}
