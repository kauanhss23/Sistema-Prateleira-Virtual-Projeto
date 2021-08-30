import React, { useEffect, useState } from 'react';
import './grafico.css';

import { Chart } from "react-google-charts";
import funcoes from "../../../Services/FuncoesGerente"

export default function Grafico(){

    const api = new funcoes();
    const [grafico,setGrafico] = useState([]);

    const BuscarGrafico = async() =>{
        const x = await api.MelhoresLivrosGrafico();
        setGrafico([...x]);
        console.log(x);
    }

    useEffect(() =>{
        BuscarGrafico();
    }, [])

    return(
        <div className="telagrafico">
            
            <div className="maingerente">
                <div id="secgerente">
                    <h1>Relatório Gráfico</h1>
                </div>
            </div>

            <div id="containerdografico">

                <div id="conteudorelatorio">

                <Chart
                    width={'1200px'}
                    height={'400px'}
                    chartType="Bar"
                    loader={<div>Loading Chart</div>}
                    rows={grafico.map((item) =>([
                        String(item.nomelivro),item.qtdvendas
                    ]))}

                    columns={["Melhores Livros","Qtd. Vendas"]}
                    rootProps={{ 'data-testid': '1' }}
                />
                
                </div>
                <div className="botaografico">
                    <a href="gerenciarfinancas" className="btn btn-primary">Voltar</a>
                </div>
            </div>

            <div id="thirdgerente">
                <h2>Direitos do site reservados @Copyright</h2>
            </div>

        </div>
    )
}
