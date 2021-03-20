using System;
using TCC.CONTROLE;

namespace TCC.MODELO
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public String loginM;
        loginDaoComandos loginDao = new loginDaoComandos();



        public bool acessar(String login, String senha)
        {

            tem = loginDao.verificarlogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            this.loginM = login;


            return tem;

        }


        public String cadastrar(String login, String senha, String confSenha, String cpf, String departamento, String email,
            String perfil, String endereco, String numero, String cidade, String bairro, String estado, String cep, String complemento, String telefone, String sexo)

        {
            this.mensagem = loginDao.cadastrar(login, senha, confSenha, cpf, departamento, email, perfil, endereco, numero, cidade, bairro, estado, cep, complemento, telefone,
                sexo);
            if (loginDao.tem)
            {
                this.tem = true;
            }

            return mensagem;
        }

        public String alteraUsuario(String login, String novoLogin)
        {
            this.mensagem = loginDao.alteraUsuario(login,novoLogin);
            if (loginDao.mensagem == "USUÁRIO ALTERADO COM SUCESSO") 
            {
                this.mensagem = "USUÁRIO ALTERADO COM SUCESSO";

            }
            else
            {
                this.mensagem = loginDao.mensagem;

            }
            
            return mensagem;
        }

        public String alteraSenha(String novaSenha, String usuario)
        {
            this.mensagem = loginDao.alteraSenha(novaSenha, usuario);
            if (loginDao.mensagem == "SENHA ALTERADA COM SUCESSO")
            {
                this.mensagem = "SENHA ALTERADA COM SUCESSO";

            }
            else
            {
                this.mensagem = loginDao.mensagem;

            }

            return mensagem;
        }

        public String alteraEmail(String email, string usuario)
        {
            this.mensagem = loginDao.alteraEmail(email, usuario);
            if (loginDao.mensagem == "EMAIL ALTERADO COM SUCESSO")
            {
                this.mensagem = "EMAIL ALTERADO COM SUCESSO";

            }
            else
            {
                this.mensagem = loginDao.mensagem;

            }

            return mensagem;
        }

        public String verificaUsuario(String usuario)
        {
            this.mensagem = loginDao.verificaUsuario(usuario);
            if (loginDao.mensagem == "USUÁRIO JÁ EXISTENTE, INSIRA UM USUÁRIO VÁLIDO")
            {
                this.mensagem = "USUÁRIO JÁ EXISTENTE, INSIRA UM USUÁRIO VÁLIDO";

            }
            else
            {
                this.mensagem = loginDao.mensagem;

            }

            return mensagem;
        }

        public String verificaEmail(String email)
        {
            this.mensagem = loginDao.verificaEmail(email);
            if (loginDao.mensagem == "EMAIL JÁ CADASTRADO, INSIRA UM EMAIL VÁLIDO")
            {
                this.mensagem = "EMAIL JÁ CADASTRADO, INSIRA UM EMAIL VÁLIDO";

            }
            else
            {
                this.mensagem = loginDao.mensagem;

            }

            return mensagem;

        }

        public String verificaCpf(String cpf)
        {
            this.mensagem = loginDao.verificaCpf(cpf);
            if (loginDao.mensagem == "CPF JÁ CADASTRADO, INSIRA UM CPF VÁLIDO")
            {
                this.mensagem = "CPF JÁ CADASTRADO, INSIRA UM CPF VÁLIDO";

            }
            else
            {
                this.mensagem = loginDao.mensagem;

            }

            return mensagem;
        }
    }
}
