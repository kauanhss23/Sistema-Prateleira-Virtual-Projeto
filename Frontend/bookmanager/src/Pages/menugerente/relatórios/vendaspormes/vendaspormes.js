import React, { useEffect, useState } from 'react';
import './vendaspormes.css';

import {Link} from 'react-router-dom';
import funcoes from '../../../Services/FuncoesGerente'

export default function VendasPormes(){

    const api = new funcoes();
    const [vendasmes,setVendasmes] = useState([]);

    const BuscarVendasMensais = async() =>{
        const x = await api.VendasporMes();
        setVendasmes([...x]);
    }

    useEffect(() => {
        BuscarVendasMensais();
    }, []);

    return(
        <div className="pri">

                <h1 className="secvendasmes">Relatório de Vendas por Mês</h1>

                <div className="tabelavendasmes">
                    <table className="table">
                        <thead className="orange">
                            <tr>
                                <th>Mes</th>
                                <th>Quantidade de Vendas</th>
                                <th>Lucro Mensal</th>
                            </tr>
                        </thead>
                        <tbody className="black">
                            {vendasmes.map((item) => (
                                <tr className="colorwhite">
                                    <td>{item.mes}</td>
                                    <td>{item.qtdvendas}</td>
                                    <td>{item.lucromensal}</td>
                                </tr>
                            ))}
                        </tbody>
                    </table>
                    <div className="botaozin">
                        <a href="gerenciarfinancas" className="btn btn-primary">Voltar</a>
                    </div>
                </div>
                
            <div id="parterocha">
                  <h2>Direitos do site reservados @Copyright</h2>
            </div>

        </div>
    )
}
