using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimuladorSeguros
{
    public partial class Calculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var form = Request.Form;
            var concat = "ctl00$ContentPlaceHolder1$";
            var nome = Request.Form[concat + "TextBoxNome"];
            float preco = 1000f;
            var seguro = Request.Form[concat + "DropDownList1"];
            var mensagem = String.Format("Olá, {0}", nome);
            var dataNascimento = Request.Form[concat + "TextBoxDNASC"];
            var cpf = Request.Form[concat + "TextBoxCPF"];
            var mensagemPreco = String.Format("O valor deste seguro deverá ser de R$ {0:F2}", preco);
            LabelDtNasc.Text = String.Format("Data de Nascimento: {0} ", dataNascimento);
            LabelCpf.Text = String.Format("CPF: {0} ", cpf);


            switch (seguro) {
                case "seguroVida":
                    titulo.Text = mensagem;
                    lblMensagem.Text = "O seu seguro escolhido foi Seguro de Vida";
                    preco *= 0.8f;
                    mensagemPreco = String.Format("O valor deste seguro deverá ser de R$ {0:F2}", preco);
                    LabelPreco.Text = mensagemPreco; 
                 break;
                case "seguroMorteAcidental":
                    titulo.Text = mensagem;
                    lblMensagem.Text = "O seu seguro escolhido foi Seguro de Morte Acidental ";
                    preco *= 0.9f;
                    mensagemPreco = String.Format("O valor deste seguro deverá ser de R$ {0}", preco);
                    LabelPreco.Text = mensagemPreco;
                    break;
                case "seguroAcidentesPessoais":
                    titulo.Text = mensagem;
                    lblMensagem.Text = "O seu seguro escolhido foi Seguro de Acidentes Pessoais ";
                    preco *= 0.5f;
                    mensagemPreco = String.Format("O valor deste seguro deverá ser de R$ {0}", preco);
                    LabelPreco.Text = mensagemPreco;
                    break;
                case "seguroSaude":
                    titulo.Text = mensagem;
                    lblMensagem.Text = "O seu seguro escolhido foi Seguro de Saúde ";
                    preco *= 0.4f;
                    mensagemPreco = String.Format("O valor deste seguro deverá ser de R$ {0}", preco);
                    LabelPreco.Text = mensagemPreco;
                    break;
                case "seguroAutomovel":
                    titulo.Text = mensagem;
                    lblMensagem.Text = "O seu seguro escolhido foi Seguro de Automóvel ";
                    preco *= 2.5f;
                    mensagemPreco = String.Format("O valor deste seguro deverá ser de R$ {0}", preco);
                    LabelPreco.Text = mensagemPreco;
                    break;
                case "seguroResidencial":
                    titulo.Text = mensagem;
                    lblMensagem.Text = "O seu seguro escolhido foi Seguro Residencial ";
                    preco *= 0.6f;
                    mensagemPreco = String.Format("O valor deste seguro deverá ser de R$ {0}", preco);
                    LabelPreco.Text = mensagemPreco;
                    break;
                case "seguroPatrimonial":
                    titulo.Text = mensagem;
                    lblMensagem.Text = "O seu seguro escolhido foi Seguro Patrimonial ";
                    preco *= 1.2f;
                    mensagemPreco = String.Format("O valor deste seguro deverá ser de R$ {0}", preco);
                    LabelPreco.Text = mensagemPreco;
                    break;
                case "seguroEmpresarial":
                    titulo.Text = mensagem;
                    lblMensagem.Text = "O seu seguro escolhido foi Seguro Empresarial ";
                    preco *= 1.5f;
                    mensagemPreco = String.Format("O valor deste seguro deverá ser de R$ {0}", preco);
                    LabelPreco.Text = mensagemPreco;
                    break;
            }
        }
    }
}