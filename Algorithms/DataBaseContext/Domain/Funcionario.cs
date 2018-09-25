using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseContext.Domain
{
    public class Funcionario
    {

        private string nuCnpj = null;

        public string NuCnpj
        {
            get { return nuCnpj; }
            set { nuCnpj = String.IsNullOrEmpty(value) ? null : value.Trim(); }
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
        private string nmFuncionario = null;

        public string NmFuncionario
        {
            get { return nmFuncionario; }
            set { nmFuncionario = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private DateTime? dtNascimento;

        public DateTime? DtNascimento
        {
            get { return dtNascimento; }
            set { dtNascimento = value; }
        }
        private string tpSexo = null;

        public string TpSexo
        {
            get { return tpSexo; }
            set { tpSexo = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuRg = null;

        public string NuRg
        {
            get { return nuRg; }
            set { nuRg = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string sgOrgexped = null;

        public string SgOrgexped
        {
            get { return sgOrgexped; }
            set { sgOrgexped = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private DateTime? dtEmissaorg;

        public DateTime? DtEmissaorg
        {
            get { return dtEmissaorg; }
            set { dtEmissaorg = value; }
        }
        private string tpEstadocivil = null;

        public string TpEstadocivil
        {
            get { return tpEstadocivil; }
            set { tpEstadocivil = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private bool flDeclarasefip;

        public bool FlDeclarasefip
        {
            get { return flDeclarasefip; }
            set { flDeclarasefip = value; }
        }
        private bool flDeclararais;

        public bool FlDeclararais
        {
            get { return flDeclararais; }
            set { flDeclararais = value; }
        }
        private bool flBrasileiro;

        public bool FlBrasileiro
        {
            get { return flBrasileiro; }
            set { flBrasileiro = value; }
        }
        private string nuCtps = null;

        public string NuCtps
        {
            get { return nuCtps; }
            set { nuCtps = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuSeriectps = null;

        public string NuSeriectps
        {
            get { return nuSeriectps; }
            set { nuSeriectps = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuPispasep = null;

        public string NuPispasep
        {
            get { return nuPispasep; }
            set { nuPispasep = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuCnh = null;

        public string NuCnh
        {
            get { return nuCnh; }
            set { nuCnh = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuCerttransporte = null;

        public string NuCerttransporte
        {
            get { return nuCerttransporte; }
            set { nuCerttransporte = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string tpCnh = null;

        public string TpCnh
        {
            get { return tpCnh; }
            set { tpCnh = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private DateTime? dtValidadecnh;

        public DateTime? DtValidadecnh
        {
            get { return dtValidadecnh; }
            set { dtValidadecnh = value; }
        }
        private DateTime? dtCerttransporte;

        public DateTime? DtCerttransporte
        {
            get { return dtCerttransporte; }
            set { dtCerttransporte = value; }
        }
        private string nuTitulo = null;

        public string NuTitulo
        {
            get { return nuTitulo; }
            set { nuTitulo = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string cdZona = null;

        public string CdZona
        {
            get { return cdZona; }
            set { cdZona = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string cdSecao = null;

        public string CdSecao
        {
            get { return cdSecao; }
            set { cdSecao = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nmPai = null;

        public string NmPai
        {
            get { return nmPai; }
            set { nmPai = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nmMae = null;

        public string NmMae
        {
            get { return nmMae; }
            set { nmMae = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuTelefone = null;

        public string NuTelefone
        {
            get { return nuTelefone; }
            set { nuTelefone = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuCelular = null;

        public string NuCelular
        {
            get { return nuCelular; }
            set { nuCelular = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string dsEmail = null;

        public string DsEmail
        {
            get { return dsEmail; }
            set { dsEmail = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string tpRacacor = null;

        public string TpRacacor
        {
            get { return tpRacacor; }
            set { tpRacacor = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private bool flMenoraprendiz;

        public bool FlMenoraprendiz
        {
            get { return flMenoraprendiz; }
            set { flMenoraprendiz = value; }
        }
        private string sgUf = null;

        public string SgUf
        {
            get { return sgUf; }
            set { sgUf = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuCep = null;

        public string NuCep
        {
            get { return nuCep; }
            set { nuCep = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string dsEndereco = null;

        public string DsEndereco
        {
            get { return dsEndereco; }
            set { dsEndereco = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuEndereco = null;

        public string NuEndereco
        {
            get { return nuEndereco; }
            set { nuEndereco = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string dsComplemento = null;

        public string DsComplemento
        {
            get { return dsComplemento; }
            set { dsComplemento = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string cdMunicipio = null;

        public string CdMunicipio
        {
            get { return cdMunicipio; }
            set { cdMunicipio = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nmBairro = null;

        public string NmBairro
        {
            get { return nmBairro; }
            set { nmBairro = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string tpDeficiencia = null;

        public string TpDeficiencia
        {
            get { return tpDeficiencia; }
            set { tpDeficiencia = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private bool flValetransporte;

        public bool FlValetransporte
        {
            get { return flValetransporte; }
            set { flValetransporte = value; }
        }
        private DateTime? dtRescisao;

        public DateTime? DtRescisao
        {
            get { return dtRescisao; }
            set { dtRescisao = value; }
        }
        private bool flSituacao;

        public bool FlSituacao
        {
            get { return flSituacao; }
            set { flSituacao = value; }
        }
        private int? qtFeriasgozadaimp;

        public int? QtFeriasgozadaimp
        {
            get { return qtFeriasgozadaimp; }
            set { qtFeriasgozadaimp = value; }
        }
        private string tpAdmissao = null;

        public string TpAdmissao
        {
            get { return tpAdmissao; }
            set { tpAdmissao = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private bool flDeclararaiz;

        public bool FlDeclararaiz
        {
            get { return flDeclararaiz; }
            set { flDeclararaiz = value; }
        }
        private bool flAnuenio;

        public bool FlAnuenio
        {
            get { return flAnuenio; }
            set { flAnuenio = value; }
        }
        private bool flBienio;

        public bool FlBienio
        {
            get { return flBienio; }
            set { flBienio = value; }
        }
        private bool flTrienio;

        public bool FlTrienio
        {
            get { return flTrienio; }
            set { flTrienio = value; }
        }
        private bool flQuadrienio;

        public bool FlQuadrienio
        {
            get { return flQuadrienio; }
            set { flQuadrienio = value; }
        }
        private bool flQuinquenio;

        public bool FlQuinquenio
        {
            get { return flQuinquenio; }
            set { flQuinquenio = value; }
        }
        private string tpCategoria = null;

        public string TpCategoria
        {
            get { return tpCategoria; }
            set { tpCategoria = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string tpOcorrencia = null;

        public string TpOcorrencia
        {
            get { return tpOcorrencia; }
            set { tpOcorrencia = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private double? vlContrivinculos;

        public double? VlContrivinculos
        {
            get { return vlContrivinculos; }
            set { vlContrivinculos = value; }
        }
        private DateTime? dtOpcaofgts;

        public DateTime? DtOpcaofgts
        {
            get { return dtOpcaofgts; }
            set { dtOpcaofgts = value; }
        }
        private bool flRegimeproprio;

        public bool FlRegimeproprio
        {
            get { return flRegimeproprio; }
            set { flRegimeproprio = value; }
        }
        private string nuContafgts = null;

        public string NuContafgts
        {
            get { return nuContafgts; }
            set { nuContafgts = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuAgenciafgts = null;

        public string NuAgenciafgts
        {
            get { return nuAgenciafgts; }
            set { nuAgenciafgts = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private bool flOptantefgts;

        public bool FlOptantefgts
        {
            get { return flOptantefgts; }
            set { flOptantefgts = value; }
        }
        private bool flPagamentocheque;

        public bool FlPagamentocheque
        {
            get { return flPagamentocheque; }
            set { flPagamentocheque = value; }
        }
        private string tpVinculorais = null;

        public string TpVinculorais
        {
            get { return tpVinculorais; }
            set { tpVinculorais = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private int? cdCentrocusto;

        public int? CdCentrocusto
        {
            get { return cdCentrocusto; }
            set { cdCentrocusto = value; }
        }
        private string tpVinculoempregado = null;

        public string TpVinculoempregado
        {
            get { return tpVinculoempregado; }
            set { tpVinculoempregado = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string tpRegimepessoal = null;

        public string TpRegimepessoal
        {
            get { return tpRegimepessoal; }
            set { tpRegimepessoal = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string cdBanco = null;

        public string CdBanco
        {
            get { return cdBanco; }
            set { cdBanco = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string cdAgencia = null;

        public string CdAgencia
        {
            get { return cdAgencia; }
            set { cdAgencia = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuContacorrente = null;

        public string NuContacorrente
        {
            get { return nuContacorrente; }
            set { nuContacorrente = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string nuTipooperacao = null;

        public string NuTipooperacao
        {
            get { return nuTipooperacao; }
            set { nuTipooperacao = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string cdEscolaridade = null;

        public string CdEscolaridade
        {
            get { return cdEscolaridade; }
            set { cdEscolaridade = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private bool flContrachequeonline;

        public bool FlContrachequeonline
        {
            get { return flContrachequeonline; }
            set { flContrachequeonline = value; }
        }
        private bool flAlterarsenha;

        public bool FlAlterarsenha
        {
            get { return flAlterarsenha; }
            set { flAlterarsenha = value; }
        }
        private string dsSenha = null;

        public string DsSenha
        {
            get { return dsSenha; }
            set { dsSenha = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private DateTime? dtDesativacao;

        public DateTime? DtDesativacao
        {
            get { return dtDesativacao; }
            set { dtDesativacao = value; }
        }
        private bool flGerarlancamento;

        public bool FlGerarlancamento
        {
            get { return flGerarlancamento; }
            set { flGerarlancamento = value; }
        }
        private string dsEventoespecial = null;

        public string DsEventoespecial
        {
            get { return dsEventoespecial; }
            set { dsEventoespecial = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string cdMunicipionascimento = null;

        public string CdMunicipionascimento
        {
            get { return cdMunicipionascimento; }
            set { cdMunicipionascimento = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string sgUfctps = null;

        public string SgUfctps
        {
            get { return sgUfctps; }
            set { sgUfctps = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string sgUfnascimento = null;

        public string SgUfnascimento
        {
            get { return sgUfnascimento; }
            set { sgUfnascimento = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private DateTime? dtAdmissao;

        public DateTime? DtAdmissao
        {
            get { return dtAdmissao; }
            set { dtAdmissao = value; }
        }
        private DateTime? dtCargoatual;

        public DateTime? DtCargoatual
        {
            get { return dtCargoatual; }
            set { dtCargoatual = value; }
        }
        private bool flFolha;

        public bool FlFolha
        {
            get { return flFolha; }
            set { flFolha = value; }
        }
        private string tpSanguineo = null;

        public string TpSanguineo
        {
            get { return tpSanguineo; }
            set { tpSanguineo = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private double? vlRemuneracaoexterna;

        public double? VlRemuneracaoexterna
        {
            get { return vlRemuneracaoexterna; }
            set { vlRemuneracaoexterna = value; }
        }
        private string dsVinculomatricula = null;

        public string DsVinculomatricula
        {
            get { return dsVinculomatricula; }
            set { dsVinculomatricula = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private DateTime? dtBasecontribuicao;

        public DateTime? DtBasecontribuicao
        {
            get { return dtBasecontribuicao; }
            set { dtBasecontribuicao = value; }
        }
        private string nuProtocolotcm = null;

        public string NuProtocolotcm
        {
            get { return nuProtocolotcm; }
            set { nuProtocolotcm = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private bool flFaltadia;

        public bool FlFaltadia
        {
            get { return flFaltadia; }
            set { flFaltadia = value; }
        }
        private bool flAdiantamentoquinzenal;

        public bool FlAdiantamentoquinzenal
        {
            get { return flAdiantamentoquinzenal; }
            set { flAdiantamentoquinzenal = value; }
        }
        private string nuConcurso = null;

        public string NuConcurso
        {
            get { return nuConcurso; }
            set { nuConcurso = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string dtAnomescessadoajusteenio = null;

        public string DtAnomescessadoajusteenio
        {
            get { return dtAnomescessadoajusteenio; }
            set { dtAnomescessadoajusteenio = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string dsApelido = null;

        public string DsApelido
        {
            get { return dsApelido; }
            set { dsApelido = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private int? qtMaxenio;

        public int? QtMaxenio
        {
            get { return qtMaxenio; }
            set { qtMaxenio = value; }
        }
        private string nuCrc = null;

        public string NuCrc
        {
            get { return nuCrc; }
            set { nuCrc = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private bool flPagar13mesestrab;

        public bool FlPagar13mesestrab
        {
            get { return flPagar13mesestrab; }
            set { flPagar13mesestrab = value; }
        }
        private double? nuPercprimeiraparcela13;

        public double? NuPercprimeiraparcela13
        {
            get { return nuPercprimeiraparcela13; }
            set { nuPercprimeiraparcela13 = value; }
        }
        private string gdFoto = null;

        public string GdFoto
        {
            get { return gdFoto; }
            set { gdFoto = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private string tpModalidadesefip = null;

        public string TpModalidadesefip
        {
            get { return tpModalidadesefip; }
            set { tpModalidadesefip = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private int? sqRegime;

        public int? SqRegime
        {
            get { return sqRegime; }
            set { sqRegime = value; }
        }
        private bool flContribuitetoinss;

        public bool FlContribuitetoinss
        {
            get { return flContribuitetoinss; }
            set { flContribuitetoinss = value; }
        }
        private double? vlIsentoirrf;

        public double? VlIsentoirrf
        {
            get { return vlIsentoirrf; }
            set { vlIsentoirrf = value; }
        }
        private bool flNepotismo;

        public bool FlNepotismo
        {
            get { return flNepotismo; }
            set { flNepotismo = value; }
        }
        private DateTime? dtTerminocontrato;

        public DateTime? DtTerminocontrato
        {
            get { return dtTerminocontrato; }
            set { dtTerminocontrato = value; }
        }
        private int? sqLinhatransporte;

        public int? SqLinhatransporte
        {
            get { return sqLinhatransporte; }
            set { sqLinhatransporte = value; }
        }
        private DateTime? dtLimitetrienio;

        public DateTime? DtLimitetrienio
        {
            get { return dtLimitetrienio; }
            set { dtLimitetrienio = value; }
        }
        private bool flLancamentozerado;

        public bool FlLancamentozerado
        {
            get { return flLancamentozerado; }
            set { flLancamentozerado = value; }
        }
        private bool flCelularwhatsapp;

        public bool FlCelularwhatsapp
        {
            get { return flCelularwhatsapp; }
            set { flCelularwhatsapp = value; }
        }
        private bool flPrimeirolancamentomesposterior;

        public bool FlPrimeirolancamentomesposterior
        {
            get { return flPrimeirolancamentomesposterior; }
            set { flPrimeirolancamentomesposterior = value; }
        }
        private DateTime? dtRecadastramento;

        public DateTime? DtRecadastramento
        {
            get { return dtRecadastramento; }
            set { dtRecadastramento = value; }
        }
        private string cdNacionalidade = null;

        public string CdNacionalidade
        {
            get { return cdNacionalidade; }
            set { cdNacionalidade = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private int? sqConselho;

        public int? SqConselho
        {
            get { return sqConselho; }
            set { sqConselho = value; }
        }
        private string nuConselho = null;

        public string NuConselho
        {
            get { return nuConselho; }
            set { nuConselho = String.IsNullOrEmpty(value) ? null : value.Trim(); }
        }
        private bool flPagar13apenasporsalariocargo;

        public bool FlPagar13apenasporsalariocargo
        {
            get { return flPagar13apenasporsalariocargo; }
            set { flPagar13apenasporsalariocargo = value; }
        }
        private bool flGerarmargemconsignavel;

        public bool FlGerarmargemconsignavel
        {
            get { return flGerarmargemconsignavel; }
            set { flGerarmargemconsignavel = value; }
        }

        #endregion

    } //Fim da Classe 
}
