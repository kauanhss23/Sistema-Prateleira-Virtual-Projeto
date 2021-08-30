import React, { useEffect, useState } from 'react';
import './topprodutos.css';

import funcoes from '../../../Services/FuncoesGerente'

export default function TopProdutos(){

    const api = new funcoes();
    const [topprodutos,setTopprodutos] = useState([]);

    const MelhoresLivros = async() =>{
        const x = await api.MelhoresProdutos();
        setTopprodutos([...x]);
    }
    useEffect(() =>{
        MelhoresLivros();
    }, [])

    return(
        <div className="telatopprodutos">

            <div className="maingerente">
                <div id="secgerente">
                    <h1>Relatório Top Livros</h1>
                </div>
            </div>

            <div className="melhoreslivros">
                <table className="table">
                    <thead className="orange">
                        <tr>
                            <td>Nome do Livro</td>
                            <td>Quantidade de Vendas</td>
                            <td>Lucro do Livro</td>
                        </tr>
                    </thead>
                    <tbody className="black">
                        {topprodutos.map((item) =>(
                            <tr className="colorwhite">
                                <td>{item.nomeproduto}</td>
                                <td>{item.qtdvendidos}</td>
                                <td>{item.lucrogeral}</td>
                            </tr>
                        ))}    
                    </tbody>
                </table>
                <div className="">
                <a href="gerenciarfinancas" className="btn btn-primary">Voltar</a>
            </div>
            </div>
            <div id="thirdgerente">
                <h2>Direitos do site reservados @Copyright</h2>
            </div>

        </div>
    )
}

