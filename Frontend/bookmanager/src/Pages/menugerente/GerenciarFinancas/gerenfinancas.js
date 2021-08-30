import React from"react";
import './gerenfinancas.css';

import { Link } from "react-router-dom";

function GerenciarFinancas(){
    return(
        <div className="financas">
            <div className="gerenciamento">
                <h1> Gerenciamento de Finanças </h1>
            </div>
               <div className='joy'>
                    <div className='onda'>  

                        <div className='irmao'>

                          <div id="relatorio">
                            <a href="/grafico" className="btn btn-light" id="sub-botao">Gráfico</a>
                          </div>

                          <div id="relatorio">
                            <a href="/topclientes" className="btn btn-light" id="sub-botao">Top Clientes do Sistema</a>
                          </div>

                          <div id="relatorio">
                            <a href="/topprodutos" className="btn btn-light" id="sub-botao">Top produtos Mais Vendidos</a>
                          </div>

                          <div id="relatorio">
                            <a href="/vendaspordia" className="btn btn-light" id="sub-botao">Vendas por Dia</a>
                          </div>

                          <div id="relatorio">
                            <a href="/vendaspormes" className="btn btn-light" id="sub-botao">Vendas por Mês</a>
                          </div>
                        </div>
                        
                        <a href="/menugerente" className="btn btn-outline-dark">
                            Voltar
                        </a>
                    </div>
                </div>
                <div className='abaixo'>
                        <h3 className="color">Direitos do site reservados @CopyRight</h3>
                </div>
        </div>
    )
}

export default GerenciarFinancas;
