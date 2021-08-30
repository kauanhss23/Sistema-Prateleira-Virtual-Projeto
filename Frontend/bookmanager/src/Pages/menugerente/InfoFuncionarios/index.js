import React from 'react'

import './style.css'

export default function VerInformacoesFunc(props){
    
    const infofunc = props.location.state.infofunc.item;

    return(
        <div className="ASDF34">
            <h3 className="informacoes">Informações do Funcionário</h3>
            <div className="formulario">
                <div className="informacoes2">
                    <div className="info1">
                        <div>
                            <label>Nome:</label>
                            {infofunc.nome}
                        </div>
                        <div>
                            <label>Cpf:</label>
                            {infofunc.cpf}
                        </div>
                        <div>
                            <label>Rg:</label>
                            {infofunc.rg}
                        </div>
                        <div>
                            <label>Email:</label>
                            {infofunc.email}
                        </div>
                        <div>
                            <label>Senha:</label>
                            {infofunc.senha}
                        </div>
                    </div>
                    <div className="info2">
                        <div>
                            <label>Cep:</label>
                            {infofunc.cep}
                        </div>
                        <div>
                            <label>Salario:</label>
                            {infofunc.salario}
                        </div>
                        <div>
                            <label>Data de Nascimento:</label>
                            {new Date(infofunc.nascimento).toLocaleDateString()}
                        </div>
                        <div>
                            <label>Carteira de Trabalho:</label>
                            {infofunc.carteira}
                        </div>
                        <div>
                            <label>Carga Horaria(Semanal):</label>
                            {infofunc.carga}
                        </div>
                    </div>
                </div>
                <div className="btnvoltar">
                    <a className="btn btn-outline-success" href="/gergerenfunc">voltar</a>
                </div>
            </div>
        </div>
    )
}