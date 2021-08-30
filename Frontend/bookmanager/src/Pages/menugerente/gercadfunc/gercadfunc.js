import React, { useState } from 'react'
import './gercadfunc.css'

import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

import funcoes from '../../Services/FuncoesGerente'
import { useHistory } from 'react-router-dom';

function Gercadfunc(){

    const api = new funcoes();
    const history = useHistory();

    const [nomefunc,setNomefunc] = useState();
    const [nascimentofunc,setNascimento] = useState();
    const [cpf,setCpf] = useState();
    const [cep,setCep] = useState();
    const [rg,setRg] = useState();
    const [carteiratrabalho,setCarteira] = useState();
    const [cargahoraria,setCarga] = useState();
    const [salario,setSalario] = useState();

    const InserirFuncionario = async() =>{
        const x = await api.CadastrarNovoFuncionario({
            nomefuncionario:nomefunc,
            nascimentofuncionario:nascimentofunc,
            cpf:cpf,
            cep:cep,
            rg:rg,
            carteiratrabalho:carteiratrabalho,
            cargahorariasemanal:cargahoraria,
            salario:salario
        });
        toast("🚀 Funcionario inserido com Sucesso");
    }
    const voltargerente = ()=>{
        history.push({
            pathname:"/menugerente"
        })
    }

    return(
        <div name="body" id="corpoform">
            <div id="titulotelanovofunc">
                <h2>Inserir Novo Funcionario:</h2>
            </div>
            <div name="formulario" id="formulariogerente">
                <div name="classe1" id="classe1form">
                    <div name="bloco1" id="bloco1form">
                        <div name="nomefuncionario">
                            <label>Nome do Funcionario</label>
                        </div>
                        <div name="nascimentofunc">
                            <label>Data de Nascimento Funcionario</label>
                        </div>
                        <div name="cpf">
                            <label>Cpf </label>
                        </div>
                        <div name="cep">
                            <label>Cep</label>
                        </div>
                        <div name="rg">
                            <label>Rg</label>
                        </div>
                        <div name="carteiratrabalho">
                            <label>Carteira de Trabalho</label>
                        </div>
                        <div name="cargahoraria">
                            <label>Carga Horaria</label>
                        </div>
                        <div name="salario">
                            <label>Salario</label>
                        </div>
                    </div>
                    <div name="bloco2" id="bloco2form">
                        <div name="infonome">
                            <input type="text" onChange={(e) => setNomefunc(e.target.value)}></input>
                        </div>
                        <div name="infonasc">
                            <input type="date" on onChange={(e) => setNascimento(e.target.value)}></input>
                        </div>
                        <div name="infocpf">
                            <input type="text" onChange={(e) => setCpf(e.target.value)}></input>
                        </div>
                        <div name="infocep">
                            <input type="text" onChange={(e) => setCep(e.target.value)}></input>
                        </div>
                        <div name="inforg">
                            <input type="text" onChange={(e) => setRg(e.target.value)}></input>
                        </div>
                        <div name="infocarteira">
                            <input type="text" onChange={(e) => setCarteira(e.target.value)}></input>
                        </div>
                        <div name="infocargahoraria">
                            <input type="text" onChange={(e) => setCarga(e.target.value)}></input>
                        </div>
                        <div name="infosalario">
                            <input type="number" onChange={(e) => setSalario(e.target.value)}></input>
                        </div>    
                    </div>
                </div>
                <div name="classe2" id="classe2form">
                    <div>
                        <button onClick={InserirFuncionario}>Inserir Novo Funcionario</button>
                    </div>
                    <div>
                        <button onClick={voltargerente}>Voltar</button>
                    </div>        
                </div>
            </div>
            <ToastContainer />
        </div>
    )
}

export default Gercadfunc;
