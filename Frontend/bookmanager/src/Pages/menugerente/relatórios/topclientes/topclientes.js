import React, { useEffect, useState } from 'react';
import './topclientes.css';

import funcoes from '../../../Services/FuncoesGerente'
import {ToastContainer,toast} from "react-toastify"
import 'react-toastify/dist/ReactToastify.css';

export default function TopClientes(){

    const api = new funcoes();
    const [topclientes,setTopClientes] = useState([]);

    const BuscarMelhoresClientes = async() =>{
        try{
        const x = await api.MelhoresClientes();
        setTopClientes([...x]);
        }
        catch(ex)
        {
            toast.warning("Não á registros de clientes");
        }
    }

    useEffect(() => { 
        BuscarMelhoresClientes();
    }, [])

    return(
        <div className="telatopcliente">

            <div className="maingerente">
                <div id="secgerente">
                    <h1>Top Clientes</h1>
                </div>
            </div>
            <div id="tabelatopcliente">
                <table className="table">
                    <thead className="orange">
                        <tr>
                            <th>Nome</th>
                            <th>Email</th>
                            <th>Telefone</th>
                            <th>Quantidade de Pedidos</th>
                            <th>Total de Gastos</th>
                        </tr>
                    </thead>
                    <tbody className="black">
                        {topclientes.map((item) =>(
                            <tr className="colorwhite">
                                <td>{item.nome}</td>
                                <td>{item.email}</td>
                                <td>{item.telefone}</td>
                                <td>{item.qtdpedidos}</td>
                                <td>{item.totaldegastos}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
                <div className="voltartopcliente">
                    <a href="gerenciarfinancas" className="btn btn-primary">Voltar</a>
                </div>
            </div>
            <div id="thirdgerente">
                <h2>Direitos do site reservados @Copyright</h2>
            </div>
            <ToastContainer/>
        </div>
    )
}