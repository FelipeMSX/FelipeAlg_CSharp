using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using _3tn.Dados;
using _3tn.Tauro;
using _3tn.Dominus;

namespace AspectProgramming.Objects
{
	public class Acao
	{
		//Chaves da classe
		private string[] keysName = new string[] { "nu_cnpj", "dt_ano", "cd_acao" };

		//Eventos 
		public delegate void AntesDeInserirEventHandler(clsAcessoDados D, Acao a);
		public event AntesDeInserirEventHandler AntesDeInserir;
		public delegate void DepoisDeInserirEventHandler(clsAcessoDados D, Acao a);
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
		private string cdAcao = null;

		[PrimaryKey]
		public string CdAcao
		{
			get { return cdAcao; }
			set { cdAcao = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string nmAcao = null;

		public string NmAcao
		{
			get { return nmAcao; }
			set { nmAcao = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string dsObjetivo = null;

		public string DsObjetivo
		{
			get { return dsObjetivo; }
			set { dsObjetivo = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string tpCredito = null;

		public string TpCredito
		{
			get { return tpCredito; }
			set { tpCredito = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string cdOrgao = null;

		public string CdOrgao
		{
			get { return cdOrgao; }
			set { cdOrgao = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string cdUnidorcamentaria = null;

		public string CdUnidorcamentaria
		{
			get { return cdUnidorcamentaria; }
			set { cdUnidorcamentaria = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string cdFuncao = null;

		public string CdFuncao
		{
			get { return cdFuncao; }
			set { cdFuncao = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string cdSubfuncao = null;

		public string CdSubfuncao
		{
			get { return cdSubfuncao; }
			set { cdSubfuncao = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string cdPrograma = null;

		public string CdPrograma
		{
			get { return cdPrograma; }
			set { cdPrograma = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private double? vlPpa;

		public double? VlPpa
		{
			get { return vlPpa; }
			set { vlPpa = value; }
		}
		private int? qtMeta;

		public int? QtMeta
		{
			get { return qtMeta; }
			set { qtMeta = value; }
		}
		private string nmProduto = null;

		public string NmProduto
		{
			get { return nmProduto; }
			set { nmProduto = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string sgUnidade = null;

		public string SgUnidade
		{
			get { return sgUnidade; }
			set { sgUnidade = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string dtAnomes = null;

		public string DtAnomes
		{
			get { return dtAnomes; }
			set { dtAnomes = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string tpOrcamento = null;

		public string TpOrcamento
		{
			get { return tpOrcamento; }
			set { tpOrcamento = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		private string cdAcaosuperior = null;

		public string CdAcaosuperior
		{
			get { return cdAcaosuperior; }
			set { cdAcaosuperior = String.IsNullOrEmpty(value) ? null : value.Trim(); }
		}
		#endregion
		#region DataTables Filhos 
		//DataTable que manterá os dados iniciais para comparação 
		private DataTable dotacao;

		[PrimaryKey(TableName = "dotacao", CollectionKey = new string[] { "nu_cnpj", "dt_ano", "cd_acao", "cd_itemDespesa", "sg_uf", "cd_fonteRecurso" })]
		public DataTable Dotacao
		{
			get { return dotacao; }
			set { dotacao = value; }
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
		public void Inserir()
		{
			clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados(clsAcessoDados.Conexao.ABERTA);
			try
			{
				D.IniciarTransacao();
				//Se foi Definido o evento AntesDeInserir 
				if (AntesDeInserir != null)
				{
					AntesDeInserir(D, this);
				}

				#region Parametros 
				D.Parametros.Clear();
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
				D._3tnAddParametro("@nm_acao", SqlDbType.VarChar, nmAcao);
				D._3tnAddParametro("@ds_objetivo", SqlDbType.VarChar, dsObjetivo);
				D._3tnAddParametro("@tp_credito", SqlDbType.VarChar, tpCredito);
				D._3tnAddParametro("@cd_orgao", SqlDbType.VarChar, cdOrgao);
				D._3tnAddParametro("@cd_unidorcamentaria", SqlDbType.VarChar, cdUnidorcamentaria);
				D._3tnAddParametro("@cd_funcao", SqlDbType.VarChar, cdFuncao);
				D._3tnAddParametro("@cd_subfuncao", SqlDbType.VarChar, cdSubfuncao);
				D._3tnAddParametro("@cd_programa", SqlDbType.VarChar, cdPrograma);
				D._3tnAddParametro("@vl_ppa", SqlDbType.Float, vlPpa);
				D._3tnAddParametro("@qt_meta", SqlDbType.Int, qtMeta);
				D._3tnAddParametro("@nm_produto", SqlDbType.VarChar, nmProduto);
				D._3tnAddParametro("@sg_unidade", SqlDbType.VarChar, sgUnidade);
				D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, dtAnomes);
				D._3tnAddParametro("@tp_orcamento", SqlDbType.VarChar, tpOrcamento);
				D._3tnAddParametro("@cd_acaosuperior", SqlDbType.VarChar, cdAcaosuperior);
				#endregion
				D._3tnExecProcedure("dbo.pi_Acao");
				//Inserindo dotacao 
				if (dotacao != null)
				{
					for (int i = 0; i < dotacao.Rows.Count; i++)
					{
						#region Parametros 
						D.Parametros.Clear();
						D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
						D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
						D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
						D._3tnAddParametro("@cd_itemdespesa", SqlDbType.VarChar, dotacao.Rows[i]["cd_itemdespesa"]);
						D._3tnAddParametro("@sg_uf", SqlDbType.VarChar, dotacao.Rows[i]["sg_uf"]);
						D._3tnAddParametro("@cd_fonterecurso", SqlDbType.VarChar, dotacao.Rows[i]["cd_fonterecurso"]);
						D._3tnAddParametro("@vl_saldoinicial", SqlDbType.Float, dotacao.Rows[i]["vl_saldoinicial"]);
						D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, dotacao.Rows[i]["dt_anomes"]);
						D._3tnExecProcedure("dbo.pi_acao_dotacao");
						#endregion
					}
				}

				//Se foi Definido o evento DepoisDeInserir 
				if (DepoisDeInserir != null)
				{
					DepoisDeInserir(D, this);
				}

				D.FinalizarTransacao();
				GravarLogEvento(Evento.Inserir);
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
		/// Descrição: Método que insere os dados no banco. 
		/// Programador: Paulo Henrique 
		/// </summary> 
		public void Atualizar()
		{
			clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados(clsAcessoDados.Conexao.ABERTA);
			try
			{
				D.IniciarTransacao();
				#region Parametros 
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
				D._3tnAddParametro("@nm_acao", SqlDbType.VarChar, nmAcao);
				D._3tnAddParametro("@ds_objetivo", SqlDbType.VarChar, dsObjetivo);
				D._3tnAddParametro("@tp_credito", SqlDbType.VarChar, tpCredito);
				D._3tnAddParametro("@cd_orgao", SqlDbType.VarChar, cdOrgao);
				D._3tnAddParametro("@cd_unidorcamentaria", SqlDbType.VarChar, cdUnidorcamentaria);
				D._3tnAddParametro("@cd_funcao", SqlDbType.VarChar, cdFuncao);
				D._3tnAddParametro("@cd_subfuncao", SqlDbType.VarChar, cdSubfuncao);
				D._3tnAddParametro("@cd_programa", SqlDbType.VarChar, cdPrograma);
				D._3tnAddParametro("@vl_ppa", SqlDbType.Float, vlPpa);
				D._3tnAddParametro("@qt_meta", SqlDbType.Int, qtMeta);
				D._3tnAddParametro("@nm_produto", SqlDbType.VarChar, nmProduto);
				D._3tnAddParametro("@sg_unidade", SqlDbType.VarChar, sgUnidade);
				D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, dtAnomes);
				D._3tnAddParametro("@tp_orcamento", SqlDbType.VarChar, tpOrcamento);
				D._3tnAddParametro("@cd_acaosuperior", SqlDbType.VarChar, cdAcaosuperior);
				#endregion
				D._3tnExecProcedure("dbo.pa_Acao");
				//Salvando dotacao 
				if (dotacao != null)
				{
					DifferenceTable diffdotacao = DifferenceTable.Compare<Acao>(CacheDataTable.Instance.getCacheTable("dotacao"), this.dotacao);
					//Operação: Delete 
					for (int i = 0; i < diffdotacao.RemovedRows.Rows.Count; i++)
					{
						#region Parametros 
						D.Parametros.Clear();
						D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, diffdotacao.RemovedRows.Rows[i]["nu_cnpj"]);
						D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, diffdotacao.RemovedRows.Rows[i]["dt_ano"]);
						D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, diffdotacao.RemovedRows.Rows[i]["cd_acao"]);
						D._3tnAddParametro("@cd_itemdespesa", SqlDbType.VarChar, diffdotacao.RemovedRows.Rows[i]["cd_itemdespesa"]);
						D._3tnAddParametro("@sg_uf", SqlDbType.VarChar, diffdotacao.RemovedRows.Rows[i]["sg_uf"]);
						D._3tnAddParametro("@cd_fonterecurso", SqlDbType.VarChar, diffdotacao.RemovedRows.Rows[i]["cd_fonterecurso"]);
						D._3tnExecProcedure("dbo.pe_acao_dotacao");
						#endregion
					}

					//Operação: Update 
					for (int i = 0; i < diffdotacao.ChangedRows.Rows.Count; i++)
					{
						#region Parametros 
						D.Parametros.Clear();
						D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, diffdotacao.ChangedRows.Rows[i]["nu_cnpj"]);
						D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, diffdotacao.ChangedRows.Rows[i]["dt_ano"]);
						D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, diffdotacao.ChangedRows.Rows[i]["cd_acao"]);
						D._3tnAddParametro("@cd_itemdespesa", SqlDbType.VarChar, diffdotacao.ChangedRows.Rows[i]["cd_itemdespesa"]);
						D._3tnAddParametro("@sg_uf", SqlDbType.VarChar, diffdotacao.ChangedRows.Rows[i]["sg_uf"]);
						D._3tnAddParametro("@cd_fonterecurso", SqlDbType.VarChar, diffdotacao.ChangedRows.Rows[i]["cd_fonterecurso"]);
						D._3tnAddParametro("@vl_saldoinicial", SqlDbType.Float, diffdotacao.ChangedRows.Rows[i]["vl_saldoinicial"]);
						D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, diffdotacao.ChangedRows.Rows[i]["dt_anomes"]);
						D._3tnExecProcedure("dbo.pa_acao_dotacao");
						#endregion
					}

					//Operação: Insert 
					for (int i = 0; i < diffdotacao.InsertedRows.Rows.Count; i++)
					{
						#region Parametros 
						D.Parametros.Clear();
						D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
						D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
						D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
						D._3tnAddParametro("@cd_itemdespesa", SqlDbType.VarChar, diffdotacao.InsertedRows.Rows[i]["cd_itemdespesa"]);
						D._3tnAddParametro("@sg_uf", SqlDbType.VarChar, diffdotacao.InsertedRows.Rows[i]["sg_uf"]);
						D._3tnAddParametro("@cd_fonterecurso", SqlDbType.VarChar, diffdotacao.InsertedRows.Rows[i]["cd_fonterecurso"]);
						D._3tnAddParametro("@vl_saldoinicial", SqlDbType.Float, diffdotacao.InsertedRows.Rows[i]["vl_saldoinicial"]);
						D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, diffdotacao.InsertedRows.Rows[i]["dt_anomes"]);
						D._3tnExecProcedure("dbo.pi_acao_dotacao");
						#endregion
					}
				}
				D.FinalizarTransacao();
				GravarLogEvento(Evento.Atualizar);
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
				D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
				#endregion
				D._3tnExecProcedure("dbo.pe_Acao");
				GravarLogEvento(Evento.Excluir);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}


		/// <summary> 
		/// Descrição: Retorna um DataTable de Dotacao 
		/// Programador: Paulo Henrique 
		/// </summary> 
		public DataTable getDotacao()
		{
			try
			{
				clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados();
				#region Parametros 
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
				#endregion
				DataTable dt = D._3tnGetDataTable("dbo.pc_Acao_Dotacao");
				dt.TableName = "dotacao";
				CacheDataTable.Instance.Add("dotacao", dt);
				return dt;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}


		/// <summary> 
		/// Descrição: Retorna um DataTable de Dotacao 
		/// Programador: Paulo Henrique 
		/// </summary> 
		public DataTable getDotacao(string busca)
		{
			try
			{
				clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados();
				#region Parametros 
				D._3tnAddParametro("@busca", SqlDbType.VarChar, busca);
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
				#endregion
				DataTable dt = D._3tnGetDataTable("dbo.pc_Acao_Dotacao");
				dt.TableName = "dotacao";
				CacheDataTable.Instance.Add("dotacao", dt);
				return dt;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
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
				D._3tnExecProcedure("dbo.pc_Acao_Existe");
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
				return D._3tnGetDataTable("dbo.pc_Acao");
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
				return D._3tnGetDataTable("dbo.pc_Acao");
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
				return D._3tnGetDataReader("dbo.pc_Acao");
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
		public static SqlDataReader ConsultarReader(string busca, Hashtable keys)
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				D._3tnAddParametro("@busca", SqlDbType.VarChar, busca);
				foreach (object iKey in keys.Keys)
				{
					D._3tnAddParametro("@" + iKey.ToString(), keys[iKey].ToString());
				}
				return D._3tnGetDataReader("dbo.pc_Acao");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		#region 3tecnos

		/// <summary> 
		/// Descrição: Sobrecarga do Método (Faz uma consulta filtrando o máximo possível). 
		/// Programador: Rogério Cardoso 
		/// </summary> 
		public static DataTable ConsultarCompleto(string busca, Hashtable keys)
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				D._3tnAddParametro("@busca", SqlDbType.VarChar, busca);
				foreach (object iKey in keys.Keys)
				{
					D._3tnAddParametro("@" + iKey.ToString(), keys[iKey].ToString());
				}
				return D._3tnGetDataTable("dbo.pd_ConsAcao");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary> 
		/// Descrição: Sobrecarga do Método (Faz uma consulta filtrando o máximo possível). 
		/// Programador: Rogério Cardoso 
		/// </summary> 
		public static DataTable ConsultarNoOrcamento(string busca, Hashtable keys)
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				D._3tnAddParametro("@busca", SqlDbType.VarChar, busca);
				foreach (object iKey in keys.Keys)
				{
					D._3tnAddParametro("@" + iKey.ToString(), keys[iKey].ToString());
				}
				return D._3tnGetDataTable("dbo.pd_ConsAcaoNoOrcamento");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary> 
		/// Descrição: Retorna um DataTable de Dotacao 
		/// Programador: Rogério Cardoso 
		/// </summary> 
		public DataTable getDotacaoCompleto()
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				#region Parametros
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
				#endregion
				return D._3tnGetDataTable("dbo.pd_ConsAcao_Dotacao");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary> 
		/// Obtem o resumo da Dotacao
		/// Programador: Rogério Cardoso 
		/// </summary> 
		public static double ObterResumoDotacao(Hashtable keys)
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				foreach (object iKey in keys.Keys)
				{
					D._3tnAddParametro("@" + iKey.ToString(), keys[iKey].ToString());
				}
				return Double.Parse(D._3tnGetUnicoRegistro("dbo.pd_ObterResumoDotacao").ToString());
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary> 
		/// Descrição: Método que insere os dados no banco. 
		/// Programador: Rogério Cardoso 
		/// </summary> 
		public static void InserirDotacao(Hashtable keys)
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				foreach (object iKey in keys.Keys)
				{
					D._3tnAddParametro("@" + iKey.ToString(), keys[iKey].ToString());
				}
				D._3tnExecProcedure("dbo.pd_InsDotacao");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary> 
		/// Descrição: Método que exclui os dados no banco. 
		/// Programador: Rogério Cardoso 
		/// </summary> 
		public static void ExcluirDotacao(Hashtable keys)
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				foreach (object iKey in keys.Keys)
				{
					D._3tnAddParametro("@" + iKey.ToString(), keys[iKey].ToString());
				}
				D._3tnExecProcedure("dbo.pd_ExcDotacao");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary> 
		/// Descrição: Sobrecarga do Método (Faz uma consulta filtrando o máximo possível). 
		/// Programador: Rogério Cardoso 
		/// </summary> 
		public static double ObterTotalFixado(Hashtable keys)
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				foreach (object iKey in keys.Keys)
				{
					D._3tnAddParametro("@" + iKey.ToString(), keys[iKey].ToString());
				}
				return double.Parse(D._3tnGetUnicoRegistro("dbo.pd_ObterTotalDespesaFixada").ToString());
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		/// <summary> 
		/// Descrição: Método que insere os dados no banco. 
		/// Programador: João Paulo 
		/// </summary> 
		public void InserirCompleto()
		{
			clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados(clsAcessoDados.Conexao.ABERTA);
			try
			{
				D.IniciarTransacao();
				//Se foi Definido o evento AntesDeInserir 
				if (AntesDeInserir != null)
				{
					AntesDeInserir(D, this);
				}

				#region Parametros 
				D.Parametros.Clear();
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				if (string.IsNullOrEmpty(cdAcaosuperior))
				{
					D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
				}
				else
				{
					D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, ParameterDirection.Output);
					D.Parametros["@cd_acao"].Size = 4;
				}
				D._3tnAddParametro("@nm_acao", SqlDbType.VarChar, nmAcao);
				D._3tnAddParametro("@ds_objetivo", SqlDbType.VarChar, dsObjetivo);
				D._3tnAddParametro("@tp_credito", SqlDbType.VarChar, tpCredito);
				D._3tnAddParametro("@cd_orgao", SqlDbType.VarChar, cdOrgao);
				D._3tnAddParametro("@cd_unidorcamentaria", SqlDbType.VarChar, cdUnidorcamentaria);
				D._3tnAddParametro("@cd_funcao", SqlDbType.VarChar, cdFuncao);
				D._3tnAddParametro("@cd_subfuncao", SqlDbType.VarChar, cdSubfuncao);
				D._3tnAddParametro("@cd_programa", SqlDbType.VarChar, cdPrograma);
				D._3tnAddParametro("@vl_ppa", SqlDbType.Float, vlPpa);
				D._3tnAddParametro("@qt_meta", SqlDbType.Int, qtMeta);
				D._3tnAddParametro("@nm_produto", SqlDbType.VarChar, nmProduto);
				D._3tnAddParametro("@sg_unidade", SqlDbType.VarChar, sgUnidade);
				D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, dtAnomes);
				D._3tnAddParametro("@tp_orcamento", SqlDbType.VarChar, tpOrcamento);
				D._3tnAddParametro("@cd_acaosuperior", SqlDbType.VarChar, cdAcaosuperior);
				#endregion
				D._3tnExecProcedure("dbo.pd_Contabilidade_InserirAcao");

				if (!string.IsNullOrEmpty(cdAcaosuperior))
				{
					//OutPut 
					cdAcao = D.Parametros["@cd_acao"].Value.ToString();
				}
				//Inserindo dotacao 
				if (dotacao != null)
				{
					for (int i = 0; i < dotacao.Rows.Count; i++)
					{
						#region Parametros
						D.Parametros.Clear();
						D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
						D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
						D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
						D._3tnAddParametro("@cd_itemdespesa", SqlDbType.VarChar, dotacao.Rows[i]["cd_itemdespesa"]);
						D._3tnAddParametro("@sg_uf", SqlDbType.VarChar, dotacao.Rows[i]["sg_uf"]);
						D._3tnAddParametro("@cd_fonterecurso", SqlDbType.VarChar, dotacao.Rows[i]["cd_fonterecurso"]);
						D._3tnAddParametro("@vl_saldoinicial", SqlDbType.Float, dotacao.Rows[i]["vl_saldoinicial"]);
						D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, dotacao.Rows[i]["dt_anomes"]);
						D._3tnExecProcedure("dbo.pi_acao_dotacao");
						#endregion
					}
				}

				//Se foi Definido o evento DepoisDeInserir 
				if (DepoisDeInserir != null)
				{
					DepoisDeInserir(D, this);
				}

				ReplicarFundos(D);
				D.FinalizarTransacao();
				GravarLogEvento(Evento.Inserir);
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

		public void AtualizarDotacao()
		{
			clsAcessoDados D = new clsAcessoDados(clsAcessoDados.Conexao.ABERTA);
			try
			{
				D.IniciarTransacao();
				#region Parametros 
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
				D._3tnAddParametro("@nm_acao", SqlDbType.VarChar, nmAcao);
				D._3tnAddParametro("@ds_objetivo", SqlDbType.VarChar, dsObjetivo);
				D._3tnAddParametro("@tp_credito", SqlDbType.VarChar, tpCredito);
				D._3tnAddParametro("@cd_orgao", SqlDbType.VarChar, cdOrgao);
				D._3tnAddParametro("@cd_unidorcamentaria", SqlDbType.VarChar, cdUnidorcamentaria);
				D._3tnAddParametro("@cd_funcao", SqlDbType.VarChar, cdFuncao);
				D._3tnAddParametro("@cd_subfuncao", SqlDbType.VarChar, cdSubfuncao);
				D._3tnAddParametro("@cd_programa", SqlDbType.VarChar, cdPrograma);
				D._3tnAddParametro("@vl_ppa", SqlDbType.Float, vlPpa);
				D._3tnAddParametro("@qt_meta", SqlDbType.Int, qtMeta);
				D._3tnAddParametro("@nm_produto", SqlDbType.VarChar, nmProduto);
				D._3tnAddParametro("@sg_unidade", SqlDbType.VarChar, sgUnidade);
				D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, dtAnomes);
				D._3tnAddParametro("@tp_orcamento", SqlDbType.VarChar, tpOrcamento);
				D._3tnAddParametro("@cd_acaosuperior", SqlDbType.VarChar, cdAcaosuperior);
				#endregion
				D._3tnExecProcedure("dbo.pa_Acao");
				//Inserindo dotacao 
				if (dotacao != null)
				{
					//Exclui os filhos, para inseri-los novamente 
					D.Parametros.Clear();
					D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
					D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
					D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
					D._3tnExecProcedure("dbo.pd_ExcluirAcaoDotacao");
					for (int i = 0; i < dotacao.Rows.Count; i++)
					{
						#region Parametros
						D.Parametros.Clear();
						D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
						D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
						D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
						D._3tnAddParametro("@sg_uf", SqlDbType.VarChar, dotacao.Rows[i]["sg_uf"]);
						D._3tnAddParametro("@cd_itemdespesa", SqlDbType.VarChar, dotacao.Rows[i]["cd_itemdespesa"]);
						D._3tnAddParametro("@cd_fonterecurso", SqlDbType.VarChar, dotacao.Rows[i]["cd_fonterecurso"]);
						D._3tnAddParametro("@vl_saldoinicial", SqlDbType.Float, dotacao.Rows[i]["vl_saldoinicial"]);
						D._3tnAddParametro("@dt_anomes", SqlDbType.VarChar, dotacao.Rows[i]["dt_anomes"]);
						D._3tnExecProcedure("dbo.pd_IncluirAcaoDotacao");
						#endregion
					}
				}
				ReplicarFundos(D);
				BloquearPropostaOrcamentaria(D, true);
				D.FinalizarTransacao();
				GravarLogEvento(Evento.Atualizar);
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
		/// Descrição: Método que exclui os dados no banco. 
		/// Programador: João Paulo
		/// </summary> 
		public void ExcluirCompleto()
		{
			try
			{
				clsAcessoDados D = (acessoDados != null) ? acessoDados : new clsAcessoDados();
				#region Parametros
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
				#endregion
				D._3tnExecProcedure("dbo.pe_Acao");
				BloquearPropostaOrcamentaria(D, false);
				GravarLogEvento(Evento.Excluir);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Obtém os totais da Dotação
		/// </summary>
		/// <returns></returns>
		public DataTable getTotaisDespesaPorOrgao()
		{
			try
			{
				clsAcessoDados D = new clsAcessoDados();
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				return D._3tnGetDataTable("dbo.pd_ObterTotaisDespesaPorOrgao");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void Importar(string nuCnpjSuperior, DataTable dtDespesaInferior, string cdUnidadesOrc)
		{
			clsAcessoDados D = new clsAcessoDados(clsAcessoDados.Conexao.ABERTA);
			try
			{
				D.IniciarTransacao();

				//Primeiramente exclui
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@cd_UnidadesOrc", SqlDbType.VarChar, cdUnidadesOrc);
				D._3tnExecProcedure("dbo.pd_ExcluirDespesa");

				for (int i = 0; i < dtDespesaInferior.Rows.Count; i++)
				{
					D.Parametros.Clear();
					D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
					D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
					D._3tnAddParametro("@nu_cnpjSuperior", SqlDbType.VarChar, nuCnpjSuperior);
					D._3tnAddParametro("@cd_orgao", SqlDbType.VarChar, dtDespesaInferior.Rows[i]["cd_orgao"]);
					D._3tnAddParametro("@cd_unidOrcamentaria", SqlDbType.VarChar, dtDespesaInferior.Rows[i]["cd_unidOrcamentaria"]);
					D._3tnExecProcedure("pd_ImportarDespesa");
				}
				D.FinalizarTransacao();
			}
			finally
			{
				D.FecharConexao();
			}
		}

		public static void RenumerarAcoes(string nuCnpj, string dtAno)
		{
			clsAcessoDados D = new clsAcessoDados(clsAcessoDados.Conexao.ABERTA);
			try
			{
				D.IniciarTransacao();

				//Reordenando as ações
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnExecProcedure("dbo.pd_OrdenarAcoes");

				D.FinalizarTransacao();
			}
			finally
			{
				D.FecharConexao();
			}
		}

		/// <summary>
		/// Replica a ação para os fundos ou do fundo para a prefeitura
		/// </summary>
		private void ReplicarFundos(clsAcessoDados D)
		{
			try
			{
				D.Parametros.Clear();
				//Replicando para Fundos
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
				D._3tnExecProcedure("dbo.pd_ReplicarAcaoParaFundos");
			}
			catch (Exception e)
			{
				throw new Exception("Exceção ao Replicar.", e);
			}

		}

		/// <summary>
		/// Replica a ação para os fundos ou do fundo para a prefeitura
		/// </summary>
		private void BloquearPropostaOrcamentaria(clsAcessoDados D, bool sim)
		{
			try
			{
				D.Parametros.Clear();
				//Bloqueia Proposta Orçamentária
				D._3tnAddParametro("@nu_cnpj", SqlDbType.VarChar, nuCnpj);
				D._3tnAddParametro("@dt_ano", SqlDbType.VarChar, dtAno);
				D._3tnAddParametro("@cd_acao", SqlDbType.VarChar, cdAcao);
				D._3tnAddParametro("@fl_bloquear", SqlDbType.Bit, sim);
				D._3tnExecProcedure("dbo.pd_BloqueiaPropostaOrcamentaria");
			}
			catch (Exception e)
			{
				throw new Exception("Exceção ao Bloquear Proposta Orçamentária.", e);
			}
		}

		#endregion 3tecnos
	} //Fim da Classe
}
