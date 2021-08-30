import React, { useEffect, useState } from 'react';
import './vendaspordia.css'

import funcoes from '../../../Services/FuncoesGerente'
import {ToastContainer,toast} from "react-toastify"
import 'react-toastify/dist/ReactToastify.css';
import { Link } from 'react-bootstrap-icons';

export default function VendasPordia(){

    const api = new funcoes();
    const [vendasdia,setVendasdia] = useState([]);

    const BuscarVendasDia = async() =>{
        try{
        const x = await api.VendasdoDia();
        setVendasdia([...x]);
        }
        catch(ex)
        {
            toast.warning("😔 " + ex.response.data.motivo);
        }
    }

    useEffect(() =>{
        BuscarVendasDia();
    }, [])

    return(
        <div className="telavendasdia">

            <div className="maingerente">
                <div id="secgerente">
                    <h1>Relatório de Vendas por Dia</h1>
                </div>
            </div>

            <div className="modelotabelavendasdia">
                <table className="table">
                    <thead>
                        <tr className="orange">
                            <th>Dia</th>
                            <th>Cliente</th>
                            <th>Valor Total</th>
                        </tr>
                    </thead>
                    <tbody className="black">
                        {vendasdia.map((item) =>(
                            <tr className="colorwhite">
                                <td>{item.dia}</td>
                                <td>{item.cliente}</td>
                                <td>{item.valortotal}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            </div>

            <ToastContainer />
            <div className="botaozin">
                <a href="gerenciarfinancas" className="btn btn-primary">Voltar</a>
            </div>
            <div id="thirdgerente">
                <h2>Direitos do site reservados @Copyright</h2>
            </div>
        </div>
    )
}
