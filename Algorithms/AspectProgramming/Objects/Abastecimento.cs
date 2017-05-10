using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using _3tn.Dados;
using _3tn.Tauro;
using _3tn.Dominus;
using AspectProgramming.ExceptionHandling;
using AspectProgramming.Transaction;

namespace AspectProgramming.Objects
{
	public class Abastecimento
	{
		//Chaves da classe
		private string[] keysName = new string[] { "nu_cnpj", "dt_ano", "sq_abastecimento", "sq_veiculo" };

		//Eventos 
		public delegate void AntesDeInserirEventHandler(clsAcessoDados D, Abastecimento a);
		public event AntesDeInserirEventHandler AntesDeInserir;
		public delegate void DepoisDeInserirEventHandler(clsAcessoDados D, Abastecimento a);
		public event DepoisDeInserirEventHandler DepoisDeInserir;

		#region Propriedades 
		private clsAcessoDados acessoDados = null;
		public clsAcessoDados AcessoDados
		{
			get { return acessoDados; }
			set { acessoDados = value; }
		}
		private string nuCnpj = null;

		[PrimaryKey]
		public string NuCnpj
		{
			get { return nuCnpj; }
			set { nuCnpj = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string dtAno = null;

		[PrimaryKey]
		public string DtAno
		{
			get { return dtAno; }
			set { dtAno = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private int sqAbastecimento;

		[PrimaryKey]
		public int SqAbastecimento
		{
			get { return sqAbastecimento; }
			set { sqAbastecimento = value; }
		}
		private int sqVeiculo;

		[PrimaryKey]
		public int SqVeiculo
		{
			get { return sqVeiculo; }
			set { sqVeiculo = value; }
		}
		private DateTime? dtAbastecimento;

		public DateTime? DtAbastecimento
		{
			get { return dtAbastecimento; }
			set { dtAbastecimento = value; }
		}
		private int? kmAtual;

		public int? KmAtual
		{
			get { return kmAtual; }
			set { kmAtual = value; }
		}
		private double? qtAbastecimento;

		public double? QtAbastecimento
		{
			get { return qtAbastecimento; }
			set { qtAbastecimento = value; }
		}
		private double? vlUnitario;

		public double? VlUnitario
		{
			get { return vlUnitario; }
			set { vlUnitario = value; }
		}
		private string dtAnomes = null;

		public string DtAnomes
		{
			get { return dtAnomes; }
			set { dtAnomes = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string nuCnpjcpffornecredor = null;

		public string NuCnpjcpffornecredor
		{
			get { return nuCnpjcpffornecredor; }
			set { nuCnpjcpffornecredor = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string nuCpffunc = null;

		public string NuCpffunc
		{
			get { return nuCpffunc; }
			set { nuCpffunc = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string nuMatricula = null;

		public string NuMatricula
		{
			get { return nuMatricula; }
			set { nuMatricula = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		#endregion
		#region Propriedades3tecnos
		#endregion Propriedades3tecnos


		/// <summary> 
		/// Descrição: Executa a thread que salva o log de evento 
		/// Programador: Paulo Henrique 
		/// </summary> 
		private void GravarLogEvento(Evento evento)
		{
			Log log = new Log(this);
			log.Gravar(evento);
		}

		/// <summary> 
		/// Descrição: Método que insere os dados no banco. 
		/// Programador: Paulo Henrique 
		/// </summary> 
		[ExceptionHandling.SqlException]
		public void Inserir()
		{
			clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados(clsAcessoDados.Conexao.ABERTA);
				D.IniciarTransacao();
				//Se foi Definido o evento AntesDeInserir 
				if (AntesDeInserir != null)
				{
					AntesDeInserir(D, this);
				}

				#region Parametros 
				D.Parametros.Clear();
				D._3tnAddParametro("@sq_abastecimento", SqlDbType.Int, ParameterDirection.Output);
				D.Parametros["@sq_abastecimento"].Size = 4;
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@sq_veiculo", SqlDbType.Int, sqVeiculo);
				D._3tnAddParametro("@dt_abastecimento", SqlDbType.DateTime, dtAbastecimento);
				D._3tnAddParametro("@km_atual", SqlDbType.Int, kmAtual);
				D._3tnAddParametro("@qt_abastecimento", SqlDbType.Float, qtAbastecimento);
				D._3tnAddParametro("@vl_unitario", SqlDbType.Float, vlUnitario);
				D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, dtAnomes);
				D._3tnAddParametro("@nu_cnpjcpffornecredor", SqlDbType.VarChar, nuCnpjcpffornecredor);
				D._3tnAddParametro("@nu_cpffunc", SqlDbType.VarChar, nuCpffunc);
				D._3tnAddParametro("@nu_matricula", SqlDbType.VarChar, nuMatricula);
				#endregion
				D._3tnExecProcedure("dbo.pi_Abastecimento");
				//OutPut 
				sqAbastecimento = Convert.ToInt32(D.Parametros["@sq_abastecimento"].Value.ToString());
				//Se foi Definido o evento DepoisDeInserir 
				if (DepoisDeInserir != null)
				{
					DepoisDeInserir(D, this);
				}

				D.FinalizarTransacao();
				GravarLogEvento(Evento.Inserir);
		}


		/// <summary> 
		/// Descrição: Inserção de Abastecimento num contexto transacional. 
		/// Programador: Paulo Henrique 
		/// </summary> 
		public void Inserir(List<Abastecimento> ListAbastecimento, Hashtable keysExclusao)
		{
			clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados(clsAcessoDados.Conexao.ABERTA);
			try
			{
				D.IniciarTransacao();

				//se possuir chaves para exclusão 
				if (keysExclusao.Count > 0)
				{
					foreach (object iKey in keysExclusao.Keys)
					{
						D._3tnAddParametro("@" + iKey.ToString(), keysExclusao[iKey].ToString());
					}
					D._3tnExecProcedure("dbo.pe_Abastecimento");
				}

				for (int i = 0; i < ListAbastecimento.Count; i++)
				{
					#region Parametros 
					D.Parametros.Clear();
					this.nuCnpj = ListAbastecimento[i].NuCnpj;
					this.dtAno = ListAbastecimento[i].DtAno;
					this.sqVeiculo = ListAbastecimento[i].SqVeiculo;
					this.dtAbastecimento = ListAbastecimento[i].DtAbastecimento;
					this.kmAtual = ListAbastecimento[i].KmAtual;
					this.qtAbastecimento = ListAbastecimento[i].QtAbastecimento;
					this.vlUnitario = ListAbastecimento[i].VlUnitario;
					this.dtAnomes = ListAbastecimento[i].DtAnomes;
					this.nuCnpjcpffornecredor = ListAbastecimento[i].NuCnpjcpffornecredor;
					this.nuCpffunc = ListAbastecimento[i].NuCpffunc;
					this.nuMatricula = ListAbastecimento[i].NuMatricula;
					D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, this.nuCnpj);
					D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, this.dtAno);
					D._3tnAddParametro("@sq_veiculo", SqlDbType.Int, this.sqVeiculo);
					D._3tnAddParametro("@dt_abastecimento", SqlDbType.DateTime, this.dtAbastecimento);
					D._3tnAddParametro("@km_atual", SqlDbType.Int, this.kmAtual);
					D._3tnAddParametro("@qt_abastecimento", SqlDbType.Float, this.qtAbastecimento);
					D._3tnAddParametro("@vl_unitario", SqlDbType.Float, this.vlUnitario);
					D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, this.dtAnomes);
					D._3tnAddParametro("@nu_cnpjcpffornecredor", SqlDbType.VarChar, this.nuCnpjcpffornecredor);
					D._3tnAddParametro("@nu_cpffunc", SqlDbType.VarChar, this.nuCpffunc);
					D._3tnAddParametro("@nu_matricula", SqlDbType.VarChar, this.nuMatricula);
					D._3tnExecProcedure("dbo.pi_Abastecimento");
					#endregion

					GravarLogEvento(Evento.Inserir);
				}
				D.FinalizarTransacao();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally
			{
				D.FecharConexao();
			}
		}


		/// <summary> 
		/// Descrição: Método que atualiza os dados no banco. 
		/// Programador: Paulo Henrique 
		/// </summary> 
		[ExceptionHandling.SqlException]
		public void Atualizar()
		{
			//try
			//{ 
				clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados();
				#region Parametros 
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@sq_abastecimento", SqlDbType.Int, sqAbastecimento);
				D._3tnAddParametro("@sq_veiculo", SqlDbType.Int, sqVeiculo);
				D._3tnAddParametro("@dt_abastecimento", SqlDbType.DateTime, dtAbastecimento);
				D._3tnAddParametro("@km_atual", SqlDbType.Int, kmAtual);
				D._3tnAddParametro("@qt_abastecimento", SqlDbType.Float, qtAbastecimento);
				D._3tnAddParametro("@vl_unitario", SqlDbType.Float, vlUnitario);
				D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, dtAnomes);
				D._3tnAddParametro("@nu_cnpjcpffornecredor", SqlDbType.VarChar, nuCnpjcpffornecredor);
				D._3tnAddParametro("@nu_cpffunc", SqlDbType.VarChar, nuCpffunc);
				D._3tnAddParametro("@nu_matricula", SqlDbType.VarChar, nuMatricula);
				#endregion
				D._3tnExecProcedure("dbo.pa_Abastecimento");
				GravarLogEvento(Evento.Atualizar);
			//}
			//catch (Exception ex)
			//{
			//	throw new Exception(ex.Message);
			//}
		}


		/// <summary> 
		/// Descrição: Método que exclui os dados no banco. 
		/// Programador: Paulo Henrique 
		/// </summary> 
		public void Excluir()
		{
			try
			{
				clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados();
				#region Parametros 
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@sq_abastecimento", SqlDbType.Int, sqAbastecimento);
				D._3tnAddParametro("@sq_veiculo", SqlDbType.Int, sqVeiculo);
				#endregion
				D._3tnExecProcedure("dbo.pe_Abastecimento");
				GravarLogEvento(Evento.Excluir);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}


		/// <summary> 
		/// Descrição: Exclusão em Massa. 
		/// Programador: Paulo Henrique 
		/// </summary> ]
		 
		[OnTransationAspect]
		[ExceptionHandling.SqlException]
		public void Excluir(List<Abastecimento> ListAbastecimento)
		{
			clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados(clsAcessoDados.Conexao.ABERTA);
			//try
			//{
			//	D.IniciarTransacao();
			//	for (int i = 0; i < ListAbastecimento.Count; i++)
			//	{
			//		#region Parametros 
			//		D.Parametros.Clear();
			//		this.nuCnpj = ListAbastecimento[i].NuCnpj;
			//		this.dtAno = ListAbastecimento[i].DtAno;
			//		this.sqAbastecimento = ListAbastecimento[i].SqAbastecimento;
			//		this.sqVeiculo = ListAbastecimento[i].SqVeiculo;
			//		D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, this.nuCnpj);
			//		D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, this.dtAno);
			//		D._3tnAddParametro("@sq_abastecimento", SqlDbType.Int, this.sqAbastecimento);
			//		D._3tnAddParametro("@sq_veiculo", SqlDbType.Int, this.sqVeiculo);
			//		D._3tnExecProcedure("dbo.pe_Abastecimento");
			//		#endregion

			//		GravarLogEvento(Evento.Excluir);
			//	}
			//	D.FinalizarTransacao();
			//}
			//catch (Exception ex)
			//{
			//	throw new Exception(ex.Message);
			//}
			//finally
			//{
			//	D.FecharConexao();
			//}

			for (int i = 0; i < ListAbastecimento.Count; i++)
			{
				#region Parametros 
				D.Parametros.Clear();
				this.nuCnpj = ListAbastecimento[i].NuCnpj;
				this.dtAno = ListAbastecimento[i].DtAno;
				this.sqAbastecimento = ListAbastecimento[i].SqAbastecimento;
				this.sqVeiculo = ListAbastecimento[i].SqVeiculo;
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, this.nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, this.dtAno);
				D._3tnAddParametro("@sq_abastecimento", SqlDbType.Int, this.sqAbastecimento);
				D._3tnAddParametro("@sq_veiculo", SqlDbType.Int, this.sqVeiculo);
				D._3tnExecProcedure("dbo.pe_Abastecimento");
				#endregion
			}
		}


		/// <summary> 
		/// Descrição: Informa se existe a informação na tabela de acordo com HashTable 
		/// Programador: Paulo Henrique 
		/// </summary> 
		public static bool Existe(Hashtable keys)
		{
			bool existe = false;
			if (keys.Count > 0)
			{
				clsAcessoDados D = new clsAcessoDados();
				foreach (object iKey in keys.Keys)
				{
					D._3tnAddParametro("@" + iKey.ToString(), keys[iKey].ToString());
				}
				D._3tnAddParametro("ReturnValue", SqlDbType.Bit, ParameterDirection.ReturnValue);
				D._3tnExecProcedure("dbo.pc_Abastecimento_Existe");
				existe = (D.Parametros["ReturnValue"].Value.ToString() == "1") ? true : false;
			}
			return existe;
		}

		/// <summary> 
		/// Descrição: Faz uma consulta filtrando o máximo possível. 
		/// Programador: Paulo Henrique 
		/// </summary> 
		public static DataTable Consultar(string busca)
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				D._3tnAddParametro("@busca", SqlDbType.VarChar, busca);
				return D._3tnGetDataTable("dbo.pc_Abastecimento");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary> 
		/// Descrição: Sobrecarga do Método (Faz uma consulta filtrando o máximo possível). 
		/// Programador: Paulo Henrique 
		/// </summary> 
		public static DataTable Consultar(string busca, Hashtable keys)
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				D._3tnAddParametro("@busca", SqlDbType.VarChar, busca);
				foreach (object iKey in keys.Keys)
				{
					D._3tnAddParametro("@" + iKey.ToString(), keys[iKey].ToString());
				}
				return D._3tnGetDataTable("dbo.pc_Abastecimento");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}


		/// <summary> 
		/// Descrição: Retorna um SqlDataReader. 
		/// Programador: Paulo Henrique 
		/// </summary> 
		public static SqlDataReader ConsultarReader(string busca)
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				D._3tnAddParametro("@busca", SqlDbType.VarChar, busca);
				return D._3tnGetDataReader("dbo.pc_Abastecimento");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary> 
		/// Descrição: Sobrecarga do Método (Faz uma consulta filtrando o máximo possível). 
		/// Programador: Paulo Henrique 
		/// </summary> 
		[ExceptionHandling.SqlException]
		public static SqlDataReader ConsultarReader(string busca, Hashtable keys)
		{
			//try
			//{
				clsAcessoDados D = new clsAcessoDados();
				D._3tnAddParametro("@busca", SqlDbType.VarChar, busca);
				foreach (object iKey in keys.Keys)
				{
					D._3tnAddParametro("@" + iKey.ToString(), keys[iKey].ToString());
				}
				return D._3tnGetDataReader("dbo.pc_Abastecimento");
			//}
			//catch (Exception ex)
			//{
			//	throw new Exception(ex.Message);
			//}
		}

		#region 3tecnos

		/// <summary> 
		/// Descrição: Sobrecarga do Método (Faz uma consulta filtrando o máximo possível). 
		/// Programador: Rogerio Cardoso 
		/// </summary> 

		[ExceptionHandling.SqlException]
		public static DataTable ConsultarCompleto(string busca, Hashtable keys)
		{
			//try
			//{
				clsAcessoDados D = new clsAcessoDados();
				D._3tnAddParametro("@busca", SqlDbType.VarChar, busca);
				foreach (object iKey in keys.Keys)
				{
					D._3tnAddParametro("@" + iKey.ToString(), keys[iKey].ToString());
				}
				return D._3tnGetDataTable("dbo.pd_Frota_AbastecimentoCompleto");
			//}
			//catch (Exception ex)
			//{
			//	throw new Exception(ex.Message);
			//}
		}

		[ExceptionHandling.NullException]
		public void Teste()
		{
			throw new NullReferenceException();
		}
		#endregion 3tecnos
	} //Fim da Classe 
}//Fim do Namespace 
