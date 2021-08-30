import React, { useState } from "react"
import {Link} from 'react-router-dom'
import { ToastContainer, toast} from "react-toastify";
import 'react-toastify/dist/ReactToastify.css';
import './App.css'

import api from '../Services/SistemaPrateleira'

export default function CriarConta(){

    const API = new api();

    const [email,setEmail] = useState('');
    const [senha,setSenha] = useState('');
    const [nome,setNome] = useState('');
    const [nascimento,setNascimento] = useState();
    const [cpf,setCpf] = useState('');
    const [rg,setRg] = useState('');
    const [cartao,setCartao] = useState('');
    const [telefone,setTelefone] = useState('');
    const [endereco,setEndereco] = useState('');
    
    const CriarConta = async() =>{
        try{
        await API.CriarConta({
            InformacoesCliente:{
                nome:nome,
                nascimento:nascimento,
                cpf:cpf,
                rg:rg,
                cartaocredito:cartao,
                endereco:endereco,
                telefone:telefone
            },
            conta:{
                email:email,
                senha:senha
            }
        });
        toast.success("🚀 Conta Criada com sucesso");
        }
        catch(ex)
        {
            if(ex.response.data.motivo)
            toast.error("😵 " + ex.response.data.motivo);
            else
            toast.error("😔 Tente Novamente");
        }

    }

    return(
        <body className="body">

                <div className="rodape">
                    <h3>Criar Conta: </h3>
                </div>

                <div id="formcriarconta">
                    <div id="priblococriarconta">
                        <label>Novo Email</label>
                        <label>Nova Senha</label>
                        <label>Nome Completo</label>
                        <label>Data de Nascimento</label>
                        <label>Cpf</label>
                        <label>Rg</label>
                        <label>Numero do Cartão de crédito</label>
                        <label>Numero de Telefone:</label>
                        <label>Endereço</label>
                    </div>
                    <div id="segblococriarconta">
                        <input type="text" onChange={(e) => setEmail(e.target.value)}></input>
                        <input type="password" onChange={(e) => setSenha(e.target.value)}></input>
                        <input type="text" onChange={(e) => setNome(e.target.value)}></input>
                        <input type="date" onChange={(e) => setNascimento(e.target.value)}></input>
                        <input type="text" name="cpf" onBlur="ValidarCPF(form1.cpf);" onKeyPress="MarcaraCPF(form1.cpf);" maxLength="14'" onChange={(e) => setCpf(e.target.value)}></input>
                        <input type="text" onChange={(e) => setRg(e.target.value)}></input>
                        <input type="text" onChange={(e) => setCartao(e.target.value)}></input>
                        <input type="text" onChange={(e) => setTelefone(e.target.value)}></input>
                        <input type="text" onChange={(e) => setEndereco(e.target.value)}></input>
                    </div>
                </div>

                <div className="eventos">
                    <div className="termos">
                       Ao criar a conta você aceita os <Link to="/termosEcondicoes" >Termos e Condicões</Link>
                    </div>
                    <div className="acoes">
                        <a className="btn btn-primary evento1" href="/" >
                            voltar
                        </a>
                        <div className="btn btn-success evento2" onClick={CriarConta}>
                            Criar
                        </div>
                    </div>
                </div>
                
                <ToastContainer/>
        </body>
    )
}



