import React, {useState, useEffect, useRef} from'react';
import './HistCompras.css';
import LoadingBar from 'react-top-loading-bar'

import {Link} from "react-router-dom"
import API from '../../Services/FuncoesCliente'
import { toast, ToastContainer } from 'react-toastify';

export default function HistoricoCompras(props){

    const api = new API();
    const [lista,setList] = useState([]);
    const loadingBar = useRef(null);

    console.log(props.location.state);
    const BuscarHistorico = async() =>{
        try{
        loadingBar.current.continuousStart();
        const x = await api.HistoricoCompras(props.location.state.id);
        setList(x);
        loadingBar.current.complete();
        }
        catch(ex)
        {
            if(ex.response.data.motivo)
            toast.error("😵 " + ex.response.data.motivo);
            else
            toast.error("😔 Tente Novamente");}
    }
    useEffect(() => {
        BuscarHistorico();
      }, []);
 
    return(

        <div className='Gaia'>
                <LoadingBar
                height={4}
                color='#f11946'
                ref={loadingBar}
                />

                <div className='Titulo'>
                    <h1 id="titulohist">Histórico de Compras</h1>
                </div>
                <div className="zeus">
                    <div id="blocodecomandos">
                        <div className="btn btn-primary minibloco" onClick={BuscarHistorico}>Buscar Novamente</div>
                        <Link to={{
                            pathname:"/menucliente",
                            state:props.location.state
                        }} className="btn btn-secondary minibloco">Voltar</Link>
                    </div>
                    
                    <div className="controlladordetable">
                        <div className="table">
                            <thead id="colunas">
                                <tr>
                                    <th>Nome do Livro</th>
                                    <th>Autor do Livro</th>
                                    <th>Genero</th>
                                    <th>Data de Compra</th>
                                    <th>Preco Livro</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody id="registros">
                            {lista.map(e => (
                                <tr key={e.idlivro} id="cor">
                                    <td>{e.livro}</td>
                                    <td>{e.autor}</td>
                                    <td>{e.serie}</td>
                                    <td>{new Date(e.datacompra).toLocaleDateString()}</td>
                                    <td>{e.preco}</td>
                                    <th><a href={"http://3.82.146.171:5000/Funcoescliente/buscarimagem/" + e.nomearquivo}>Baixar</a></th>
                                </tr>
                            ))}
                            </tbody>
                        </div>
                    </div>
                </div>
            <ToastContainer />
        </div>
    )
}
