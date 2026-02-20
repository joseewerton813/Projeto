using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Atletas
{
    public static class BancoDeDados
    {
        const string connectionString = "Server=localhost;Database=uc12;Uid=root;";

        public static bool InserirAtleta(Atleta atleta)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))

            {
                MySqlTransaction transaction = null;
                try

                {
                    connection.Open();

                    transaction = connection.BeginTransaction();

                    string sqlMedical = @"
                                          
                                           INSERT INTO MedicalInfo
                                           (TipoSanguineo, Alergia, Altura, Peso, IMC)
                                           VALUES
                                           (@TipoSanguineo, @Alergia, Altura, @Peso, @IMC);
                                           SELECT LAST_INSERT_ID();";

                    int medicalInfoId;

                    using (MySqlCommand cmMedical = new MySqlCommand(sqlMedical, connection, transaction))
                    {
                        cmMedical.Parameters.AddWithValue("@TipoSanguineo", atleta.InformacoesMedicas.TipoSanguineo);
                        cmMedical.Parameters.AddWithValue("@Alergia", atleta.InformacoesMedicas.Alergia);
                        cmMedical.Parameters.AddWithValue("@Altura", atleta.InformacoesMedicas.Altura);
                        cmMedical.Parameters.AddWithValue("@Peso", atleta.InformacoesMedicas.Peso);
                        cmMedical.Parameters.AddWithValue("@IMC", atleta.InformacoesMedicas.IMC);

                        medicalInfoId = Convert.ToInt32(cmMedical.ExecuteScalar());


                    }




                    string sqlAtleta = @"
                                           INSERT INTO Atleta
                                           (Nome, Idade, DataNascimento, Genero, Nacionalidade, Modalidade, MedicalInfoId)
                                           VALUES
                                           (@Nome, @Idade, @DataNascimento, @Genero, @Nacionalidade, @Modalidade, @MedicalInfoId);";

                    using (MySqlCommand cmdAtleta = new MySqlCommand(sqlAtleta, connection, transaction))

                    {
                        cmdAtleta.Parameters.AddWithValue("@Nome", atleta.Nome);
                        cmdAtleta.Parameters.AddWithValue("@Idade", atleta.Idade);
                        cmdAtleta.Parameters.AddWithValue("@DataNascimento", atleta.DataNascimento);
                        cmdAtleta.Parameters.AddWithValue("@Genero", atleta.Genero);
                        cmdAtleta.Parameters.AddWithValue("@Nacionalidade", atleta.Nacionalidade);
                        cmdAtleta.Parameters.AddWithValue("@Modalidade", atleta.Modalidade);
                        cmdAtleta.Parameters.AddWithValue("@MedicalInfoId", medicalInfoId);

                        cmdAtleta.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar no banco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (transaction != null)
                        transaction.Rollback();
                    return false;

                }
            }
        }

        public static List<Atleta> BuscaAtletas()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    List<Atleta> atletas = new List<Atleta>();
                    connection.Open();

                    string sqlMedical = @"select m.*, a.* from atleta a inner join MedicalInfo m on m.Id = a.MedicalInfoId;";

                    using (MySqlCommand cmdMedical = new MySqlCommand(sqlMedical, connection))
                    {

                        MySqlDataReader resultado = cmdMedical.ExecuteReader();

                        while (resultado.Read())
                        {
                            Atleta atleta = new Atleta();
                            atleta.InformacoesMedicas.id = Convert.ToInt32(resultado[0]);
                            atleta.InformacoesMedicas.TipoSanguineo = resultado[1].ToString();
                            atleta.InformacoesMedicas.Alergia = resultado[2].ToString();
                            atleta.InformacoesMedicas.Altura = Convert.ToDouble(resultado[3]);
                            atleta.InformacoesMedicas.Peso = Convert.ToDouble(resultado[4]);
                            atleta.InformacoesMedicas.IMC = Convert.ToDouble(resultado[5]);
                            atleta.id = Convert.ToInt32(resultado[6]);
                            atleta.Nome = resultado[7].ToString();
                            atleta.Idade = Convert.ToInt32(resultado[8]);
                            atleta.DataNascimento = Convert.ToDateTime(resultado[9]);
                            atleta.Genero = resultado[10].ToString();
                            atleta.Nacionalidade = resultado[11].ToString();
                            atleta.Modalidade = resultado[12].ToString();

                            atletas.Add(atleta);

                        }

                    }

                    return atletas;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar no banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return null;

                }
            }
        }
    }
}
