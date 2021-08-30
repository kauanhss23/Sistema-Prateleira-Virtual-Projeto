import React, { useState } from 'react';
import'./compra.css';
import {Link, useHistory} from 'react-router-dom';
import { ToastContainer, toast} from "react-toastify";
import 'react-toastify/dist/ReactToastify.css';

import API from '../../Services/FuncoesCliente'

function Compra(props){

    const [codigo,setCodigo] = useState();
    const api = new API();
    const history = useHistory();
    const infocliente = props.location.state.cliente.informacoescliente;
    const infolivro = props.location.state.livro.e;

    const fazercompra = async() =>{
        
        if(codigo.length < 3 )
            toast.error("😵 Código de Segurança Inválido");
        
        else if(codigo.length > 3)
            toast.error("😵 Código de Segurança Inválido");
        
        else{
        await api.FazerCompra(infolivro.idlivro,infocliente.id);
        toast.success("🚀 Comprado!")
        history.push({
            pathname:"/finalizar",
            state:{cliente:{infocliente},livro:{infolivro}}
        })
        }
    }

    return(
        <body id="corpotelacompra">
            <div id="mae">

                <div name="titulolivro" id="titulocompralivro">
                    <h2>{infolivro.livro}</h2>
                </div>
                <div name="containerimglivro" id="containerimglivro">
                    <div name="imagem" id="imagemcapalivro">
                        <img className="capadolivrocompra" src={"http://3.82.146.171:5000/Funcoescliente/buscarimagem/" + infolivro.nomeimg} height="230"/>
                    </div>
                    
                    <div name="informacoescruciais" id="informacoesrelevante">
                        <div id="outrocontainer">
                            <div name="preco" id="valorlivrocompra">
                                <h4>Valor Do Livro:</h4>
                                <div>
                                    {infolivro.preco}
                                </div>
                            </div>
                            <div name="acaocompra" id="acaodecompra">
                                <button className="btn btn-primary" onClick={fazercompra}>Comprar</button>
                            </div>
                            <input type="number" placeholder="Código de Segurança do Cartão" onChange={(e) => setCodigo(e.target.value)}></input>
                        </div>
                        <div id="maisumcontainer">
                            {infolivro.sinopse}
                        </div>
                        </div>
                    </div>
                <div name="caracteristicas" id="caracteristicasimportantes">
                    <h2 id="minititulo">Caracteristicas:</h2>
                </div>
                <div name="informacoes" id="informacoesessenciais">
                    <div name="informacoesparte1" id="infocontainer1">
                        <div name="numeropaginas" id="espaconasinformacoes">
                            <h5>Numero de Paginas: </h5>
                            <div>
                                {infolivro.paginas}
                            </div>
                        </div>
                        <div name="autor" id="espaconasinformacoes">
                            <h5>Nome do Autor: </h5>
                            <div>
                                {infolivro.autor}
                            </div>
                        </div>
                        <div name="editora" id="espaconasinformacoes">
                            <h5>Editora: </h5>
                            <div>                          
                                {infolivro.editora}
                            </div>
                        </div>
                        <div name="publicacaolivro" id="espaconasinformacoes">
                            <h5>Data de Publicação:</h5>
                            <div>{infolivro.publicacao}</div>
                        </div>
                    </div>
                    <div name="informacoesparte2" id="infocontainer2">
                        <div name="numeroserie" id="espaconasinformacoes">
                            <h5>Numero de Serie:</h5>
                            <div>{infolivro.serie}</div>
                        </div>
                        <div name="genero" id="espaconasinformacoes">
                            <h5>Genero: </h5>
                            <div>{infolivro.genero}</div>
                        </div>
                        <div name="acaovoltar" id="espaconasinformacoes">
                            <Link to={{
                                pathname:"/menucliente",
                                state:infocliente
                            }} className="btn btn-secondary">Voltar</Link>
                        </div>
                    </div>
                </div>
            </div>
            
            <ToastContainer />
        </body>
    )
}


export default Compra;
